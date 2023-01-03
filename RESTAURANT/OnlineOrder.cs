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
    public partial class OnlineOrder : Form
    {
        StaffClass staf; 
        DataTable table;
        List<SpecialOrder> sp;
        
      
        public OnlineOrder(StaffClass st)
        {
           
            InitializeComponent();
            staf = st;
            
            //make some virtual online orders that came from the client side app/website
            sp = new List<SpecialOrder> { };
            sp.Add( new SpecialOrder("01000920326","2022-12-31","Online"));
            sp[0].items = new List<mealItem> { new mealItem("Cheese Burger", 60, 3), new mealItem("Tea", 5, 2) };
            sp.Add(  new SpecialOrder("01006564294", "2022-12-31", "Online"));
            sp[1].items = new List<mealItem> { new mealItem("Scrambled Eggs", 25, 6), new mealItem("Tea", 5, 2) };


        }

        private void OnlineOrder_Load(object sender, EventArgs e)
        {
            //make a grid view that shows phone number of ordering customer and the date of order
            table = new DataTable();
            table.Columns.Add("Phone");
            table.Columns.Add("Date");


            for (int i = 0; i < sp.Count(); i++)
            {
                DataRow r = table.NewRow();
                r["Phone"] = sp[i].phone;
                r["Date"] = sp[i].OrdDate;
                table.Rows.Add(r);
            }
            dataGridView1.DataSource = table;
           
           
        }

        //an order is selcted
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int ind = dataGridView1.CurrentRow.Index;
            //assign staff to order
            sp[ind].OrdStaff = staf;
            sp[ind].PaymentMethod = "Cash";
            //add order
            int check = staf.AddAnOrd(sp[ind]);
            if (check == 1)
            {
                System.Windows.Forms.MessageBox.Show(sp[ind].PrintReciept());
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                this.Close();
            }
            else if (check == 0)
                System.Windows.Forms.MessageBox.Show("There seems to be a problem!");
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
