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
    public partial class Lecturers : Form
    {
        private string userEmail;
        public Lecturers()
        {
            InitializeComponent();
        }
        public Lecturers(string Email)
        {
            InitializeComponent();
            userEmail = Email;
            BusinessLogicLayer bll = new BusinessLogicLayer();

            DAL.Fields userData = bll.GetFullNameByEmail(Email);

            if (userData != null)
            {
                // Display the user's email in a label
                lblName.Text = userData.Title + "  " + userData.Name + "  " + userData.Surname;
            }
        }
        public void showControl(Control control)
        {
            // Clear the existing controls from the Content container
            Contents.Controls.Clear();

            // Set the Dock and bring the new control to the front
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            // Add the new control to the Content container
            Contents.Controls.Add(control);
        }
        private void Lecturers_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            cmdMyModules.DataSource = bll.ViewLeturerModByEmail(userEmail);
            cmdMyModules.DisplayMember = "ModuleName";
            cmdMyModules.ValueMember = "LecturerModuleID";

            cmdMyModules.SelectedItem = "Choose Modules";
            cmdMyModules.Text = "Choose Modules";

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            MessageBox.Show("You Have Sucessfully Logged Out");
        }

        private void btnLectExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMyModules_Click(object sender, EventArgs e)
        {
            int lecturerModuleID = int.Parse(cmdMyModules.SelectedValue.ToString());
            string selectedModule = cmdMyModules.Text;
            if (selectedModule == "Choose Modules")
            {
                // Display the current contents in the panel called Contents

            }
            else
            {
                LecturerControl lc = new LecturerControl(lecturerModuleID, userEmail);
                // Add the new UsersControl to the container
                showControl(lc);

            }
        }

        private void btnCreateAssess_Click(object sender, EventArgs e)
        {
            LecturerAssess lecturer = new LecturerAssess(userEmail);
            lecturer.Show();
            this.Hide();
        }
    }
}
