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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace swr_project
{
    public partial class Customers : Form
    {
        public Employee employee;
        public Admin admin;
        public string UserId;
        public Customers()
        {
            InitializeComponent();
            
        }

        public Customers(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            List<Customer> listOfCustomers = employee.viewAllUsers();
            dataGridView1.DataSource = listOfCustomers;
            //remove button
            button3.Visible = false;
            //add button
            button1.Visible = false;
        }

        public Customers(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            List<Customer> listOfCustomers = admin.viewAllUsers();
            dataGridView1.DataSource = listOfCustomers;
        }



        private void button1_Click(object sender, EventArgs e)
        {

           
                
            
            
                Person ins = new Person(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
            
        {
           

         
            




        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                Choose ins = new Choose(employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else if (admin != null)
            {
                Choose ins = new Choose(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            admin.removeUser(UserId);
            Choose ins = new Choose(admin);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
