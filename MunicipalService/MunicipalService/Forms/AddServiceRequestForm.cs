using System;
using System.Windows.Forms;
using MunicipalServiceApplication.Data;
using MunicipalServiceApplication.Models;

namespace MunicipalServiceApplication.Forms
{
    public partial class AddServiceRequestForm : Form
    {
        public AddServiceRequestForm()
        {
            InitializeComponent();
            InitializeDepartmentDropdown();
        }

        private void InitializeDepartmentDropdown()
        {
            cmbDepartment.Items.Clear();
            cmbDepartment.Items.Add("Water");
            cmbDepartment.Items.Add("Electricity");
            cmbDepartment.Items.Add("Roads");
            cmbDepartment.Items.Add("Waste Collection");
            cmbDepartment.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string residentName = txtResidentName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string department = cmbDepartment.SelectedItem.ToString();

            if (string.IsNullOrEmpty(residentName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ServiceRequest request = FakeDatabase.CreateServiceRequest(residentName, description, department);

            MessageBox.Show($"Service Request Created Successfully!\nRequest ID: {request.RequestID}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtResidentName.Text = "";
            txtDescription.Text = "";
            cmbDepartment.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}