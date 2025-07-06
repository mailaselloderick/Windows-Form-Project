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
    public partial class LecturerModule : Form
    {
        private string userEmail;
        public LecturerModule()
        {
            InitializeComponent();
        }
        public LecturerModule(string Email)
        {
            InitializeComponent();
            userEmail = Email;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnModulesManSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void ClearData()
        {
            txtLecturerModuleID.Text = " ";
            cmbLectureName.Text = " ";
            cmbModuleName.Text = " ";
            
            cmbLecturerModStatus.Text = " ";
            
        }
        private void btnLecturerModExit_Click(object sender, EventArgs e)
        {
            SystemAdmin admin = new SystemAdmin(userEmail);
            admin.Show();
            this.Hide();
        }

        private void btnLecturerModAdd_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.ModuleID = int.Parse(cmbModuleName.SelectedValue.ToString());
            fields.UserID = int.Parse(cmbLectureName.SelectedValue.ToString());
            fields.Date = dtpLecturerMod.Value;
            fields.ModLecturerStatus = cmbLecturerModStatus.Text;

            int x = bll.InsertLecturerMod(fields);
            ClearData();
            dgvDisplayLecturerModule.DataSource = bll.GetLecturerMod();
        }

        private void LecturerModule_Load(object sender, EventArgs e)
        {
            cmbLectureName.DataSource = bll.GetLecturerDetails();
            cmbLectureName.DisplayMember = "LecturerName";
            cmbLectureName.ValueMember = "UserID";


            cmbModuleName.DataSource = bll.GetModuleName();
            cmbModuleName.DisplayMember = "ModuleName";
            cmbModuleName.ValueMember = "ModuleID";

            cmbLecturerModStatus.Items.Add("Full");
            cmbLecturerModStatus.Items.Add("Not-Full");
                
        }

        private void btnLecturerModRefresh_Click(object sender, EventArgs e)
        {
            dgvDisplayLecturerModule.DataSource = bll.GetLecturerMod();

        }

        private void dgvDisplayLecturerModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvDisplayLecturerModule.SelectedRows.Count > 0)
            {
                
                txtLecturerModuleID.Text = dgvDisplayLecturerModule.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString();
                cmbLectureName.Text = dgvDisplayLecturerModule.SelectedRows[0].Cells["LecturerName"].Value.ToString();
                cmbModuleName.Text = dgvDisplayLecturerModule.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                dtpLecturerMod.Text = dgvDisplayLecturerModule.SelectedRows[0].Cells["Date"].Value.ToString();
                cmbLecturerModStatus.Text = dgvDisplayLecturerModule.SelectedRows[0].Cells["ModLecturerStatus"].Value.ToString();
              
            }
            
        }

        private void btnLecturerModUpdate_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.LecturerModuleID = int.Parse(txtLecturerModuleID.Text);
            fields.ModuleID = int.Parse(cmbModuleName.SelectedValue.ToString());
            fields.UserID = int.Parse(cmbLectureName.SelectedValue.ToString());
            fields.ModLecturerStatus = cmbLecturerModStatus.Text;

            int x = bll.UpdateLecturerMod(fields);
           // ClearData();
            dgvDisplayLecturerModule.DataSource = bll.GetLecturerMod();

        }

        private void btnLecturerModDelete_Click(object sender, EventArgs e)
        {
            //HAVEN'T DONE THE CODE YET
        }
    }
}
