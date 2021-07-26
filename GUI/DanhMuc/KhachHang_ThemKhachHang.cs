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

namespace DoAn_ver5.GUI.DanhMuc
{
    public partial class KhachHang_ThemKhachHang : Form
    {
        public KhachHang_ThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_KhachHang.Instance.InsertKhachHang
            (
                txtMaKhachHang.Text.Trim(),
                txtHovaTen.Text.Trim(),
                rbNam.Checked == true ? rbNam.Text : rbNu.Text,
                dtpNgaySinh.Value.Date.ToString("yyyy/MM/dd"),
                txtEmail.Text.Trim(),
                txtSDT.Text.Trim(),
                "Thường",
                dtpNgayDK.Value.Date.ToString("yyyy/MM/dd"),
                Convert.ToInt32(txtCMND.Text.Trim())
            );
            this.Close();
        }
    }
}
