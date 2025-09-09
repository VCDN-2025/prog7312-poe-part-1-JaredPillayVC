using System;
using System.IO;
using System.Windows.Forms;
using MunicipalityServicesApplication.Infrastructure;

namespace MunicipalityServicesApplication.App
{
    /// <summary>
    /// Application entry point; configures default font, creates storage dependencies, and launches the dashboard.
    /// </summary>
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetDefaultFont(new Font("Segoe UI", 10, FontStyle.Regular));
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
            string storagePath = Path.Combine(projectRoot, "Data");

            if (!Directory.Exists(storagePath))
            {
                Directory.CreateDirectory(storagePath);
            }

            var repo = new FlatFileRepository(storagePath);

            var store = new IssueStore(repo);

            Application.Run(new DashboardForm(store, repo));
        }
    }
}
