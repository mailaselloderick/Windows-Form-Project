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
    public partial class LecturerControl : UserControl
    {
        private string userEmail;
        private int lecturerModuleID;
        public LecturerControl()
        {
            InitializeComponent();
        }
        public LecturerControl(int LecturerModuleID, string Email )
        {
            InitializeComponent();
            userEmail = Email;
            lecturerModuleID = LecturerModuleID;

        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void LecturerControl_Load(object sender, EventArgs e)
        {
            DAL.Fields userData = bll.ViewLecturerModOnPortal(lecturerModuleID, userEmail);

            if (userData != null)
            {
                // Display the user's details in the control
                txtLecturerName.Text = userData.Name + " " + userData.Surname;
                lblModName.Text = userData.ModuleName;
                txtLecturerEmail.Text = userData.Email;

            }
        }

        private void btnAssessments_Click(object sender, EventArgs e)
        {
            LectAssessmentReport report = new LectAssessmentReport(lecturerModuleID, userEmail);
            report.Show();
            this.Hide();
        }
    }
}
