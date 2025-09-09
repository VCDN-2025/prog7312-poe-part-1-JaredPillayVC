using System;
using System.IO;
using System.Windows.Forms;
using MunicipalityServicesApplication.Infrastructure;

namespace MunicipalityServicesApplication.App
{
    public partial class DashboardForm : Form
    {
        // Keep one instance of the persistence services for the app lifetime
        private readonly FlatFileRepository _repo;
        private readonly IssueStore _store;

        public DashboardForm()
        {
            InitializeComponent();

            // Prepare a data folder under Documents
            var dataDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "MunicipalityServicesAppData_Jared");

            _repo = new FlatFileRepository(dataDir);
            _store = new IssueStore(_repo);
        }

        // Sidebar button: "Report an Issue"
        private void btnReport_Click(object sender, EventArgs e)
        {
            using var report = new IssueReportForm(_store, _repo);
            report.ShowDialog(this);
        }

        // Card button: "Open Form"
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            using var report = new IssueReportForm(_store, _repo);
            report.ShowDialog(this);
        }
    }
}
