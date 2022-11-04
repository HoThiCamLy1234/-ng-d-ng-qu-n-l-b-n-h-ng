using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmChatLieu = new frmDMChatLieu(); //Khởi tạo đối tượng
            frmChatLieu.ShowDialog(); //Hiển thị
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frmNhanVien = new frmDMNhanVien(); //Khởi tạo đối tượng
            frmNhanVien.ShowDialog(); //Hiển thị
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frmKhachHang = new frmDMKhachHang(); //Khởi tạo đối tượng
            frmKhachHang.ShowDialog(); //Hiển thị
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang frmHang = new frmDMHang(); //Khởi tạo đối tượng
            frmHang.ShowDialog(); //Hiển thị
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan frmTimHDBan = new frmTimHDBan(); //Khởi tạo đối tượng
            frmTimHDBan.ShowDialog(); //Hiển thị
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan(); //Khởi tạo đối tượng
            frmHoaDonBan.ShowDialog(); //Hiển thị
        }

        private void mnuHienTroGiup_Click(object sender, EventArgs e)
        {
            frmTrogiup frmTrogiup = new frmTrogiup(); //Khởi tạo đối tượng
            frmTrogiup.ShowDialog(); //Hiển thị
        }
    }
}
