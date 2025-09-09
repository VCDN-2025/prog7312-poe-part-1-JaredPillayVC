using System;
using System.Drawing;
using System.Windows.Forms;
using MunicipalityServicesApplication.Infrastructure;

namespace MunicipalityServicesApplication.App
{
    public partial class DashboardForm : Form
    {
        private readonly IssueStore _store;
        private readonly FlatFileRepository _repo;

        public DashboardForm(IssueStore store, FlatFileRepository repo)
        {
            _store = store;
            _repo = repo;

            InitializeComponent();
            BuildUi();
        }

        private void BuildUi()
        {
            Text = "Municipality Application — Dashboard";
            Width = 960; Height = 600; BackColor = Color.White;

            var header = new Label
            {
                Text = "Municipality Application",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(24, 20)
            };
            Controls.Add(header);

            var btnReport = new Button
            {
                Text = "Report an Issue",
                Location = new Point(24, 100),
                Width = 200,
                Height = 50
            };
            btnReport.Click += (_, __) =>
            {
                using var form = new IssueReportForm(_store, _repo);
                form.ShowDialog(this);
            };
            Controls.Add(btnReport);
        }
    }
}
