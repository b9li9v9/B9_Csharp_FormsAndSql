using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

using System.Security.Principal;

namespace WinFormsCS
{
    /// <summary>
    /// tableName -> Users
    /// Id int
    /// Account nvarchar(50)
    /// Permissions int
    /// NickName nvarchar(50)
    /// PassWord varbinary(256)
    /// MailBox nvarchar(50)
    /// PhoneNumber nvarchar(30)
    /// ReadName nvarchar(50)
    /// Sex int
    /// Birthday date
    /// Organization nvarchar(50)
    /// 
    /// 
    /// 
    /// 
    /// 其实数据库最好全是字符类型 更通用 要使用在代码里动态去改
    /// 主键种子从1000开始  保留数字判断空值 
    /// 
    /// 连接式
    /// Connection对象  负责连接数据库
    /// Command对象     负责对数据库执行指令
    /// DataReader游标对象  复杂检索 只读操作
    /// 
    /// 断开式
    /// DataAdapter  数据适配器
    /// DataSet
    /// 
    /// 流程
    /// 1.创建数据库对象   new...
    /// 2.打开连接        ...open
    /// 3.创建Command对象执行脚本  obj.(sql语句，conn)   obj.ExecuteNonQuery()增删改 obj.ExecuteScalar()查单行单列 返回object类型 obj.ExecuteReader()查多行多 游标对象 返回SqlDataReader类型
    /// 4.释放资源        ...close
    /// 
    /// </summary>
    internal class SqlControl
    {
        /*
        private static SqlControl _Instances;
        public static SqlControl Instances
        {
            get
            {
                if (_Instances == null)
                {
                    _Instances = new SqlControl();
                }
                return _Instances;
            }
        }
        */

        // 缓存用户信息
        internal int Id;
        internal string Account;
        internal string Permissions;
        internal string NickName;
        internal string PassWord;
        internal string MailBox;
        internal string PhoneNumber;
        internal string ReadName;
        internal string Sex;
        internal string Birthday;
        internal int OrganizationID;
        
