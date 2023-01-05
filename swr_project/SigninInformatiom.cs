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
using swr_project.controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;


namespace swr_project
{
    public partial class SigninInformatiom : Form
    {

        DB_helpers db_helpers = new DB_helpers();
     
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



        private void SigninInformatiom_Load(object sender, EventArgs e)
        {



        }


        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            string UserName = userName.Text;
            string password = Password.Text;

          newUser= db_helpers.FindUser(UserName, password);

            if (newUser == null)
            {
                MessageBox.Show("not Exist");
            }

            else
            {
                Choose ins = new Choose();
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            
        }
    }
}
