namespace WinFormsCS
{
    partial class SettingUserBasic
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
            Btnabc = new Button();
            TbVerify = new TextBox();
            label7 = new Label();
            LbBirthday = new Label();
            LbSex = new Label();
            TbReadName = new TextBox();
            LbReadName = new Label();
            TbPhoneNumber = new TextBox();
            LbPhoneNumber = new Label();
            TbMailbox = new TextBox();
            LbEmailBox = new Label();
            TbPassword = new TextBox();
            LbPassWord = new Label();
            LbNickName = new Label();
            BtnDelete = new Button();
            TbNickName = new TextBox();
            TbOrganizationID = new TextBox();
            LbOrganization = new Label();
            SuspendLayout();
            // 
            // RbWoman
            // 
            RbWoman.AutoSize = true;
            RbWoman.Location = new Point(235, 205);
            RbWoman.Name = "RbWoman";
            RbWoman.Size = new Size(50, 21);
            RbWoman.TabIndex = 43;
            RbWoman.Text = "女性";
            RbWoman.UseVisualStyleBackColor = true;
            // 
            // RbMan
            // 
            RbMan.AutoSize = true;
            RbMan.Location = new Point(179, 205);
            RbMan.Name = "RbMan";
            RbMan.Size = new Size(50, 21);
            RbMan.TabIndex = 42;
            RbMan.Text = "男性";
            RbMan.UseVisualStyleBackColor = true;
            // 
            // DtpBirthday
            // 
            DtpBirthday.Location = new Point(179, 236);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(156, 23);
            DtpBirthday.TabIndex = 41;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(260, 291);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 40;
            BtnCancel.Text = "返回";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // Btnabc
            // 
            Btnabc.Location = new Point(98, 291);
            Btnabc.Name = "Btnabc";
            Btnabc.Size = new Size(75, 23);
            Btnabc.TabIndex = 39;
            Btnabc.Text = "修改";
            Btnabc.UseVisualStyleBackColor = true;
            Btnabc.Click += BtnUpData_Click;
            // 
            // TbVerify
            // 
            TbVerify.Location = new Point(179, 263);
            TbVerify.Name = "TbVerify";
            TbVerify.Size = new Size(156, 23);
            TbVerify.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(99, 263);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 37;
            label7.Text = "验证码：";
            // 
            // LbBirthday
            // 
            LbBirthday.AutoSize = true;
            LbBirthday.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbBirthday.Location = new Point(83, 236);
            LbBirthday.Name = "LbBirthday";
            LbBirthday.Size = new Size(90, 21);
            LbBirthday.TabIndex = 36;
            LbBirthday.Text = "出生日期：";
            // 
            // LbSex
            // 
            LbSex.AutoSize = true;
            LbSex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbSex.Location = new Point(115, 205);
            LbSex.Name = "LbSex";
            LbSex.Size = new Size(58, 21);
            LbSex.TabIndex = 35;
            LbSex.Text = "性别：";
            // 
            // TbReadName
            // 
            TbReadName.Location = new Point(179, 142);
            TbReadName.Name = "TbReadName";
            TbReadName.Size = new Size(156, 23);
            TbReadName.TabIndex = 34;
            // 
            // LbReadName
            // 
            LbReadName.AutoSize = true;
            LbReadName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbReadName.Location = new Point(83, 144);
            LbReadName.Name = "LbReadName";
            LbReadName.Size = new Size(90, 21);
            LbReadName.TabIndex = 33;
            LbReadName.Text = "真实姓名：";
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Location = new Point(179, 113);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(156, 23);
            TbPhoneNumber.TabIndex = 32;
            // 
            // LbPhoneNumber
            // 
            LbPhoneNumber.AutoSize = true;
            LbPhoneNumber.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbPhoneNumber.Location = new Point(83, 115);
            LbPhoneNumber.Name = "LbPhoneNumber";
            LbPhoneNumber.Size = new Size(90, 21);
            LbPhoneNumber.TabIndex = 31;
            LbPhoneNumber.Text = "手机号码：";
            // 
            // TbMailbox
            // 
            TbMailbox.Location = new Point(179, 84);
            TbMailbox.Name = "TbMailbox";
            TbMailbox.Size = new Size(156, 23);
            TbMailbox.TabIndex = 30;
            // 
            // LbEmailBox
            // 
            LbEmailBox.AutoSize = true;
            LbEmailBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbEmailBox.Location = new Point(115, 86);
            LbEmailBox.Name = "LbEmailBox";
            LbEmailBox.Size = new Size(58, 21);
            LbEmailBox.TabIndex = 29;
            LbEmailBox.Text = "邮箱：";
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(179, 55);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.Size = new Size(156, 23);
            TbPassword.TabIndex = 28;
            // 
            // LbPassWord
            // 
            LbPassWord.AutoSize = true;
            LbPassWord.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbPassWord.Location = new Point(115, 57);
            LbPassWord.Name = "LbPassWord";
            LbPassWord.Size = new Size(58, 21);
            LbPassWord.TabIndex = 27;
            LbPassWord.Text = "密码：";
            // 
            // LbNickName
            // 
            LbNickName.AutoSize = true;
            LbNickName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbNickName.Location = new Point(115, 28);
            LbNickName.Name = "LbNickName";
            LbNickName.Size = new Size(58, 21);
            LbNickName.TabIndex = 25;
            LbNickName.Text = "昵称：";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(179, 292);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 44;
            BtnDelete.Text = "删除账号";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // TbNickName
            // 
            TbNickName.Location = new Point(179, 27);
            TbNickName.Name = "TbNickName";
            TbNickName.Size = new Size(156, 23);
            TbNickName.TabIndex = 45;
            // 
            // TbOrganizationID
            // 
            TbOrganizationID.Location = new Point(179, 171);
            TbOrganizationID.Name = "TbOrganizationID";
            TbOrganizationID.Size = new Size(156, 23);
            TbOrganizationID.TabIndex = 47;
            // 
            // LbOrganization
            // 
            LbOrganization.AutoSize = true;
            LbOrganization.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LbOrganization.Location = new Point(83, 173);
            LbOrganization.Name = "LbOrganization";
            LbOrganization.Size = new Size(90, 21);
            LbOrganization.TabIndex = 46;
            LbOrganization.Text = "组织编号：";
            // 
            // SettingUserBasic
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 347);
            Controls.Add(TbOrganizationID);
            Controls.Add(LbOrganization);
            Controls.Add(TbNickName);
            Controls.Add(BtnDelete);
            Controls.Add(RbWoman);
            Controls.Add(RbMan);
            Controls.Add(DtpBirthday);
            Controls.Add(BtnCancel);
            Controls.Add(Btnabc);
            Controls.Add(TbVerify);
            Controls.Add(label7);
            Controls.Add(LbBirthday);
            Controls.Add(LbSex);
            Controls.Add(TbReadName);
            Controls.Add(LbReadName);
            Controls.Add(TbPhoneNumber);
            Controls.Add(LbPhoneNumber);
            Controls.Add(TbMailbox);
            Controls.Add(LbEmailBox);
            Controls.Add(TbPassword);
            Controls.Add(LbPassWord);
            Controls.Add(LbNickName);
            Name = "SettingUserBasic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            FormClosing += SettingUserBasic_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal RadioButton RbWoman;
        internal RadioButton RbMan;
        internal DateTimePicker DtpBirthday;
        internal Button BtnCancel;
        internal Button Btnabc;
        internal TextBox TbVerify;
        internal Label label7;
        internal Label LbBirthday;
        internal Label LbSex;
        internal TextBox TbReadName;
        internal Label LbReadName;
        internal TextBox TbPhoneNumber;
        internal Label LbPhoneNumber;
        internal TextBox TbMailbox;
        internal Label LbEmailBox;
        internal TextBox TbPassword;
        internal Label LbPassWord;
        internal Label LbNickName;
        internal Button BtnDelete;
        internal TextBox TbNickName;
        internal TextBox TbOrganizationID;
        internal Label LbOrganization;
    }
}