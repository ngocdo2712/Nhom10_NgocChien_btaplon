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
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        string user = "admin";
        string pass = "123";

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txttaikhoan.Focus();


            }
            else if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtmatkhau.Focus();
            }
            else if (user.Equals(txttaikhoan.Text) && pass.Equals(txtmatkhau.Text))
            {

                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                frmmainchinh f = new frmmainchinh();
                f.Show();


            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai"); }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmdangky1 dangky = new Frmdangky1();
            dangky.ShowDialog();
        }

        private void linkLabel_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmquenmatkhau quenmatkhau = new frmquenmatkhau();
            quenmatkhau.ShowDialog();
        }
    }
}
