using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCS
{
    internal class UIManager
    {
        // 这里的单例是没有意义的，因为已经new给GP了 调用起来不是类名是实例名 _Instances是悬空的
        /*
        private static UIManager _Instances;
        public static UIManager Instances
        {
            get
            {
                if (_Instances == null)
                {
                    _Instances = new UIManager();
                }
                return _Instances;
            }
        }
        */



        // 方法 界面切换
        public void FormSwitch(Form form)
        {
            GP.Instances.login.Hide();
            GP.Instances.index.Hide();
            GP.Instances.signUp.Hide();
            GP.Instances.settingUserBasic.Hide();
            form.Show();
        }

        // 方法 基础信息初始化
        public void SettingUserBasicInit()
        {
            GP.Instances.settingUserBasic.TbNickName.Text = GP.Instances.sqlControl.NickName;
            GP.Instances.settingUserBasic.TbPassword.Text = GP.Instances.sqlControl.PassWord;
            GP.Instances.settingUserBasic.TbMailbox.Text = GP.Instances.sqlControl.MailBox;
            GP.Instances.settingUserBasic.TbPhoneNumber.Text = GP.Instances.sqlControl.PhoneNumber;
            GP.Instances.settingUserBasic.TbReadName.Text = GP.Instances.sqlControl.ReadName;
            GP.Instances.settingUserBasic.TbOrganizationID.Text = GP.Instances.sqlControl.OrganizationID==0? "":GP.Instances.sqlControl.OrganizationID.ToString();
            if (GP.Instances.sqlControl.Sex == "0")
            {
                GP.Instances.settingUserBasic.RbWoman.Checked = true;
            }
            else if(GP.Instances.sqlControl.Sex == "1")
            {
                GP.Instances.settingUserBasic.RbWoman.Checked = true;
            }
            DateTime.TryParse(GP.Instances.sqlControl.Birthday, out DateTime date);
            GP.Instances.settingUserBasic.DtpBirthday.Value = date;
            //dateTimePicker1.Value = date;  DateTime.TryParse(dateString, out DateTime date)
            //GP.Instances.settingUserBasic.DtpBirthday.Text = GP.Instances.sqlControl.Birthday;
            GP.Instances.settingUserBasic.Show();
        }

        // 注册后清理
        public void SignUpClear()
        {

        }
    }



}
