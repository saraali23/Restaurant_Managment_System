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
namespace RESTAURANT
{
    public partial class EDIT_Customer_Info : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds1;
        public EDIT_Customer_Info()
        {
            InitializeComponent();
        }

        private void EDIT_Customer_Info_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            button2.Visible = false;
          //  groupBox1.Visible = false;
            textBox2.Select();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=orcl; User Id=hr;Password=hr;";
            string cmdstr = "";

            cmdstr = "SELECT * FROM CUSTOMER WHERE CUSTOMER_ID = '" + textBox2.Text + "'";

            adapter = new OracleDataAdapter(cmdstr, conn);
            ds1 = new DataSet();
            adapter.Fill(ds1);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = ds1.Tables[0];
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds1.Tables[0]);
           
            MessageBox.Show("Your Info Edited Successfully");
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
