using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace PROJECT_ONT23
{
    public partial class StudentAssignment : Form
    {
        public StudentAssignment()
        {
            InitializeComponent();
        }
        private string userEmail;
        public StudentAssignment(string Email)
        {
            InitializeComponent();
            userEmail = Email;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
      

        private void btnStudAssessManSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDisplayStudAssignment.DataSource = bll.GetStudentAssessmentByEmail(userEmail);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.AssessmentID = int.Parse(txtAssessmentID.Text);
            fields.AssessmentStatus = cmbAssessmentStatus.Text;
            fields.DueDate = dtpSudAssignment.Value;
            int x = bll.UpdateAssessmentStatus(fields);
            MessageBox.Show(x + " Updated");

            dgvDisplayStudAssignment.DataSource = bll.GetStudentAssessmentByEmail(userEmail);
        }

        private void dgvDisplayStudAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDisplayStudAssignment.SelectedRows.Count>0)
            {
                txtAssessmentID.Text = dgvDisplayStudAssignment.SelectedRows[0].Cells["AssessmentID"].Value.ToString();
                txtMyModuleName.Text = dgvDisplayStudAssignment.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                txtLecturerName.Text = dgvDisplayStudAssignment.SelectedRows[0].Cells["LecturerName"].Value.ToString();
                dtpSudAssignment.Text = dgvDisplayStudAssignment.SelectedRows[0].Cells["DueDate"].Value.ToString();
                cmbStudAssessmentType.Text = dgvDisplayStudAssignment.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();
                cmbAssessmentStatus.Text = dgvDisplayStudAssignment.SelectedRows[0].Cells["AssessmentStatus"].Value.ToString();
            }

        }

        private void StudentAssignment_Load(object sender, EventArgs e)
        {
            cmbAssessmentStatus.Items.Add("Completed");
            cmbAssessmentStatus.Items.Add("Missed");
            cmbAssessmentStatus.Items.Add("Rescheduled");
        }
    }
}
