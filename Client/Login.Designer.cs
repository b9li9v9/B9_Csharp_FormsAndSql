namespace WinFormsCS
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LoginTbAccout = new TextBox();
            LoginTbPassword = new TextBox();
            label2 = new Label();
            LoginBtnLogin = new Button();
            LoginBtnRegistered = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(91, 62);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // LoginTbAccout
            // 
            LoginTbAccout.Location = new Point(155, 62);
            LoginTbAccout.Name = "LoginTbAccout";
            LoginTbAccout.Size = new Size(156, 23);
            LoginTbAccout.TabIndex = 1;
            // 
            // LoginTbPassword
            // 
            LoginTbPassword.Location = new Point(155, 111);
            LoginTbPassword.Name = "LoginTbPassword";
            LoginTbPassword.PasswordChar = '*';
            LoginTbPassword.Size = new Size(156, 23);
            LoginTbPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(91, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 2;
            label2.Text = "密码：";
            // 
            // LoginBtnLogin
            // 
            LoginBtnLogin.Location = new Point(155, 156);
            LoginBtnLogin.Name = "LoginBtnLogin";
            LoginBtnLogin.Size = new Size(75, 23);
            LoginBtnLogin.TabIndex = 4;
            LoginBtnLogin.Text = "登录";
            LoginBtnLogin.UseVisualStyleBackColor = true;
            LoginBtnLogin.Click += LoginBtnLogin_Click;
            // 
            // LoginBtnRegistered
            // 
            LoginBtnRegistered.Location = new Point(236, 156);
            LoginBtnRegistered.Name = "LoginBtnRegistered";
            LoginBtnRegistered.Size = new Size(75, 23);
            LoginBtnRegistered.TabIndex = 5;
            LoginBtnRegistered.Text = "注册";
            LoginBtnRegistered.UseVisualStyleBackColor = true;
            LoginBtnRegistered.Click += LoginBtnRegistered_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 227);
            Controls.Add(LoginBtnRegistered);
            Controls.Add(LoginBtnLogin);
            Controls.Add(LoginTbPassword);
            Controls.Add(label2);
            Controls.Add(LoginTbAccout);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyDown += Login_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginTbAccout;
        private TextBox LoginTbPassword;
        private Label label2;
        private Button LoginBtnLogin;
        private Button LoginBtnRegistered;

    }
}
