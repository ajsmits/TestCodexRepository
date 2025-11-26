using System;
using System.Windows.Forms;

namespace TreeViewApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var connectionString = Environment.GetEnvironmentVariable("COMPANY_DB_CONNECTION_STRING")
                ?? "Data Source=localhost;Initial Catalog=WebUI;Integrated Security=True";

            Application.Run(new MainForm(connectionString));
        }
    }
}
