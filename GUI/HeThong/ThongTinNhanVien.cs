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

namespace DoAn_ver5.GUI.HeThong
{
    public partial class ThongTinNhanVien : Form
    {
        string MaNhanVien;
        string DiaChi, Email, SDT;
        public ThongTinNhanVien(string MaNhanVien)
        {
            InitializeComponent();
            this.MaNhanVien = MaNhanVien;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            DataTable row = BLL_NhanVien.Instance.GetNhanVienByMaNhanVien(MaNhanVien);
            lblTenNhanVien.Text = row.Rows[0]["HoVaTen"].ToString();
            lblMaNhanVien.Text = row.Rows[0]["MaNhanVien"].ToString();
            lblCMND.Text = row.Rows[0]["CMND"].ToString();
            lblChucVu.Text = row.Rows[0]["ChucVu"].ToString();
            lblGioiTinh.Text = row.Rows[0]["GioiTinh"].ToString();
            lblNgaySinh.Text = row.Rows[0]["NgaySinh"].ToString();
            lblNgayVaoLam.Text = row.Rows[0]["NgayVaoLam"].ToString();
            txtDiaChi.Text = DiaChi = row.Rows[0]["DiaChi"].ToString();
            txtEmail.Text = Email = row.Rows[0]["Email"].ToString();
            txtSoDienThoai.Text = SDT = row.Rows[0]["SDT"].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != DiaChi)
                BLL_TaiKhoan.Instance.UpdateThongTin("DiaChi", "N'" +txtDiaChi.Text+ "'", MaNhanVien);
            if (txtSoDienThoai.Text != SDT)
                BLL_TaiKhoan.Instance.UpdateThongTin("SDT", "'" + txtSoDienThoai.Text + "'", MaNhanVien);
            if (txtEmail.Text != Email)
                BLL_TaiKhoan.Instance.UpdateThongTin("Email", "'" + txtEmail.Text + "'", MaNhanVien);
            if(txtMatKhauCu.Text!="" && txtMatKhauMoi.Text!="" && txtNhapLaiMKMoi.Text != "")
            {
                if (BLL_TaiKhoan.Instance.GetTaiKhoanByMaNhanVien(MaNhanVien).Rows[0]["MatKhau"].ToString() == txtMatKhauCu.Text)
                {
                    if (txtMatKhauMoi.Text == txtNhapLaiMKMoi.Text)
                    {
                        BLL_TaiKhoan.Instance.UpdateMatKhau(txtMatKhauMoi.Text, MaNhanVien);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ và mật khẩu mới không trùng nhau.");
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu cũ.");
                }
            }
        }
    }
}
