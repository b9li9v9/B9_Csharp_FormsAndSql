using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormsCS
{
    public partial class Index : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public Index()
        {
            InitializeComponent();
        }


        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// 关闭按钮
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IndexBtnTest_Click(object sender, EventArgs e)
        {
            //GP.Instances.setting.Show();
            //GP.Instances.index.Hide();
            GP.Instances.FormSwitch(GP.Instances.setting);
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION,0);
        }
    }
}
