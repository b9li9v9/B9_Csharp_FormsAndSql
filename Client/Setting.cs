using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCS
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        // 先到数据库检索信息，检测非"" 更新值
        // 原数据 新数据 
        private void SignUpBtnSignUp_Click(object sender, EventArgs e)
        {
            // 输出每行数据的信息，例如输出用户名和其他信息
            string old_UserId = string.Empty;
            string old_UserName = string.Empty;
            byte[] old_hashedBytes = null;
            string old_MailBox = string.Empty;
            string old_PhoneNumber = string.Empty;
            string old_ReadName = string.Empty;
            int old_Sex = 0;
            DateTime old_Birthday = DateTime.MinValue;

            string new_UserName = GP.Instances.setting.TbAccount.Text;
            byte[] new_hashedBytes = SignUp.CalculateSHA256(GP.Instances.setting.TbPassword.Text);
            string new_MailBox = GP.Instances.setting.TbMailbox.Text;
            string new_PhoneNumber = GP.Instances.setting.TbPhoneNumber.Text;
            string new_ReadName = GP.Instances.setting.TbReadName.Text;
            int new_Sex = GP.Instances.setting.RbMan.Checked ? 1 : 0;
            DateTime new_Birthday = GP.Instances.setting.DtpBirthday.Value.Date;

            string set_UserName = string.Empty;
            byte[] set_hashedBytes = null;
            string set_MailBox = string.Empty;
            string set_PhoneNumber = string.Empty;
            string set_ReadName = string.Empty;
            int set_Sex = 0;
            DateTime set_Birthday = DateTime.MinValue;

            string NameQuery = "SELECT * FROM UserAccount WHERE UserName = @UserName";
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;"))
            {
                conn.Open();
                using (SqlCommand Ncommand = new SqlCommand(NameQuery, conn))
                {
                    // 添加参数以防止 SQL 注入攻击
                    Ncommand.Parameters.AddWithValue("@UserName", GP.Instances.UserName);

                    // 使用 SqlDataReader 读取查询结果
                    using (SqlDataReader reader = Ncommand.ExecuteReader())
                    {
                        // 检查是否有行返回
                        if (reader.HasRows)
                        {
                            // 读取前必须Read
                            if (reader.Read())
                            {
                                // 输出每行数据的信息，例如输出用户名和其他信息
                                old_UserId = reader["UserId"].ToString();
                                old_UserName = reader["UserName"].ToString();
                                old_hashedBytes = SignUp.CalculateSHA256(reader["PassWord"].ToString());
                                old_MailBox = reader["MailBox"].ToString();
                                old_PhoneNumber = reader["PhoneNumber"].ToString();
                                old_ReadName = reader["ReadName"].ToString();
                                old_Sex = Convert.ToInt32(reader["Sex"]);
                                old_Birthday = Convert.ToDateTime(reader["Birthday"]);


                            }
                        }
                        else
                        {
                            //Debug.WriteLine("No user found with the specified username.");
                            MessageBox.Show("检索错误");
                            return;
                        }
                    }
                }
            }
            Debug.WriteLine("UserId: " + old_UserId);
            Debug.WriteLine("UserName: " + old_UserName);
            Debug.WriteLine("PassWord: " + BitConverter.ToString(old_hashedBytes).Replace("-", ""));
            Debug.WriteLine("MailBox: " + old_MailBox);
            Debug.WriteLine("PhoneNumber: " + old_PhoneNumber);
            Debug.WriteLine("ReadName: " + old_ReadName);
            Debug.WriteLine("Sex: " + old_Sex);
            Debug.WriteLine("Birthday: " + old_Birthday);

            Debug.WriteLine("UserName: " + new_UserName);
            Debug.WriteLine("PassWord: " + BitConverter.ToString(new_hashedBytes).Replace("-", ""));
            Debug.WriteLine("MailBox: " + new_MailBox);
            Debug.WriteLine("PhoneNumber: " + new_PhoneNumber);
            Debug.WriteLine("ReadName: " + new_ReadName);
            Debug.WriteLine("Sex: " + new_Sex);
            Debug.WriteLine("Birthday: " + new_Birthday);

            set_UserName = (new_UserName != "") ? new_UserName : old_UserName;
            set_hashedBytes = (GP.Instances.setting.TbPassword.Text != "") ? new_hashedBytes : old_hashedBytes;
            set_MailBox = (new_UserName != "") ? new_UserName : old_UserName;
            set_PhoneNumber = (new_PhoneNumber != "") ? new_PhoneNumber : old_PhoneNumber;
            set_ReadName = (new_ReadName != "") ? new_ReadName : old_ReadName;
            set_Sex = GP.Instances.setting.RbMan.Checked ? 1 : 0;
            set_Birthday = GP.Instances.setting.DtpBirthday.Value.Date;

            //string setQuery = "SELECT * FROM UserAccount WHERE UserName = @UserName";
            string updateQuery = "UPDATE UserAccount SET UserName = @set_UserName, PassWord = @set_hashedBytes,MailBox = @set_MailBox,PhoneNumber=@set_PhoneNumber,ReadName=@set_ReadName,Sex=@set_Sex,Birthday=@set_Birthday WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;"))
            {
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserId", old_UserId);
                    cmd.Parameters.AddWithValue("@set_UserName", set_UserName);
                    cmd.Parameters.AddWithValue("@set_hashedBytes", set_hashedBytes);
                    cmd.Parameters.AddWithValue("@set_MailBox", set_MailBox);
                    cmd.Parameters.AddWithValue("@set_PhoneNumber", set_PhoneNumber);
                    cmd.Parameters.AddWithValue("@set_ReadName", set_ReadName);
                    cmd.Parameters.AddWithValue("@set_Sex", set_Sex);
                    cmd.Parameters.AddWithValue("@set_Birthday", set_Birthday);

                    int rowsAffected = cmd.ExecuteNonQuery();

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

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int UserId = 0;

            string NameQuery = "SELECT * FROM UserAccount WHERE UserName = @UserName";
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;"))
            {
                conn.Open();
                using (SqlCommand Ncommand = new SqlCommand(NameQuery, conn))
                {
                    // 添加参数以防止 SQL 注入攻击
                    Ncommand.Parameters.AddWithValue("@UserName", GP.Instances.UserName);

                    // 使用 SqlDataReader 读取查询结果
                    using (SqlDataReader reader = Ncommand.ExecuteReader())
                    {
                        // 检查是否有行返回
                        if (reader.HasRows)
                        {
                            // 读取前必须Read
                            if (reader.Read())
                            {
                                // 输出每行数据的信息，例如输出用户名和其他信息
                                UserId = Convert.ToInt32(reader["UserId"].ToString());
                            }
                        }
                    }
                }
            }



            string deleteQuery = "DELETE FROM UserAccount WHERE UserID = @UserID";
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;"))
            {
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserId); // 要删除的特定 UserID

                    conn.Open();

                    // 执行 DELETE 查询并获取受影响的行数
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("本账户已删除");
                        GP.Instances.setting.Hide();
                        GP.Instances.login.Show();
                    }
                    else
                    {
                        Console.WriteLine("没有找到符合条件的数据或删除失败。");
                    }
                }
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GP.Instances.setting.Hide();
            GP.Instances.index.Show();
        }
    }
}
