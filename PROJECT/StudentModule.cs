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
    public partial class StudentModule : Form
    {
        private string userEmail;
        public StudentModule()
        {
            InitializeComponent();
        }
        public StudentModule(string Email)
        {
            InitializeComponent();
            userEmail = Email;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnLecturerModExit_Click(object sender, EventArgs e)
        {
            SystemAdmin admin = new SystemAdmin(userEmail);
            admin.Show();
            this.Hide();
        }

        private void btnStudentModulesManSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void ClearData()
        {
             cmbStudentDetails.Text = " ";
            cmbLecturerModDetails.Text = " ";
            cmbStudentModuleStatus.Text = " ";

        }
        private void btnStudentModAdd_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.LecturerModuleID = int.Parse(cmbLecturerModDetails.SelectedValue.ToString());
            fields.UserID = int.Parse(cmbStudentDetails.SelectedValue.ToString());
            fields.Date = dtpStudentMod.Value;
            fields.StudModStatus = cmbStudentModuleStatus.Text;

            int x = bll.InsertStudentModule(fields);
            ClearData();
            dgvDisplayStudentModule.DataSource = bll.GetStudentMod();
        }

        private void StudentModule_Load(object sender, EventArgs e)
        {
            //adds the lecturer modules to the combobox option
            cmbLecturerModDetails.DataSource = bll.GetLecturerModDetails();
            cmbLecturerModDetails.DisplayMember = "ModuleName";
            cmbLecturerModDetails.ValueMember = "LecturerModuleID";
            //adds the student full names to the combobox
            cmbStudentDetails.DataSource = bll.GetStudentDetails();
            cmbStudentDetails.DisplayMember = "StudentDetails";
            cmbStudentDetails.ValueMember = "UserID";

            cmbStudentModuleStatus.Items.Add("Full");
            cmbStudentModuleStatus.Items.Add("Not-Full");
        }

        private void btnStudentModRefresh_Click(object sender, EventArgs e)
        {
            dgvDisplayStudentModule.DataSource = bll.GetStudentMod();

        }

        private void dgvDisplayStudentModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayStudentModule.SelectedRows.Count>0)
            {
                txtStudentModuleID.Text = dgvDisplayStudentModule.SelectedRows[0].Cells["StudentModuleID"].Value.ToString();
                cmbLecturerModDetails.Text = dgvDisplayStudentModule.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                cmbStudentDetails.Text = dgvDisplayStudentModule.SelectedRows[0].Cells["StudentDetails"].Value.ToString();
                dtpStudentMod.Value = Convert.ToDateTime(dgvDisplayStudentModule.SelectedRows[0].Cells["Date"].Value);
                cmbStudentModuleStatus.Text = dgvDisplayStudentModule.SelectedRows[0].Cells["StudModStatus"].Value.ToString();
            }
        }
    }
}
