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
    public partial class SystemAdmin : Form
    {
        public SystemAdmin()
        {
            InitializeComponent();
        }
        //declare a variable passed from Login Form
        private string userEmail;
        //This method is designed to accept an email as a parameter ,
        //will use that email to retrieve and display the user's title, name, and surname
        public SystemAdmin(string Email)
        {
            InitializeComponent();
            //set the userEmail field to the email parameter
            userEmail = Email;
            BusinessLogicLayer bll = new BusinessLogicLayer();

            DAL.Fields userData = bll.GetFullNameByEmail(Email);

            if (userData != null)
            {
                // Display the user's email in a label
                lblName.Text = userData.Title + "  " + userData.Name + "  "+ userData.Surname;
            }


         
        }
        private void btnSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have Succefully Logged Out.");

            Login F1 = new Login();
            F1.Show();
            this.Hide();
        }

        private void SystemAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users(userEmail);
            users.Show();
            this.Hide();

        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            Modules modules = new Modules(userEmail);
            modules.Show();
            this.Hide();

        }

        private void btnLecturerMo_Click(object sender, EventArgs e)
        {
            LecturerModule lecturerMod = new LecturerModule(userEmail);
            lecturerMod.Show();
            this.Hide();

        }

        private void btnStudentMod_Click(object sender, EventArgs e)
        {
            StudentModule studentModule = new StudentModule(userEmail);
            studentModule.Show();
            this.Hide();
        }
    }
}
