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
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        public void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            Important_Customers cr = new Important_Customers();
            crystalReportViewer2.ReportSource = cr;
        }

        private void crystalReportViewer2_Click(object sender, EventArgs e)
        {

        }
    }
}
