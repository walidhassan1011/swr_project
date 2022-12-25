
using swr_project.controllers;
using swr_project.Models;
using System;
using System.Windows.Forms;

namespace swr_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            DB_helpers db = new DB_helpers();
            
            db.addNewInvoice(new Invoice { invoiceNumber = "123" });

        }
    }
}