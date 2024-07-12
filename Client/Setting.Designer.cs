namespace WinFormsCS
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RbWoman = new RadioButton();
            RbMan = new RadioButton();
            DtpBirthday = new DateTimePicker();
            BtnCancel = new Button();
            BtnSignUp = new Button();
            TbVerify = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            TbReadName = new TextBox();
            label6 = new Label();
            TbPhoneNumber = new TextBox();
            label3 = new Label();
            TbMailbox = new TextBox();
            label4 = new Label();
            TbPassword = new TextBox();
            label2 = new Label();
            TbAccount = new TextBox();
            label1 = new Label();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // RbWoman
            // 
            RbWoman.AutoSize = true;
            RbWoman.Location = new Point(235, 171);
            RbWoman.Name = "RbWoman";
            RbWoman.Size = new Size(50, 21);
            RbWoman.TabIndex = 43;
            RbWoman.TabStop = true;
            RbWoman.Text = "女性";
            RbWoman.UseVisualStyleBackColor = true;
            // 
            // RbMan
            // 
            RbMan.AutoSize = true;
            RbMan.Location = new Point(179, 171);
            RbMan.Name = "RbMan";
            RbMan.Size = new Size(50, 21);
            RbMan.TabIndex = 42;
            RbMan.TabStop = true;
            RbMan.Text = "男性";
            RbMan.UseVisualStyleBackColor = true;
            // 
            // DtpBirthday
            // 
            DtpBirthday.Location = new Point(179, 202);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(156, 23);
            DtpBirthday.TabIndex = 41;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(260, 257);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 40;
            BtnCancel.Text = "返回";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSignUp
            // 
            BtnSignUp.Location = new Point(98, 257);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(75, 23);
            BtnSignUp.TabIndex = 39;
            BtnSignUp.Text = "修改";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += SignUpBtnSignUp_Click;
            // 
            // TbVerify
            // 
            TbVerify.Location = new Point(179, 229);
            TbVerify.Name = "TbVerify";
            TbVerify.Size = new Size(156, 23);
            TbVerify.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(99, 229);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 37;
            label7.Text = "验证码：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(83, 202);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 36;
            label8.Text = "出生日期：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(115, 171);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 35;
            label5.Text = "性别：";
            // 
            // TbReadName
            // 
            TbReadName.Location = new Point(179, 142);
            TbReadName.Name = "TbReadName";
            TbReadName.Size = new Size(156, 23);
            TbReadName.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(83, 144);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 33;
            label6.Text = "真实姓名：";
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Location = new Point(179, 113);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(156, 23);
            TbPhoneNumber.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(83, 115);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 31;
            label3.Text = "手机号码：";
            // 
            // TbMailbox
            // 
            TbMailbox.Location = new Point(179, 84);
            TbMailbox.Name = "TbMailbox";
            TbMailbox.Size = new Size(156, 23);
            TbMailbox.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(115, 86);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 29;
            label4.Text = "邮箱：";
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(179, 55);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(156, 23);
            TbPassword.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(115, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 27;
            label2.Text = "密码：";
            // 
            // TbAccount
            // 
            TbAccount.Location = new Point(179, 26);
            TbAccount.Name = "TbAccount";
            TbAccount.Size = new Size(156, 23);
            TbAccount.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(99, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 25;
            label1.Text = "用户名：";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(179, 258);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 44;
            BtnDelete.Text = "删除账号";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 306);
            Controls.Add(BtnDelete);
            Controls.Add(RbWoman);
            Controls.Add(RbMan);
            Controls.Add(DtpBirthday);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSignUp);
            Controls.Add(TbVerify);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(TbReadName);
            Controls.Add(label6);
            Controls.Add(TbPhoneNumber);
            Controls.Add(label3);
            Controls.Add(TbMailbox);
            Controls.Add(label4);
            Controls.Add(TbPassword);
            Controls.Add(label2);
            Controls.Add(TbAccount);
            Controls.Add(label1);
            Name = "Setting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            FormClosing += Setting_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RbWoman;
        private RadioButton RbMan;
        private DateTimePicker DtpBirthday;
        private Button BtnCancel;
        private Button BtnSignUp;
        private TextBox TbVerify;
        private Label label7;
        private Label label8;
        private Label label5;
        private TextBox TbReadName;
        private Label label6;
        private TextBox TbPhoneNumber;
        private Label label3;
        private TextBox TbMailbox;
        private Label label4;
        private TextBox TbPassword;
        private Label label2;
        private TextBox TbAccount;
        private Label label1;
        private Button BtnDelete;
    }
}