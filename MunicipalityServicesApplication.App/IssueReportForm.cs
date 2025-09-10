using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using MunicipalityServicesApplication.DataStructures;
using MunicipalityServicesApplication.Domain;
using MunicipalityServicesApplication.Infrastructure;
using MunicipalityServicesApplication.Services.Geo;
using MunicipalityServicesApplication.Services.Validation;

namespace MunicipalityServicesApplication.App
{
    public partial class IssueReportForm : Form
    {
        private readonly IssueStore _store;
        private readonly FlatFileRepository _repo;

        private readonly Debounce _debounce = new();
        private readonly GeoCache _geoCache = new(20);
        private readonly GeoLookupClient _geo; // created in ctor with shared HttpClient
        private readonly ValidationSummary _summary = new();

        private readonly ForwardList<Attachment> _attachments = new();

        public IssueReportForm(IssueStore store, FlatFileRepository repo)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _store = store;
            _repo = repo;
            _geo = new GeoLookupClient(new HttpClient(), _geoCache);

            cboCategory.DataSource = Enum.GetNames(typeof(IssueCategory));
            cboCategory.SelectedItem = null;
            cboCategory.Text = "Select a category...";
            progressGeo.Visible = true;

            txtLocation.TextChanged += (_, __) =>
            {
                _debounce.Run(async () => await CheckAddressAsync(), 400);
                UpdateCompletionProgress();
            };
            cboCategory.SelectedIndexChanged += (_, __) => UpdateCompletionProgress();
            rtbDescription.TextChanged += (_, __) => UpdateCompletionProgress();

            txtLocation.Validating += new System.ComponentModel.CancelEventHandler(txtLocation_Validating);
            cboCategory.Validating += new System.ComponentModel.CancelEventHandler(cboCategory_Validating);
            rtbDescription.Validating += new System.ComponentModel.CancelEventHandler(rtbDescription_Validating);

            UpdateCompletionProgress();
            UpdateQuickTip();
        }

