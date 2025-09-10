using System;
using System.Drawing;
using System.Windows.Forms;
using MunicipalityServicesApplication.Infrastructure;

namespace MunicipalityServicesApplication.App
{
    /// <summary>
    /// Main dashboard with a branded sidebar and a hero card, acting as the starting point for Task 2 actions.
    /// </summary>
    public partial class DashboardForm : Form
    {
        private readonly IssueStore _issueStore;
        private readonly FlatFileRepository _repo;

        public DashboardForm(IssueStore store, FlatFileRepository repo)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            _issueStore = store;
            _repo = repo;

            ApplyTheme();
            UpdateNavButtonWidths();
        }


        private void ApplyTheme()
        {
            // Brand color
            var brand = Color.FromArgb(0, 121, 118);
            lblTitle.ForeColor = brand;
            lblBrand.ForeColor = brand;

            // Hover/pressed styles for the primary nav button
            btnReport.MouseEnter += (_, __) => btnReport.BackColor = Color.FromArgb(246, 251, 251);
            btnReport.MouseLeave += (_, __) => btnReport.BackColor = Color.White;

            // Uniform text alignment
            btnReport.TextAlign = ContentAlignment.MiddleCenter;
            btnEvents.TextAlign = ContentAlignment.MiddleCenter;
            btnStatus.TextAlign = ContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Opens the Issue Report form from the card button.
        /// </summary>
        private void btnOpenForm_Click(object? sender, EventArgs e) => OpenIssueForm();

        /// <summary>
        /// Opens the Issue Report form from the left nav button.
        /// </summary>
        private void btnReport_Click(object? sender, EventArgs e) => OpenIssueForm();

        /// <summary>
        /// Opens the Issue Report form
        /// </summary>
        private void OpenIssueForm()
        {
            using var f = new IssueReportForm(_issueStore, _repo);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }

        /// <summary>
        /// Keep nav buttons responsive when window resizes/maximizes.
        /// </summary>
        private void DashboardForm_Resize(object? sender, EventArgs e) => UpdateNavButtonWidths();

        private void UpdateNavButtonWidths()
        {
            // Make each nav button span the full width of the single column
            int w = tableNav.ClientSize.Width;
            btnReport.Width = w;
            btnEvents.Width = w;
            btnStatus.Width = w;
        }
    }
}
