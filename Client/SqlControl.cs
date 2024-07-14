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
    /// 其实数据库最好全是字符类型 更通用 要使用再转换
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
        internal string Organization;
        
        private string SQL_connectionString = "server=DESKTOP-10B83JG\\SQLEXPRESS;uid=zhangsan;pwd=123456;database=WinFormsCS;";
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
                                                    "Organization = @Organization WHERE Id = @Id";
        private string SQL_Query_SetAccount = "INSERT INTO Users " +
            "(Permissions,Account,NickName,PassWord,MailBox,PhoneNumber,ReadName,Sex,Birthday,Organization) " +
            "VALUES (@Permissions,@Account,@NickName,@PassWord,@MailBox,@PhoneNumber,@ReadName,@Sex,@Birthday,@Organization)";
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
                                GP.Instances.sqlControl.Organization = reader["Organization"].ToString();
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
                    GP.Instances.FormSwitch(GP.Instances.index);
                }
            }
        }
        
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


            string Account = GP.Instances.signUp.TbAccount.Text;
            string Permissions = "0";
            string NickName = GP.Instances.signUp.TbNickName.Text;
            string PassWord = BitConverter.ToString((Tools.CalculateSHA256(GP.Instances.signUp.TbPassword.Text))).Replace("-", "").ToLower();
            string MailBox = GP.Instances.signUp.TbMailbox.Text;
            string PhoneNumber = GP.Instances.signUp.TbPhoneNumber.Text;
            string Sex = GP.Instances.signUp.RbMan.Checked ? "1" : "0";
            string ReadName = GP.Instances.signUp.TbReadName.Text;
            string Birthday = GP.Instances.signUp.DtpBirthday.Value.Date.ToString("yyyy-MM-dd");
            string Organization = GP.Instances.signUp.TbOrganization.Text;
            //Debug.WriteLine(BitConverter.ToString(hashedBytes).Replace("-", "").ToLower());


            try
            {
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
                        command.Parameters.AddWithValue("@Organization", Organization);
                        command.Parameters.AddWithValue("@Permissions", Permissions);


                        int rowsAffected = command.ExecuteNonQuery();
                        Debug.WriteLine($"Rows affected: {rowsAffected}");
                    }
                    MessageBox.Show("注册成功！");
                    //GP.Instances.signUp.Hide();
                    //GP.Instances.login.Show();
                    GP.Instances.FormSwitch(GP.Instances.login);
                }

            }
            catch (Exception ex)
            {
                // 捕获所有类型的异常
                MessageBox.Show(ex.Message);
            }
        }

        // 更新逻辑有大问题 这个函数没法用，和很多其他函数矛盾 先放着后改
        internal void SettingForm_UpDataAccount()
        {

            //string new_ReadName = GP.Instances.setting.TbReadName.Text;

            using (SqlConnection conn = new SqlConnection(this.SQL_connectionString))
            {
                using (SqlCommand comm = new SqlCommand(this.SQL_Query_UpDataAccount, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@NickName", (GP.Instances.setting.TbNickName.Text != "") ? GP.Instances.setting.TbNickName.Text : GP.Instances.sqlControl.NickName);
                    //comm.Parameters.AddWithValue("@PassWord", (GP.Instances.setting.TbPassword.Text != "") ? this.CalculateSHA256(GP.Instances.setting.TbPassword.Text) : GP.Instances.sqlControl.PassWord);
                    comm.Parameters.AddWithValue("@PassWord", (GP.Instances.setting.TbPassword.Text != "") ? BitConverter.ToString((Tools.CalculateSHA256(GP.Instances.setting.TbPassword.Text))).Replace("-", "").ToLower() : GP.Instances.sqlControl.PassWord);
                    comm.Parameters.AddWithValue("@MailBox", (GP.Instances.setting.TbMailbox.Text != "") ? GP.Instances.setting.TbMailbox.Text : GP.Instances.sqlControl.MailBox);
                    comm.Parameters.AddWithValue("@PhoneNumber", (GP.Instances.setting.TbPhoneNumber.Text != "") ? GP.Instances.setting.TbPhoneNumber.Text : GP.Instances.sqlControl.PhoneNumber);
                    comm.Parameters.AddWithValue("@Sex", (GP.Instances.setting.RbMan.Checked == GP.Instances.setting.RbWoman.Checked) ? GP.Instances.sqlControl.Sex : (GP.Instances.setting.RbMan.Checked ? "1" : "0"));
                    //comm.Parameters.AddWithValue("@Birthday", GP.Instances.setting.DtpBirthday.Value.Date);
                    comm.Parameters.AddWithValue("@Birthday", GP.Instances.setting.DtpBirthday.Value.Date.ToString("yyyy-MM-dd"));
                    comm.Parameters.AddWithValue("@Organization", (GP.Instances.setting.TbOrganization.Text != "") ? GP.Instances.setting.TbOrganization.Text: GP.Instances.sqlControl.Organization);
                    comm.Parameters.AddWithValue("@ReadName", (GP.Instances.setting.TbReadName.Text != "") ? GP.Instances.setting.TbReadName.Text : GP.Instances.sqlControl.ReadName);
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
                        GP.Instances.FormSwitch(GP.Instances.login);
                    }
                    else
                    {
                        Console.WriteLine("没有找到符合条件的数据或删除失败。");
                    }
                }
            }

            //GP.Instances.login.Show();
            //GP.Instances.setting.Hide();
            GP.Instances.FormSwitch(GP.Instances.login);
        }



    }




}
/*
 * 
 * 
 * 
T-SQL建表
CREATE TABLE dbo.Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Account nvarchar(50),
    Permissions nvarchar(50),
    NickName nvarchar(50),
    PassWord nvarchar(64),
    MailBox nvarchar(50),
    PhoneNumber nvarchar(30),
    ReadName nvarchar(50),
    Sex nvarchar(1),
    Birthday nvarchar(20),
    Organization nvarchar(50),
);
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