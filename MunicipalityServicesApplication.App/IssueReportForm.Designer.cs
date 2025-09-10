namespace MunicipalityServicesApplication.App
{
    partial class IssueReportForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.Button btnSubmit;

        // GEO UI
        private System.Windows.Forms.ProgressBar progressGeo;
        private System.Windows.Forms.Label lblGeoStatus;
        private System.Windows.Forms.Label lblNormalized;

        // Completion Progress
        private System.Windows.Forms.ProgressBar progressCompletion;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        /// <summary>Clean up any resources being used.</summary>
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

            lblTitle = new System.Windows.Forms.Label();
            lblLocation = new System.Windows.Forms.Label();
            txtLocation = new System.Windows.Forms.TextBox();
            lblCategory = new System.Windows.Forms.Label();
            cboCategory = new System.Windows.Forms.ComboBox();
            lblDescription = new System.Windows.Forms.Label();
            rtbDescription = new System.Windows.Forms.RichTextBox();
            lblAttachments = new System.Windows.Forms.Label();
            lstAttachments = new System.Windows.Forms.ListBox();
            btnAddAttachment = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();

            progressGeo = new System.Windows.Forms.ProgressBar();
            lblGeoStatus = new System.Windows.Forms.Label();
            lblNormalized = new System.Windows.Forms.Label();
            progressCompletion = new System.Windows.Forms.ProgressBar();

            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Report an Issue";
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.BackColor = System.Drawing.Color.White;

            // Title
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(24, 18);
            lblTitle.Text = "Report an Issue";

            // Location
            lblLocation.AutoSize = true;
            lblLocation.Location = new System.Drawing.Point(24, 70);
            lblLocation.Text = "Location*";

            // txtLocation
            txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            txtLocation.Location = new System.Drawing.Point(24, 90);
            txtLocation.Size = new System.Drawing.Size(520, 23);

            // Geo progress
            progressGeo.Location = new System.Drawing.Point(24, 118);
            progressGeo.Size = new System.Drawing.Size(220, 8);
            progressGeo.Style = System.Windows.Forms.ProgressBarStyle.Blocks;

            // Geo status
            lblGeoStatus.AutoSize = true;
            lblGeoStatus.Location = new System.Drawing.Point(250, 114);
            lblGeoStatus.Text = "Enter a more specific location…";
            lblGeoStatus.ForeColor = System.Drawing.Color.DimGray;

            // Normalized
            lblNormalized.AutoSize = true;
            lblNormalized.Location = new System.Drawing.Point(24, 134);
            lblNormalized.ForeColor = System.Drawing.Color.Gray;
            lblNormalized.Cursor = System.Windows.Forms.Cursors.Hand;
            lblNormalized.Click += new System.EventHandler(this.lblNormalized_Click);

            // Category
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(24, 168);
            lblCategory.Text = "Category*";

            cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategory.Location = new System.Drawing.Point(24, 188);
            cboCategory.Size = new System.Drawing.Size(240, 23);

            // Description
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(24, 224);
            lblDescription.Text = "Description* (≥ 5 words)";

            // rtbDescription
            rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            rtbDescription.Location = new System.Drawing.Point(24, 244);
            rtbDescription.Size = new System.Drawing.Size(520, 140);

            // Attachments
            lblAttachments.AutoSize = true;
            lblAttachments.Location = new System.Drawing.Point(570, 70);
            lblAttachments.Text = "Attachments (optional)";

            // lstAttachments
            lstAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lstAttachments.Location = new System.Drawing.Point(570, 90);
            lstAttachments.Size = new System.Drawing.Size(300, 264);

            // btnAddAttachment
            btnAddAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnAddAttachment.Location = new System.Drawing.Point(570, 360);
            btnAddAttachment.Size = new System.Drawing.Size(300, 30);
            btnAddAttachment.Text = "Add Attachment";
            btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);

            // Submit
            btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            btnSubmit.Location = new System.Drawing.Point(24, 408);
            btnSubmit.Size = new System.Drawing.Size(140, 34);
            btnSubmit.Text = "Submit";
            btnSubmit.BackColor = System.Drawing.Color.Teal;
            btnSubmit.ForeColor = System.Drawing.Color.White;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Completion Progress
            progressCompletion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            progressCompletion.Location = new System.Drawing.Point(24, 460);
            progressCompletion.Size = new System.Drawing.Size(846, 23);

            // ErrorProvider
            errorProvider1.ContainerControl = this;

            // Add Controls
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblLocation);
            this.Controls.Add(txtLocation);
            this.Controls.Add(progressGeo);
            this.Controls.Add(lblGeoStatus);
            this.Controls.Add(lblNormalized);

            this.Controls.Add(lblCategory);
            this.Controls.Add(cboCategory);
            this.Controls.Add(lblDescription);
            this.Controls.Add(rtbDescription);
            this.Controls.Add(lblAttachments);
            this.Controls.Add(lstAttachments);
            this.Controls.Add(btnAddAttachment);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(progressCompletion);

            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
