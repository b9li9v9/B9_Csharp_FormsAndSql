using Microsoft.VisualBasic.ApplicationServices;
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

namespace WinFormsCS
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        // 先到数据库检索信息，检测非"" 更新值
        // 原数据 新数据 
        private void BtnUpData_Click(object sender, EventArgs e)
        {
            GP.Instances.sqlControl.SettingForm_UpDataAccount();


        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            GP.Instances.sqlControl.SettingForm_DeleteAccount();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //GP.Instances.setting.Hide();
            //GP.Instances.index.Show();
            GP.Instances.FormSwitch(GP.Instances.index);
        }


    }
}
