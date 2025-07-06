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
    public partial class LecturerAssess : Form
    {
        //declare a variable passed from Login Form
        private string userEmail;
        public LecturerAssess()
        {
            InitializeComponent();
        }

        public LecturerAssess(string Email)
        {
            InitializeComponent();
            userEmail = Email;
        }
           BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Lecturer_Load(object sender, EventArgs e)
        {
            //load the assessment description
            cmbAssessmentStatus.Items.Add("Open");
            cmbAssessmentStatus.Items.Add("Restricted");

            LoadModInCmb(userEmail);

            cmbAssessmentType.DataSource = bll.GetAssessmentType();
            cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";
            cmbAssessmentType.ValueMember = "AssessmentTypeID";

        }
        private void LoadModInCmb(string Email)
        {
            DataTable dt = bll.GetLecturerModByEmail(Email);
            if (dt != null)
            {
                // Set the ComboBox's DataSource and DisplayMember
                cmbLecturerModDetails.DataSource = dt;
                cmbLecturerModDetails.DisplayMember = "ModuleName";
                cmbLecturerModDetails.ValueMember = "LecturerModuleID";


            }
        }

        public void ClearData()
        { 
            cmbLecturerModDetails.Text = " ";
            cmbAssessmentStatus.Text = " ";
            cmbAssessmentType.Text = " ";
        }
      
        private void dgvDisplayAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayAssignment.SelectedRows.Count > 0)
            {
                
                txtStudentNo.Text = dgvDisplayAssignment.SelectedRows[0].Cells["NumberOfStudents"].Value.ToString();
                cmbLecturerModDetails.Text = dgvDisplayAssignment.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                dtpAssignment.Text = dgvDisplayAssignment.SelectedRows[0].Cells["DueDate"].Value.ToString();
                cmbAssessmentType.Text = dgvDisplayAssignment.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();
                
            }
        }

        private void btnAssessManSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAssExit_Click(object sender, EventArgs e)
        {
            Lecturers lecturer = new Lecturers(userEmail);
            lecturer.Show();
            this.Hide();
        }

        private void btnRefreshTb_Click(object sender, EventArgs e)
        {
            dgvDisplayAssignment.DataSource = bll.GetAssessmentModByEmail(userEmail);
        }
        //changed
        private void btnAddAssess_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.GetStudentModIDbyEmail(userEmail, int.Parse(cmbLecturerModDetails.SelectedValue.ToString()));

            // Check if the StudentModuleID is valid
            if (dt != null && dt.Rows.Count > 0)
            {
                int studentModuleID = int.Parse(dt.Rows[0]["StudentModuleID"].ToString()); // Assuming the column name is "StudentModuleID"

                Fields fields = new Fields();
                fields.Email = userEmail; // Assuming userEmail is a valid email
                fields.LecturerModuleID = int.Parse(cmbLecturerModDetails.SelectedValue.ToString()); // Assuming cmbLecturerModDetails has a selected value
                fields.StudentModuleID = studentModuleID; // Add StudentModuleID to your Fields class
                fields.DueDate = dtpAssignment.Value; // Assuming dtpAssignment is a valid DateTimePicker
                fields.AssessmentTypeID = int.Parse(cmbAssessmentType.SelectedValue.ToString()); // Assuming cmbAssessmentType has a selected value
                fields.AssessmentStatus = cmbAssessmentStatus.Text; // Assuming cmbAssessmentStatus is a valid ComboBox

                int x = bll.InsertAssessment(fields);
                MessageBox.Show("Assignment created for " + x + "Students");
                ClearData();
               dgvDisplayAssignment.DataSource = bll.GetAssessmentModByEmail(userEmail);
            }

        }
    }
}
