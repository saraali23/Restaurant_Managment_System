using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Microsoft.VisualBasic;

namespace RESTAURANT
{
    public partial class USER_FORM : Form
    {
        OracleDataAdapter adapter;
        OracleDataAdapter adapter2;
        OracleCommandBuilder builder;
        OracleCommandBuilder builder2;
        DataSet ds1;
        DataSet ds2;
        string Q;
        int count_orders = 1;
        int total_price = 0;
        OracleCommand cmd;
        OracleConnection conn2;
        public USER_FORM ()
        {

            InitializeComponent();
        }
        protected void dataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void USER_FORM_Load(object sender, EventArgs e)
        {
            string conn = "Data Source=orcl; User Id=hr;Password=hr;";

            conn2 = new OracleConnection(conn);
            conn2.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn2;
            cmd.CommandText = "SELECT MAX(ORDER_ID) FROM ORDERS";
            try
            {
                int maxId = Convert.ToInt32(cmd.ExecuteScalar());
                count_orders = maxId + 1;
            }
            catch
            {
                count_orders = 1;
            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conn = "Data Source=orcl; User Id=hr;Password=hr;";
            string cmdstr = "";
            string s = "Breakfast";
            if (radioButton1.Checked)
            {
                cmdstr = "select * from MEAL where MEAL_TYPE='Breakfast'";

            }
            if (radioButton2.Checked)
            {
                cmdstr = "select * from MEAL where MEAL_TYPE='Dinner'";

            }
            if (radioButton3.Checked)
            {
                cmdstr = "select * from MEAL where MEAL_TYPE='Launch'";

            }
            adapter = new OracleDataAdapter(cmdstr, conn);
            ds1 = new DataSet();
            adapter.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn2;
            cmd.CommandText = "update ORDERS set ORDER_PRICE=:total_price where ORDER_ID=:count_orders ";
            cmd.Parameters.Add("total_price", total_price);
            cmd.Parameters.Add("count_orders", count_orders);
            MessageBox.Show(" Total Price " + total_price);
            cmd.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int meal_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            string status = "waiting";
            int customer_id = 1;
            int order_price = 10;

            cmd = new OracleCommand();
            cmd.Connection = conn2;
            try
            {
                cmd.CommandText = "Insert  into ORDERS  VALUES( :count_orders, :status ,:customer_id,:order_price)";
                cmd.Parameters.Add("count_orders", count_orders);
                cmd.Parameters.Add("status", status);
                cmd.Parameters.Add("customer_id", customer_id);
                cmd.Parameters.Add("order_price", order_price);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            //=================//
            OracleCommand cmd2 = new OracleCommand();

            cmd2.Connection = conn2;
            int meal_price = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            Q = Interaction.InputBox("Enter your Quantity?", "quantity");
            int QToINT = Int32.Parse(Q);

            int price = meal_price * QToINT;
            total_price += price;
            cmd2.CommandText = "Insert into ORDER_MEAL  VALUES( :count_orders, :meal_id ,:QToINT,:price)";
            cmd2.Parameters.Add("count_orders", count_orders);
            cmd2.Parameters.Add("meal_id", meal_id);
            cmd2.Parameters.Add("QToINT", QToINT);
            cmd2.Parameters.Add("price", price);
            cmd2.ExecuteNonQuery();

        }
    }
}
