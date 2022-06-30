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
    public partial class frmQLtacgia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        DataTable comdt = new DataTable();
        int i;
        bool addnewflag;
        DataTable dtBC = new DataTable();

        public frmQLtacgia()
        {
            InitializeComponent();
        }

        private void frmQLtacgia_Load(object sender, EventArgs e)
        {
            constr = " Data Source = DESKTOP-DTNCD1C\\SQLEXPRESS; Initial Catalog = QLSach; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * From QLGiaoTrinh order by MaSach";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //dữ liệu từ da đổ vào bảng dt
            GrdData.DataSource = dt;
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            sql = "Select Distinct manhom from QLGiaoTrinh";
            da = new SqlDataAdapter(sql, conn);
            //da.Fill(dtNhom);
            //txtMaSach.DataSource = dtNhom;
            //txtMaSach.DisplayMember = "MaSach";
            NapCT();
            conn.Close();


        }
        private void NapCT()
        {
            i = GrdData.CurrentRow.Index; //i sẽ chứa số thứ tự của dòng hiện thời trong ô lưới
            txtMaTG.Text = GrdData.Rows[i].Cells["clMaTG"].Value.ToString();       // cách lấy gt dòng i, cột mã nhóm 
            txtTenTG.Text = GrdData.Rows[i].Cells["clTenTG"].Value.ToString();
            txtNamSinh.Text = GrdData.Rows[i].Cells["clNamSinh"].Value.ToString();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, 0]; //[cot, dong]
            NapCT();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            int i = Convert.ToInt16(GrdData.CurrentRow.Index.ToString());
            if (i < GrdData.RowCount - 1)
            {
                GrdData.CurrentCell = GrdData[0, i + 1];
                NapCT();

            }
            

        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount - 1];
            NapCT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                i = GrdData.CurrentRow.Index;
                sql = "delete from QLTacGia where MaTG = '" + GrdData.Rows[i].Cells["MaTG"].Value.ToString() + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                GrdData.Rows.RemoveAt(i); //////xóa dòng hiện tại (dòng i)
                                          //  NapCT();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTG.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("MaTG='{0}'", txtMaTG.Text);
            }
        }

        private void txtTenTG_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTG.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenTG LIKE '%{0}%'", txtTenTG.Text);

            }
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamSinh.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("NamSinh LIKE '%{0}%'", txtNamSinh.Text);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount - 1];
            // NapCT();
            MessageBox.Show("Hãy nhập nội dung của bản ghi mới, kết thúc với nút Lưu");
            //ấn enter xuống dòng -> mở cửa sổ property của form -> key preview -> true nếu muốn click phím enter thì nhảy xuống ô tiếp theo
            // key down trong event
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtNamSinh.Text = "";
            txtMaTG.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "insert into QLGiaoTrinh values (@MaTG, @TenTG, @NamSinh)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("MaTG", txtMaTG.Text);
            cmd.Parameters.AddWithValue("TenTG", txtTenTG.Text);
            cmd.Parameters.AddWithValue("NamSinh", txtNamSinh.Text);
            cmd.ExecuteNonQuery();
            sql = "Select * From QLTacGia";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            GrdData.DataSource = dt;
            //tạo grid table->tạo column->sửa name, text và name = data property name, sửa align...
            GrdData.Refresh();
            MessageBox.Show("Dữ liệu mới đã được Lưu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            i = GrdData.CurrentRow.Index;
            if (i > 0)
            {
                GrdData.CurrentCell = GrdData[0, i - 1];
                NapCT();
            }

        }
    }
}
