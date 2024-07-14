using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCS
{
    /// <summary>
    /// Global Panel
    /// 全局面板 单例模式
    /// </summary>
    internal class GP
    {   
        // 界面
        static GP(){}
        internal Login login;
        internal Index index;
        internal SignUp signUp;
        internal Setting setting;

        // 界面切换
        public void FormSwitch(Form form)
        {
            this.login.Hide();
            this.index.Hide();
            this.signUp.Hide();
            this.setting.Hide();
            form.Show();
        }
        
        // 数据库
        internal SqlControl sqlControl;

        // 单例
        private static GP _Instances;
        public static GP Instances
        {
            get
            {
                if (_Instances == null)
                {
                    _Instances = new GP();
                }
                return _Instances;
            }
        }



    }
}
