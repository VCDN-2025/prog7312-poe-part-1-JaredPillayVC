using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityServicesApplication.App
{
    partial class IssueReportForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer? components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>Designer support method — do not modify with the code editor.</summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // IssueReportForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(880, 480);
            this.Name = "IssueReportForm";
            this.Text = "Report an Issue";
            this.ResumeLayout(false);
        }
    }
}
