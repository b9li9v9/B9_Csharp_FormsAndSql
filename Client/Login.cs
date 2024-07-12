using System;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace WinFormsCS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtnLogin_Click(object sender, EventArgs e)
        {
            VerifyLogin();
        }

        /// <summary>
        /// 1.���û�����
        /// 2.���˻��Ƿ����
        /// 3.�˺������Ƿ�ƥ��
        /// </summary>
        private void VerifyLogin()
        {
            if (LoginTbAccout.Text == "" || LoginTbPassword.Text == "")
            {
                MessageBox.Show("�˺��������");
                return;
            }

            string username = LoginTbAccout.Text; 
            byte[] hashedBytes = SignUp.CalculateSHA256(LoginTbPassword.Text);
            string NameQuery = "SELECT COUNT(*) FROM UserAccount WHERE UserName = @UserName";
            string VerifyQuery = "SELECT COUNT(*) FROM UserAccount WHERE UserName = @UserName AND PassWord = @PassWord";

            
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;"))
            {
                conn.Open();
                using (SqlCommand Ncommand = new SqlCommand(NameQuery, conn))
                {
                    // ��Ӳ����Է�ֹ SQL ע�빥��
                    Ncommand.Parameters.AddWithValue("@UserName", username);
                    int Ncount = (int)Ncommand.ExecuteScalar(); // ִ�в�ѯ�����ؽ�����е�һ�еĵ�һ��
                    Debug.WriteLine(Ncount);
                    if (Ncount == 0)
                    {
                        MessageBox.Show("���˺�δע��");
                        return;
                    }
                }
            }
            
                
            using (SqlConnection new_conn = new SqlConnection("server=DESKTOP-L4L7RP1;uid=zhangsan;pwd=123456;database=WinFormsCS;Max Pool Size=200;"))
            {
                new_conn.Open();
                using (SqlCommand Vcommand = new SqlCommand(VerifyQuery, new_conn))
                {
                    Vcommand.Parameters.AddWithValue("@UserName", username);
                    Vcommand.Parameters.AddWithValue("@PassWord", hashedBytes);
                    int Vcount = (int)Vcommand.ExecuteScalar();
                    if (Vcount == 0)
                    {
                        MessageBox.Show("�������");
                        Debug.WriteLine(Vcount);
                        return;
                        //LoginBtnLogin.PerformClick();
                    }  
                }
            }
            // ��¼�û���Ϣ ��������ʹ��
            GP.Instances.UserName = username;
            GP.Instances.Password = hashedBytes;

            GP.Instances.index = new Index();
            GP.Instances.index.Show();
            GP.Instances.login.Hide();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerifyLogin();
                e.Handled = true; // ��ֹ�¼���������
            }
        }

        private void LoginBtnRegistered_Click(object sender, EventArgs e)
        {
            GP.Instances.signUp = new SignUp();
            GP.Instances.signUp.Show();
            GP.Instances.login.Hide();
        }
    }
}
