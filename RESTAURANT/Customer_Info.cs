using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace RESTAURANT
{
    public partial class Customer_Info : Form
    {
        StaffClass staf;
        DataTable table;
        SqlCommand cmd;
        string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
        SqlConnection conn;
        public Customer_Info(StaffClass st)
        {
            staf = st;
            conn = new SqlConnection(sqldb);
            InitializeComponent();
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            if (phone_textbox.Text.Length != 11)
                System.Windows.Forms.MessageBox.Show("Enter Valid Number of 12 digits please!");
            else
            {
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Customer where PhNumber='" +phone_textbox.Text.Trim() + "'";
                cmd.CommandType = CommandType.Text;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());

                if (table.Rows.Count != 1)
                {
                    System.Windows.Forms.MessageBox.Show("Customer not found!");
                }
                else
                {
                    dataGridView1.DataSource = table;
                }

               
                conn.Close();
            }
        }

        

        private void phone_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //don't allow letters
        }

        private void addnewcust_btn_Click(object sender, EventArgs e)
        {
            using (var t = new AddNewCustomer())
            {
                t.StartPosition = FormStartPosition.Manual;
                t.Location = this.Location;
                this.Hide();
                t.ShowDialog();
            }
            this.Show();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string phone = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            using (var t = new Order("Delivery", phone,staf))
            {
                this.Hide();
                t.ShowDialog();
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
