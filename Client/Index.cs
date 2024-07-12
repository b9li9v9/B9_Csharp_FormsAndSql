using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCS
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void IndexBtnTest_Click(object sender, EventArgs e)
        {
            GP.Instances.setting = new Setting();
            GP.Instances.setting.Show();
            GP.Instances.index.Hide();
        }
    }
}
