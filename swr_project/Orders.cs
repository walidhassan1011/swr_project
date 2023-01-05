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
        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdersAdding ins = new OrdersAdding();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choose ins = new Choose();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();

        }
    }
}
