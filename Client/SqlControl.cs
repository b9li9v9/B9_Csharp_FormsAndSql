using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsCS
{
    /// <summary>
    /// UserId int
    /// UserName nvarchar(50)
    /// PassWord varbinary（256）
    /// MailBox nvarchar(50)
    /// PhoneNumber nvarchar(30)
    /// ReadName nchar(20)
    /// Sex nchar
    /// Birthday date
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

        //private string connectionString = "server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;";

        //public SqlConnection CreateConn(string connectionString)
        //{
        //    return new SqlConnection(connectionString);
        //}


        //注册
    }




}
/*
 * 连接
 * using System.Data.SqlClient;

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