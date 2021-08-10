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
using DoAn_ver5.DTO;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class BanVeControl : UserControl
    {
        private static BanVeControl _instance;
        public static BanVeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BanVeControl();
                return _instance;
            }
        }
        public BanVeControl()
        {
            InitializeComponent();
            dtpChonNgay.Value = DateTime.Now;
            
        }       

        private void HienThiPhimLenListView(DateTime date)
        {
            DataTable data = BLL_Phim.Instance.GetPhimHaveSuatPhimByDate(date);
            int i = 1;
            foreach(DataRow row in data.Rows)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(row["TenPhim"].ToString());
                lstListPhim.Items.Add(lvi);
                i++;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (BLL_NhanVien.Instance.IsQuyenBanVe() == false)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
                return;
            }
            lstListPhim.Items.Clear();
            HienThiPhimLenListView(dtpChonNgay.Value);
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            if (BLL_NhanVien.Instance.IsQuyenBanVe() == false)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
                return;
            }
            if (lstListSuatChieu.SelectedItems.Count > 0)
            {
                BanVe_ChonGhe frm = new BanVe_ChonGhe(lstListSuatChieu.SelectedItems[0].SubItems[1].Text);
                frm.Show();
            }           
        }

        private void lstListPhim_MouseClick(object sender, MouseEventArgs e)
        {
            lstListSuatChieu.Items.Clear();
            string tenPhim = lstListPhim.SelectedItems[0].SubItems[1].Text;
            DataTable SuatChieus = BLL_SuatChieu.Instance.GetSuatChieusByTenPhimAndDate(tenPhim, dtpChonNgay.Value);
            int i = 1;
            foreach (DataRow row in SuatChieus.Rows)
            {
                ListViewItem lviLst = new ListViewItem(i + "");
                lviLst.SubItems.Add(row["MaSuatChieu"].ToString());
                lviLst.SubItems.Add(((DateTime)row["NgayGio"]).TimeOfDay.ToString());
                lviLst.SubItems.Add(row["DinhDang"].ToString());
                lviLst.SubItems.Add(row["HinhThuc"].ToString());
                lviLst.SubItems.Add(row["NgonNgu"].ToString());
                lviLst.SubItems.Add(row["TenPhongChieu"].ToString());
                lviLst.SubItems.Add(row["TrangThai"].ToString());
                lstListSuatChieu.Items.Add(lviLst);
                i++;
            }

        }
    }
}
