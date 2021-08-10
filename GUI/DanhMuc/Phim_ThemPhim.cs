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
                int.Parse(nmDoTuoi.Value.ToString()),
                dtpNgayChieu.Value.Date.ToString("yyyy/MM/dd"),
                txtDienVien.Text.Trim(),
                txtNuocSX.Text.Trim(),
                txtNhaSX.Text.Trim(),
                txtTomTat.Text.Trim()
            );

            for(int i=0; i<lstSuatphim.Items.Count; i++)
            {
                DAL_SuatChieu.Instance.InsertSuatPhimByMaPhim
                (
                    "SP" + (DataProvider.Instance.GetRowCount(BLL_SuatChieu.Instance.GetAllSuatPhim()) + 1),
                    lstSuatphim.Items[i].SubItems[1].Text.Trim(),
                    lstSuatphim.Items[i].SubItems[2].Text.Trim(),
                    lstSuatphim.Items[i].SubItems[3].Text.Trim(),
                    txtMaPhim.Text.Trim()
                );
            }
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstSuatphim.SelectedItems.Count > 0)
            {
                lstSuatphim.Items.RemoveAt(lstSuatphim.SelectedItems[0].Index);
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {

            int count = lstSuatphim.Items.Count + 1;
            ListViewItem ls = new ListViewItem(count.ToString());
            ls.SubItems.Add(cbbDinhDang.SelectedItem.ToString());
            ls.SubItems.Add(cbbHinhthuc.SelectedItem.ToString().Trim());
            ls.SubItems.Add(txtNgonngu.Text.Trim());
            lstSuatphim.Items.Add(ls);
        }

        private void Phim_ThemPhim_Load(object sender, EventArgs e)
        {
            txtMaPhim.Text = "P" + ((BLL_General.Instance.GetRowCount(BLL_Phim.Instance.GetAllPhim())) + 1);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
