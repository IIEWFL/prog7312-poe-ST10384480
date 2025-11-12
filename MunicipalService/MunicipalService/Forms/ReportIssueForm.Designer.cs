using System.Drawing;

namespace MunicipalServiceApplication.Forms
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEngagement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.BackColor = Color.WhiteSmoke;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issue / Request Service";

            // Labels
            lblLocation.Text = "Location:";
            lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblLocation.ForeColor = Color.Black;
            lblLocation.Location = new System.Drawing.Point(30, 30);
            lblLocation.AutoSize = true;

            lblCategory.Text = "Category:";
            lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new System.Drawing.Point(30, 80);
            lblCategory.AutoSize = true;

            lblDescription.Text = "Description:";
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new System.Drawing.Point(30, 130);
            lblDescription.AutoSize = true;

            // Text Inputs
            txtLocation.Location = new System.Drawing.Point(150, 27);
            txtLocation.Size = new System.Drawing.Size(350, 25);

            cmbCategory.Location = new System.Drawing.Point(150, 77);
            cmbCategory.Size = new System.Drawing.Size(350, 25);
            cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new object[]
            {
                "Water Leakage", "Electricity Issue", "Road Damage", "Waste Management", "Other"
            });

            rtbDescription.Location = new System.Drawing.Point(150, 130);
            rtbDescription.Size = new System.Drawing.Size(350, 120);

            // Buttons
            btnAttach.Text = "Attach File";
            btnAttach.BackColor = Color.Gray;
            btnAttach.ForeColor = Color.White;
            btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAttach.Location = new System.Drawing.Point(150, 270);
            btnAttach.Size = new System.Drawing.Size(100, 30);
            btnAttach.Click += new System.EventHandler(this.btnAttach_Click);

            lblAttachment.Text = "No file attached";
            lblAttachment.Location = new System.Drawing.Point(270, 275);
            lblAttachment.AutoSize = true;

            btnSubmit.Text = "Submit";
            btnSubmit.BackColor = Color.Black;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.Location = new System.Drawing.Point(150, 320);
            btnSubmit.Size = new System.Drawing.Size(120, 35);
            btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            btnBack.Text = "Back";
            btnBack.BackColor = Color.DarkGray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Location = new System.Drawing.Point(290, 320);
            btnBack.Size = new System.Drawing.Size(120, 35);
            btnBack.Click += new System.EventHandler(this.btnBack_Click);

            lblEngagement.ForeColor = Color.Black;
            lblEngagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEngagement.Location = new System.Drawing.Point(60, 380);
            lblEngagement.Size = new System.Drawing.Size(430, 30);
            lblEngagement.Visible = false;

            // Add Controls
            this.Controls.Add(lblLocation);
            this.Controls.Add(txtLocation);
            this.Controls.Add(lblCategory);
            this.Controls.Add(cmbCategory);
            this.Controls.Add(lblDescription);
            this.Controls.Add(rtbDescription);
            this.Controls.Add(btnAttach);
            this.Controls.Add(lblAttachment);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(btnBack);
            this.Controls.Add(lblEngagement);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}