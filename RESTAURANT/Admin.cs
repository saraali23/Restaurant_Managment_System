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
    public partial class Admin : Form
    {
        int check = 0;
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            meal_name_cmb.Enabled = false;
            meal_price.Enabled = false;
            meal_name_label.Enabled = false;
            price_label.Enabled = false;
            insert_btn.Enabled = false;
            show_price.Enabled = false;
            meal_type.Enabled = false;
            type_txt.Enabled = false;
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            //proc change check
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "check_admin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", txt_admin_id.Text);
            cmd.Parameters.Add("name", txt_admin_name.Text);
            cmd.Parameters.Add("r", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int cnt = Convert.ToInt32(cmd.Parameters["r"].Value.ToString());    //Convert.ToString(cmd.Parameters["role"].Value.ToString());
            //check = 1; //
            if (cnt == 1)
            {
                meal_name_cmb.Enabled = true;
                meal_price.Enabled = true;
                meal_name_label.Enabled = true;
                price_label.Enabled = true;
                insert_btn.Enabled = true;
                show_price.Enabled = true;
                meal_type.Enabled = true;
                type_txt.Enabled = true;

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select meal_name from meal";
                cmd2.CommandType = CommandType.Text;
                OracleDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    meal_name_cmb.Items.Add(dr[0]);
                }
            }
        }

        private void type_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void meal_type_Click(object sender, EventArgs e)
        {

        }

        private void price_label_Click(object sender, EventArgs e)
        {

        }

        private void meal_name_label_Click(object sender, EventArgs e)
        {

        }

        private void meal_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void meal_name_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //generate new id       cmd.txt
            int max_id, new_id;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMealID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                max_id = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                new_id = max_id + 1;
            }
            catch
            {
                new_id = 1;
            }

            //call insert       proc
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn; ; ;
            cmd2.CommandText = "insert into meal (meal_id, meal_name, meal_price,  meal_type)   values(:new_id , :name , :price,:type)";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("id", new_id);
            cmd2.Parameters.Add("name", meal_name_cmb.Text);
            cmd2.Parameters.Add("price", meal_price.Text);
            cmd2.Parameters.Add("type", type_txt.Text);

            int r = cmd2.ExecuteNonQuery();
            if (r != -1)
            {
                meal_name_cmb.Items.Add(meal_name_cmb.Text);
                MessageBox.Show("meal added");
                meal_name_cmb.Text = "";
                meal_price.Text = "";
                type_txt.Text = "";
            }

        }

        private void show_price_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "show_meal_price";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", meal_name_cmb.SelectedItem.ToString());
            cmd.Parameters.Add("price", OracleDbType.Int32, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            meal_price.Text = (cmd.Parameters["price"].Value.ToString());

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "show_meal_type";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("name", meal_name_cmb.SelectedItem.ToString());
            cmd2.Parameters.Add("type", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {

                type_txt.Text = dr[0].ToString();
                dr.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_admin_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_admin_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
