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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //GP.Instances.signUp.Hide();
            //GP.Instances.login.Show();
            GP.Instances.FormSwitch(GP.Instances.login);
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
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            GP.Instances.sqlControl.SignUpForm_SignUpAccount();
        }
    }
}
