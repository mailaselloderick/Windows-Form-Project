using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PROJECT_ONT23
{
    public partial class StudAssessments : Form
    {
        private string userEmail;
        public StudAssessments()
        {
            InitializeComponent();
        }
        public StudAssessments(string Email )
        {
            InitializeComponent();
            userEmail = Email;
           
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void StudAssessments_Load(object sender, EventArgs e)
        {
            cmbAssessmentStatus.Items.Add("Completed");
            cmbAssessmentStatus.Items.Add("Missed");
            cmbAssessmentStatus.Items.Add("Rescheduled");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Lecturers lecturer = new Lecturers(userEmail);
            lecturer.Show();
            this.Hide();
        }

        private void dgvDisplayStudAssessment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayStudAssessment.SelectedRows.Count > 0)
            {
                txtAssessmentID.Text = dgvDisplayStudAssessment.SelectedRows[0].Cells["AssessmentID"].Value.ToString();
                txtMyModuleName.Text = dgvDisplayStudAssessment.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                txtLecturerName.Text = dgvDisplayStudAssessment.SelectedRows[0].Cells["LecturerName"].Value.ToString();
                dtpSudAssignment.Text = dgvDisplayStudAssessment.SelectedRows[0].Cells["DueDate"].Value.ToString();
                cmbStudAssessmentType.Text = dgvDisplayStudAssessment.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();
                cmbAssessmentStatus.Text = dgvDisplayStudAssessment.SelectedRows[0].Cells["AssessmentStatus"].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDisplayStudAssessment.DataSource = bll.GetStudentAssessmentByEmail(userEmail);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.AssessmentID = int.Parse(txtAssessmentID.Text);
            fields.AssessmentStatus = cmbAssessmentStatus.Text;
            fields.DueDate = dtpSudAssignment.Value;
            int x = bll.UpdateAssessmentStatus(fields);
            MessageBox.Show(x + " Updated");

            dgvDisplayStudAssessment.DataSource = bll.GetStudentAssessmentByEmail(userEmail);
        }
    }
}
