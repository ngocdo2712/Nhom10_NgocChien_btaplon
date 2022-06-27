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
    public partial class frmmainchinh : Form
    {
        public frmmainchinh()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Form m = new Formchinh();
            //m.Hide();
            frmdangnhap f = new frmdangnhap();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sáchGiáoTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLsach form = new frmQLsach();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();

        }

        private void sáchTạpChíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmuontra2 form = new frmmuontra2();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void thôngTinĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLdocgia form = new frmQLdocgia();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLtacgia form = new frmQLtacgia();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void quảnLýMượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmuontra form = new frmmuontra ();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem form = new frmTimKiem ();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Show();
        }

        private void frmmainchinh_Load(object sender, EventArgs e)
        {

        }
    }
}
