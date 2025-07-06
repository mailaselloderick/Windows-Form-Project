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
    public partial class Modules : Form
    {
        private string userEmail;
        public Modules()
        {
            InitializeComponent();
        }
        public Modules(string Email)
        {
            InitializeComponent();
            userEmail = Email;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnModulesManSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModManExit_Click(object sender, EventArgs e)
        {
            SystemAdmin admin = new SystemAdmin(userEmail);
            admin.Show();
            this.Hide();
        }

        private void Modules_Load(object sender, EventArgs e)
        {
            cmbModuleDuration.Items.Add("Year Module");
            cmbModuleDuration.Items.Add("Semeter Module");

            cmbModuleStatus.Items.Add("Full");
            cmbModuleStatus.Items.Add("Not-Full");
         
            cmbModuleDescription.DataSource = bll.GetModuleType();
            cmbModuleDescription.DisplayMember = "ModuleTypeDescription";
            cmbModuleDescription.ValueMember = "ModuleTypeID";

            cmbFilterByModName.DataSource = bll.GetModuleName();
            cmbFilterByModName.DisplayMember = "ModuleName";
        }

        private void cmbModuleDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModuleDescription.Text = " ";
        }
        public void ClearData()
        {
            txtModuleName.Text = " ";
            cmbModuleDuration.Text = " ";
            cmbModuleDescription.Text = " ";
            cmbModuleStatus.Text = " ";
           

        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.ModuleName = txtModuleName.Text;
            fields.ModuleDuration = cmbModuleDuration.Text;
            fields.ModuleTypeID = int.Parse(cmbModuleDescription.SelectedValue.ToString());
            fields.ModuleStatus = cmbModuleStatus.Text;

            int x = bll.InsertModule(fields);
            ClearData();
            dgvDisplayModule.DataSource = bll.GetModule();
        }

        private void btnModuleRefresh_Click(object sender, EventArgs e)
        {
            dgvDisplayModule.DataSource = bll.GetModule();
        }

       

        private void dgvDisplayModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayModule.SelectedRows.Count > 0)
            {
                txtModuleID.Text = dgvDisplayModule.SelectedRows[0].Cells["ModuleID"].Value.ToString();
                txtModuleName.Text = dgvDisplayModule.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                cmbModuleDuration.Text = dgvDisplayModule.SelectedRows[0].Cells["ModuleDuration"].Value.ToString();
                cmbModuleDescription.Text = dgvDisplayModule.SelectedRows[0].Cells["ModuleTypeDescription"].Value.ToString();
                cmbModuleStatus.Text = dgvDisplayModule.SelectedRows[0].Cells["ModuleStatus"].Value.ToString();
                
            }
        }

        private void btnModuleDelete_Click(object sender, EventArgs e)
        {
            

        }

        private void cmbFilterByModName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.ModuleName = cmbFilterByModName.Text;
            dgvDisplayModule.DataSource = bll.SearchModule(fields.ModuleName);
        }
    }
}
