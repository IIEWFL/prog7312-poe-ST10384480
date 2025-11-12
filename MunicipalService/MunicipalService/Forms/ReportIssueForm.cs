using System;
using System.Windows.Forms;
using MunicipalServiceApplication.Data;
using MunicipalServiceApplication.Models;

namespace MunicipalServiceApplication.Forms
{
    public partial class ReportIssueForm : Form
    {
        private string selectedFilePath = string.Empty;

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Attach Image or Document",
                Filter = "Image Files|.jpg;.jpeg;.png|All Files|.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                lblAttachment.Text = $"Attached: {System.IO.Path.GetFileName(selectedFilePath)}";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var issue = new Issue
            {
                Id = Guid.NewGuid(),
                Location = txtLocation.Text,
                Category = cmbCategory.Text,
                Description = rtbDescription.Text,
                AttachmentPath = selectedFilePath,
                Status = "Pending",
                DateReported = DateTime.Now
            };

            FakeDatabase.AddIssue(issue);

            lblEngagement.Text = "✅ Thank you for reporting! Your issue helps improve the community.";
            lblEngagement.Visible = true;

            MessageBox.Show("Issue successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblAttachment.Text = "No file attached";
            selectedFilePath = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}