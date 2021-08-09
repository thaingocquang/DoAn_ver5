using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.BLL;
using DoAn_ver5.GUI;

namespace DoAn_ver5
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //MaNhanVien = BLL_TaiKhoan.Instance.GetMaNhanVien(txtTenDangNhap.Text, txtMatKhau.Text);
            //if (MaNhanVien != "")
            //{
            //    MainWorkSpace MWS = new MainWorkSpace();
            //    MWS.Show();
            //}
            DataTable TaiKhoan = BLL_TaiKhoan.Instance.GetNhanVienByUserAndPassword(txtTenDangNhap.Text, txtMatKhau.Text);
            if (TaiKhoan.Rows.Count != 0)
            {
                MainWorkSpace MWS = new MainWorkSpace();
                BLL_TaiKhoan.Instance.MaNhanVien = TaiKhoan.Rows[0]["MaNhanVien"].ToString();
                MWS.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu đăng nhập.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
