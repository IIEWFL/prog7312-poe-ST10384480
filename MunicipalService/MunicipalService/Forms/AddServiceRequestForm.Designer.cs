using System.Drawing;

namespace MunicipalServiceApplication.Forms
{
    partial class AddServiceRequestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblResidentName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtResidentName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblResidentName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtResidentName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Labels
            this.lblResidentName.Text = "Resident Name:";
            this.lblResidentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResidentName.ForeColor = System.Drawing.Color.Black;
            this.lblResidentName.AutoSize = true;
            this.lblResidentName.Location = new System.Drawing.Point(40, 30);

            this.lblDescription.Text = "Description:";
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(40, 80);

            this.lblDepartment.Text = "Department:";
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(40, 190);

            // TextBoxes and ComboBox
            this.txtResidentName.Location = new System.Drawing.Point(180, 27);
            this.txtResidentName.Size = new System.Drawing.Size(200, 25);
            this.txtDescription.Location = new System.Drawing.Point(180, 77);
            this.txtDescription.Size = new System.Drawing.Size(200, 100);
            this.txtDescription.Multiline = true;
            this.cmbDepartment.Location = new System.Drawing.Point(180, 187);
            this.cmbDepartment.Size = new System.Drawing.Size(200, 25);
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.ForeColor = Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(120, 240);
            this.btnSubmit.Size = new System.Drawing.Size(100, 35);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = Color.DarkGray;
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(250, 240);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lblResidentName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtResidentName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.BackColor = Color.WhiteSmoke;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Service Request";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}