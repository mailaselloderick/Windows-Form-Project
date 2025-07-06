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
using System.Text.RegularExpressions;



namespace PROJECT_ONT23
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        Fields fields = new Fields();

        static public DataTable DBInfo;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validate = false;
            //Perform input validation
            if (string.IsNullOrEmpty(txtEmail.Text) )
            {
                errorProvider1.SetError(txtEmail, "Please enter Email!");

            }
            else
            {
                validate = true;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Please enter Password!");
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                fields.Email = txtEmail.Text;
                fields.Password = txtPassword.Text;
                DBInfo = bll.Login(txtEmail.Text, txtPassword.Text);

                if (DBInfo.Rows.Count > 0)
                {
                    string userRole = DBInfo.Rows[0][4].ToString();

                    if (userRole == "Administrator")
                    {
                        string userEmail = txtEmail.Text;
                        // pass the userEmail to be accessed on SystemAdmin form 
                        SystemAdmin admin = new SystemAdmin(userEmail);
                        admin.Show();
                        this.Hide();  
                    }
                    else if (userRole == "Lecturer")
                    {
                        string userEmail = txtEmail.Text;
                        // pass the userEmail to be accessed on Lecturer form 
                        Lecturers lecturer = new Lecturers(userEmail);
                        lecturer.Show();
                        this.Hide();
                    }
                    else if (userRole == "Student")
                    {
                        string userEmail = txtEmail.Text;
                        // pass the userEmail to be accessed on Student form 
                        //COME BACK
                        Students stud = new Students(userEmail);
                        stud.Show();
                        this.Hide();
                    }
                }
               
            }
     

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txtPassword.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtEmail.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;

        }

    }
}
