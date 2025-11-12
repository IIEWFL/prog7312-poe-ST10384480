using System.Drawing;

namespace MunicipalServiceApplication.Forms
{
    partial class EventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label lblRecommendation;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lblRecommendation = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events & Announcements";

            // Category ComboBox
            this.cmbCategory.Location = new System.Drawing.Point(50, 30);
            this.cmbCategory.Size = new System.Drawing.Size(150, 25);

            // Date Label & TextBox
            this.lblDate.Text = "Date (dd/MM/yyyy):";
            this.lblDate.Location = new System.Drawing.Point(230, 33);
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = Color.Black;

            this.txtDate.Location = new System.Drawing.Point(370, 30);
            this.txtDate.Size = new System.Drawing.Size(120, 25);

            // Search Button
            this.btnSearch.Text = "Search";
            this.btnSearch.BackColor = Color.Gray;
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(510, 28);
            this.btnSearch.Size = new System.Drawing.Size(70, 28);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // Events List
            this.lstEvents.Location = new System.Drawing.Point(50, 70);
            this.lstEvents.Size = new System.Drawing.Size(530, 220);
            this.lstEvents.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Recommendations Label
            this.lblRecommendation.Location = new System.Drawing.Point(50, 300);
            this.lblRecommendation.Size = new System.Drawing.Size(530, 120);
            this.lblRecommendation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblRecommendation.ForeColor = Color.Black;
            this.lblRecommendation.Text = "Recommended events will appear here.";

            // Add Controls
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.lblRecommendation);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}