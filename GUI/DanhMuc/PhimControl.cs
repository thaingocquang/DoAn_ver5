using DoAn_ver5.BLL;
using DoAn_ver5.DTO;
using DoAn_ver5.GUI.DanhMuc;
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
    public partial class PhimControl : UserControl
    {
        private static PhimControl _instance;
        public static PhimControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PhimControl();
                return _instance;
            }
        }
        public PhimControl()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Phim_ThemPhim frm = new Phim_ThemPhim();
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstPhim.SelectedItems.Count > 0)
            {
                ListViewItem ls = lstPhim.SelectedItems[0];
                string MaPhim = ls.SubItems[0].Text.Trim();
                Phim_SuaPhim f = new Phim_SuaPhim(MaPhim);
                f.ShowDialog();
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            lstPhim.Items.Clear();
            int count = 1;
            foreach (DataRow i in BLL_Phim.Instance.GetAllPhim().Rows)
            {
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaPhim"].ToString());
                ls.SubItems.Add(i["TenPhim"].ToString());
                ls.SubItems.Add(i["ThoiLuong"].ToString());
                ls.SubItems.Add(i["NhaSanXuat"].ToString());
                ls.SubItems.Add(i["NamSanXuat"].ToString());
                ls.SubItems.Add(i["NgonNgu"].ToString());
                ls.SubItems.Add(i["NgayRaMat"].ToString());
                ls.SubItems.Add(i["NuocSanXuat"].ToString());
                ls.SubItems.Add(i["DoanhThu"].ToString());
                ls.SubItems.Add(i["DienVien"].ToString());
                ls.SubItems.Add(i["TrangThai"].ToString());
                ls.SubItems.Add(i["TomTat"].ToString());
                lstPhim.Items.Add(ls);
                count++;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int count = 1;
            string TenPhim = txtTheoTenPhim.Text;
            string dt1 = dtpTuNgay.Value.ToString("yyyy/MM/dd");
            string dt2 = dtpDenNgay.Value.ToString("yyyy/MM/dd");
            if (chkTheoTenPhim.Checked == true)
            {
                lstPhim.Items.Clear();
                foreach (DataRow i in BLL_Phim.Instance.GetPhimByTenPhim1(TenPhim).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaPhim"].ToString());
                    ls.SubItems.Add(i["ThoiLuong"].ToString());
                    ls.SubItems.Add(i["NhaSanXuat"].ToString());
                    ls.SubItems.Add(i["NamSanXuat"].ToString());
                    ls.SubItems.Add(i["NgonNgu"].ToString());
                    ls.SubItems.Add(i["NgayRaMat"].ToString());
                    ls.SubItems.Add(i["NuocSanXuat"].ToString());
                    ls.SubItems.Add(i["DoanhThu"].ToString());
                    ls.SubItems.Add(i["DienVien"].ToString());
                    ls.SubItems.Add(i["TrangThai"].ToString());
                    ls.SubItems.Add(i["TomTat"].ToString());
                    lstPhim.Items.Add(ls);
                    count++; ;
                }
            }
            if (chkTheoKhoangTime.Checked == true)
            {
                lstPhim.Items.Clear();
                foreach (DataRow i in BLL_Phim.Instance.GetPhimByDate1(dt1, dt2).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaPhim"].ToString());
                    ls.SubItems.Add(i["ThoiLuong"].ToString());
                    ls.SubItems.Add(i["NhaSanXuat"].ToString());
                    ls.SubItems.Add(i["NamSanXuat"].ToString());
                    ls.SubItems.Add(i["NgonNgu"].ToString());
                    ls.SubItems.Add(i["NgayRaMat"].ToString());
                    ls.SubItems.Add(i["NuocSanXuat"].ToString());
                    ls.SubItems.Add(i["DoanhThu"].ToString());
                    ls.SubItems.Add(i["DienVien"].ToString());
                    ls.SubItems.Add(i["TrangThai"].ToString());
                    ls.SubItems.Add(i["TomTat"].ToString());
                    lstPhim.Items.Add(ls);
                    count++;
                }
            }
        }

        private void chkTheoTenPhim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTheoTenPhim.Checked == true)
            {
                txtTheoTenPhim.Enabled = true;
                chkTheoKhoangTime.Checked = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void chkTheoKhoangTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTheoKhoangTime.Checked == true)
            {
                dtpDenNgay.Enabled = true;
                dtpTuNgay.Enabled = true;
                txtTheoTenPhim.Enabled = false;
                chkTheoTenPhim.Checked = false;
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtTheoTenPhim.Text = "";
            txtTheoTenPhim.Enabled = true;
            dtpTuNgay.Enabled = true;
            dtpDenNgay.Enabled = true;
            chkTheoTenPhim.Checked = false;
            chkTheoKhoangTime.Checked = false;
        }
    }
      
}
