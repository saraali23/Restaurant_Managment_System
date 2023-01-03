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
    public partial class OrderType : Form
    {
        StaffClass staf;
        public OrderType(StaffClass st)
        {
            staf = st;
            InitializeComponent();
        }

        private void normalorder_btn_Click(object sender, EventArgs e)
        {
            using (var t = new Order("Normal","",staf))
            {
                t.StartPosition = FormStartPosition.Manual;
                t.Location = this.Location;
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void deliveryorder_btn_Click(object sender, EventArgs e)
        {
            using (var t = new Customer_Info(staf))
            {
                t.StartPosition = FormStartPosition.Manual;
                t.Location = this.Location;
                this.Hide();
                t.ShowDialog();
            }
            this.Show();


        }

        private void onlineorder_btn_Click(object sender, EventArgs e)
        {
            using (var t = new OnlineOrder(staf))
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
