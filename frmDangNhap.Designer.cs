
namespace QuanLyBanHang1
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.lbltentaikhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btttDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.piclogoshop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoshop)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltentaikhoan
            // 
            this.lbltentaikhoan.AutoSize = true;
            this.lbltentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentaikhoan.ForeColor = System.Drawing.Color.Gold;
            this.lbltentaikhoan.Location = new System.Drawing.Point(23, 247);
            this.lbltentaikhoan.Name = "lbltentaikhoan";
            this.lbltentaikhoan.Size = new System.Drawing.Size(91, 16);
            this.lbltentaikhoan.TabIndex = 1;
            this.lbltentaikhoan.Text = "Tên tài khoản:";
            this.lbltentaikhoan.Click += new System.EventHandler(this.lbltentaikhoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(24, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(121, 243);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(173, 20);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(121, 287);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(173, 20);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // btttDangNhap
            // 
            this.btttDangNhap.Location = new System.Drawing.Point(69, 343);
            this.btttDangNhap.Name = "btttDangNhap";
            this.btttDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btttDangNhap.TabIndex = 5;
            this.btttDangNhap.Text = "Đăng nhập";
            this.btttDangNhap.UseVisualStyleBackColor = true;
            this.btttDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(199, 343);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // piclogoshop
            // 
            this.piclogoshop.Image = ((System.Drawing.Image)(resources.GetObject("piclogoshop.Image")));
            this.piclogoshop.Location = new System.Drawing.Point(42, 12);
            this.piclogoshop.Name = "piclogoshop";
            this.piclogoshop.Size = new System.Drawing.Size(252, 202);
            this.piclogoshop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogoshop.TabIndex = 7;
            this.piclogoshop.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(346, 408);
            this.Controls.Add(this.piclogoshop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btttDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltentaikhoan);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclogoshop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltentaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btttDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox piclogoshop;
    }
}