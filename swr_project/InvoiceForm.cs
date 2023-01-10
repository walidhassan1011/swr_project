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
           
        }
        Bitmap memoryImage;
        private void PrintDocument1_PrintPage(System.Object sender,
        System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.groupBox1.Width, this.groupBox1.Height);
            this.groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.PrintDocument1_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
    }
}
