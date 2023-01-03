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
    public partial class Staff : Form
    {
        StaffClass staf;
        public Staff(StaffClass s)
        {
            staf = s;
            InitializeComponent();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            using (var t = new OrderType(staf))
            {
                t.StartPosition = FormStartPosition.Manual;
                t.Location = this.Location;
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var t = new ViewOrderBy(staf))
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
