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
    public partial class frmmuontra2 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        DataTable comdt = new DataTable();
        int i;
        bool addnewflag;
        public frmmuontra2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTC.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("MaTC='{0}'", txtMaTC.Text);
            }
        }

        private void txtTenTC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTC.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenTC LIKE '%{0}%'", txtTenTC.Text);

            }
        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTacGia.Text))
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GrdData.DataSource as DataTable).DefaultView.RowFilter = string.Format("TacGiaTC LIKE '%{0}%'", txtTacGia.Text);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                i = GrdData.CurrentRow.Index;
                sql = "delete from QLTapChi where MaTC = '" + GrdData.Rows[i].Cells["MaTC"].Value.ToString() + "'";

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

        private void btnnext_Click(object sender, EventArgs e)
        {
            i = GrdData.CurrentRow.Index;
            if (i > 0)
            {
                GrdData.CurrentCell = GrdData[0, i + 1];
                //NapCT();
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount - 1];

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

        private void frmmuontra2_Load(object sender, EventArgs e)
        {
            constr = " Data Source = DESKTOP-DTNCD1C\\SQLEXPRESS; Initial Catalog = QLSach; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * From QLTapChi";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //cmt
            GrdData.DataSource = dt;
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            GrdData.Refresh();
        }
    }
}
