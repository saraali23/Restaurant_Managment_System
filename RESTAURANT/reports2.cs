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
    public partial class reports2 : Form
    {
        public reports2()
        {
            InitializeComponent();
        }

        private void reports2_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Important_Customers cr = new Important_Customers();
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
