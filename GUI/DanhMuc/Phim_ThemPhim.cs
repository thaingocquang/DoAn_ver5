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
    public partial class Phim_ThemPhim : Form
    {
        public Phim_ThemPhim()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_Phim.Instance.InsertPhim
            (
                txtMaPhim.Text.Trim(),
                txtTenPhim.Text.Trim(),
                int.Parse(ThoiLuong.Value.ToString()),
                int.Parse(NamSX.Value.ToString()),
                int.Parse(cbbDoTuoi.SelectedItem.ToString()),
                dtpNgayChieu.Value.Date.ToString("yyyy/MM/dd"),
                cbbTrangThai.SelectedItem.ToString(),
                txtDienVien.Text.Trim(),
                cbbNuocSX.SelectedItem.ToString(),
                cbbNN.SelectedItem.ToString(),
                cbbNhaSX.SelectedItem.ToString(),
                int.Parse(txtDoanhThu.Text.Trim()),
                txtTomTat.Text.Trim()
            );
            this.Close();
        }
    }
}
