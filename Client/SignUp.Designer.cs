namespace WinFormsCS
{
    partial class SignUp
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
            components = new System.ComponentModel.Container();
            TbPassword = new TextBox();
            label2 = new Label();
            TbAccount = new TextBox();
            label1 = new Label();
            TbPhoneNumber = new TextBox();
            label3 = new Label();
            TbMailbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TbReadName = new TextBox();
            label6 = new Label();
            TbVerify = new TextBox();
            label7 = new Label();
            label8 = new Label();
            BtnSignUp = new Button();
            BtnCancel = new Button();
            toolTip1 = new ToolTip(components);
            DtpBirthday = new DateTimePicker();
            RbMan = new RadioButton();
            RbWoman = new RadioButton();
            SuspendLayout();
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(162, 57);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(156, 23);
            TbPassword.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(98, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 6;
            label2.Text = "密码：";
            // 
            // TbAccount
            // 
            TbAccount.Location = new Point(162, 28);
            TbAccount.Name = "TbAccount";
            TbAccount.Size = new Size(156, 23);
            TbAccount.TabIndex = 5;
            toolTip1.SetToolTip(TbAccount, "填写示例：例如，John Doe");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(82, 30);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 4;
            label1.Text = "用户名：";
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Location = new Point(162, 115);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(156, 23);
            TbPhoneNumber.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(66, 117);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 10;
            label3.Text = "手机号码：";
            // 
            // TbMailbox
            // 
            TbMailbox.Location = new Point(162, 86);
            TbMailbox.Name = "TbMailbox";
            TbMailbox.Size = new Size(156, 23);
            TbMailbox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(98, 88);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 8;
            label4.Text = "邮箱：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(98, 173);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 14;
            label5.Text = "性别：";
            // 
            // TbReadName
            // 
            TbReadName.Location = new Point(162, 144);
            TbReadName.Name = "TbReadName";
            TbReadName.Size = new Size(156, 23);
            TbReadName.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(66, 146);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 12;
            label6.Text = "真实姓名：";
            // 
            // TbVerify
            // 
            TbVerify.Location = new Point(162, 231);
            TbVerify.Name = "TbVerify";
            TbVerify.Size = new Size(156, 23);
            TbVerify.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(82, 231);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 18;
            label7.Text = "验证码：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(66, 204);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 16;
            label8.Text = "出生日期：";
            // 
            // BtnSignUp
            // 
            BtnSignUp.Location = new Point(162, 259);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(75, 23);
            BtnSignUp.TabIndex = 20;
            BtnSignUp.Text = "注册";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += SignUpBtnSignUp_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(243, 259);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "取消";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += SignUpBtnCancel_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 100;
            // 
            // DtpBirthday
            // 
            DtpBirthday.Location = new Point(162, 204);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(156, 23);
            DtpBirthday.TabIndex = 22;
            // 
            // RbMan
            // 
            RbMan.AutoSize = true;
            RbMan.Location = new Point(162, 173);
            RbMan.Name = "RbMan";
            RbMan.Size = new Size(50, 21);
            RbMan.TabIndex = 23;
            RbMan.TabStop = true;
            RbMan.Text = "男性";
            RbMan.UseVisualStyleBackColor = true;
            // 
            // RbWoman
            // 
            RbWoman.AutoSize = true;
            RbWoman.Location = new Point(218, 173);
            RbWoman.Name = "RbWoman";
            RbWoman.Size = new Size(50, 21);
            RbWoman.TabIndex = 24;
            RbWoman.TabStop = true;
            RbWoman.Text = "女性";
            RbWoman.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 306);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            FormClosing += SignUp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbPassword;
        private Label label2;
        private TextBox TbAccount;
        private Label label1;
        private TextBox TbPhoneNumber;
        private Label label3;
        private TextBox TbMailbox;
        private Label label4;
        private Label label5;
        private TextBox TbReadName;
        private Label label6;
        private TextBox TbVerify;
        private Label label7;
        private Label label8;
        private Button BtnSignUp;
        private Button BtnCancel;
        private ToolTip toolTip1;
        private DateTimePicker DtpBirthday;
        private RadioButton RbMan;
        private RadioButton RbWoman;
    }
    }