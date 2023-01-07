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
        public User newUser;
        public Order newOrder;
        public InvoiceForm()
        {
            InitializeComponent();
        }
        public InvoiceForm(string orderById,string orderId,User newUser)
        {
            InitializeComponent();

            this.newUser = newUser;
            
            Customer newCustomer = newUser.FinUserById(orderById);
            Vehicles newVehicle = newUser.FindVehicleById(orderId);
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