        private void UpdateQuickTip()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) || txtLocation.Text.Trim().Length < 5)
            {
                lblQuickTip.Text = "Quick Tip: Start by entering a detailed location for the issue.";
            }
            else if (cboCategory.SelectedItem == null)
            {
                lblQuickTip.Text = "Quick Tip: Next, please select a category for the issue.";
            }
            else if (string.IsNullOrWhiteSpace(rtbDescription.Text) || rtbDescription.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length < 5)
            {
                lblQuickTip.Text = "Quick Tip: Now, provide a clear and detailed description (at least 5 words).";
            }
            else if (_attachments.Count == 0)
            {
                lblQuickTip.Text = "Quick Tip: Finally, add at least one attachment to support your report.";
            }
            else
            {
                lblQuickTip.Text = "Quick Tip: The form is complete! You can now click Submit.";
            }
        }

        private void txtLocation_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            var (ok, message) = FieldRules.RequireLocation(txtLocation.Text, _summary);
            if (!ok)
            {
                errorProvider1.SetError(txtLocation, message);
            }
            else
            {
                errorProvider1.SetError(txtLocation, "");
            }
        }

        private void cboCategory_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            var (ok, message) = FieldRules.RequireCategory(cboCategory.SelectedItem, _summary);
            if (!ok)
            {
                errorProvider1.SetError(cboCategory, message);
            }
            else
            {
                errorProvider1.SetError(cboCategory, "");
            }
        }

        private void rtbDescription_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            var (ok, message) = FieldRules.DescriptionMinWords(rtbDescription.Text, 5, _summary);
            if (!ok)
            {
                errorProvider1.SetError(rtbDescription, message);
            }
            else
            {
                errorProvider1.SetError(rtbDescription, "");
            }
        }

        private void lblNormalized_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblNormalized.Text))
            {
                txtLocation.Text = lblNormalized.Text;
            }
        }

        private void UpdateCompletionProgress()
        {
            int progress = 0;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text) && txtLocation.Text.Trim().Length >= 5)
            {
                progress += 25;
            }
            if (cboCategory.SelectedItem != null)
            {
                progress += 25;
            }
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length >= 5)
            {
                progress += 25;
            }
            if (_attachments.Count > 0)
            {
                progress += 25;
            }
            progressCompletion.Value = Math.Min(100, progress);
            UpdateQuickTip();
        }

        private async Task CheckAddressAsync()
        {
            var text = txtLocation.Text.Trim();

            if (text.Length < 5)
            {
                progressGeo.Style = ProgressBarStyle.Blocks;
                progressGeo.Value = 0;
                lblGeoStatus.ForeColor = Color.DimGray;
                lblGeoStatus.Text = "Enter a more specific location…";
                lblNormalized.Text = "";
                return;
            }

            try
            {
                progressGeo.Style = ProgressBarStyle.Marquee;
                lblGeoStatus.ForeColor = Color.DimGray;
                lblGeoStatus.Text = "Validating address…";

                var place = await _geo.SearchAsync(text);

                progressGeo.Style = ProgressBarStyle.Blocks;
                progressGeo.Value = 0;

                if (place == null)
                {
                    lblGeoStatus.ForeColor = Color.Firebrick;
                    lblGeoStatus.Text = "Address not recognised.";
                    lblNormalized.Text = "";
                    return;
                }

                lblGeoStatus.ForeColor = Color.SeaGreen;
                lblGeoStatus.Text = "Address recognised";
                lblNormalized.Text = place.display_name ?? "";
            }
            catch
            {
                progressGeo.Style = ProgressBarStyle.Blocks;
                progressGeo.Value = 0;
                lblGeoStatus.ForeColor = Color.Firebrick;
                lblGeoStatus.Text = "Validation service unavailable.";
                lblNormalized.Text = "";
            }
        }

        private void btnAddAttachment_Click(object? sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Filter = "Images/PDF|*.jpg;*.jpeg;*.png;*.heic;*.pdf",
                Multiselect = false
            };
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            var fi = new FileInfo(dlg.FileName);
            var stored = _repo.StoreAttachment(dlg.FileName);
            _attachments.AddLast(new Attachment(dlg.FileName, stored, fi.Length));
            lstAttachments.Items.Add(Path.GetFileName(dlg.FileName));
            UpdateCompletionProgress();
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            _summary.Clear();

            var locOk = FieldRules.RequireLocation(txtLocation.Text, _summary);
            if (!locOk.ok) errorProvider1.SetError(txtLocation, locOk.message);

            var catOk = FieldRules.RequireCategory(cboCategory.SelectedItem, _summary);
            if (!catOk.ok) errorProvider1.SetError(cboCategory, catOk.message);

            var descOk = FieldRules.DescriptionMinWords(rtbDescription.Text, 5, _summary);
            if (!descOk.ok) errorProvider1.SetError(rtbDescription, descOk.message);

            var attOk = FieldRules.CheckAttachments(_attachments, _summary);
            if (!attOk.ok) errorProvider1.SetError(lstAttachments, attOk.message);

            return locOk.ok && catOk.ok && descOk.ok && attOk.ok;
        }

        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show(this, "Please correct the highlighted fields.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = $"MAPP-{DateTime.UtcNow:yyyyMMddHHmmssfff}-{Guid.NewGuid().ToString("N")[..6].ToUpper()}";
            var issue = new Issue(id,
                                  txtLocation.Text.Trim(),
                                  Enum.Parse<IssueCategory>(cboCategory.SelectedItem!.ToString()!),
                                  rtbDescription.Text.Trim(),
                                  DateTime.UtcNow,
                                  _attachments);

            _store.Add(issue);
            Clipboard.SetText(id);

            MessageBox.Show(this, $"Issue submitted. Tracking number: {id}\n(Copied to clipboard)",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
