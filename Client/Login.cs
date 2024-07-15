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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            GP.Instances.sqlControl.LoginForm_VerifyLogin();
            //GP.Instances.uiManager.FormSwitch(GP.Instances.index);

        }


        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GP.Instances.sqlControl.LoginForm_VerifyLogin();
                e.Handled = true; // 防止事件继续传播
            }
        }

        private void BtnRegistered_Click(object sender, EventArgs e)
        {
            //GP.Instances.signUp.Show();
            //GP.Instances.login.Hide();
            GP.Instances.uiManager.FormSwitch(GP.Instances.signUp);
        }
    }
}
