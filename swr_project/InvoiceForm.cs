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
    public partial class InvoiceForm : Form
    {
        public Employee employee;
        public Admin admin;
        public Order newOrder;
        public InvoiceForm()
        {
            InitializeComponent();
        }
        public InvoiceForm(string orderById,string orderId,Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            Customer newCustomer = employee.FinUserById(orderById);
            Vehicles newVehicle = employee.FindVehicleById(orderId);
            orderBy.Text = newCustomer.firstName;
            order.Text = newVehicle.Model;
            price.Text = newVehicle.price.ToString();
            Type.Text = newVehicle.Type;
            serial_Number.Text = newVehicle.serialNumber;
            
            




        }
        public InvoiceForm(string orderById, string orderId, Admin admin)
        {
            InitializeComponent();

            this.admin = admin;

            Customer newCustomer = admin.FinUserById(orderById);
            Vehicles newVehicle = admin.FindVehicleById(orderId);
            orderBy.Text = newCustomer.firstName;
            order.Text = newVehicle.Model;
            price.Text = newVehicle.price.ToString();
            Type.Text = newVehicle.Type;
            serial_Number.Text = newVehicle.serialNumber;






        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
