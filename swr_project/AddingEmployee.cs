using swr_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swr_project
{
    public partial class AddingEmployee : Form
    {
        public Admin admin;
        public AddingEmployee()
        {
            InitializeComponent();
        }
        public AddingEmployee(Admin admin)
        {

            InitializeComponent();
            this.admin = admin;

        }

        private void AddingEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Type = comboBox1.Text;
            
            string Gender;
            string DefaultPassword = "1234";
            string FullName = Firstname.Text + " " + LastName.Text;
            bool Checked = Male.Checked;
            if (Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            
                // add new admin


                if (Firstname.Text == "" || LastName.Text == "" || Email.Text == "" || PhoneNumber.Text == "" || Address.Text == ""|| Gender =="")
                {

                MessageBox.Show("Please Fill All Fields");


            }
                else

                {  
                Admin newAdmin = new Admin(
                      Firstname.Text,
                      LastName.Text,
                      FullName,
                      Address.Text,
                      PhoneNumber.Text,
                      Email.Text,
                      Type,
                      Gender,
                      DefaultPassword
                       );
                newAdmin.addUser(newAdmin);
                MessageBox.Show("Admin Added");
                EmployeeForm ins = new EmployeeForm(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();


            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm ins = new EmployeeForm(admin);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
