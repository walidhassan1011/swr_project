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
    public partial class OrdersAdding : Form
    {
        public OrdersAdding()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders ins = new Orders();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
