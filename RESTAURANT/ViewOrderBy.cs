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
    public partial class ViewOrderBy : Form
    {
        int type;
        DataTable table;
        StaffClass staf;
        public ViewOrderBy( StaffClass st)
        {
            staf = st;
            InitializeComponent();
        }

        private void ViewOrderBy_Load(object sender, EventArgs e)
        {
            
            HideElements();
        }
        private void HideElements()
        {
            dateTimePicker1.Hide();
            phone_textbox.Hide();
            Ordertype_combo.Hide();
            
        }

        private void searchbydate_btn_Click(object sender, EventArgs e)
        {
            type = 0;
            HideElements();
            dateTimePicker1.Show();

        }

        private void searchbyphone_btn_Click(object sender, EventArgs e)
        {
            type = 1;
            HideElements();
            phone_textbox.Show();
        }

        private void searchbyord_btn_Click(object sender, EventArgs e)
        {
            type = 2;
            HideElements();
            Ordertype_combo.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            
          
            table = new DataTable();
            if (type == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Choose A Search Method!");
            }
            else if (type == 0)//by date
            {
                string OrderDate= dateTimePicker1.Value.ToString("yyyy-MM-dd");
                staf.GetOrdersByDate(OrderDate,table);
                

            }
            else if(type ==1)//by cust phone
            {
                string CustPhone = phone_textbox.Text.Trim();
                if (CustPhone.Length != 11)
                    System.Windows.Forms.MessageBox.Show("Enter Valid Number of 12 digits please!");
                else
                {
                    staf.GetOrdersByCust(CustPhone,table);
                }
               
            }
            else if (type == 2)//by order type
            {
                string Ordtype = Ordertype_combo.SelectedItem.ToString();
                staf.GetOrdersByOrdType(Ordtype, table);
            }
            dataGridView1.DataSource = table;

        }

        private void phone_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = conn;
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());
            cmd.CommandText = "select * from getMealsByOrdId(@id)";
            cmd.Parameters.Add("id", id);
            cmd.CommandType = CommandType.Text;
            table = new DataTable();
            table.Constraints.Clear();
            conn.Open();
            table.Load(cmd.ExecuteReader());
            
            string messege = "Order Meals:" + System.Environment.NewLine;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                messege += " Item: " + table.Rows[i].ItemArray[0] + ",  Quantity: " + table.Rows[i].ItemArray[1] + System.Environment.NewLine;
            }
            System.Windows.Forms.MessageBox.Show(messege);

            conn.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
