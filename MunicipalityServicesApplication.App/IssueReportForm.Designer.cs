using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityServicesApplication.App
{
    partial class IssueReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // Header
            panelHeader = new Panel();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 48;
            panelHeader.BackColor = ColorTranslator.FromHtml("#007A78");
            panelHeader.Name = "panelHeader";

            lblHdrIcon = new Label();
            lblHdrIcon.AutoSize = true;
            lblHdrIcon.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblHdrIcon.ForeColor = Color.White;
            lblHdrIcon.Location = new Point(14, 12);
            lblHdrIcon.Text = "";

            lblHdrTitle = new Label();
            lblHdrTitle.AutoSize = true;
            lblHdrTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHdrTitle.ForeColor = Color.White;
            lblHdrTitle.Location = new Point(40, 14);
            lblHdrTitle.Text = "Report an Issue";

            panelHeader.Controls.Add(lblHdrIcon);
            panelHeader.Controls.Add(lblHdrTitle);

            // Left column
            lblLocation = new Label();
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(24, 64);
            lblLocation.Text = "Location*";

            txtLocation = new TextBox();
            txtLocation.Location = new Point(24, 84);
            txtLocation.Size = new Size(520, 23);

            lblCategory = new Label();
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(24, 120);
            lblCategory.Text = "Category*";

            cboCategory = new ComboBox();
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(24, 140);
            cboCategory.Size = new Size(240, 23);

            lblDescription = new Label();
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(24, 176);
            lblDescription.Text = "Description*";

            rtbDescription = new RichTextBox();
            rtbDescription.Location = new Point(24, 196);
            rtbDescription.Size = new Size(520, 140);

            // Right column
            lblAttach = new Label();
            lblAttach.AutoSize = true;
            lblAttach.Location = new Point(560, 64);
            lblAttach.Text = "Attachments (optional)";

            lstAttachments = new ListBox();
            lstAttachments.Location = new Point(560, 84);
            lstAttachments.Size = new Size(240, 220);

            btnAddAttachment = new Button();
            btnAddAttachment.Location = new Point(560, 312);
            btnAddAttachment.Size = new Size(240, 32);
            btnAddAttachment.Text = "Add Attachment";

            // Bottom
            progress = new ProgressBar();
            progress.Location = new Point(24, 350);
            progress.Size = new Size(520, 16);
            progress.Minimum = 0;
            progress.Maximum = 100;
            progress.Value = 0;

            lblProgress = new Label();
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(24, 370);
            lblProgress.Text = "0% complete";

            btnSubmit = new Button();
            btnSubmit.Location = new Point(24, 400);
            btnSubmit.Size = new Size(140, 34);
            btnSubmit.Text = "Submit";
            btnSubmit.BackColor = ColorTranslator.FromHtml("#007A78");
            btnSubmit.ForeColor = Color.White;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lblProgress);
            Controls.Add(progress);
            Controls.Add(btnAddAttachment);
            Controls.Add(lstAttachments);
            Controls.Add(lblAttach);
            Controls.Add(rtbDescription);
            Controls.Add(lblDescription);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(panelHeader);
            MinimumSize = new Size(860, 460);
            Name = "IssueReportForm";
            Text = "Report an Issue";
            StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        private Panel panelHeader;
        private Label lblHdrIcon;
        private Label lblHdrTitle;

        private Label lblLocation;
        public TextBox txtLocation;
        private Label lblCategory;
        public ComboBox cboCategory;
        private Label lblDescription;
        public RichTextBox rtbDescription;

        private Label lblAttach;
        public ListBox lstAttachments;
        public Button btnAddAttachment;

        public ProgressBar progress;
        public Label lblProgress;
        public Button btnSubmit;
    }
}
