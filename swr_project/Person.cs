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
    public partial class Person : Form
    {
        public Admin admin;

        public Person()
        {
            InitializeComponent();
        }
           public Person(Admin admin)
            {
                InitializeComponent();
            this.admin = admin;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string FullName = Firstname.Text + LastName.Text;
            string Gender;
            string Type = "Customer";
            string DefaultPassword="1234";
           
            bool Checked = Male.Checked;
            if (Checked)
            {
                Gender     = "Male";
            }
            else
            {
                Gender = "Female";
            }
            if (Firstname.Text == "" || LastName.Text == "" || FullName == "" || Address.Text == "" || PhoneNumber.Text ==""|| Email.Text==""|| Type=="" || Gender==""||DefaultPassword=="")
            {
                

                MessageBox.Show("Please Fill All Fields");
            }
            else
            {

                Customer newCustomer = new Customer(

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


                admin.addUser(newCustomer);
                MessageBox.Show("Customer Added Successfully");
                Customers ins = new Customers(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Customers ins = new Customers(admin);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();

        }

        private void Person_Load(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
