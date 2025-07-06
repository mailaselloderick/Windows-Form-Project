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
    public partial class LectAssessmentReport : Form
    {
        private string userEmail;
        private int lecturerModuleID;

        public LectAssessmentReport()
        {
            InitializeComponent();
        }
        public LectAssessmentReport(int LecturerModuleID,string Email)
        {
            InitializeComponent();
            userEmail = Email;
            lecturerModuleID = LecturerModuleID;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void LectAssessmentReport_Load(object sender, EventArgs e)
        {
            DAL.Fields userData = bll.ViewLecturerModOnPortal(lecturerModuleID, userEmail);

            if (userData != null)
            {
                // Display the user's details in the control
                lblLecName.Text = userData.Name + " " + userData.Surname;
                lblModName.Text = userData.ModuleName;
            }

                cmbFilterByAssessmentType.DataSource = bll.GetAssessmentType();
            cmbFilterByAssessmentType.DisplayMember = "AssessmentTypeDescription";
            cmbFilterByAssessmentType.ValueMember = "AssessmentTypeDescription";
            cmbFilterByAssessmentType.SelectedItem = "Choose Type";
            cmbFilterByAssessmentType.Text = "Choose Type";

            cmbFilterByAssessmentStatus.Items.Add("Completed");
            cmbFilterByAssessmentStatus.Items.Add("Missed");
            cmbFilterByAssessmentStatus.Items.Add("Rescheduled");
            cmbFilterByAssessmentStatus.SelectedItem = "Choose Status";
            cmbFilterByAssessmentStatus.Text = "Choose Status";


        }

        private void btnSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefreshTb_Click(object sender, EventArgs e)
        {
            dgvDisplayAssignment.DataSource = bll.ViewAllAssignOnModules(userEmail, lecturerModuleID);

        }

        private void btnAssExit_Click(object sender, EventArgs e)
        {
            Lecturers lecturer = new Lecturers(userEmail);
            lecturer.Show();
            this.Hide();
        }

        private void btnSystemExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void cmbFilterByAssessmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.Email = userEmail;
            fields.AssessmentTypeDescription = cmbFilterByAssessmentType.Text;
            fields.LecturerModuleID = lecturerModuleID;
            dgvDisplayAssignment.DataSource = bll.FilterAssessByType(fields.Email, fields.AssessmentTypeDescription,fields.LecturerModuleID);

        }

        private void txtStudName_TextChanged(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.Email = userEmail;
            fields.LecturerModuleID = lecturerModuleID;
            fields.Name = txtStudName.Text;
            dgvDisplayAssignment.DataSource = bll.ViewAssignByStudName(fields.Email, fields.LecturerModuleID, fields.Name);


        }

        private void cmbFilterByAssessmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.Email = userEmail;
            fields.LecturerModuleID = lecturerModuleID;
            fields.AssessmentStatus = cmbFilterByAssessmentStatus.Text;
            dgvDisplayAssignment.DataSource = bll.FilterAssess(fields.Email, fields.AssessmentStatus, fields.LecturerModuleID);
        }

        private void dtpFilterByDueDate_ValueChanged(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.Email = userEmail;
            fields.LecturerModuleID = lecturerModuleID;
            fields.DueDate = dtpFilterByDueDate.Value;
            dgvDisplayAssignment.DataSource = bll.FilterAssessByDueDate(fields.Email, fields.DueDate, fields.LecturerModuleID);

        }
    }
}
