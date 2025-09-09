namespace MunicipalityServicesApplication.App
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.tableNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.lblCardBody = new System.Windows.Forms.Label();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.tableNav.SuspendLayout();
            this.panelBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panelContent.SuspendLayout();
            this.grpCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(232, 245, 245);
            this.panelSidebar.Controls.Add(this.tableNav);
            this.panelSidebar.Controls.Add(this.panelBrand);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
            this.panelSidebar.Size = new System.Drawing.Size(280, 640);
            this.panelSidebar.TabIndex = 0;
            // 
            // tableNav
            // 
            this.tableNav.ColumnCount = 1;
            this.tableNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNav.Controls.Add(this.btnStatus, 0, 5);
            this.tableNav.Controls.Add(this.btnEvents, 0, 3);
            this.tableNav.Controls.Add(this.btnReport, 0, 1);
            this.tableNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableNav.Location = new System.Drawing.Point(16, 70);
            this.tableNav.Margin = new System.Windows.Forms.Padding(0);
            this.tableNav.Name = "tableNav";
            this.tableNav.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.tableNav.RowCount = 7;
            this.tableNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F)); // Report
            this.tableNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F)); // Events
            this.tableNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F)); // Status
            this.tableNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNav.Size = new System.Drawing.Size(248, 554);
            this.tableNav.TabIndex = 1;
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right));
            this.btnStatus.BackColor = System.Drawing.Color.White;
            this.btnStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 234, 234);
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStatus.Image = (System.Drawing.Image)resources.GetObject("icon.status"); // 24px PNG in Resources
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(0, 144);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnStatus.Size = new System.Drawing.Size(248, 48);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "  Service Request Status";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Enabled = true; // enabled as per your latest screenshot
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right));
            this.btnEvents.BackColor = System.Drawing.Color.White;
            this.btnEvents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(225, 234, 234);
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEvents.Image = (System.Drawing.Image)resources.GetObject("icon.events");
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(0, 76);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnEvents.Size = new System.Drawing.Size(248, 48);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "  Local Events (Coming Soon)";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Enabled = true; // enabled in your latest UI
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right));
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 121, 118);
            this.btnReport.FlatAppearance.BorderSize = 2;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReport.Image = (System.Drawing.Image)resources.GetObject("icon.report");
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 8);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnReport.Size = new System.Drawing.Size(248, 48);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "  Report an Issue";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panelBrand
            // 
            this.panelBrand.Controls.Add(this.picHome);
            this.panelBrand.Controls.Add(this.lblBrand);
            this.panelBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrand.Location = new System.Drawing.Point(16, 12);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(248, 58);
            this.panelBrand.TabIndex = 0;
            // 
            // picHome
            // 
            this.picHome.Image = (System.Drawing.Image)resources.GetObject("icon.home");
            this.picHome.Location = new System.Drawing.Point(0, 8);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(0, 121, 118);
            this.lblBrand.Location = new System.Drawing.Point(40, 12);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(194, 23);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Municipality Services";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.grpCard);
            this.panelContent.Controls.Add(this.lblSubtitle);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(280, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24, 16, 24, 24);
            this.panelContent.Size = new System.Drawing.Size(1040, 640);
            this.panelContent.TabIndex = 1;
            // 
            // grpCard
            // 
            this.grpCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCard.BackColor = System.Drawing.Color.FromArgb(240, 252, 252);
            this.grpCard.Controls.Add(this.btnOpenForm);
            this.grpCard.Controls.Add(this.lblCardBody);
            this.grpCard.Controls.Add(this.lblCardTitle);
            this.grpCard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.grpCard.Location = new System.Drawing.Point(24, 86);
            this.grpCard.Name = "grpCard";
            this.grpCard.Padding = new System.Windows.Forms.Padding(16);
            this.grpCard.Size = new System.Drawing.Size(992, 120);
            this.grpCard.TabIndex = 2;
            this.grpCard.TabStop = false;
            this.grpCard.Text = "";
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpenForm.BackColor = System.Drawing.Color.FromArgb(0, 121, 118);
            this.btnOpenForm.FlatAppearance.BorderSize = 0;
            this.btnOpenForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOpenForm.ForeColor = System.Drawing.Color.White;
            this.btnOpenForm.Location = new System.Drawing.Point(24, 74);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(140, 36);
            this.btnOpenForm.TabIndex = 2;
            this.btnOpenForm.Text = "Open Form";
            this.btnOpenForm.UseVisualStyleBackColor = false;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // lblCardBody
            // 
            this.lblCardBody.AutoSize = true;
            this.lblCardBody.Location = new System.Drawing.Point(22, 48);
            this.lblCardBody.Name = "lblCardBody";
            this.lblCardBody.Size = new System.Drawing.Size(642, 17);
            this.lblCardBody.TabIndex = 1;
            this.lblCardBody.Text = "Provide location, pick a category, and describe the issue (≥ 20 words). Attach im" +
    "ages/PDFs if needed.";
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.Location = new System.Drawing.Point(20, 22);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(144, 19);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Submit a new issue";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 121, 118);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report an Issue";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(456, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Log municipal issues quickly and track them with a unique ticket.";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 640);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "DashboardForm";
            this.Text = "Municipality Services Application — Dashboard";
            this.Resize += new System.EventHandler(this.DashboardForm_Resize);
            this.panelSidebar.ResumeLayout(false);
            this.tableNav.ResumeLayout(false);
            this.panelBrand.ResumeLayout(false);
            this.panelBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.grpCard.ResumeLayout(false);
            this.grpCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.TableLayoutPanel tableNav;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.Label lblCardBody;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
    }
}
