using System.Drawing;

namespace MunicipalServiceApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Button btnAddServiceRequest;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.btnAddServiceRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Municipal Services Portal";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 80;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;

            // btnReportIssue
            this.btnReportIssue.Text = "Report Issue";
            this.btnReportIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReportIssue.Size = new System.Drawing.Size(280, 60);
            this.btnReportIssue.BackColor = System.Drawing.Color.LightGray;
            this.btnReportIssue.ForeColor = System.Drawing.Color.Black;
            this.btnReportIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssue.FlatAppearance.BorderSize = 0;
            this.btnReportIssue.Location = new System.Drawing.Point(35, 100);
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);

            // btnLocalEvents
            this.btnLocalEvents.Text = "Local Events & Announcements";
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLocalEvents.Size = new System.Drawing.Size(280, 60);
            this.btnLocalEvents.BackColor = System.Drawing.Color.Gray;
            this.btnLocalEvents.ForeColor = System.Drawing.Color.White;
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.FlatAppearance.BorderSize = 0;
            this.btnLocalEvents.Location = new System.Drawing.Point(35, 180);
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);

            // btnServiceStatus
            this.btnServiceStatus.Text = "Service Request Status";
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnServiceStatus.Size = new System.Drawing.Size(280, 60);
            this.btnServiceStatus.BackColor = System.Drawing.Color.DimGray;
            this.btnServiceStatus.ForeColor = System.Drawing.Color.White;
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.FlatAppearance.BorderSize = 0;
            this.btnServiceStatus.Location = new System.Drawing.Point(35, 260);
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);

            // btnAddServiceRequest
            this.btnAddServiceRequest.Text = "Add Service Request";
            this.btnAddServiceRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddServiceRequest.Size = new System.Drawing.Size(280, 60);
            this.btnAddServiceRequest.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddServiceRequest.ForeColor = System.Drawing.Color.White;
            this.btnAddServiceRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServiceRequest.FlatAppearance.BorderSize = 0;
            this.btnAddServiceRequest.Location = new System.Drawing.Point(35, 340);
            this.btnAddServiceRequest.Click += new System.EventHandler(this.btnAddServiceRequest_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReportIssue);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnAddServiceRequest);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services";

            this.ResumeLayout(false);
        }
    }
}