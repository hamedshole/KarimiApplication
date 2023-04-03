using KarimiApp.Client.View;
using KarimiApp.Client.View.Settings;
using KarimiApp.Model;
using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace KarimiApp.Client.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo perCulture = new CultureInfo("fa-ir");
            CultureInfo.DefaultThreadCurrentCulture = perCulture;
            CultureInfo.DefaultThreadCurrentUICulture = perCulture;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app= config.AppSettings;

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ////  KarimiApp.Client.View.Edit.AddInventoryItemDetail addInventoryItem = new View.Edit.AddInventoryItemDetail();
            //Application.Run(new CashierPage());
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (app.Settings.Count == 0)
                {
                    View.Settings.ClientFirstConfig firstConfig = new ClientFirstConfig();
                    Application.Run(firstConfig);
                }
                else
                {
                    LoginPage login = new LoginPage();
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        UserModel loggeduser = login.LoginValue().Result;
                        CashierMain cashierMain = new CashierMain(loggeduser);
                        Application.Run(cashierMain);
                    }
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
    }
}

