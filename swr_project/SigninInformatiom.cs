﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using swr_project.controllers;
using swr_project.Models;


namespace swr_project
{
    public partial class SigninInformatiom : Form
    {
        public SigninInformatiom()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SigninInformatiom_Load(object sender, EventArgs e)
        {
            Vehicles v1 = new Vehicles(
                    "1",
                    "Diesel",
                    "Audi",
                    "A4",
                    "2019",
                    "123456789",
                    100000,
                    "123456789",
                    "123456789"

                );
            User u1 = new User();
            u1.firstName = "John";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB_helpers db = new DB_helpers();
            User u1 = new User(
                    
                    
                );

            db.AddNewUser(u1);
        }
    }
}
