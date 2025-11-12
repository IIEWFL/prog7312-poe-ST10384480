using System;
using System.Windows.Forms;
using MunicipalServiceApplication.Forms;

namespace MunicipalServiceApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            ReportIssueForm reportForm = new ReportIssueForm();
            reportForm.ShowDialog();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            EventsForm eventsForm = new EventsForm();
            eventsForm.ShowDialog();
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm();
            statusForm.ShowDialog();
        }

        private void btnAddServiceRequest_Click(object sender, EventArgs e)
        {
            AddServiceRequestForm addRequestForm = new AddServiceRequestForm();
            addRequestForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Data.FakeDatabase.SeedDemoData();
        }
    }
}