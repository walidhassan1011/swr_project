using System;
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB_helpers db = new DB_helpers();
            User u1 = new User(
                    "walid",
                    "hassan",
                    "walid hassan",
                    "1234 Main St",
                    123456789,
                    "walidhassan009@gmail.com",
                    "Admin",
                    "Male",
                    "1234"

                );

            db.AddNewUser(u1);
        }
    }
}
