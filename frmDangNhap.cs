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

namespace QuanLyBanHang1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // hiện thị thông báo ra màn hình
            MessageBox.Show("Hẹn gặp lại Bạn");
            // tắt form hiện tại
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\QuanLyBanHang1\Quanlybanhang.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "Select  *from tblDangNhap where Tentaikhoan= '"+tk+"' and Matkhau='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain f = new frmMain();
                    this.Hide();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại tên tài khoản hoặc mật khẩu");
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void lbltentaikhoan_Click(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
