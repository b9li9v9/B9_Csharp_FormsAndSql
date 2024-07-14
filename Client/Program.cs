namespace WinFormsCS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            GP.Instances.login = new Login();
            GP.Instances.index = new Index();
            GP.Instances.signUp = new SignUp();
            GP.Instances.setting = new Setting();
            GP.Instances.sqlControl = new SqlControl();
            Application.Run(GP.Instances.login);
        }
    }
}