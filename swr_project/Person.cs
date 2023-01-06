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
        public User newUser;

        public Person()
        {
            InitializeComponent();
        }
           public Person(User newUserr)
            {
                InitializeComponent();
                this.newUser = newUserr;
            }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string FullName = Firstname.Text + LastName.Text;
            string Gender;
            string Type = "Customer";
            string DefaultPassword="1234";
            List<Order> orders = new List<Order>();
            bool Checked = Male.Checked;
            if (Checked)
            {
                Gender     = "Male";
            }
            else
            {
                Gender = "Female";
            }
            Customer newCustomer = new Customer(

                Firstname.Text,
                LastName.Text,
                FullName,
                Address.Text,
               Convert.ToInt32(PhoneNumber.Text),
               Email.Text,
                    Type,
                    Gender,
                    DefaultPassword,
                    orders
                );
            Admin newAdmin = new Admin();

            newAdmin.addUser(newCustomer);


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
           
            Customers ins = new Customers(newUser);
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
