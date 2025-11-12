using System.Drawing;

namespace MunicipalServiceApplication.Forms
{
    partial class StatusForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstRequests;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.BackColor = Color.WhiteSmoke;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request Status";

            // Label
            lblSearch.Text = "Search Request ID:";
            lblSearch.Location = new System.Drawing.Point(30, 20);
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSearch.ForeColor = Color.Black;

            // TextBox
            txtSearchID.Location = new System.Drawing.Point(160, 18);
            txtSearchID.Size = new System.Drawing.Size(120, 25);

            // Buttons
            btnSearch.Text = "Search";
            btnSearch.BackColor = Color.Gray;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Location = new System.Drawing.Point(300, 16);
            btnSearch.Size = new System.Drawing.Size(70, 28);
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            btnRefresh.Text = "Refresh";
            btnRefresh.BackColor = Color.DarkGray;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Location = new System.Drawing.Point(380, 16);
            btnRefresh.Size = new System.Drawing.Size(70, 28);
            btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.BackColor = Color.Black;
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateStatus.Location = new System.Drawing.Point(460, 16);
            btnUpdateStatus.Size = new System.Drawing.Size(80, 28);
            btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);

            // ListBox
            lstRequests.Location = new System.Drawing.Point(30, 60);
            lstRequests.Size = new System.Drawing.Size(510, 360);
            lstRequests.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Add Controls
            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearchID);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnRefresh);
            this.Controls.Add(btnUpdateStatus);
            this.Controls.Add(lstRequests);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}