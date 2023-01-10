using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using swr_project.controllers;
using swr_project.Models;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;


namespace swr_project
{
    public partial class SigninInformatiom : Form
    {

        DB_helpers db_helpers = new DB_helpers();

        public static string TYPE;
     
        public SigninInformatiom()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void SigninInformatiom_Load(object sender, EventArgs e)
        {



        }


        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            


            string UserName = userName.Text;
            string password = Password.Text;
            if(UserName == "" || password == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                
            }
            Admin employee = db_helpers.FindUser(UserName, password);
            

            if (employee == null)
            {
                MessageBox.Show("User Name or Password is incorrect");
            }

            else
            {
                if (employee.type == "employee" || employee.type == "Employee")
                {
                    // casting the type of the employee to the admin


                    Employee employee1 = (Employee)employee;

                    MessageBox.Show("Welcome " + employee1.firstName);
                    Choose ins = new Choose(employee1);
                    ins.MdiParent = this.MdiParent;
                    this.Hide();

                    ins.ShowDialog();

                }
               else {
                    Admin admin = new Admin();

                    admin = employee;

                    
                    MessageBox.Show("Welcome " + admin.firstName);
                    Choose ins = new Choose(admin);
                    ins.MdiParent = this.MdiParent;
                    this.Hide();

                    ins.ShowDialog();
                }



            }


            }

            
        }

        
    
}
