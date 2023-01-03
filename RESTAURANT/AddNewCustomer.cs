using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RESTAURANT
{
    public partial class AddNewCustomer : Form
    {
        StaffClass CurrStaff;
        DataTable table;
        SqlCommand cmd;
        string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
        SqlConnection conn;

        public AddNewCustomer()
        {
            CurrStaff = new StaffClass();
            conn = new SqlConnection(sqldb);
            InitializeComponent();
        }

        private void phone_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // don't type letters
        }

        private void custname_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);// don't type numbers
        }

        private void addcust_btn_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                Customer cust = new Customer();
                cust.phone = phone_textbox.Text.Trim();
                cust.name = custname_textbox.Text.Trim();
                cust.street = custadd_textbox.Text.Trim();
                cust.city = comboBox1.SelectedItem.ToString();

                AddCustToDB(cust);//insert customer into database
            }
        }
        private bool CheckValid() //validate input
        {
            bool valid = true;

            if (phone_textbox.Text.Length != 11)
            {
                System.Windows.Forms.MessageBox.Show("Enter Valid Number of 12 digits please!");
                valid = false;
            }
            if (custname_textbox.Text.Length > 30)  
            {
                System.Windows.Forms.MessageBox.Show("Enter Name of 30 characters maximum!");
                valid = false;
            }
            if (custadd_textbox.Text.Length > 30)
            {
                System.Windows.Forms.MessageBox.Show("Enter Address of 30 characters maximum!");
                valid = false;
            }
            return valid;
        }
        private void AddCustToDB(Customer cust)
        {


            int check = CurrStaff.AddNewCust(cust);
            if (check == 1)
            {
                System.Windows.Forms.MessageBox.Show("Customer Added Successfully!");
                this.Close();
            }
            else if (check == 0)
                System.Windows.Forms.MessageBox.Show("Customer Phone Number Already Exists!");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
