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
using static System.Windows.Forms.DataFormats;

namespace swr_project
{
    public partial class Choose : Form
    {
        public Employee employee;
        public Admin admin;
        public Choose()
        {
            InitializeComponent();
        }
        public Choose(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            
             

            
            
                button4.Visible = false;
                
                
          
        }
        public Choose(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            
                button4.Visible = true;

            
           
        }
        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                Products ins = new Products(employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else if (admin != null)
            {
                Products ins = new Products(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                Orders ins = new Orders(employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else if (admin != null)
            {
                Orders ins = new Orders(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                Customers ins = new Customers(employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else if (admin != null)
            {
                Customers ins = new Customers(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                EmployeeForm ins = new EmployeeForm(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            
        }
    }
}
