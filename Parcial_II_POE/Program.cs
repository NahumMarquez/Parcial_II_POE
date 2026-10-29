using System;
using System.Windows.Forms;
using RepoDb;

namespace Parcial_II_POE
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Necesario una sola vez para que RepoDB funcione con SQL Server
            GlobalConfiguration.Setup().UseSqlServer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formularios.Panel());
        }
    }
}
