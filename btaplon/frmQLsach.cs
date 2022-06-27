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
        bool addnewflag;
        
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
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("TacGia LIKE '%{0}%'", txtTacGia.Text);

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNganh.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nganh LIKE '%{0}%'", txtNganh.Text);

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
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.RowCount - 1];
           // NapCT();
            MessageBox.Show("Hãy nhập nội dung của bản ghi mới, kết thúc với nút Lưu");
            //ấn enter xuống dòng -> mở cửa sổ property của form -> key preview -> true nếu muốn click phím enter thì nhảy xuống ô tiếp theo
            // key down trong event
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNganh.Text = "";
            txtMaSach.Focus();
            addnewflag = true;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("MaSach='{0}'", txtMaSach.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenSach LIKE '%{0}%'", txtTenSach.Text);

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
            
               // NapCT();
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
                
                sql = "delete from QLGiaoTrinh where MaSach = '" + txtMaSach.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                i = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(i); //////xóa dòng hiện tại (dòng i)
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
            sql = "Select * From QLGiaoTrinh";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //cmt

            dataGridView1.DataSource = dt;
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            dataGridView1.Refresh();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa nội dung của bản ghi hiện thời, kết thúc bằng nút Lưu");
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0, 0]; //[cot, dong]
            //NapCT();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.RowCount - 1];
            //NapCT();
        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;
            if (i > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[0, i - 1];
               // NapCT();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dataGridView1.CurrentRow.Index.ToString());
            if (i < dataGridView1.RowCount - 1)
            {
                dataGridView1.CurrentCell = dataGridView1[0, i + 1];
                // NapCT();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                addnewflag = false;

                //string sqlINSERT = "insert into QLGiaoTrinh values (@MaSach, @TenSach, @TacGia, @Nganh)";
                //SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                //cmd.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                //cmd.Parameters.AddWithValue("TenSach", txtTenSach.Text);
                //cmd.Parameters.AddWithValue("TacGia", txtTacGia.Text);
                //cmd.Parameters.AddWithValue("Nganh", txtNganh.Text);
                // cmd.ExecuteNonQuery();
                //sql = "Select MaSach, TenSach, TacGia, Nganh From QLGiaoTrinh";
                //da = new SqlDataAdapter(sql, conn);
                //dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;
                ////tạo grid table->tạo column->sửa name, text và name = data property name, sửa align...
                //dataGridView1.Refresh();
                //MessageBox.Show("Dữ liệu mới đã được Lưu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //conn.Close();
                //sql = "Insert into QLGiaoTrinh (MaSach, TenSach, TacGia,Nganh)" +  values ('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + txtTacGia.Text
                //    + "',N'" + txtNganh.Text + "')";

                string sqlINSERT = "insert into QLGiaoTrinh values (@MaSach, @TenSach, @TacGia, @Nganh)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                cmd.Parameters.AddWithValue("TenSach", txtTenSach.Text);
                cmd.Parameters.AddWithValue("TacGia", txtTacGia.Text);
                cmd.Parameters.AddWithValue("Nganh", txtNganh.Text);
                cmd.ExecuteNonQuery();
                sql = "Select MaSach, TenSach, TacGia, Nganh From QLGiaoTrinh";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //tạo grid table->tạo column->sửa name, text và name = data property name, sửa align...
                dataGridView1.Refresh();
                MessageBox.Show("Dữ liệu mới đã được Lưu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                ////cmd.Connection = conn;
                ////cmd.CommandText = sql;
                ////cmd.ExecuteNonQuery();
                ////MessageBox.Show("Đã cập nhật thêm mới thành công");

            }
            else
            {
                for (i = 0; i <= dataGridView1.RowCount - 2; i++)
                {
                    string sqlEdit = "update QLGiaoTrinh set MaSach=@MaSach, TenSach=@TenSach, TacGia=@TacGia, Nganh=@Nganh)";
                    SqlCommand cmd = new SqlCommand(sqlEdit, conn);
                    cmd.Parameters.AddWithValue("MaSach", txtMaSach.Text);
                    cmd.Parameters.AddWithValue("TenSach", txtTenSach.Text);
                    cmd.Parameters.AddWithValue("TacGia", txtTacGia.Text);
                    cmd.Parameters.AddWithValue("Nganh", txtNganh.Text);
                    cmd.ExecuteNonQuery();
                    sql = "Select MaSach, TenSach, TacGia, Nganh From QLGiaoTrinh";
                    da = new SqlDataAdapter(sql, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //tạo grid table->tạo column->sửa name, text và name = data property name, sửa align...
                    dataGridView1.Refresh();
                    conn.Close();

                    //txtMaSach.Text = dataGridView1.Rows[i].Cells["MaSach2"].Value.ToString();
                    //txtTenSach.Text = dataGridView1.Rows[i].Cells["TenSach2"].Value.ToString();
                    //txtTacGia.Text = dataGridView1.Rows[i].Cells["TacGia2"].Value.ToString();
                    //txtNganh.Text = dataGridView1.Rows[i].Cells["Nganh2"].Value.ToString();

                    //string sqlEdit = "update QLSach2 SET TenSach=@TenSach, TacGia=@TacGia, Nganh=@Nganh where MaSach=@MaSach";
                    //cmd = new SqlCommand(sql, conn);
                    //cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật sửa đổi thành công trên toàn ô lưới");
            }

        }


    }

        //private void NapCT()
        //{

        //    //int i = dataGridView1.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
        //    //txtMaSach.Text = dataGridView1.Rows[i].Cells["MaSach"].Value.ToString();
        //    //txtTenSach.Text = dataGridView1.Rows[i].Cells["TenSach"].Value.ToString();
        //    //txtTacGia.Text = dataGridView1.Rows[i].Cells["TacGia"].Value.ToString();
        //    //txtNganh.Text = dataGridView1.Rows[i].Cells["Nganh"].Value.ToString();
        //}

        
    
}
