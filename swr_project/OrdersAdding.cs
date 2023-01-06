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
    public partial class OrdersAdding : Form
    {
        public User newUser;
        public string Order;
        public string orderBy;
        public OrdersAdding()
        {
            InitializeComponent();
        }
        public OrdersAdding (User newUser)
        
            {
                InitializeComponent();
                this.newUser = newUser;
            List<Customer> customers=newUser.viewAllUsers();
            List<Vehicles> Vehicles = newUser.viewAllVehicles();
            OrderBydataGrid.DataSource = customers;
            OrderDataGrid.DataSource = Vehicles;
        


    }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Orders ins = new Orders(newUser);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OrdersAdding_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order(
                Order,
                orderBy
                );
           if(
                Order == "" ||
                orderBy == ""
                )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Admin newAdmin = new Admin();
                Customer NewCustomer = newUser.FinUserById(orderBy);
                if (NewCustomer == null)
                {
                    

                    MessageBox.Show("Please enter a valid customer ID");
                }
                else
                {
                    NewCustomer?.customerOrders?.Add(newOrder);
                    newAdmin.editUser(NewCustomer);
                    newUser.addNewOrder(newOrder);
                    MessageBox.Show("Order added successfully");
                }
                
                    
               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OrderBydataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderBydataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // put the selected row data into Customer object
             orderBy  = OrderBydataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            



        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // put the selected row data into Vehicles object

            Order = OrderDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            
            


        }
    }
}
