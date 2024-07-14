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
            TbNickName = new TextBox();
            DtpBirthday = new DateTimePicker();
            RbMan = new RadioButton();
            RbWoman = new RadioButton();
            label9 = new Label();
            TbOrganization = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(162, 86);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(156, 23);
            TbPassword.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(98, 88);
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
            label1.Location = new Point(98, 30);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 4;
            label1.Text = "账号：";
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Location = new Point(162, 173);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(156, 23);
            TbPhoneNumber.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(66, 175);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 10;
            label3.Text = "手机号码：";
            // 
            // TbMailbox
            // 
            TbMailbox.Location = new Point(162, 115);
            TbMailbox.Name = "TbMailbox";
            TbMailbox.Size = new Size(156, 23);
            TbMailbox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(98, 117);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 8;
            label4.Text = "邮箱：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(98, 231);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 14;
            label5.Text = "性别：";
            // 
            // TbReadName
            // 
            TbReadName.Location = new Point(162, 202);
            TbReadName.Name = "TbReadName";
            TbReadName.Size = new Size(156, 23);
            TbReadName.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(66, 204);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 12;
            label6.Text = "真实姓名：";
            // 
            // TbVerify
            // 
            TbVerify.Location = new Point(162, 289);
            TbVerify.Name = "TbVerify";
            TbVerify.Size = new Size(156, 23);
            TbVerify.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(82, 289);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 18;
            label7.Text = "验证码：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(66, 262);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 16;
            label8.Text = "出生日期：";
            // 
            // BtnSignUp
            // 
            BtnSignUp.Location = new Point(162, 317);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(75, 23);
            BtnSignUp.TabIndex = 20;
            BtnSignUp.Text = "注册";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(243, 317);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "取消";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 100;
            // 
            // TbNickName
            // 
            TbNickName.Location = new Point(162, 57);
            TbNickName.Name = "TbNickName";
            TbNickName.Size = new Size(156, 23);
            TbNickName.TabIndex = 26;
            toolTip1.SetToolTip(TbNickName, "填写示例：例如，John Doe");
            // 
            // DtpBirthday
            // 
            DtpBirthday.Location = new Point(162, 262);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(156, 23);
            DtpBirthday.TabIndex = 22;
            // 
            // RbMan
            // 
            RbMan.AutoSize = true;
            RbMan.Location = new Point(162, 231);
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
            RbWoman.Location = new Point(218, 231);
            RbWoman.Name = "RbWoman";
            RbWoman.Size = new Size(50, 21);
            RbWoman.TabIndex = 24;
            RbWoman.TabStop = true;
            RbWoman.Text = "女性";
            RbWoman.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label9.Location = new Point(98, 59);
            label9.Name = "label9";
            label9.Size = new Size(42, 21);
            label9.TabIndex = 25;
            label9.Text = "昵称";
            // 
            // TbOrganization
            // 
            TbOrganization.Location = new Point(162, 144);
            TbOrganization.Name = "TbOrganization";
            TbOrganization.Size = new Size(156, 23);
            TbOrganization.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label10.Location = new Point(98, 146);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 27;
            label10.Text = "组织：";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 382);
            Controls.Add(TbOrganization);
            Controls.Add(label10);
            Controls.Add(TbNickName);
            Controls.Add(label9);
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

        internal TextBox TbPassword;
        internal Label label2;
        internal TextBox TbAccount;
        internal Label label1;
        internal TextBox TbPhoneNumber;
        internal Label label3;
        internal TextBox TbMailbox;
        internal Label label4;
        internal Label label5;
        internal TextBox TbReadName;
        internal Label label6;
        internal TextBox TbVerify;
        internal Label label7;
        internal Label label8;
        internal Button BtnSignUp;
        internal Button BtnCancel;
        internal ToolTip toolTip1;
        internal DateTimePicker DtpBirthday;
        internal RadioButton RbMan;
        internal RadioButton RbWoman;
        internal TextBox TbNickName;
        internal Label label9;
        internal TextBox TbOrganization;
        internal Label label10;
    }
    }