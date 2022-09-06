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
    public partial class Role_Rep : Form
    {
        public Role_Rep()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ROLE cr = new ROLE();
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
