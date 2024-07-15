using System.Drawing;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripSplitButton();
            用户设置ToolStripMenuItem = new ToolStripMenuItem();
            TsmSettingUserBasic = new ToolStripMenuItem();
            组织信息ToolStripMenuItem = new ToolStripMenuItem();
            界面设置ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLightLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.MouseDown += toolStrip1_MouseDown;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Transparent;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "关闭";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { 用户设置ToolStripMenuItem, 界面设置ToolStripMenuItem });
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(48, 22);
            toolStripDropDownButton1.Text = "设置";
            // 
            // 用户设置ToolStripMenuItem
            // 
            用户设置ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TsmSettingUserBasic, 组织信息ToolStripMenuItem });
            用户设置ToolStripMenuItem.Name = "用户设置ToolStripMenuItem";
            用户设置ToolStripMenuItem.Size = new Size(180, 22);
            用户设置ToolStripMenuItem.Text = "用户设置";
            // 
            // TsmSettingUserBasic
            // 
            TsmSettingUserBasic.Name = "TsmSettingUserBasic";
            TsmSettingUserBasic.Size = new Size(180, 22);
            TsmSettingUserBasic.Text = "基础信息";
            TsmSettingUserBasic.Click += TsmSettingUserBasic_Click;
            // 
            // 组织信息ToolStripMenuItem
            // 
            组织信息ToolStripMenuItem.Name = "组织信息ToolStripMenuItem";
            组织信息ToolStripMenuItem.Size = new Size(180, 22);
            组织信息ToolStripMenuItem.Text = "组织信息";
            // 
            // 界面设置ToolStripMenuItem
            // 
            界面设置ToolStripMenuItem.Name = "界面设置ToolStripMenuItem";
            界面设置ToolStripMenuItem.Size = new Size(180, 22);
            界面设置ToolStripMenuItem.Text = "界面设置";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "hi, ";
            FormClosing += Index_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSplitButton toolStripDropDownButton1;
        private ToolStripMenuItem 用户设置ToolStripMenuItem;
        private ToolStripMenuItem TsmSettingUserBasic;
        private ToolStripMenuItem 组织信息ToolStripMenuItem;
        private ToolStripMenuItem 界面设置ToolStripMenuItem;


    }
}