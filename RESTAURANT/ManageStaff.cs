using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT
{
    public partial class ManageStaff : Form
    {
        int AddOrRemov;
        AdminClass admin;
        StaffClass st;
        public ManageStaff(AdminClass adm)
        {
            AddOrRemov = 0;
            admin = adm;
            InitializeComponent();
            
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            //hide  unneded elemnts
            staff_name_label.Hide();
            staffname_box.Hide();
            staffpass_box.Hide();
            staffpass_label.Hide();
            dataGridView1.Hide();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            
            if (AddOrRemov == 0)//add staff
            {
                if (staffname_box.Text != "" && staffpass_box.Text!="")
                {
                    string name = staffname_box.Text.Trim();
                    int pass = int.Parse(staffpass_box.Text.Trim());
                    st = new StaffClass(name, pass);
                    if (admin.AddStaff(st) != -1)
                    {
                        System.Windows.Forms.MessageBox.Show("Staff Added sucessfuly!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Staff Already Exists!");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please Enter Valid Name and Password!");
                }
            }
            else if(AddOrRemov == 1)//remove staff
            {
                int Staffid =int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string Staffname= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                int Staffpass = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                st = new StaffClass(Staffid, Staffname, Staffpass);
                if (admin.RemoveStaff(st) == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Staff Removed sucessfuly!");

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("There seems to be a problem!");


                }
            }
        }

        private void AddSatffBtn_Click(object sender, EventArgs e)
        {
            AddOrRemov = 0;//add staff is clicked
            staff_name_label.Show();
            staffname_box.Show();
            staffpass_box.Show();
            staffpass_label.Show();
            dataGridView1.Hide();
        }

        private void RemoveStaffBtn_Click(object sender, EventArgs e)
        {
            AddOrRemov = 1;//remove staff is clicked
            staff_name_label.Hide();
            staffname_box.Hide();
            staffpass_box.Hide();
            staffpass_label.Hide();
            dataGridView1.Show();
          
            List<StaffClass> staf=new List<StaffClass>();
            int ch=admin.GetAllStaff(staf);
            dataGridView1.Rows.Clear();
            for(int i = 0; i < staf.Count(); i++)
            {
                DataGridViewRow r = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                r.Cells[0].Value =staf[i].Id;
                r.Cells[1].Value = staf[i].Name;
                r.Cells[2].Value = staf[i].Password;
                dataGridView1.Rows.Add(r);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffname_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar);
        }

        private void staffpass_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
