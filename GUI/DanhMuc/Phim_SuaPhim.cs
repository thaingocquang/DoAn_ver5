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

namespace DoAn_ver5.GUI.DanhMuc
{
    public partial class Phim_SuaPhim : Form
    {
        
        
        public Phim_SuaPhim(string m)
        {
            InitializeComponent();            
            GUI(m);
          
        }    
        public void GUI(string MaPhim)
        {
            if (BLL_Phim.Instance.GetPhimByMaPhim(MaPhim) != null)
            {
                DataTable dt = BLL_Phim.Instance.GetPhimByMaPhim(MaPhim);
                foreach (DataRow i in dt.Rows)
                {
                    txtMaPhim.Text = i["MaPhim"].ToString();
                    txtTenPhim.Text = i["TenPhim"].ToString();
                    numericUpDown2.Value = Convert.ToInt32(i["ThoiLuong"].ToString());
                    numericUpDown3.Value = Convert.ToInt32(i["NamSanXuat"].ToString());
                    cbbDoTuoi.SelectedItem = Convert.ToInt32(i["GioiHanTuoi"].ToString());
                    dtpNgayChieu.Value = Convert.ToDateTime(i["NgayRaMat"].ToString());
                    cbbTrangThai.SelectedItem = i["TrangThai"].ToString();
                    txtDienVien.Text = i["DienVien"].ToString();
                    cbbNuocsx.SelectedItem = i["NuocSanXuat"].ToString();
                    cbbNN.SelectedItem = i["NgonNgu"].ToString();
                    cbbNhasx.SelectedItem = i["NhaSanXuat"].ToString();
                    txtDoanhThu.Text = i["DoanhThu"].ToString();
                    txtTomTat.Text = i["TomTat"].ToString();
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_Phim.Instance.UpdatePhim
                (
                    txtMaPhim.Text.Trim(),
                    txtTenPhim.Text.Trim(),
                    int.Parse(numericUpDown2.Value.ToString()),
                    int.Parse(numericUpDown3.Value.ToString()),
                    int.Parse(cbbDoTuoi.SelectedItem.ToString()),
                    dtpNgayChieu.Value.ToString(),
                    cbbTrangThai.SelectedItem.ToString(),
                    txtDienVien.Text.Trim(),
                    cbbNuocsx.SelectedItem.ToString(),
                    cbbNN.SelectedItem.ToString(),
                    cbbNhasx.SelectedItem.ToString(),
                    int.Parse(txtDoanhThu.Text.Trim()),
                    txtTomTat.Text.Trim()
                );
            this.Close();
        }
    }
}
