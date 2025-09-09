using MunicipalityServicesApplication.DataStructures;
using MunicipalityServicesApplication.Domain;
using MunicipalityServicesApplication.Infrastructure;
using MunicipalityServicesApplication.Services;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityServicesApplication.App
{
    public partial class IssueReportForm : Form
    {
        private readonly IssueStore _store;
        private readonly FlatFileRepository _repo;

        private readonly ForwardList<Domain.Attachment> _attachments = new();

        /// <summary>
        /// Issue Report Form that validates user input, manages attachments with a custom ForwardList, and persists issues.
        /// </summary>
        public IssueReportForm(IssueStore store, FlatFileRepository repo)
        {
            _store = store;
            _repo = repo;

            InitializeComponent();

            // Populate categories
            cboCategory.Items.AddRange(Enum.GetNames(typeof(IssueCategory)));

            // Wire events
            txtLocation.TextChanged += ValidateAndProgress;
            rtbDescription.TextChanged += ValidateAndProgress;
            cboCategory.SelectedIndexChanged += ValidateAndProgress;

            btnAddAttachment.Click += BtnAddAttachment_Click;
            btnSubmit.Click += BtnSubmit_Click;
        }

        /// <summary>
        /// Adds a validated attachment and lists it in the UI.
        /// </summary>
        private void BtnAddAttachment_Click(object? sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Filter = "Images/PDF|*.jpg;*.jpeg;*.png;*.heic;*.pdf",
                Multiselect = false
            };

            if (dlg.ShowDialog() != DialogResult.OK) return;

            var check = InputValidator.Attachment(dlg.FileName);
            if (!check.ok)
            {
                MessageBox.Show(check.error, "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string stored = _repo.StoreAttachment(dlg.FileName);
            var fi = new FileInfo(dlg.FileName);

            _attachments.AddLast(new Domain.Attachment(dlg.FileName, stored, fi.Length));
            lstAttachments.Items.Add(Path.GetFileName(dlg.FileName));
        }

        /// <summary>
        /// Validates fields and updates the progress indicator to guide completion.
        /// </summary>
        private void ValidateAndProgress(object? sender, EventArgs e)
        {
            int progressValue = 0;

            // Location
            var loc = InputValidator.Location(txtLocation.Text);
            if (loc.ok) progressValue += 33;

            // Category
            if (cboCategory.SelectedIndex >= 0) progressValue += 33;

            // Description
            var des = InputValidator.Description(rtbDescription.Text);
            if (des.ok) progressValue += 34;

            progress.Value = Math.Max(0, Math.Min(100, progressValue));
            lblProgress.Text = $"{progress.Value}% complete";
        }

        /// <summary>
        /// Finalizes validation, generates a ticket id, persists the issue, and shows success feedback.
        /// </summary>
        private void BtnSubmit_Click(object? sender, EventArgs e)
        {
            // Validate all
            var vLoc = InputValidator.Location(txtLocation.Text);
            if (!vLoc.ok) { Warn(vLoc.error); return; }

            if (cboCategory.SelectedIndex < 0) { Warn("Please select a category."); return; }
            var category = (IssueCategory)Enum.Parse(typeof(IssueCategory), cboCategory.SelectedItem!.ToString()!);

            var vDes = InputValidator.Description(rtbDescription.Text);
            if (!vDes.ok) { Warn(vDes.error); return; }

            // Create and store issue
            var id = TicketIdFactory.NewId();
            var issue = new Issue(id, txtLocation.Text.Trim(), category, rtbDescription.Text.Trim(),
                                  DateTime.UtcNow, _attachments);

            _store.Add(issue);

            Clipboard.SetText(id);
            MessageBox.Show($"Ticket created: {id}\n(Copied to clipboard)", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private static void Warn(string msg) =>
            MessageBox.Show(msg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
