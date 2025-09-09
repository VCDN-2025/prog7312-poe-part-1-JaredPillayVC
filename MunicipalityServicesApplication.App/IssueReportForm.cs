using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using MunicipalityServicesApplication.Domain;
using MunicipalityServicesApplication.DataStructures;
using MunicipalityServicesApplication.Infrastructure;
using MunicipalityServicesApplication.Services;

using DomainAttachment = MunicipalityServicesApplication.Domain.Attachment;

namespace MunicipalityServicesApplication.App
{
    public partial class IssueReportForm : Form
    {
        // Dependencies
        private readonly IssueStore _store;
        private readonly FlatFileRepository _repo;

        // Custom DS for attachments
        private readonly ForwardList<DomainAttachment> _attachments = new();

        // UI controls
        private readonly TextBox txtLocation = new() { Location = new Point(24, 64), Width = 520 };
        private readonly ComboBox cboCategory = new() { Location = new Point(24, 128), Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
        private readonly RichTextBox rtbDescription = new() { Location = new Point(24, 192), Width = 520, Height = 140 };
        private readonly ListBox lstAttachments = new() { Location = new Point(568, 64), Width = 260, Height = 220 };
        private readonly ProgressBar _progress = new() { Location = new Point(24, 352), Size = new Size(520, 14) };
        private readonly Label _progressText = new() { Location = new Point(24, 370), AutoSize = true, Text = "0% complete" };

        public IssueReportForm(IssueStore store, FlatFileRepository repo)
        {
            _store = store;
            _repo = repo;

            InitializeComponent();   // defined in Designer partial
            BuildUi();               // custom layout
        }

        private void BuildUi()
        {
            // Labels + inputs
            Controls.Add(new Label { Text = "Location*", Location = new Point(24, 40) });
            Controls.Add(txtLocation);

            Controls.Add(new Label { Text = "Category*", Location = new Point(24, 104) });
            Controls.Add(cboCategory);

            Controls.Add(new Label { Text = "Description*", Location = new Point(24, 168) });
            Controls.Add(rtbDescription);

            Controls.Add(new Label { Text = "Attachments (optional)", Location = new Point(568, 40) });
            Controls.Add(lstAttachments);

            Controls.Add(_progress);
            Controls.Add(_progressText);

            cboCategory.Items.AddRange(Enum.GetNames(typeof(IssueCategory)));

            var btnAdd = new Button { Text = "Add Attachment", Location = new Point(568, 292), Width = 260 };
            var btnSubmit = new Button { Text = "Submit", Location = new Point(24, 400), Width = 140 };
            Controls.Add(btnAdd);
            Controls.Add(btnSubmit);

            txtLocation.TextChanged += ValidateAndProgress;
            rtbDescription.TextChanged += ValidateAndProgress;
            cboCategory.SelectedIndexChanged += ValidateAndProgress;
            btnAdd.Click += (_, __) => AddAttachment();
            btnSubmit.Click += (_, __) => Submit();
        }

        private void ValidateAndProgress(object? sender, EventArgs e)
        {
            int progress = 0;
            if (InputValidator.Location(txtLocation.Text).ok) progress += 33;
            if (cboCategory.SelectedIndex >= 0) progress += 33;
            if (InputValidator.Description(rtbDescription.Text).ok) progress += 34;

            _progress.Value = Math.Max(0, Math.Min(100, progress));
            _progressText.Text = $"{progress}% complete";
        }

        private void AddAttachment()
        {
            using var dlg = new OpenFileDialog
            {
                Filter = "Images/PDF|*.jpg;*.jpeg;*.png;*.heic;*.pdf",
                Multiselect = false,
                Title = "Select an attachment"
            };

            if (dlg.ShowDialog() != DialogResult.OK) return;

            var path = dlg.FileName;
            var v = InputValidator.Attachment(path);
            if (!v.ok)
            {
                MessageBox.Show(v.error, "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stored = _repo.StoreAttachment(path);
            var fi = new FileInfo(path);

            _attachments.AddLast(new DomainAttachment(path, stored, fi.Length));
            lstAttachments.Items.Add(Path.GetFileName(path));
        }

        private void Submit()
        {
            var loc = InputValidator.Location(txtLocation.Text);
            if (!loc.ok) { MessageBox.Show(loc.error, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cboCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var des = InputValidator.Description(rtbDescription.Text);
            if (!des.ok) { MessageBox.Show(des.error, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var id = TicketIdFactory.NewId();
            var category = (IssueCategory)Enum.Parse(typeof(IssueCategory), cboCategory.SelectedItem!.ToString()!);

            var issue = new Issue(
                ticketId: id,
                location: txtLocation.Text.Trim(),
                category: category,
                description: rtbDescription.Text.Trim(),
                createdUtc: DateTime.UtcNow,
                attachments: _attachments
            );

            _store.Add(issue);

            Clipboard.SetText(id);
            MessageBox.Show($"Ticket created: {id}\n(Copied to clipboard)", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
