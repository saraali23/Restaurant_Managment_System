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
    public partial class Admin : Form
    {
        AdminClass admin;
        public Admin(AdminClass ad)
        {
            admin = ad;
            InitializeComponent();
        }

        private void managemeals_btn_Click(object sender, EventArgs e)
        {
            using (var t = new ManageMeals(admin))
            {
                t.StartPosition = FormStartPosition.Manual;
                t.Location = this.Location;
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void managestaff_btn_Click(object sender, EventArgs e)
        {
            using (var t = new ManageStaff(admin))
            {
                t.StartPosition = FormStartPosition.Manual;
                t.Location = this.Location;
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