        private string SQL_connectionString = "server=.;uid=zhangsan;pwd=123456;database=WinFormsCS;";
        private string SQL_Query_ReadAccount = "SELECT COUNT(*) FROM Users WHERE Account = @Account;";
        private string SQL_Query_ReadAccountInfo = "SELECT * FROM Users WHERE Account = @Account AND PassWord = @PassWord;";
        private string SQL_Query_ReadAccountAll = "SELECT * FROM Users WHERE Account = @Account;";
        private string SQL_Query_DeleteAccount = "DELETE FROM Users WHERE Id = @Id;";
        private string SQL_Query_UpDataAccount = @"UPDATE Users SET " +
                                                    "NickName = @NickName," +
                                                    "PassWord = @PassWord," +
                                                    "MailBox = @MailBox," +
                                                    "PhoneNumber = @PhoneNumber," +
                                                    "ReadName = @ReadName," +
                                                    "Sex = @Sex," +
                                                    "Birthday= @Birthday," +
                                                    "OrganizationID = @OrganizationID WHERE Id = @Id";
        private string SQL_Query_SetAccount = "INSERT INTO Users " +
            "(Permissions,Account,NickName,PassWord,MailBox,PhoneNumber,ReadName,Sex,Birthday,OrganizationID) " +
            "VALUES (@Permissions,@Account,@NickName,@PassWord,@MailBox,@PhoneNumber,@ReadName,@Sex,@Birthday,@OrganizationID)";
        /// <summary>
        /// 1.查用户输入
        /// 2.查账户是否存在
        /// 3.账号密码是否匹配
        /// </summary>
        internal void LoginForm_VerifyLogin()
        {
            if (GP.Instances.login.TbAccout.Text == "" || GP.Instances.login.TbPassword.Text == "")
            {
                MessageBox.Show("请输入账号密码");
                return;
            }

            string account = GP.Instances.login.TbAccout.Text;
            string password = BitConverter.ToString((Tools.CalculateSHA256(GP.Instances.login.TbPassword.Text))).Replace("-", "").ToLower();

            using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
            {
                
                conn.Open();
                using (SqlCommand comm = new SqlCommand(this.SQL_Query_ReadAccount, conn))
                {
                    // 添加参数以防止 SQL 注入攻击
                    comm.Parameters.AddWithValue("@Account", account);
                    int count = (int)comm.ExecuteScalar(); // 执行查询并返回结果集中第一行的第一列
                    if (count == 0)
                    {
                        MessageBox.Show("该账号未注册");
                        return;
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(this.SQL_Query_ReadAccountInfo, conn))
                {
                    comm.Parameters.AddWithValue("@Account", account);
                    comm.Parameters.AddWithValue("@PassWord", password);

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        // 检查是否有行返回
                        if (reader.HasRows)
                        {
                            // 读取前必须Read
                            if (reader.Read())
                            {

                                GP.Instances.sqlControl.Id = Convert.ToInt32(reader["Id"]);
                                GP.Instances.sqlControl.Account = reader["Account"].ToString() ;
                                //GP.Instances.sqlControl.Permissions = reader["Permissions"].ToString() != "0" ? Convert.ToInt32(reader["Permissions"].ToString()) :0;
                                GP.Instances.sqlControl.Permissions = reader["Permissions"].ToString();
                                GP.Instances.sqlControl.NickName = reader["NickName"].ToString();
                                //GP.Instances.sqlControl.PassWord = this.CalculateSHA256(reader["PassWord"].ToString());
                                GP.Instances.sqlControl.PassWord = reader["PassWord"].ToString();
                                GP.Instances.sqlControl.MailBox = reader["MailBox"].ToString();
                                GP.Instances.sqlControl.PhoneNumber = reader["PhoneNumber"].ToString();
                                GP.Instances.sqlControl.ReadName = reader["ReadName"].ToString();
                                //GP.Instances.sqlControl.Sex = Convert.ToInt32(reader["Sex"]);
                                GP.Instances.sqlControl.Sex = reader["Sex"].ToString();
                                //GP.Instances.sqlControl.Birthday = Convert.ToDateTime(reader["Birthday"]);
                                GP.Instances.sqlControl.Birthday = reader["Birthday"].ToString();
                                //GP.Instances.sqlControl.Organization = reader["Organization"].ToString();
                                // 这里发生了关联，OrganizationID为null无法转int
                                //GP.Instances.sqlControl.OrganizationID = Convert.ToInt32(reader["OrganizationID"].ToString());
                                if (reader["OrganizationID"] != DBNull.Value)
                                {
                                    int.TryParse(reader["OrganizationID"].ToString(), out int organizationID);
                                    GP.Instances.sqlControl.OrganizationID = organizationID;
                                }
                                //初始为0了
                                //Debug.WriteLine(GP.Instances.sqlControl.OrganizationID);

                            }
                        }
                        else
                        {
                            MessageBox.Show("密码错误");
                            return;

                        }
                    }
                    //GP.Instances.index.Show();
                    //GP.Instances.login.Hide();
                    GP.Instances.uiManager.FormSwitch(GP.Instances.index);
                }
            }
        }
        

        // 待完成：需要去检索组织编号是否存在、如果不存在禁止填写
        internal void SignUpForm_SignUpAccount()
        {
            if (GP.Instances.signUp.TbAccount.Text == "" || GP.Instances.signUp.TbPassword.Text == "" || GP.Instances.signUp.TbMailbox.Text == "" || GP.Instances.signUp.TbNickName.Text == "")
            {
                MessageBox.Show("账号、昵称、密码、邮箱 为必填项");
                return;
            }

            // 检查是否已被注册
            using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(this.SQL_Query_ReadAccount, conn))
                {
                    // 添加参数以防止 SQL 注入攻击
                    comm.Parameters.AddWithValue("@Account", GP.Instances.signUp.TbAccount.Text);
                    int count = (int)comm.ExecuteScalar(); // 执行查询并返回结果集中第一行的第一列
                    Debug.WriteLine(count);
                    if (count == 1)
                    {
                        MessageBox.Show("该账号已注册");
                        return;
                    }
                }
            }




