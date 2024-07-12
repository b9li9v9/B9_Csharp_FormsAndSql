namespace WinFormsCS
{
    partial class Index
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
            IndexBtnTest = new Button();
            IndexLbtest = new Label();
            SuspendLayout();
            // 
            // IndexBtnTest
            // 
            IndexBtnTest.Location = new Point(12, 12);
            IndexBtnTest.Name = "IndexBtnTest";
            IndexBtnTest.Size = new Size(72, 63);
            IndexBtnTest.TabIndex = 0;
            IndexBtnTest.Text = "用户设置";
            IndexBtnTest.UseVisualStyleBackColor = true;
            IndexBtnTest.Click += IndexBtnTest_Click;
            // 
            // IndexLbtest
            // 
            IndexLbtest.AutoSize = true;
            IndexLbtest.Location = new Point(353, 218);
            IndexLbtest.Name = "IndexLbtest";
            IndexLbtest.Size = new Size(29, 17);
            IndexLbtest.TabIndex = 1;
            IndexLbtest.Text = "test";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IndexLbtest);
            Controls.Add(IndexBtnTest);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "hi, ";
            FormClosing += Index_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IndexBtnTest;
        private Label IndexLbtest;
    }
}