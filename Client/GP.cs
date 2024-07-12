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

        static GP(){}
        public Login login;
        public Index index;
        public SignUp signUp;
        public Setting setting;
        public SqlControl sqlControl;

        // 用户信息
        public string UserName;
        public byte[] Password;

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
