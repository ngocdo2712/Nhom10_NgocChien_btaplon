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
    public partial class frmQLdocgia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        DataTable comdt = new DataTable();
        int i;
        bool addnewflag;
        public frmQLdocgia()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txttenDG_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDG.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenDG LIKE '%{0}%'", txtTenDG.Text);
            }
        }

        private void txtSoThe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoThe.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("SoTheDG='{0}'", txtSoThe.Text);
            }
        }

        private void txtNgheNghiep_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNgheNghiep.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("NgheNghiep LIKE '%{0}%'", txtNgheNghiep.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                i = GrdData.CurrentRow.Index;
                sql = "delete from QLDocGia where SoTheDG = '" + GrdData.Rows[i].Cells["SoTheDG"].Value.ToString() + "'";

                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                GrdData.Rows.RemoveAt(i);
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, 0]; //[cot, dong]

        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            i = GrdData.CurrentRow.Index;
            if (i > 0)
            {
                GrdData.CurrentCell = GrdData[0, i - 1];
                // NapCT();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(GrdData.CurrentRow.Index.ToString());
            if (i < GrdData.RowCount - 1)
            {
                GrdData.CurrentCell = GrdData[0, i + 1];
                // NapCT();
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount - 1];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount - 1];
            // NapCT();
            MessageBox.Show("Hãy nhập nội dung của bản ghi mới, kết thúc với nút Lưu");
            //TenDG, SoTheDG, NgayCapThe, NgheNghiep 
            //ấn enter xuống dòng -> mở cửa sổ property của form -> key preview -> true nếu muốn click phím enter thì nhảy xuống ô tiếp theo
            // key down trong event
            txtTenDG.Text = "";
            txtSoThe.Text = "";
            txtNgayCapThe.Text = "";
            txtNgheNghiep.Text = "";
            txtTenDG.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "insert into QLDocGia values (@TenDG, @SoTheDG, @NgayCapThe, @NgheNghiep)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("TenDG", txtTenDG.Text);
            cmd.Parameters.AddWithValue("SoTheDG", txtSoThe.Text);
            cmd.Parameters.AddWithValue("NgayCapThe", txtNgayCapThe.Text);
            cmd.Parameters.AddWithValue("NgheNghiep", txtNgheNghiep.Text);

            cmd.ExecuteNonQuery();
            sql = "Select * From QLDocGia";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            GrdData.DataSource = dt;
            //tạo grid table->tạo column->sửa name, text và name = data property name, sửa align...
            GrdData.Refresh();
            MessageBox.Show("Dữ liệu mới đã được Lưu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void frmQLdocgia_Load(object sender, EventArgs e)
        {
            constr = " Data Source = DESKTOP-DTNCD1C\\SQLEXPRESS; Initial Catalog = QLSach; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select TenDG, SoTheDG, NgayCapThe, NgheNghiep From QLDocGia";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //cmt
            GrdData.DataSource = dt;
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            GrdData.Refresh();
        }
    }
}
