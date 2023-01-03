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
using Microsoft.VisualBasic;


namespace RESTAURANT
{
    public partial class Order : Form
    {
        DataTable meals;
        OrderClass ord;
        StaffClass staf;
        string orderType;
        string phone;
        SqlCommand cmd;
        string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
        SqlConnection conn;
        public Order(string type,string phoneNum,StaffClass st)
        {
            staf=st;
            this.orderType = type;
            this.phone = phoneNum;
            if (orderType == "Normal")
               ord = new OrderClass();
            else
               ord = new SpecialOrder(phone," ","Delivery");

            conn = new SqlConnection(sqldb);

            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            string s = "Breakfast";
            if (!all_btn.Checked)
            {
                if (dinner_btn.Checked)
                    s = "Dinner";
                else if (lunch_btn.Checked)
                    s = "Lunch";
                else if (drinks_btn.Checked)
                    s = "Drinks";


                meals = getMealsByType(s);
            }
            else
            {
                meals = getAllMeals();
            }

            dataGridView1.DataSource = meals;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            int check;
            string cardNum="";
            string visa = "No";//use visa or not
            ord.OrdStaff = staf;//assign staff to order
           
            if(orderType == "Normal")
          
                do
                {
                
                    visa = getPaymentType();
                    if (visa == "Yes")
                    {
                        cardNum = getCradNumber();
                        if(cardNum == "")
                        {
                            System.Windows.Forms.MessageBox.Show("Process Cancelled!");

                        }
                        else if (cardNum.Length>0 && cardNum.Length != 14)
                        {
                            System.Windows.Forms.MessageBox.Show("Not A valid Card Number!");

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Payment Successful");
                            ord.PaymentMethod = "Visa";
                        }
                    }
                    else
                    {
                        ord.PaymentMethod = "Cash";
                    }
               
                   
                }
                while (cardNum == "" && visa == "Yes");//cancelled
            else
            {
                ord.PaymentMethod = "Cash";
            }
                  
             check = staf.AddAnOrd(ord); //add order to database
            if (check == 1)
            {
                System.Windows.Forms.MessageBox.Show(ord.PrintReciept());//print order       
                this.Close();
            }
            else if (check == 0)
                System.Windows.Forms.MessageBox.Show("There seems to be a problem!");
         
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            string mealname = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int meal_price = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string quan = Interaction.InputBox("Enter your Quantity?", "quantity");

            if (quan == "")
                System.Windows.Forms.MessageBox.Show("Item wasn't Added");
            else if (!quan.All(char.IsDigit) || Int32.Parse(quan) < 1)
                System.Windows.Forms.MessageBox.Show("Please Enter A Valid Number");
            else
            {
                int QToINT = Int32.Parse(quan);

                int found = 0;
                int len;

                len = ord.items.Count();

                for (int i = 0; i < len; i++)//item already added to order
                {
                    if (ord.items.ElementAt(i).mealName == mealname)
                    {
                        found = 1;
                        ord.items.ElementAt(i).quantity = 1;
                    }
                }
                if (found != 1)//first time item is added
                {
                    ord.items.Add(new mealItem());
                    ord.items[len].mealName = mealname;
                    ord.items[len].mealPrice = meal_price;
                    ord.items[len].quantity = QToINT;
                }
            }


        }
        private DataTable getAllMeals()
        {
            conn.Open();
            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from showAllMeals";
            table.Load(cmd.ExecuteReader());
            conn.Close();

            return table;


        }
        private DataTable getMealsByType(string type)
        {
            conn.Open();
            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Meal where mealType='" + type + "'";
            table.Load(cmd.ExecuteReader());
            conn.Close();
            return table;


        }

        public string getPaymentType()
        {
           
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Pay be Visa?", "Payment Method",buttons);
            string res = result.ToString();      
            return res;

        }
        public string getCradNumber()
        {
 
           
            string num = Interaction.InputBox("Please Enter Card Number:", "Card Number");       
            return num;

        }
        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
