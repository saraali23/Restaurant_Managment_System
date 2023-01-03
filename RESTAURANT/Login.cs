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
using System.Data;

namespace RESTAURANT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            //Validate Admin
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);   
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "check_admin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", username_box.Text);
            cmd.Parameters.Add("pass", pass_box.Text);
            cmd.Parameters.Add("check", SqlDbType.Int).Direction = ParameterDirection.Output;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            int check = Convert.ToInt32(cmd.Parameters["check"].Value.ToString());   
            if(check==1) //if valid
            {
               
                AdminClass Admin = new AdminClass();
                
          
                using (var t = new Admin(Admin))
                {
                    t.StartPosition = FormStartPosition.Manual;
                    t.Location = this.Location;
                    this.Hide();
                    t.ShowDialog();
                }
            }
            else//else check if staff
            {
              
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "valid_staff";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name", username_box.Text);
                cmd.Parameters.Add("@password", int.Parse(pass_box.Text.Trim())); ;
                cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
                if (check == -1) //not staff or admin
                {
                    System.Windows.Forms.MessageBox.Show("Wrong Username Or Password!");
                }
                else //valid staff
                {
                    StaffClass staf = new StaffClass(check, username_box.Text, int.Parse(pass_box.Text.Trim()));
                   
                    using (var t = new Staff(staf))
                    {
                        t.StartPosition = FormStartPosition.Manual;
                        t.Location = this.Location;
                        this.Hide();
                        t.ShowDialog();
                    }
                }

            }
           

           
            this.Show();
            
           
        }

        

      
    }
}
