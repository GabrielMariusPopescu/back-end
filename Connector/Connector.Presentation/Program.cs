using Connector.Library;
using Connector.Presentation.Services;
using System;
using System.Windows.Forms;

namespace Connector.Presentation
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfiguration.InitializeConnection(DatabaseType.Sql);
            // Application.Run(new ProfileForm());
            Application.Run(new MainForm(new MainLogic()));
        }
    }
}
