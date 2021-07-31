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
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            DataTable row = BLL_NhanVien.Instance.GetNhanVienByMaNhanVien(DangNhap.MaNhanVien);
            lblTenNhanVien.Text = row.Rows[0]["HoVaTen"].ToString();
            lblMaNhanVien.Text = row.Rows[0]["MaNhanVien"].ToString();
            lblCMND.Text = row.Rows[0]["CMND"].ToString();
            lblChucVu.Text = row.Rows[0]["ChucVu"].ToString();
            lblGioiTinh.Text = row.Rows[0]["GioiTinh"].ToString();
            lblNgaySinh.Text = row.Rows[0]["NgaySinh"].ToString();
            lblNgayVaoLam.Text = row.Rows[0]["NgayVaoLam"].ToString();
        }
    }
}
