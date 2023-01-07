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
    public partial class OrdersAdding : Form
    {
        public Employee employee;
        public Admin admin;
        public string order;
        public string orderBy;
        public OrdersAdding()
        {
            InitializeComponent();
        }

        public OrdersAdding(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            List<Customer> customers = admin.viewAllUsers();
            List<Vehicles> Vehicles = admin.viewAllVehicles();
            OrderBydataGrid.DataSource = customers;
            OrderDataGrid.DataSource = Vehicles;

        }

        public OrdersAdding (Employee employee)
        
            {
                InitializeComponent();
            this.employee = employee;
            List<Customer> customers=employee.viewAllUsers();
            List<Vehicles> Vehicles = employee.viewAllVehicles();
            OrderBydataGrid.DataSource = customers;
            OrderDataGrid.DataSource = Vehicles;
            OrderBydataGrid.ReadOnly = true;
            OrderDataGrid.ReadOnly = true;
        


    }
        
        private void button3_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OrdersAdding_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (employee != null)
            {
                Customer customer = employee.FinUserById(orderBy);
                Vehicles vehicle = employee.FindVehicleById(order);
                Order newOrder = new Order(vehicle, customer);
                employee.addNewOrder(newOrder);
                customer.customersOrders.Add(vehicle);
                employee.editUser(customer);
                MessageBox.Show("order added ");
                InvoiceForm ins = new InvoiceForm(orderBy,order,newOrder._id,employee);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();

            }
            else
            {
                Customer customer = admin.FinUserById(orderBy);
                Vehicles vehicle = admin.FindVehicleById(order);
                Order newOrder = new Order(vehicle, customer);
                admin.addNewOrder(newOrder);
                customer.customersOrders.Add(vehicle);
                admin.editUser(customer);
                MessageBox.Show("order added ");
                InvoiceForm ins = new InvoiceForm(orderBy, order, newOrder._id, admin);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OrderBydataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderBydataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // put the selected row data into Customer object
             orderBy  = OrderBydataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            



        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // put the selected row data into Vehicles object

            order = OrderDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            
            


        }
    }
}
