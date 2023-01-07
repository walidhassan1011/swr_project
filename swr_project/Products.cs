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
    public partial class Products : Form
    {
        public string name = "car";
        public Employee employee;
        public Admin admin;

        public Products()
        {
            InitializeComponent();
        }
        public Products(Employee employee )
        {
            InitializeComponent();
            this.employee = employee;
            List<Vehicles> listOfVehicles=  employee.viewAllVehicles();
            dataGridView1.DataSource = listOfVehicles;
            dataGridView1.ReadOnly = true;
        }
        public Products(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            List<Vehicles> listOfVehicles = admin.viewAllVehicles();
            dataGridView1.DataSource = listOfVehicles;
            dataGridView1.ReadOnly = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                VehiclesAdding ins = new VehiclesAdding(employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else
            {
                VehiclesAdding ins = new VehiclesAdding(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
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
            else
            {
                Choose ins = new Choose(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (employee != null && dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
            {
                employee.DeleteVehicle(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Choose ins = new Choose(employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else if (admin != null && dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
            {
                admin.DeleteVehicle(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Choose ins = new Choose(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
           else {
                MessageBox.Show("Please select a vehicle to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
