
namespace QuanLyBanHang1
{
    partial class frmDMChatLieu
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
            this.tblNhanVienTableAdapter = new QuanLyBanHang1.QuanlybanhangDataSetTableAdapters.tblNhanVienTableAdapter();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlybanhangDataSet = new QuanLyBanHang1.QuanlybanhangDataSet();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quanlybanhangDataSet1 = new QuanLyBanHang1.QuanlybanhangDataSet1();
            this.tblChatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblChatLieuTableAdapter = new QuanLyBanHang1.QuanlybanhangDataSet1TableAdapters.tblChatLieuTableAdapter();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.maChatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlybanhangDataSet6 = new QuanLyBanHang1.QuanlybanhangDataSet6();
            this.tblChatLieuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblChatLieuTableAdapter1 = new QuanLyBanHang1.QuanlybanhangDataSet6TableAdapters.tblChatLieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChatLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChatLieuBindingSource1)).BeginInit();
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
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(136, 86);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(221, 20);
            this.txtTenChatLieu.TabIndex = 25;
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(136, 51);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(221, 20);
            this.txtMaChatLieu.TabIndex = 24;
            this.txtMaChatLieu.TextChanged += new System.EventHandler(this.txtMaChatLieu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên Chất Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Chất Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(317, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // quanlybanhangDataSet1
            // 
            this.quanlybanhangDataSet1.DataSetName = "QuanlybanhangDataSet1";
            this.quanlybanhangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChatLieuBindingSource
            // 
            this.tblChatLieuBindingSource.DataMember = "tblChatLieu";
            this.tblChatLieuBindingSource.DataSource = this.quanlybanhangDataSet1;
            // 
            // tblChatLieuTableAdapter
            // 
            this.tblChatLieuTableAdapter.ClearBeforeFill = true;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Location = new System.Drawing.Point(654, 402);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 23);
            this.btnDong.TabIndex = 48;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoQua.Location = new System.Drawing.Point(552, 402);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(81, 23);
            this.btnBoQua.TabIndex = 47;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(428, 402);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 46;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(291, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 23);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(154, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 23);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(25, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 23);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.AutoGenerateColumns = false;
            this.dgvChatLieu.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChatLieuDataGridViewTextBoxColumn,
            this.tenChatLieuDataGridViewTextBoxColumn});
            this.dgvChatLieu.DataSource = this.tblChatLieuBindingSource1;
            this.dgvChatLieu.Location = new System.Drawing.Point(-6, 126);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.Size = new System.Drawing.Size(807, 265);
            this.dgvChatLieu.TabIndex = 49;
            this.dgvChatLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChatLieu_Click);
            // 
            // maChatLieuDataGridViewTextBoxColumn
            // 
            this.maChatLieuDataGridViewTextBoxColumn.DataPropertyName = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.HeaderText = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.Name = "maChatLieuDataGridViewTextBoxColumn";
            // 
            // tenChatLieuDataGridViewTextBoxColumn
            // 
            this.tenChatLieuDataGridViewTextBoxColumn.DataPropertyName = "TenChatLieu";
            this.tenChatLieuDataGridViewTextBoxColumn.HeaderText = "TenChatLieu";
            this.tenChatLieuDataGridViewTextBoxColumn.Name = "tenChatLieuDataGridViewTextBoxColumn";
            // 
            // quanlybanhangDataSet6
            // 
            this.quanlybanhangDataSet6.DataSetName = "QuanlybanhangDataSet6";
            this.quanlybanhangDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChatLieuBindingSource1
            // 
            this.tblChatLieuBindingSource1.DataMember = "tblChatLieu";
            this.tblChatLieuBindingSource1.DataSource = this.quanlybanhangDataSet6;
            // 
            // tblChatLieuTableAdapter1
            // 
            this.tblChatLieuTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDMChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChatLieu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenChatLieu);
            this.Controls.Add(this.txtMaChatLieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDMChatLieu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Mục Chất Liệu";
            this.Load += new System.EventHandler(this.frmDMChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChatLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChatLieuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuanlybanhangDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QuanlybanhangDataSet1 quanlybanhangDataSet1;
        private System.Windows.Forms.BindingSource tblChatLieuBindingSource;
        private QuanlybanhangDataSet1TableAdapters.tblChatLieuTableAdapter tblChatLieuTableAdapter;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChatLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChatLieuDataGridViewTextBoxColumn;
        private QuanlybanhangDataSet6 quanlybanhangDataSet6;
        private System.Windows.Forms.BindingSource tblChatLieuBindingSource1;
        private QuanlybanhangDataSet6TableAdapters.tblChatLieuTableAdapter tblChatLieuTableAdapter1;
    }
}