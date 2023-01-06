using swr_project.controllers;
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
    public partial class VehiclesAdding : Form
    {
        DB_helpers db = new DB_helpers();
        public User newUser;

        public VehiclesAdding()
        {
            InitializeComponent();
        }
        public VehiclesAdding (User newUser)
        {
            
                InitializeComponent();
                this.newUser = newUser;
            
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products ins = new Products(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)

        {

            if ( this.Model.Text =="" || this.Brand.Text == "" || this.Price.Text == "" || 
                this.EngineNumber.Text==""||
                    this.SerialNumber.Text==""||
                    this.textBox1.Text == "" 


                )
                
            {

                MessageBox.Show("Please fill all the fields");

            }
            else
            {
                if (this.Type.Text == "car"|| this.Type.Text=="Car")
                {
                    Car newCar = new Car(
                        this.textBox1.Text,
                    this.Model.Text,
                    this.Brand.Text,
                    this.Type.Text,
                    Convert.ToDouble(this.Price.Text),
                    this.EngineNumber.Text,
                    this.SerialNumber.Text);

                    newCar.addNewCar(newCar);
                    if (newCar.addNewCar(newCar) == null)
                    {
                        MessageBox.Show("something went wrong");
                    }
                    else {
                        MessageBox.Show("Car added successfully");
                        Choose ins = new Choose(newUser);
                        ins.MdiParent = this.MdiParent;
                        this.Hide();

                        ins.ShowDialog();
                    }
                }
                else
                {
                    Bike newBike = new Bike(
                        this.textBox1.Text,
                    this.Model.Text,
                    this.Brand.Text,
                    this.Type.Text,
                    Convert.ToDouble(this.Price.Text),
                    this.EngineNumber.Text,
                    this.SerialNumber.Text);

                    if (newBike.addNewBike(newBike) == null) { 
                        MessageBox.Show("something went wrong");
                }
                    else { 
                    MessageBox.Show("Bike added successfully");

                        Choose ins = new Choose(newUser);
                        ins.MdiParent = this.MdiParent;
                        this.Hide();

                        ins.ShowDialog();

                    }
            }
           

            
            }


        }

        private void VehiclesAdding_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
