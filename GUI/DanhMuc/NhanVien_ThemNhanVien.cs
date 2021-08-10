using DoAn_ver5.BLL;
using DoAn_ver5.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI
{
    public partial class NhanVien_ThemNhanVien : Form
    {
        public NhanVien_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_NhanVien.Instance.InsertNhanVien
                (
                    txtMaNV.Text.Trim(),
                    txtTen.Text.Trim(),
                    dtpNgaySinh.Value.Date.ToString("yyyy/MM/dd"),
                    rdNam.Checked == true ? rdNam.Text : rdNu.Text,
                    txtDiaChi.Text.Trim(),
                    int.Parse(txtCMND.Text.Trim()),
                    txtEmail.Text.Trim(),
                    txtSDT.Text.Trim(),
                    cbbChucVu.SelectedItem.ToString(),
                    dtpNgayLam.Value.Date.ToString("yyyy/MM/dd"),
                    txtTenDangNhap.Text.Trim(),
                    "123456",
                    "true"
                );
            this.Close();
        }

        private void NhanVien_ThemNhanVien_Load(object sender, EventArgs e)
        {
            if(cbTaiKhoan.Checked == true)
            {
                txtTenDangNhap.Text = "NV" + (DataProvider.Instance.GetRowCount(BLL_NhanVien.Instance.GetAllNhanVien()) + 1);
            }
        }
    }
}
