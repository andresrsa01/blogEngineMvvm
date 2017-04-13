using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BlogEngine.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            base.OnStartup(e);
#if DEBUG
            try
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();
            }
            catch (Exception)
            {

                throw;
            }

#else
            Login login = new Login();
            login.Show();
#endif
        }
    }
}
