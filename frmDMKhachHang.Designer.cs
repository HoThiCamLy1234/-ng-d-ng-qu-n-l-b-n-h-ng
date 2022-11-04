
namespace QuanLyBanHang1
{
    partial class frmDMKhachHang
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tblNhanVienTableAdapter = new QuanLyBanHang1.QuanlybanhangDataSetTableAdapters.tblNhanVienTableAdapter();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlybanhangDataSet = new QuanLyBanHang1.QuanlybanhangDataSet();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.maKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlybanhangDataSet2 = new QuanLyBanHang1.QuanlybanhangDataSet2();
            this.tblKhachTableAdapter = new QuanLyBanHang1.QuanlybanhangDataSet2TableAdapters.tblKhachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Location = new System.Drawing.Point(684, 410);
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
            this.btnBoQua.Location = new System.Drawing.Point(582, 410);
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
            this.btnLuu.Location = new System.Drawing.Point(458, 410);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(321, 410);
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
            this.btnXoa.Location = new System.Drawing.Point(184, 410);
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
            this.btnThem.Location = new System.Drawing.Point(55, 410);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 23);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(513, 90);
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(159, 20);
            this.mtbDienThoai.TabIndex = 30;
            this.mtbDienThoai.Text = "Mask: Phone Number";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(513, 51);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(159, 20);
            this.txtDiaChi.TabIndex = 27;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(136, 86);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(159, 20);
            this.txtTenKhach.TabIndex = 26;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(136, 51);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(159, 20);
            this.txtMaKhach.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(426, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(426, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên Khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã Khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(317, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachDataGridViewTextBoxColumn,
            this.tenKhachDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn});
            this.dgvKhachHang.DataSource = this.tblKhachBindingSource;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 124);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(806, 269);
            this.dgvKhachHang.TabIndex = 42;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_Click);
            // 
            // maKhachDataGridViewTextBoxColumn
            // 
            this.maKhachDataGridViewTextBoxColumn.DataPropertyName = "MaKhach";
            this.maKhachDataGridViewTextBoxColumn.HeaderText = "MaKhach";
            this.maKhachDataGridViewTextBoxColumn.Name = "maKhachDataGridViewTextBoxColumn";
            // 
            // tenKhachDataGridViewTextBoxColumn
            // 
            this.tenKhachDataGridViewTextBoxColumn.DataPropertyName = "TenKhach";
            this.tenKhachDataGridViewTextBoxColumn.HeaderText = "TenKhach";
            this.tenKhachDataGridViewTextBoxColumn.Name = "tenKhachDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            // 
            // tblKhachBindingSource
            // 
            this.tblKhachBindingSource.DataMember = "tblKhach";
            this.tblKhachBindingSource.DataSource = this.quanlybanhangDataSet2;
            // 
            // quanlybanhangDataSet2
            // 
            this.quanlybanhangDataSet2.DataSetName = "QuanlybanhangDataSet2";
            this.quanlybanhangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKhachTableAdapter
            // 
            this.tblKhachTableAdapter.ClearBeforeFill = true;
            // 
            // frmDMKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.mtbDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDMKhachHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Muc Khach Hang";
            this.Load += new System.EventHandler(this.frmDMKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private QuanlybanhangDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private QuanlybanhangDataSet2 quanlybanhangDataSet2;
        private System.Windows.Forms.BindingSource tblKhachBindingSource;
        private QuanlybanhangDataSet2TableAdapters.tblKhachTableAdapter tblKhachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
    }
}