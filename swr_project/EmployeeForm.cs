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
    public partial class EmployeeForm : Form
    {
        public Employee employee;
        public Admin admin;
        string UserId;
        public EmployeeForm()
        {
            InitializeComponent();
        }
       
        public EmployeeForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            List<Employee> Employees = admin.GetAllEmployees();
            dataGridView1.DataSource = Employees;
            dataGridView1.ReadOnly = true;
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                AddingEmployee ins = new AddingEmployee(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // deleteUser

            admin.removeUser(UserId);
            Choose ins = new Choose(admin);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                Choose ins = new Choose(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           UserId= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
