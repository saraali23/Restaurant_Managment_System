using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace RESTAURANT
{
    public partial class Form1 : Form
    {
        reports2 r = new reports2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var t = new Admin())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var t = new EDIT_Customer_Info())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var t = new reports2())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new Admin())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new USER_FORM())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void updateUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new EDIT_Customer_Info())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void rEPORT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var t = new reports2())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rEPORT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var t = new Role_Rep())
            {
                this.Hide();
                t.ShowDialog();
            }
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
