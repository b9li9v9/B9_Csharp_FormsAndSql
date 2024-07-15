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
    /// 
    /// 
    /// 
    /// 这个写法有很大问题，1.多地登录时缓存的用户信息就冲突了，每次crud都应该立马访问一次数据库  2.一个窗口配一个数据库控制器+一个面板控制，全堆一起代码量上来就难以管理
    /// 既然是练习就接着往下写吧 不改了
    /// </summary>
    internal class GP
    {   
        // 界面
        static GP(){}
        internal Login login;
        internal Index index;
        internal SignUp signUp;
        internal SettingUserBasic settingUserBasic;

        // 数据库控制器
        internal SqlControl sqlControl;
        // 界面控制器
        internal UIManager uiManager;

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
