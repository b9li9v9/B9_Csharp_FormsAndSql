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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsCS
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtnCancel_Click(object sender, EventArgs e)
        {
            GP.Instances.signUp.Hide();
            GP.Instances.login.Show();
        }

        public static byte[] CalculateSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = sha256.ComputeHash(inputBytes);
                return hashedBytes;
            }
        }
        /// <summary>
        /// 先将输入框更改好数据库类型
        /// 连接数据库
        /// 提交请求
        /// 处理返回
        /// 
        /// UserId int
        /// UserName nvarchar(50)
        /// PassWord varbinary（256）
        /// MailBox nvarchar(50)
        /// PhoneNumber nvarchar(30)
        /// ReadName nvarchar(20)
        /// Sex int
        /// Birthday date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  如果我只有字符串 “2024年7月11日”呢 DateTime 类型
        private void SignUpBtnSignUp_Click(object sender, EventArgs e)
        {
            if (GP.Instances.signUp.TbAccount.Text == "" || GP.Instances.signUp.TbPassword.Text == "" || GP.Instances.signUp.TbMailbox.Text == "")
            {
                MessageBox.Show("账号、密码、邮箱 为必填项");
                return;
            }

            string NameQuery = "SELECT COUNT(*) FROM UserAccount WHERE UserName = @UserName";
            // 检查是否已被注册
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;"))
            {
                conn.Open();
                using (SqlCommand Ncommand = new SqlCommand(NameQuery, conn))
                {
                    // 添加参数以防止 SQL 注入攻击
                    Ncommand.Parameters.AddWithValue("@UserName", GP.Instances.signUp.TbAccount.Text);
                    int Ncount = (int)Ncommand.ExecuteScalar(); // 执行查询并返回结果集中第一行的第一列
                    Debug.WriteLine(Ncount);
                    if (Ncount == 1)
                    {
                        MessageBox.Show("该账号已注册");
                        return;
                    }
                }
            }


            string UserName = GP.Instances.signUp.TbAccount.Text;
            byte[] hashedBytes = CalculateSHA256(GP.Instances.signUp.TbPassword.Text);
            string MailBox = GP.Instances.signUp.TbMailbox.Text;
            string PhoneNumber = GP.Instances.signUp.TbPhoneNumber.Text;
            string ReadName = GP.Instances.signUp.TbReadName.Text;
            int Sex = GP.Instances.signUp.RbMan.Checked ? 1:0;
            DateTime Birthday = GP.Instances.signUp.DtpBirthday.Value.Date;

            //Debug.WriteLine(Birthday is DateTime);
            //Debug.WriteLine(Birthday);

            Debug.WriteLine(BitConverter.ToString(hashedBytes).Replace("-", "").ToLower());

            
                try
                {
                    using (SqlConnection conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;"))
                    {
                        conn.Open();
                        string insertQuery = "INSERT INTO UserAccount (UserName, PassWord, MailBox, PhoneNumber, ReadName, Sex, Birthday) " +
                        "VALUES (@UserName, @Password, @MailBox, @PhoneNumber, @RealName, @Sex, @Birthday)";
                        using (SqlCommand command = new SqlCommand(insertQuery, conn))
                            {
                                command.Parameters.AddWithValue("@UserName", UserName);
                                command.Parameters.AddWithValue("@Password", hashedBytes);
                                command.Parameters.AddWithValue("@MailBox", MailBox);
                                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                                command.Parameters.AddWithValue("@RealName", ReadName);
                                command.Parameters.AddWithValue("@Sex", Sex);
                                command.Parameters.AddWithValue("@Birthday", Birthday);
                                int rowsAffected = command.ExecuteNonQuery();
                                Debug.WriteLine($"Rows affected: {rowsAffected}");
                            }
                        MessageBox.Show("注册成功！");
                        BtnCancel.PerformClick();
                }

                }
                catch (Exception ex)
                {
                    // 捕获所有类型的异常
                    MessageBox.Show(ex.Message);
                }




            //  GP.Instances.sqlControl = new SqlControl();
            // GP.Instances.sqlControl.conn
            // GP.Instances.sqlControl.conn


        }
    }
}
