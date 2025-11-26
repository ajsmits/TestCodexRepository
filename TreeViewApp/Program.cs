using System;
using System.Configuration;
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
            var connectionString = ConfigurationManager.ConnectionStrings["CompanyDb"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show(
                    "Connection string 'CompanyDb' is missing from configuration.",
                    "Configuration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm(connectionString));
        }
    }
}
