using System;
using System.Windows.Forms;
using MunicipalServiceApplication.Data;
using MunicipalServiceApplication.Models;

namespace MunicipalServiceApplication.Forms
{
    public partial class StatusForm : Form
    {
        private ServiceRequestBST bst = new ServiceRequestBST();

        public StatusForm()
        {
            InitializeComponent();
            LoadAllRequests();
        }

        private void LoadAllRequests()
        {
            lstRequests.Items.Clear();
            bst = new ServiceRequestBST();
            foreach (var req in FakeDatabase.GetAllServiceRequests())
            {
                bst.Insert(req);
                lstRequests.Items.Add($"{req.RequestID} - {req.ResidentName} - {req.Status}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchID.Text.Trim(), out int searchID))
            {
                ServiceRequest result = bst.Search(searchID);
                lstRequests.Items.Clear();
                if (result != null)
                {
                    lstRequests.Items.Add($"{result.RequestID} - {result.ResidentName} - {result.Status}");
                }
                else
                {
                    MessageBox.Show("Service Request not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Request ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllRequests();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (lstRequests.SelectedItem != null)
            {
                string selected = lstRequests.SelectedItem.ToString();
                int requestID = int.Parse(selected.Split('-')[0].Trim());
                ServiceRequest req = FakeDatabase.GetServiceRequestByID(requestID);
                if (req != null)
                {
                    switch (req.Status)
                    {
                        case "Pending": req.Status = "In Progress"; break;
                        case "In Progress": req.Status = "Completed"; break;
                        case "Completed": req.Status = "Pending"; break;
                    }
                    MessageBox.Show($"Status updated to: {req.Status}", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllRequests();
                }
            }
            else
            {
                MessageBox.Show("Please select a service request from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}