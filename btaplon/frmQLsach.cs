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
        bool addnewflag = false;
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
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TacGia LIKE '%{0}%'", txtTacGia.Text);

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNganh.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nganh LIKE '%{0}%'", txtNganh.Text);

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
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount - 1];
            //NapCT();
            //ấn enter xuống dòng -> mở cửa sổ property của form -> key preview -> true nếu muốn click phím enter thì nhảy xuống ô tiếp theo
            // key down trong event
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNganh.Text = "";
            //addnewflag = true;
            //GrdData.Rows.Add(txtMaSach.Text, txtTenSach.Text, txtTacGia.Text, txtNganh.Text);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO QLSach(MaSach, TenSach, TacGia, Nganh) values ('" + this.txtMaSach.Text + "','" + this.txtTenSach.Text + "','" + this.txtTacGia.Text + "','" + this.txtNganh.Text + "');";
            cmd.Parameters.Add("@MaSach", txtMaSach.Text);
            cmd.Parameters.Add("@TenSach", txtTenSach.Text);
            cmd.Parameters.Add("@TacGia", txtTacGia.Text);
            cmd.Parameters.Add("@Nganh", txtNganh.Text);
            cmd.ExecuteNonQuery();


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
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenSach LIKE '%{0}%'", txtTenSach.Text);

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
            
                //NapCT();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                i = GrdData.CurrentRow.Index;
                sql = "delete from QLSach where MaSach = '" + GrdData.Rows[i].Cells["MaSach"].Value.ToString() + "'";

                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                GrdData.Rows.RemoveAt(i); //////xóa dòng hiện tại (dòng i)
              //  NapCT();
            }
            
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
           
            //int a = GrdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            //txtMaSach.Text = GrdData.Rows[a].Cells["MaSach"].Value.ToString();
            //txtTenSach.Text = GrdData.Rows[a].Cells["TenSach"].Value.ToString();
            //txtTacGia.Text = GrdData.Rows[a].Cells["TacGia"].Value.ToString();
            //txtNganh.Text = GrdData.Rows[a].Cells["Nganh"].Value.ToString();
        }

        
    }
}
