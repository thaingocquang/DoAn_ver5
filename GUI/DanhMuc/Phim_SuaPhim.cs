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
            int count = 1;
            if (BLL_Phim.Instance.GetPhimByMaPhim(MaPhim) != null)
            {
                DataTable dt = BLL_Phim.Instance.GetPhimByMaPhim(MaPhim);
                foreach (DataRow i in dt.Rows)
                {
                    txtMaPhim.Text = i["MaPhim"].ToString();
                    txtTenPhim.Text = i["TenPhim"].ToString();
                    numericUpDown2.Value = Convert.ToInt32(i["ThoiLuong"].ToString());
                    numericUpDown3.Value = Convert.ToInt32(i["NamSanXuat"].ToString());
                    cbbDoTuoi.SelectedItem = i["GioiHanTuoi"].ToString();
                    dtpNgayChieu.Value = Convert.ToDateTime(i["NgayRaMat"].ToString());
                    txtDienVien.Text = i["DienVien"].ToString();
                    cbbNuocsx.SelectedItem = i["NuocSanXuat"].ToString();
                    cbbNhasx.SelectedItem = i["NhaSanXuat"].ToString();
                    txtTomTat.Text = i["TomTat"].ToString();
                }
            }
            if (BLL_SuatChieu.Instance.GetSuatPhimByMaPhim(MaPhim) != null)
            {
                DataTable dt = BLL_SuatChieu.Instance.GetSuatPhimByMaPhim(MaPhim);
                foreach (DataRow i in dt.Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["DinhDang"].ToString());
                    ls.SubItems.Add(i["HinhThuc"].ToString());
                    ls.SubItems.Add(i["NgonNgu"].ToString());
                    lstSuatphim.Items.Add(ls);
                    count++;
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
                    dtpNgayChieu.Value.ToString("yyyy/MM/dd"),
                    txtDienVien.Text.Trim(),
                    cbbNuocsx.SelectedItem.ToString(),
                    cbbNhasx.SelectedItem.ToString(),
                    txtTomTat.Text.Trim()
                );            

            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSuatphim.SelectedItems.Count > 0)
            {
                string DinhDang = lstSuatphim.SelectedItems[0].SubItems[1].Text.Trim();
                string HinhThuc = lstSuatphim.SelectedItems[0].SubItems[2].Text.Trim();
                string NgonNgu = lstSuatphim.SelectedItems[0].SubItems[3].Text.Trim();
                string MaPhim = txtMaPhim.Text.Trim();
                DataTable dt = DAL_SuatChieu.Instance.GetMaSuatPhiminMaPhim(DinhDang,HinhThuc,NgonNgu,MaPhim);
                string s = dt.Rows[0]["MaSuatPhim"].ToString();
                DAL_SuatChieu.Instance.DeleteSuatPhim
                    (
                        s,
                        lstSuatphim.SelectedItems[0].SubItems[1].Text.Trim(),
                        lstSuatphim.SelectedItems[0].SubItems[2].Text.Trim(),
                        lstSuatphim.SelectedItems[0].SubItems[3].Text.Trim(),
                        txtMaPhim.Text.Trim()
                    );
                lstSuatphim.Items.RemoveAt(lstSuatphim.SelectedItems[0].Index);
            }
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(lstSuatphim.SelectedItems.Count == 0)
            {
                int count = lstSuatphim.Items.Count + 1;
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(txtDinhdang.Text.Trim());
                ls.SubItems.Add(cbbHinhthuc.SelectedItem.ToString().Trim());
                ls.SubItems.Add(txtNgonngu.Text.Trim());
                lstSuatphim.Items.Add(ls);
                DAL_SuatChieu.Instance.InsertSuatPhimByMaPhim
                (
                    "SP" + (DataProvider.Instance.GetRowCount(BLL_SuatChieu.Instance.GetAllSuatPhim()) + 1),
                    txtDinhdang.Text.Trim(),
                    cbbHinhthuc.SelectedItem.ToString().Trim(),
                    txtNgonngu.Text.Trim(),
                    txtMaPhim.Text.Trim()
                );
            }
            if(lstSuatphim.SelectedItems.Count > 0)
            {
                ListViewItem sl = lstSuatphim.SelectedItems[0];
                sl.SubItems[1].Text = txtDinhdang.Text.Trim();
                sl.SubItems[2].Text = cbbHinhthuc.SelectedItem.ToString();
                sl.SubItems[3].Text = txtNgonngu.Text.Trim();
            }            
        }

        private void lstSuatphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDinhdang.Text = "";
            txtNgonngu.Text = "";
            cbbHinhthuc.SelectedItem = null;
            if(lstSuatphim.SelectedItems.Count > 0)
            {
                txtDinhdang.Text = lstSuatphim.SelectedItems[0].SubItems[1].Text.Trim();
                txtNgonngu.Text = lstSuatphim.SelectedItems[0].SubItems[3].Text.Trim();
                cbbHinhthuc.SelectedItem = lstSuatphim.SelectedItems[0].SubItems[2].Text.Trim();
            }     
        }
    }
}
