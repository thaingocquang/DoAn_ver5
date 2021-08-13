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

namespace DoAn_ver5.GUI.DanhMuc
{
    public partial class VeControl : UserControl
    {
        private static VeControl _instance;
        public static VeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VeControl();
                return _instance;
            }
        }
        public VeControl()
        {
            InitializeComponent();
        }

        private void chkMa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMa.Checked == true)
            {
                txtMa.Enabled = true;
                chkTen.Checked = false;
                txtTen.Enabled = false;
                chkThoiGian.Checked = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                txtTen.Enabled = true;
                chkMa.Checked = false;
                txtMa.Enabled = false;
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
                chkMa.Checked = false;
                txtMa.Enabled = false;
                chkTen.Checked = false;
                txtTen.Enabled = false;
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkTen.Checked = false;
            chkMa.Checked = false;
            chkThoiGian.Checked = false;
            txtTen.Enabled = true;
            txtMa.Enabled = true;
            dtpTuNgay.Enabled = true;
            dtpDenNgay.Enabled = true;
            txtTen.Text = "";
            txtMa.Text = "";
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            int count = 1;
            listView1.Items.Clear();
            foreach (DataRow i in BLL_Ve.Instance.GetVe().Rows)
            {
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaHoaDonVe"].ToString());
                ls.SubItems.Add(i["MaSuatChieu"].ToString());
                ls.SubItems.Add(i["MaGhe"].ToString());
                ls.SubItems.Add(i["NgayBanVe"].ToString());
                ls.SubItems.Add(i["HovaTen"].ToString());
                ls.SubItems.Add(i["GiaVe"].ToString());
                ls.SubItems.Add(i["TenKhachHang"].ToString());
                listView1.Items.Add(ls);
                count++;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
