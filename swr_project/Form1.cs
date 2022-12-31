
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

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB_helpers db = new DB_helpers();
           Vehicles p45 = new Vehicles();
            
            //Person p3 = new Person()
            //{
            //   _id = "63ad7312a975aca8d2b60e4e"
            //};
            //db.DeleteUser(p3);

            p45._id = "63ad82576850cb60cafc7f1c";
            p45.model = "waldi122";
            Task v1 = db.UpdateVehicle(p45);

            if (v1 != null)
            {
              MessageBox.Show("updated");
            }
            else
           {
                MessageBox.Show("not updated");
           }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}