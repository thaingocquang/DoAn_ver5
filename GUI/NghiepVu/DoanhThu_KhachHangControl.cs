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

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class DoanhThu_KhachHangControl : UserControl
    {
        private static DoanhThu_KhachHangControl _instance;
        public static DoanhThu_KhachHangControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DoanhThu_KhachHangControl();
                return _instance;
            }
        }
        public DoanhThu_KhachHangControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            lstDoanhThuKH.Items.Clear();
            DateTime tu_ngay = dtpTuNgay.Value;
            string tungay = tu_ngay.Date.ToString("yyyy/MM/dd");
            DateTime den_ngay = dtpDenNgay.Value;
            string denngay = den_ngay.Date.ToString("yyyy/MM/dd");
            int count = 1;
            foreach (DataRow row in BLL_KhachHang.Instance.GetlistDoanhThuKH(tungay, denngay).Rows)
            {
                ListViewItem lvi = new ListViewItem(count.ToString());
                lvi.SubItems.Add(row["MaKhachHang"].ToString());
                lvi.SubItems.Add(row["TenKhachHang"].ToString());
                lvi.SubItems.Add(row["NgayDangKy"].ToString());
                lvi.SubItems.Add(row["LoaiKhachHang"].ToString());
                lvi.SubItems.Add(row["DoanhThuKH"].ToString());
                lstDoanhThuKH.Items.Add(lvi);
                count++;
            }
        }
    }
}
