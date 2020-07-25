using DesignPatterns.Business;
using System;
using System.Windows.Forms;

namespace DesignPatterns
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var businessLogic = new BusinessLogic();
            Application.Run(new MainForm(businessLogic));
        }
    }
}
