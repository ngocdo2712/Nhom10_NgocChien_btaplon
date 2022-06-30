using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btaplon
{
    public partial class rptQLGiaoTrinh : Form
    {
        public rptQLGiaoTrinh(QLSachReport rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;

        }

        private void rptQLGiaoTrinh_Load(object sender, EventArgs e)
        {

        }
    }
}
