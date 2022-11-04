
namespace QuanLyBanHang1
{
    partial class frmDMHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMHang));
            this.tblNhanVienTableAdapter = new QuanLyBanHang1.QuanlybanhangDataSetTableAdapters.tblNhanVienTableAdapter();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlybanhangDataSet = new QuanLyBanHang1.QuanlybanhangDataSet();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboMaChatLieu = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlybanhangDataSet3 = new QuanLyBanHang1.QuanlybanhangDataSet3();
            this.tblHangTableAdapter = new QuanLyBanHang1.QuanlybanhangDataSet3TableAdapters.tblHangTableAdapter();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.quanlybanhangDataSet;
            // 
            // quanlybanhangDataSet
            // 
            this.quanlybanhangDataSet.DataSetName = "QuanlybanhangDataSet";
            this.quanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Location = new System.Drawing.Point(680, 452);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 23);
            this.btnDong.TabIndex = 41;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoQua.Location = new System.Drawing.Point(406, 452);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(81, 23);
            this.btnBoQua.TabIndex = 40;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(318, 452);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(227, 452);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 23);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(135, 452);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 23);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(46, 452);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(136, 86);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(159, 20);
            this.txtTenHang.TabIndex = 25;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(136, 51);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(159, 20);
            this.txtMaHang.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên Hàng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(317, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(136, 159);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(159, 20);
            this.txtSoLuong.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(35, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Số Lượng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(35, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã Chất Liệu";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(136, 231);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(159, 20);
            this.txtDonGiaBan.TabIndex = 47;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(136, 196);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(159, 20);
            this.txtDonGiaNhap.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(35, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Đơn giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(35, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Đơn giá nhập";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(493, 452);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 23);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHienThi.Location = new System.Drawing.Point(580, 452);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(82, 23);
            this.btnHienThi.TabIndex = 51;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(415, 55);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(168, 67);
            this.txtAnh.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(359, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Ghi Chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(359, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Ảnh";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpen.Location = new System.Drawing.Point(595, 55);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 23);
            this.btnOpen.TabIndex = 56;
            this.btnOpen.Text = "Mở";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboMaChatLieu
            // 
            this.cboMaChatLieu.FormattingEnabled = true;
            this.cboMaChatLieu.Location = new System.Drawing.Point(136, 123);
            this.cboMaChatLieu.Name = "cboMaChatLieu";
            this.cboMaChatLieu.Size = new System.Drawing.Size(159, 21);
            this.cboMaChatLieu.TabIndex = 57;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(415, 128);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(168, 110);
            this.txtGhiChu.TabIndex = 58;
            // 
            // dgvHang
            // 
            this.dgvHang.AutoGenerateColumns = false;
            this.dgvHang.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.maChatLieuDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaNhapDataGridViewTextBoxColumn,
            this.donGiaBanDataGridViewTextBoxColumn,
            this.anhDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvHang.DataSource = this.tblHangBindingSource;
            this.dgvHang.Location = new System.Drawing.Point(-1, 269);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.Size = new System.Drawing.Size(803, 167);
            this.dgvHang.TabIndex = 59;
            this.dgvHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHang_Click);
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            // 
            // maChatLieuDataGridViewTextBoxColumn
            // 
            this.maChatLieuDataGridViewTextBoxColumn.DataPropertyName = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.HeaderText = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.Name = "maChatLieuDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donGiaNhapDataGridViewTextBoxColumn
            // 
            this.donGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.HeaderText = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.Name = "donGiaNhapDataGridViewTextBoxColumn";
            // 
            // donGiaBanDataGridViewTextBoxColumn
            // 
            this.donGiaBanDataGridViewTextBoxColumn.DataPropertyName = "DonGiaBan";
            this.donGiaBanDataGridViewTextBoxColumn.HeaderText = "DonGiaBan";
            this.donGiaBanDataGridViewTextBoxColumn.Name = "donGiaBanDataGridViewTextBoxColumn";
            // 
            // anhDataGridViewTextBoxColumn
            // 
            this.anhDataGridViewTextBoxColumn.DataPropertyName = "Anh";
            this.anhDataGridViewTextBoxColumn.HeaderText = "Anh";
            this.anhDataGridViewTextBoxColumn.Name = "anhDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // tblHangBindingSource
            // 
            this.tblHangBindingSource.DataMember = "tblHang";
            this.tblHangBindingSource.DataSource = this.quanlybanhangDataSet3;
            // 
            // quanlybanhangDataSet3
            // 
            this.quanlybanhangDataSet3.DataSetName = "QuanlybanhangDataSet3";
            this.quanlybanhangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHangTableAdapter
            // 
            this.tblHangTableAdapter.ClearBeforeFill = true;
            // 
            // picAnh
            // 
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.Location = new System.Drawing.Point(595, 90);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(172, 148);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 60;
            this.picAnh.TabStop = false;
            // 
            // frmDMHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(794, 486);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.cboMaChatLieu);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDMHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Mục Hàng Hóa";
            this.Load += new System.EventHandler(this.frmDMHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuanlybanhangDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboMaChatLieu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgvHang;
        private QuanlybanhangDataSet3 quanlybanhangDataSet3;
        private System.Windows.Forms.BindingSource tblHangBindingSource;
        private QuanlybanhangDataSet3TableAdapters.tblHangTableAdapter tblHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChatLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picAnh;
    }
}