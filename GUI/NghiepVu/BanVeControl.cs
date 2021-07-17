﻿using System;
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
            DataTable data = BLL_Phim.Instance.GetPhimByDate(date);
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
            lstListPhim.Items.Clear();
            HienThiPhimLenListView(dtpChonNgay.Value);
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            if (lstListSuatChieu.SelectedItems.Count > 0)
            {
                DTO_SuatChieu SuatChieu = BLL_SuatChieu.Instance.GetSuatChieuByMaSuatChieu(lstListSuatChieu.SelectedItems[0].SubItems[1].Text);
                DTO_Phim Phim = BLL_Phim.Instance.GetPhimByTenPhim(lstListPhim.SelectedItems[0].SubItems[1].Text);
                BanVe_ChonGhe frm = new BanVe_ChonGhe(SuatChieu, Phim);
                frm.Show();
            }           
        }

        private void lstListPhim_MouseClick(object sender, MouseEventArgs e)
        {
            lstListSuatChieu.Items.Clear();
            string tenPhim = lstListPhim.SelectedItems[0].SubItems[1].Text;
            DataTable SuatChieus = BLL_SuatChieu.Instance.GetSuatChieusByTenPhim(tenPhim);
            int i = 1;
            foreach (DataRow row in SuatChieus.Rows)
            {
                ListViewItem lviLst = new ListViewItem(i + "");
                lviLst.SubItems.Add(row["MaSuatChieu"].ToString());
                lviLst.SubItems.Add(((DateTime)row["NgayGio"]).ToString());
                lviLst.SubItems.Add(row["DinhDang"].ToString());
                lviLst.SubItems.Add(row["HinhThuc"].ToString());
                lviLst.SubItems.Add(row["NgonNgu"].ToString());
                lviLst.SubItems.Add(row["TenPhongChieu"].ToString());
                lstListSuatChieu.Items.Add(lviLst);
                i++;
            }

        }

        private void lstListPhim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
