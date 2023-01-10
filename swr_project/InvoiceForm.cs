using swr_project.Models;
using System.Drawing.Printing;
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
        public InvoiceForm(string orderById,string orderId,string theOrderId,Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            Customer newCustomer = employee.FinUserById(orderById);
            Vehicles newVehicle = employee.FindVehicleById(orderId);
            Invoice newInvoice = new Invoice(newVehicle.price, newVehicle.Model, newCustomer);
            newInvoice.addNewInvoice(newInvoice);
            orderBy.Text = newCustomer.firstName;
            order.Text = newVehicle.Model;
            price.Text = newVehicle.price.ToString();
            Type.Text = newVehicle.Type;
            serial_Number.Text = newVehicle.serialNumber;
            order_Id.Text = theOrderId;
            date.Text = DateTime.Now.ToString("M/d/yyyy");





        }
        public InvoiceForm(string orderById, string orderId,  string theOrderId, Admin admin)
        {
            InitializeComponent();

            this.admin = admin;

            Customer newCustomer = admin.FinUserById(orderById);
            Vehicles newVehicle = admin.FindVehicleById(orderId);
            Invoice newInvoice = new Invoice(newVehicle.price, newVehicle.Model, newCustomer);
            newInvoice.addNewInvoice(newInvoice);
            orderBy.Text = newCustomer.firstName;
            order.Text = newVehicle.Model;
            price.Text = newVehicle.price.ToString();
            Type.Text = newVehicle.Type;
            serial_Number.Text = newVehicle.serialNumber;
            order_Id.Text = theOrderId;
            date.Text = DateTime.Now.ToString("M/d/yyyy");





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

        private void pictureBox3_Click(object sender, EventArgs e)
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
        Bitmap memoryImage;
        private void PrintDocument1_PrintPage(System.Object sender,
        System.Drawing.Printing.PrintPageEventArgs e) =>
            e.Graphics.DrawImage(memoryImage, 0, 0);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }
    }
}