            try
            {

                string Account = GP.Instances.signUp.TbAccount.Text;
                string Permissions = "0";
                string NickName = GP.Instances.signUp.TbNickName.Text;
                string PassWord = BitConverter.ToString((Tools.CalculateSHA256(GP.Instances.signUp.TbPassword.Text))).Replace("-", "").ToLower();
                string MailBox = GP.Instances.signUp.TbMailbox.Text;
                string PhoneNumber = GP.Instances.signUp.TbPhoneNumber.Text;
                string Sex = GP.Instances.signUp.RbMan.Checked ? "1" : "0";
                string ReadName = GP.Instances.signUp.TbReadName.Text;
                string Birthday = GP.Instances.signUp.DtpBirthday.Value.Date.ToString("yyyy-MM-dd");
                int OrganizationID = Convert.ToInt32(GP.Instances.signUp.TbOrganizationID.Text);
                //Debug.WriteLine(BitConverter.ToString(hashedBytes).Replace("-", "").ToLower());


                using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(SQL_Query_SetAccount, conn))
                    {
                        //@Account,@Perimissions,@NickName,@PassWord,@MailBox,@PhoneNumber,@ReadName,@Sex,@Brithday,@Organization)
                        command.Parameters.AddWithValue("@Account", Account);
                        command.Parameters.AddWithValue("@NickName", NickName);
                        command.Parameters.AddWithValue("@PassWord", PassWord);
                        command.Parameters.AddWithValue("@MailBox", MailBox);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@ReadName", ReadName);
                        command.Parameters.AddWithValue("@Sex", Sex);
                        command.Parameters.AddWithValue("@Birthday", Birthday);
                        command.Parameters.AddWithValue("@OrganizationID", OrganizationID);
                        command.Parameters.AddWithValue("@Permissions", Permissions);


                        int rowsAffected = command.ExecuteNonQuery();
                        Debug.WriteLine($"Rows affected: {rowsAffected}");
                    }
                    MessageBox.Show("注册成功！");
                    //GP.Instances.signUp.Hide();
                    //GP.Instances.login.Show();
                    //GP.Instances.FormSwitch(GP.Instances.login);
                }

            }
            catch (Exception ex)
            {
                // 捕获所有类型的异常
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // !! 逻辑有大问题 这个函数没法用，和很多其他函数矛盾 先放着后改
        internal void SettingForm_UpDataAccount()
        {
            try
            {
                //string new_ReadName = GP.Instances.setting.TbReadName.Text;

                using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
                {
                    using (SqlCommand comm = new SqlCommand(this.SQL_Query_UpDataAccount, conn))
                    {
                        conn.Open();
                        comm.Parameters.AddWithValue("@NickName", (GP.Instances.settingUserBasic.TbNickName.Text != "") ? GP.Instances.settingUserBasic.TbNickName.Text : GP.Instances.sqlControl.NickName);
                        //comm.Parameters.AddWithValue("@PassWord", (GP.Instances.setting.TbPassword.Text != "") ? this.CalculateSHA256(GP.Instances.setting.TbPassword.Text) : GP.Instances.sqlControl.PassWord);
                        comm.Parameters.AddWithValue("@PassWord", (GP.Instances.settingUserBasic.TbPassword.Text != "") ? BitConverter.ToString((Tools.CalculateSHA256(GP.Instances.settingUserBasic.TbPassword.Text))).Replace("-", "").ToLower() : GP.Instances.sqlControl.PassWord);
                        comm.Parameters.AddWithValue("@MailBox", (GP.Instances.settingUserBasic.TbMailbox.Text != "") ? GP.Instances.settingUserBasic.TbMailbox.Text : GP.Instances.sqlControl.MailBox);
                        comm.Parameters.AddWithValue("@PhoneNumber", (GP.Instances.settingUserBasic.TbPhoneNumber.Text != "") ? GP.Instances.settingUserBasic.TbPhoneNumber.Text : GP.Instances.sqlControl.PhoneNumber);
                        comm.Parameters.AddWithValue("@Sex", (GP.Instances.settingUserBasic.RbMan.Checked == GP.Instances.settingUserBasic.RbWoman.Checked) ? GP.Instances.sqlControl.Sex : (GP.Instances.settingUserBasic.RbMan.Checked ? "1" : "0"));
                        //comm.Parameters.AddWithValue("@Birthday", GP.Instances.setting.DtpBirthday.Value.Date);
                        comm.Parameters.AddWithValue("@Birthday", GP.Instances.settingUserBasic.DtpBirthday.Value.Date.ToString("yyyy-MM-dd"));
                        comm.Parameters.AddWithValue("@OrganizationID", (GP.Instances.settingUserBasic.TbOrganizationID.Text != "") ? GP.Instances.settingUserBasic.TbOrganizationID.Text : GP.Instances.sqlControl.OrganizationID);
                        comm.Parameters.AddWithValue("@ReadName", (GP.Instances.settingUserBasic.TbReadName.Text != "") ? GP.Instances.settingUserBasic.TbReadName.Text : GP.Instances.sqlControl.ReadName);
                        comm.Parameters.AddWithValue("@Id", GP.Instances.sqlControl.Id);//提供ID更新 

                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("数据更新成功！");
                        }
                        else
                        {
                            MessageBox.Show("没有找到符合条件的数据或更新失败。");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 捕获所有类型的异常
                MessageBox.Show(ex.Message);
                return;
            }



        }

        internal void SettingForm_DeleteAccount() 
        {
            // 其实开头登陆已经拿到ID了，这里是熟悉下语法而写
            int Id = 0;

            using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(SQL_Query_ReadAccountAll, conn))
                {
                    // 添加参数以防止 SQL 注入攻击
                    comm.Parameters.AddWithValue("@Account", GP.Instances.sqlControl.Account);

                    // 使用 SqlDataReader 读取查询结果
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        // 检查是否有行返回
                        if (reader.HasRows)
                        {
                            // 读取前必须Read
                            if (reader.Read())
                            {
                                // 拿到索引
                                Id = Convert.ToInt32(reader["Id"].ToString());
                            }
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
            {
                using (SqlCommand comm = new SqlCommand(SQL_Query_DeleteAccount, conn))
                {
                    comm.Parameters.AddWithValue("@Id", Id); // 要删除的特定 UserID

                    conn.Open();

                    // 执行 DELETE 查询并获取受影响的行数
                    int rowsAffected = comm.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("本账户已删除");
                        //GP.Instances.setting.Hide();
                        //GP.Instances.login.Show();
                        //GP.Instances.uiManager.FormSwitch(GP.Instances.login);
                    }

                    /*
                    else
                    {
                        Console.WriteLine("没有找到符合条件的数据或删除失败。");
                    }
                    */
                }
            }
        }



    }




}
/*
 * 
 * 
 * 
T-SQL建表

用户表
CREATE TABLE dbo.Users (
    Id INT PRIMARY KEY IDENTITY(1000,1),
    Account nvarchar(50),
    Permissions nvarchar(50),
    NickName nvarchar(50),
    PassWord nvarchar(64),
    MailBox nvarchar(50),
    PhoneNumber nvarchar(30),
    ReadName nvarchar(50),
    Sex nvarchar(1),
    Birthday nvarchar(20),
    OrganizationID int,
    CONSTRAINT FK_Organizations_Users_OrganizationID FOREIGN KEY (OrganizationID)
        REFERENCES Organizations(OrganizationID)
        ON DELETE SET NULL
        ON UPDATE CASCADE,
);

组织表
CREATE TABLE dbo.Organizations (
    OrganizationID INT PRIMARY KEY IDENTITY(1000,1),
    OrganizationName nvarchar(50),
    EstablishedDate nvarchar(50),
    Type nvarchar(50),
    LegalRepresentative nvarchar(50),
    RegisteredCapital nvarchar(50),
    RegisteredAddress nvarchar(50),
    ContactNumber nvarchar(50),
    Email nvarchar(50),
    Website nvarchar(50),
    Industry nvarchar(50),
    NumberOfEmployees nvarchar(50),
    BusinessScope nvarchar(50),
    BusinessStatus nvarchar(50),
    MainProductsOrServices nvarchar(50),
    Notes nvarchar(50),
);

部门表
CREATE TABLE dbo.Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1000,1),
    OrganizationID int,
    DepartmentName nvarchar(50),
    DepartmentHeadID int,
    EstablishedDate nvarchar(50),
    Description nvarchar(50),
    ParentDepartmentID nvarchar(50),
    CONSTRAINT FK_Organizations_Departments_OrganizationID FOREIGN KEY (OrganizationID)
        REFERENCES Organizations(OrganizationID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT FK_Users_Departments_DepartmentHeadID FOREIGN KEY (DepartmentHeadID)
        REFERENCES Users(Id)
        ON DELETE SET NULL
        ON UPDATE NO ACTION,
);

员工表
CREATE TABLE dbo.Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    OrganizationID int,
    DepartmentID int,
    DepartmentHeadID int,
    SystemUserID int,
    EmployeeName nvarchar(50),
    Gender nvarchar(50),
    DateOfBirth nvarchar(50),
    HireDate nvarchar(50),
    Position nvarchar(50),
    Salary nvarchar(50),
    ContactNumber nvarchar(50),
    Email nvarchar(50),
    HomeAddress nvarchar(50),
    EmergencyContact nvarchar(50),
    EmergencyContactNumber nvarchar(50),
    EmploymentStatus nvarchar(50),
    Notes nvarchar(50),
    CONSTRAINT FK_Organizations_OrganizationID_OrganizationID FOREIGN KEY (OrganizationID)
        REFERENCES Organizations(OrganizationID)
        ON DELETE SET NULL
        ON UPDATE CASCADE,
    CONSTRAINT FK_Users_Employees_DepartmentHeadID FOREIGN KEY (DepartmentHeadID)
        REFERENCES Users(Id)
       ON DELETE SET NULL
        ON UPDATE CASCADE,
    CONSTRAINT FK_Users_Employees_SystemUserID FOREIGN KEY (SystemUserID)
        REFERENCES Users(Id)
        ON DELETE SET NULL
        ON UPDATE CASCADE,
);

组织表（Organizations）
组织ID（OrganizationID）：主键，唯一标识符。
组织名称（OrganizationName）：组织的全名或简称。
成立日期（EstablishedDate）：组织的成立或注册日期。
类型（Type）：组织的类型，如企业、非营利组织、政府机构等。
法定代表人（LegalRepresentative）：法定代表人或主要负责人的姓名。
注册资本（RegisteredCapital）：组织注册时的资本金额。
注册地址（RegisteredAddress）：组织的注册地址。
联系电话（ContactNumber）：主要联系电话。
电子邮件（Email）：主要联系电子邮件地址。
网站（Website）：组织的官方网站链接。
行业（Industry）：组织所属的行业或领域。
员工数量（NumberOfEmployees）：组织目前的员工人数。
营业范围（BusinessScope）：组织的主要业务或经营范围描述。
经营状态（BusinessStatus）：如营业中、停业、注销等状态。
主要产品或服务（MainProductsOrServices）：组织提供的主要产品或服务描述。
备注（Notes）：额外的备注或注释信息。

部门表（Departments）
部门ID（DepartmentID）：部门的唯一标识符，主键。
组织ID（OrganizationID）：外键，与组织表关联，表示部门所属的组织。
部门名称（DepartmentName）：部门的名称。
部门负责人（DepartmentHead）：部门负责人的姓名或员工ID。
成立日期（EstablishedDate）：部门的成立日期。
部门描述（Description）：部门的简要描述或功能。
父部门ID（ParentDepartmentID）：如果有的话，表示上级部门的部门ID（可以使用自引用外键）。

员工表（Employees）
组织ID（OrganizationID）：外键，与组织表关联，表示部门所属的组织。
员工ID（EmployeeID）：主键，唯一标识符。
部门ID（DepartmentID）：外键，与部门表关联，表示员工所属的部门。
部门负责人（DepartmentHeadID）：部门负责人的姓名或员工ID。
员工姓名（EmployeeName）：员工的全名或姓名。
性别（Gender）：员工的性别。
出生日期（DateOfBirth）：员工的出生日期。
入职日期（HireDate）：员工的入职日期。
职位（Position）：员工的职位或岗位。
工资（Salary）：员工的薪资或工资水平。
联系电话（ContactNumber）：员工的联系电话。
电子邮件（Email）：员工的电子邮件地址。
家庭地址（HomeAddress）：员工的家庭地址。
紧急联系人（EmergencyContact）：紧急情况下联系的人。
紧急联系电话（EmergencyContactNumber）：紧急联系人的电话号码。
在职状态（EmploymentStatus）：员工的在职状态，如在职、离职、休假等。
备注（Notes）：额外的备注或注释信息。


添加列
ALTER TABLE dbo.YourTableName
ADD NewColumn NVARCHAR(50);
修改列
ALTER TABLE dbo.YourTableName
ALTER COLUMN ExistingColumn NVARCHAR(100) NOT NULL;
删除列
ALTER TABLE dbo.YourTableName
DROP COLUMN UnnecessaryColumn;
创建索引
CREATE INDEX IX_YourTableName_ColumnName
ON dbo.YourTableName (ColumnName);

级联设置

1.    
    CONSTRAINT FK_OrganizationID FOREIGN KEY (OrganizationID)
        REFERENCES Organizations(OrganizationID)
        ON DELETE SET NULL
        ON UPDATE CASCADE,
    CONSTRAINT FK_Account FOREIGN KEY (Account)
            REFERENCES Organizations(Account)
            ON DELETE CASCADE 
            ON UPDATE CASCADE
2.
    ALTER TABLE Orders
    ADD CONSTRAINT FK_Orders_Customers FOREIGN KEY (CustomerID)
    REFERENCES Customers(CustomerID)
    ON DELETE SET NULL,  -- 删除时设置为 NULL
    ON UPDATE CASCADE;   -- 更新时级联更新

    ALTER TABLE Orders
    ADD CONSTRAINT FK_Orders_Products FOREIGN KEY (ProductID)
    REFERENCES Products(ProductID)
    ON DELETE CASCADE,   -- 删除时级联删除
    ON UPDATE NO ACTION; -- 更新时不执行任何操作

 
连接
using System.Data.SqlClient;

string connectionString = "Server=myServerAddress;Database=myDatabase;User Id=myUsername;Password=myPassword;";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    // 执行数据库操作
}


查询
string queryString = "SELECT * FROM MyTable";
using (SqlCommand command = new SqlCommand(queryString, connection))
{
    using (SqlDataReader reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine($"Name: {reader["Name"]}, Age: {reader["Age"]}");
        }
    }
}

插入
string insertQuery = "INSERT INTO MyTable (Name, Age) VALUES (@Name, @Age)";
using (SqlCommand command = new SqlCommand(insertQuery, connection))
{
    command.Parameters.AddWithValue("@Name", "John");
    command.Parameters.AddWithValue("@Age", 30);
    int rowsAffected = command.ExecuteNonQuery();
    Console.WriteLine($"Rows affected: {rowsAffected}");
}

更新
string updateQuery = "UPDATE MyTable SET Age = @Age WHERE Name = @Name";
using (SqlCommand command = new SqlCommand(updateQuery, connection))
{
    command.Parameters.AddWithValue("@Age", 31);
    command.Parameters.AddWithValue("@Name", "John");
    int rowsAffected = command.ExecuteNonQuery();
    Console.WriteLine($"Rows updated: {rowsAffected}");
}

删除
string deleteQuery = "DELETE FROM MyTable WHERE Name = @Name";
using (SqlCommand command = new SqlCommand(deleteQuery, connection))
{
    command.Parameters.AddWithValue("@Name", "John");
    int rowsAffected = command.ExecuteNonQuery();
    Console.WriteLine($"Rows deleted: {rowsAffected}");
}

包裹捕获
try
{
    // 可能抛出异常的代码
}
catch (Exception ex)
{
    // 捕获所有类型的异常
    Console.WriteLine("Error: " + ex.Message);
}
 */