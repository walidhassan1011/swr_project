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
            MessageBox.Show(Type);
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
            if (Type == "Admin")
            {

                // add new admin
               
               
                Admin newAdmin = new Admin(
                    Firstname.Text,
                    LastName.Text,
                    FullName,
                    Address.Text,
                    Convert.ToInt32(PhoneNumber.Text),
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
            else
            {
              
                
                Admin newAdmin = new Admin();
                // add new employee
                Employee newEmployee = new Employee(
                    Firstname.Text,
                    LastName.Text,
                    FullName,
                    Address.Text,
                    Convert.ToInt32(PhoneNumber.Text),
                    Email.Text,
                    Type,
                    Gender,
                    DefaultPassword);
                newAdmin.addUser(newEmployee);

                MessageBox.Show("employee Added");

                EmployeeForm ins = new EmployeeForm(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
        }
    }
}
