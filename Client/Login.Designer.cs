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
            TbAccout = new TextBox();
            TbPassword = new TextBox();
            label2 = new Label();
            BtnLogin = new Button();
            BtnRegistered = new Button();
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
            // TbAccout
            // 
            TbAccout.Location = new Point(155, 62);
            TbAccout.Name = "TbAccout";
            TbAccout.Size = new Size(156, 23);
            TbAccout.TabIndex = 1;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(155, 111);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(156, 23);
            TbPassword.TabIndex = 3;
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
            // BtnLogin
            // 
            BtnLogin.Location = new Point(155, 156);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "登录";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnRegistered
            // 
            BtnRegistered.Location = new Point(236, 156);
            BtnRegistered.Name = "BtnRegistered";
            BtnRegistered.Size = new Size(75, 23);
            BtnRegistered.TabIndex = 5;
            BtnRegistered.Text = "注册";
            BtnRegistered.UseVisualStyleBackColor = true;
            BtnRegistered.Click += BtnRegistered_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 227);
            Controls.Add(BtnRegistered);
            Controls.Add(BtnLogin);
            Controls.Add(TbPassword);
            Controls.Add(label2);
            Controls.Add(TbAccout);
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

        internal Label label1;
        internal TextBox TbAccout;
        internal TextBox TbPassword;
        internal Label label2;
        internal Button BtnLogin;
        internal Button BtnRegistered;

    }
}
