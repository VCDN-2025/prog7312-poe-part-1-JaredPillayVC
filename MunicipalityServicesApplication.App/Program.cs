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

            // Define a folder for storage (e.g., AppData folder or local project directory)
            string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            // Ensure the folder exists
            if (!Directory.Exists(storagePath))
            {
                Directory.CreateDirectory(storagePath);
            }

            // Create repository with storage path
            var repo = new FlatFileRepository(storagePath);

            // Pass repository into IssueStore
            var store = new IssueStore(repo);

            // Run dashboard with dependencies
            Application.Run(new DashboardForm(store, repo));
        }
    }
}
