using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Data;

namespace WinFormsCS
{
   
    public class DBHelpr
    {
        private static string ConnStr = "server=.;uid=zhangsan;pwd=123456;database=WinFormsCS;";

        /// <summary>
        /// 添加 删除 修改 通用方法
        /// </summary>
        public static int ExecuteNonQuery(string sql,params SqlParameter[] paras)
        {
            int result = -1;
            using(SqlConnection conn = new SqlConnection(ConnStr))
            { 
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(paras);
                result = comm.ExecuteNonQuery();
            }
            return result;
        }

        /// <summary>
        /// 查询 返回单行单列
        /// string account = "test";
        /// string password = "test";
        /// SqlParameter[] paras = new SqlParameter[]
        /// {
        ///      new SqlParameter("@account", account),
        ///      new SqlParameter("@password", password)
        /// };
        /// string sql = "select count(1) from users where qq=@qq and password = @password";
        /// int result = (int)DBHelper.ExecuteScalar(sql, paras);
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            object result = null;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            { 
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(paras);
                result = comm.ExecuteScalar();
            }
            return result;
        }
        
        /// <summary>
        /// 查询 多行多列
        /// 执行返回游标方式结果集
        /// SqlDataReader建立在数据库连接状态下 所以不能using
        /// </summary>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
        {
            SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(paras);
            SqlDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }

        
        /// <summary>
        /// 执行返回临时表DataTable
        /// 
        /// dt.Rows[0]["ID"];
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql,params SqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            //断开式连接不需要显示写Open Close
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(paras);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
/*
 Command（命令）：

作用：用于向数据库发送查询（如SQL语句或存储过程）或更新（如插入、更新、删除数据）的命令。
主要类：具体的命令类如SqlCommand、OleDbCommand、OracleCommand等，它们继承自Db
Command类。
功能：负责设置和执行命令文本，可以执行参数化查询，以及获取受影响的行数或执行结果。

DataReader（数据读取器）：
作用：提供一种从数据源逐行读取数据的方式，适合于只读、快速访问数据的场景。
主要类：具体的数据读取器类如SqlDataReader、OleDbDataReader、OracleDataReader等，它们继承自DbDataReader类。
功能：高效地读取大量数据，通过Read()方法逐行读取数据，不需要在内存中缓存整个结果集。

DataAdapter和DataSet：
作用：用于在内存中缓存数据并支持对数据的操作，适合需要离线操作数据的情况。
主要类：
DataAdapter类如SqlDataAdapter、OleDbDataAdapter、OracleDataAdapter，它们负责填充DataSet并更新数据源。
DataSet类用于在内存中存储数据，包含多个DataTable（数据表）、DataRelation（数据关系）和Constraint（约束）。
功能：
DataAdapter通过Fill()方法将数据库中的数据填充到DataSet中，通过Update()方法将DataSet中的变更保存回数据库。
DataSet允许在断开连接的情况下操作数据，支持数据的增删改查，提供了数据的本地缓存和数据之间的关系管理。
*/