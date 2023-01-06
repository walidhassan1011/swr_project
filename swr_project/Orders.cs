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
    public partial class Orders : Form
    {
        public User newUser;
        public Orders()
        {
            InitializeComponent();
        }
        public Orders(User newUser)
        {
            InitializeComponent();
            this.newUser = newUser;

            newUser.viewAllOrders();

            dataGridView1.DataSource = newUser.viewAllOrders();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdersAdding ins = new OrdersAdding(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choose ins = new Choose(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();

        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
