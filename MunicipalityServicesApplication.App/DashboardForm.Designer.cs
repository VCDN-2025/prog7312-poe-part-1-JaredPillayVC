namespace MunicipalityServicesApplication.App
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandIcon = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.lblCardBody = new System.Windows.Forms.Label();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Panel1.Controls.Add(this.panelSidebar);
            this.splitContainerMain.Panel2.Controls.Add(this.panelContent);
            this.splitContainerMain.Size = new System.Drawing.Size(1080, 680);
            this.splitContainerMain.SplitterDistance = 280;
            this.splitContainerMain.SplitterWidth = 1;
            this.splitContainerMain.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(236, 246, 246);
            this.panelSidebar.Controls.Add(this.btnStatus);
            this.panelSidebar.Controls.Add(this.btnEvents);
            this.panelSidebar.Controls.Add(this.btnReport);
            this.panelSidebar.Controls.Add(this.lblBrand);
            this.panelSidebar.Controls.Add(this.lblBrandIcon);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(16, 18, 16, 16);
            this.panelSidebar.Size = new System.Drawing.Size(280, 680);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnReport.Location = new System.Drawing.Point(20, 77);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(240, 48);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report an Issue";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.White;
            this.btnEvents.Enabled = false;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEvents.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnEvents.Location = new System.Drawing.Point(20, 131);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(240, 48);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Local Events (Coming Soon)";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEvents.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.White;
            this.btnStatus.Enabled = false;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStatus.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnStatus.Location = new System.Drawing.Point(20, 185);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(240, 48);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Text = "Service Request Status";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.lblBrand.Location = new System.Drawing.Point(60, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(134, 25);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Municipality Services";
            // 
            // lblBrandIcon
            // 
            this.lblBrandIcon.AutoSize = true;
            this.lblBrandIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F);
            this.lblBrandIcon.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.lblBrandIcon.Location = new System.Drawing.Point(22, 18);
            this.lblBrandIcon.Name = "lblBrandIcon";
            this.lblBrandIcon.Size = new System.Drawing.Size(32, 27);
            this.lblBrandIcon.TabIndex = 0;
            this.lblBrandIcon.Text = "\uE80F"; // home icon
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelCard);
            this.panelContent.Controls.Add(this.lblSubtitle);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24, 18, 24, 24);
            this.panelContent.Size = new System.Drawing.Size(799, 680);
            this.panelContent.TabIndex = 0;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(236, 246, 246);
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.btnOpenForm);
            this.panelCard.Controls.Add(this.lblCardBody);
            this.panelCard.Controls.Add(this.lblCardTitle);
            this.panelCard.Location = new System.Drawing.Point(24, 120);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.panelCard.Size = new System.Drawing.Size(751, 140);
            this.panelCard.TabIndex = 3;
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.BackColor = System.Drawing.Color.FromArgb(0, 110, 110);
            this.btnOpenForm.FlatAppearance.BorderSize = 0;
            this.btnOpenForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenForm.ForeColor = System.Drawing.Color.White;
            this.btnOpenForm.Location = new System.Drawing.Point(22, 95);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(150, 38);
            this.btnOpenForm.TabIndex = 2;
            this.btnOpenForm.Text = "Open Form";
            this.btnOpenForm.UseVisualStyleBackColor = false;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // lblCardBody
            // 
            this.lblCardBody.AutoSize = true;
            this.lblCardBody.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardBody.ForeColor = System.Drawing.Color.FromArgb(35, 45, 55);
            this.lblCardBody.Location = new System.Drawing.Point(19, 56);
            this.lblCardBody.Name = "lblCardBody";
            this.lblCardBody.Size = new System.Drawing.Size(557, 17);
            this.lblCardBody.TabIndex = 1;
            this.lblCardBody.Text = "Provide location, pick a category, and describe the issue (≥ 20 words). Attach im" +
    "ages/PDFs if needed.";
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.lblCardTitle.Location = new System.Drawing.Point(18, 16);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(162, 21);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Submit a new issue";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(35, 45, 55);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 64);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(442, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Log municipal issues quickly and track them with a unique ticket.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 102);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(418, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Report an Issue";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "DashboardForm";
            this.Text = "Municipality Services Application — Dashboard";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblBrandIcon;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblCardBody;
        private System.Windows.Forms.Button btnOpenForm;
    }
}
