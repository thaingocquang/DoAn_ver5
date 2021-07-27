using DoAn_ver5.BLL;
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
    public partial class SuatChieuControl : UserControl
    {
        private static SuatChieuControl _instance;
        public static SuatChieuControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SuatChieuControl();
                return _instance;
            }
        }
        public SuatChieuControl()
        {
            InitializeComponent();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            lstSuatChieu.Items.Clear();
            int count = 1;
            foreach (DataRow i in BLL_SuatChieu.Instance.GetAllSuatChieu().Rows)
            {
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaSuatChieu"].ToString());
                ls.SubItems.Add(i["MaPhim"].ToString());
                ls.SubItems.Add(i["TenPhim"].ToString());
                ls.SubItems.Add(i["NgayGio"].ToString());
                ls.SubItems.Add(i["DinhDang"].ToString());
                ls.SubItems.Add(i["HinhThuc"].ToString());
                ls.SubItems.Add(i["NgonNgu"].ToString());
                ls.SubItems.Add(i["TenPhongChieu"].ToString());
                ls.SubItems.Add(i["TrangThai"].ToString());
                ls.SubItems.Add(i["MaSuatChieu"].ToString());
                lstSuatChieu.Items.Add(ls);
                count++;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int count = 1;
            string TenPhim = txtTen.Text;
            string dt1 = dtpTuNgay.Value.ToString("yyyy/MM/dd");
            string dt2 = dtpDenNgay.Value.ToString("yyyy/MM/dd");
            if (chkTen.Checked == true)
            {
                lstSuatChieu.Items.Clear();
                foreach (DataRow i in BLL_SuatChieu.Instance.GetSuatChieusByTenPhim(TenPhim).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaSuatChieu"].ToString());
                    ls.SubItems.Add(i["MaPhim"].ToString());
                    ls.SubItems.Add(i["TenPhim"].ToString());
                    ls.SubItems.Add(i["NgayGio"].ToString());
                    ls.SubItems.Add(i["DinhDang"].ToString());
                    ls.SubItems.Add(i["HinhThuc"].ToString());
                    ls.SubItems.Add(i["NgonNgu"].ToString());
                    ls.SubItems.Add(i["TenPhongChieu"].ToString());
                    ls.SubItems.Add(i["TrangThai"].ToString());
                    ls.SubItems.Add(i["MaSuatChieu"].ToString());
                    lstSuatChieu.Items.Add(ls);
                }
            }
            if (chkThoiGian.Checked == true)
            {
                lstSuatChieu.Items.Clear();
                foreach (DataRow i in BLL_SuatChieu.Instance.GetSuatChieuByDate(dt1, dt2).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaSuatChieu"].ToString());
                    ls.SubItems.Add(i["MaPhim"].ToString());
                    ls.SubItems.Add(i["TenPhim"].ToString());
                    ls.SubItems.Add(i["NgayGio"].ToString());
                    ls.SubItems.Add(i["DinhDang"].ToString());
                    ls.SubItems.Add(i["HinhThuc"].ToString());
                    ls.SubItems.Add(i["NgonNgu"].ToString());
                    ls.SubItems.Add(i["TenPhongChieu"].ToString());
                    ls.SubItems.Add(i["TrangThai"].ToString());
                    ls.SubItems.Add(i["MaSuatChieu"].ToString());
                    lstSuatChieu.Items.Add(ls);
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            chkTen.Checked = false;
            dtpTuNgay.Enabled = true;
            dtpDenNgay.Enabled = true;
            chkThoiGian.Checked = false;
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                txtTen.Enabled = true;
                chkThoiGian.Checked = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void chkThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThoiGian.Checked == true)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
                chkTen.Checked = false;
                txtTen.Enabled = false;
            }
        }
    }
}
