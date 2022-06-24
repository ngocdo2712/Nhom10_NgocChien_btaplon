using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace btaplon
{
    public partial class frmQLsach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        DataTable comdt = new DataTable();
        int i;

        public frmQLsach()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTacGia.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TacGia LIKE '{0}%'", txtTacGia.Text);

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTacGia.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nganh LIKE '{0}%'", txtNganh.Text);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("MaSach='{0}'", txtMaSach.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenSach LIKE '{0}%'", txtTenSach.Text);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                NapCT();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //if (string.IsNullOrEmpty(txtMaSach.Text))
            //{
            //    (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            //}
            //else
            //{
            //    (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("MaSach='{0}'", txtMaSach.Text);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu",
            //MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ////if (this.GrdData.SelectedRows.Count > 0)
            ////{
            ////    GrdData.Rows.RemoveAt(this.GrdData.SelectedRows[0].Index);
            ////}
            ////string mahang;
            ////if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu",
            ////MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            ////{
            ////    int i = Convert.ToInt16(GrdData.CurrentRow.Index.ToString());
            ////    mahang = GrdData.Rows[i].Cells[1].Value.ToString();
            ////    sql = "Delete from QLSach where MaSach='" + mahang + "'";
            ////    cls.DoSQL(sql); dt.Clear();
            ////    sql = "Select * From QLSach";
            ////    da = new SqlDataAdapter(sql, conn);
            ////    da.Fill(dt); GrdData.DataSource = dt;
            //}
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmQLsach_Load(object sender, EventArgs e)
        {
            constr = " Data Source = DESKTOP-DTNCD1C\\SQLEXPRESS; Initial Catalog = QLSach; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select MaSach, TenSach, TacGia, Nganh From QLSach";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //cmt
            GrdData.DataSource = dt;
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            GrdData.Refresh();
        }
        private void NapCT()
        {
            int i = GrdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMaSach.Text = GrdData.Rows[i].Cells["MaSach"].Value.ToString();
            txtTenSach.Text = GrdData.Rows[i].Cells["TenSach"].Value.ToString();
            txtTacGia.Text = GrdData.Rows[i].Cells["TacGia"].Value.ToString();
            txtNganh.Text = GrdData.Rows[i].Cells["Nganh"].Value.ToString();
        }

        
    }
}
