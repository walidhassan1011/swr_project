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
using static System.Windows.Forms.DataFormats;

namespace swr_project
{
    public partial class Choose : Form
    {
        public User newUser;
        public Choose()
        {
            InitializeComponent();
        }
        public Choose(User newUser)
        {
            InitializeComponent();
            this.newUser = newUser;
            if (newUser.type == "Admin"||newUser.type=="admin")
            {
                button4.Visible = true;

            }
            else
            {
                button4.Visible = false;
                
                
           }
        }
        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products ins = new Products (newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders ins = new Orders(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers ins = new Customers(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeForm ins = new EmployeeForm(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
