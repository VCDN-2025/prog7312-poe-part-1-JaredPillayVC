using System;
using System.IO;
using System.Windows.Forms;
using MunicipalityServicesApplication.Infrastructure;

namespace MunicipalityServicesApplication.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var dataDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "MunicipalityServicesAppData_Jared");

            var repo = new FlatFileRepository(dataDir);
            var store = new IssueStore(repo);

            Application.Run(new DashboardForm(store, repo));
        }
    }
}
