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
    public partial class Orders : Form
    {
        public Employee employee;
        public Admin admin;
        
        public Orders()
        {
            InitializeComponent();
        }
        public Orders(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            employee.viewAllOrders();

            List<Order> listOfOrders = employee.viewAllOrders();
            dataGridView1.DataSource = listOfOrders;

            // edit datagridview data display in row

            dataGridView1.ReadOnly = true;

            foreach (Order order in listOfOrders)
            {
                dataGridView1.Rows[1].Cells[0].Value = order.orderBy._id;
                dataGridView1.Rows[2].Cells[0].Value = order.order._id;
            }



        }

        public Orders(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            List<Order> listOfOrders = admin.viewAllOrders();
            dataGridView1.ReadOnly = true;

            foreach (Order order in listOfOrders)
            {
                dataGridView1.Rows.Add(order._id, order.orderBy._id, order.order._id);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                OrdersAdding ins = new OrdersAdding(employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else if (admin != null)
            {
                OrdersAdding ins = new OrdersAdding(admin);
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
            else if (admin != null)
            {
                Choose ins = new Choose(admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }

        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(employee != null && dataGridView1.CurrentRow.Cells[0].Value.ToString()!=null)
            {
                employee.deleteOrder(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else if (admin != null && dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
            {
                    admin.deleteOrder(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
            else
            {
                
                    MessageBox.Show("Please select a row to delete");
                
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
