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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace swr_project
{
    public partial class Customers : Form
    {
        public User newUser;
        public string UserId;
        public Customers()
        {
            InitializeComponent();
            
        }

        public Customers(User newUser)
        {
            InitializeComponent();
            this.newUser = newUser;
            List<Customer> listOfUser = newUser.viewAllUsers();
            dataGridView1.DataSource = listOfUser;

            if (newUser.type == "Admin" || newUser.type == "admin")
            {
                
                button3.Visible = true;
                button1.Visible = true;
            }
            else
            {
                
                //remove button
                button3.Visible = false;
                //add button
                button1.Visible = false;
            }







        }



        private void button1_Click(object sender, EventArgs e)
        {

           
            Person ins = new Person(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
            
        {
           

            // users in dataGrid view
            




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choose ins = new Choose(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.removeUser(UserId);
            Choose ins = new Choose(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
