
namespace btaplon
{
    partial class frmQLtacgia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprv = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.GrdData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.comTruong = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clMaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(228, 187);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamSinh.Multiline = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(240, 30);
            this.txtNamSinh.TabIndex = 7;
            this.txtNamSinh.TextChanged += new System.EventHandler(this.txtNamSinh_TextChanged);
            // 
            // txtTenTG
            // 
            this.txtTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(228, 135);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTG.Multiline = true;
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(240, 30);
            this.txtTenTG.TabIndex = 6;
            this.txtTenTG.TextChanged += new System.EventHandler(this.txtTenTG_TextChanged);
            // 
            // txtMaTG
            // 
            this.txtMaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(228, 83);
            this.txtMaTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTG.Multiline = true;
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(240, 30);
            this.txtMaTG.TabIndex = 5;
            this.txtMaTG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tác Giả";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnlast);
            this.panel2.Controls.Add(this.btnprv);
            this.panel2.Controls.Add(this.btnnext);
            this.panel2.Controls.Add(this.btnfirst);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 288);
            this.panel2.TabIndex = 14;
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(1064, 214);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 27);
            this.btnlast.TabIndex = 31;
            this.btnlast.Text = "Cuối";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprv
            // 
            this.btnprv.Location = new System.Drawing.Point(868, 212);
            this.btnprv.Name = "btnprv";
            this.btnprv.Size = new System.Drawing.Size(75, 27);
            this.btnprv.TabIndex = 28;
            this.btnprv.Text = "Trước";
            this.btnprv.UseVisualStyleBackColor = true;
            this.btnprv.Click += new System.EventHandler(this.btnprv_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(966, 214);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 27);
            this.btnnext.TabIndex = 30;
            this.btnnext.Text = "Sau";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(770, 212);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 27);
            this.btnfirst.TabIndex = 29;
            this.btnfirst.Text = "Đầu";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // GrdData
            // 
            this.GrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaTG,
            this.clTenTG,
            this.clNamSinh});
            this.GrdData.Location = new System.Drawing.Point(4, 342);
            this.GrdData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrdData.Name = "GrdData";
            this.GrdData.RowHeadersWidth = 51;
            this.GrdData.RowTemplate.Height = 24;
            this.GrdData.Size = new System.Drawing.Size(1184, 280);
            this.GrdData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tác Giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtNamSinh);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Controls.Add(this.txtMaTG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1184, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tác Giả";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSave.Location = new System.Drawing.Point(1005, 175);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 41);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(696, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(844, 175);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Xóa ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Blue;
            this.btnadd.Location = new System.Drawing.Point(548, 175);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(127, 43);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 261);
            this.panel1.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.AliceBlue;
            this.button5.Location = new System.Drawing.Point(855, 283);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 40);
            this.button5.TabIndex = 26;
            this.button5.Text = "Xuất Báo Cáo";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(701, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "Hủy Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comGT
            // 
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(356, 287);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(113, 28);
            this.comGT.TabIndex = 24;
            // 
            // comTruong
            // 
            this.comTruong.FormattingEnabled = true;
            this.comTruong.Items.AddRange(new object[] {
            "MaSach",
            "TenSach",
            "TacGia",
            "Nganh"});
            this.comTruong.Location = new System.Drawing.Point(229, 287);
            this.comTruong.Name = "comTruong";
            this.comTruong.Size = new System.Drawing.Size(121, 28);
            this.comTruong.TabIndex = 23;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btntimkiem.Location = new System.Drawing.Point(553, 283);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(127, 40);
            this.btntimkiem.TabIndex = 21;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tìm Kiếm";
            // 
            // clMaTG
            // 
            this.clMaTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaTG.DataPropertyName = "MaTG";
            this.clMaTG.HeaderText = "Mã Tác Giả";
            this.clMaTG.MinimumWidth = 6;
            this.clMaTG.Name = "clMaTG";
            // 
            // clTenTG
            // 
            this.clTenTG.DataPropertyName = "TenTG";
            this.clTenTG.HeaderText = "Tên Tác Giả";
            this.clTenTG.MinimumWidth = 6;
            this.clTenTG.Name = "clTenTG";
            this.clTenTG.Width = 125;
            // 
            // clNamSinh
            // 
            this.clNamSinh.DataPropertyName = "NamSinh";
            this.clNamSinh.HeaderText = "Năm Sinh";
            this.clNamSinh.MinimumWidth = 6;
            this.clNamSinh.Name = "clNamSinh";
            this.clNamSinh.Width = 125;
            // 
            // frmQLtacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 704);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.comTruong);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GrdData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQLtacgia";
            this.Text = "frmQLtacgia";
            this.Load += new System.EventHandler(this.frmQLtacgia_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GrdData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprv;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox comTruong;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamSinh;
    }
}