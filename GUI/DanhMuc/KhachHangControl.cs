using DoAn_ver5.BLL;
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
    public partial class KhachHangControl : UserControl
    {
        private static KhachHangControl _instance;
        public static KhachHangControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KhachHangControl();
                return _instance;
            }
        }
        public KhachHangControl()
        {
            InitializeComponent();
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                txtTen.Enabled = true;
                chkCMND.Checked = false;
                txtCMND.Enabled = false;
            }
        }

        private void chkCMND_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCMND.Checked == true)
            {
                txtCMND.Enabled = true;
                txtTen.Enabled = false;
                chkTen.Checked = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int count = 1;
            string Ten = txtTen.Text;
            string CMND = txtCMND.Text;
            if (chkTen.Checked == true)
            {
                foreach (DataRow i in BLL_KhachHang.Instance.GetKHByTenKH(Ten).Rows)
                {
                    lstKhachHang.Items.Clear();
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaKhachHang"].ToString());
                    ls.SubItems.Add(i["TenKhachHang"].ToString());
                    ls.SubItems.Add(i["GioiTinh"].ToString());
                    ls.SubItems.Add(i["CMND"].ToString());
                    ls.SubItems.Add(i["NgaySinh"].ToString());
                    ls.SubItems.Add(i["Email"].ToString());
                    ls.SubItems.Add(i["SDT"].ToString());
                    ls.SubItems.Add(i["LoaiKhachHang"].ToString());
                    ls.SubItems.Add(i["NgayDangKy"].ToString());
                    lstKhachHang.Items.Add(ls);
                    count++;
                }
            }
            if (chkCMND.Checked == true)
            {
                foreach (DataRow i in BLL_KhachHang.Instance.GetKHByCMND(CMND).Rows)
                {
                    lstKhachHang.Items.Clear();
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaKhachHang"].ToString());
                    ls.SubItems.Add(i["TenKhachHang"].ToString());
                    ls.SubItems.Add(i["GioiTinh"].ToString());
                    ls.SubItems.Add(i["CMND"].ToString());
                    ls.SubItems.Add(i["NgaySinh"].ToString());
                    ls.SubItems.Add(i["Email"].ToString());
                    ls.SubItems.Add(i["SDT"].ToString());
                    ls.SubItems.Add(i["LoaiKhachHang"].ToString());
                    ls.SubItems.Add(i["NgayDangKy"].ToString());
                    lstKhachHang.Items.Add(ls);
                    count++;
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkTen.Checked = false;
            chkCMND.Checked = false;
            txtTen.Enabled = true;
            txtCMND.Enabled = true;
            txtTen.Text = "";
            txtCMND.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BLL_NhanVien.Instance.IsQuyenQuanTri() == false)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
                return;
            }
            KhachHang_ThemKhachHang kh = new KhachHang_ThemKhachHang();
            kh.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (BLL_NhanVien.Instance.IsQuyenQuanTri() == false)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
                return;
            }
            if (lstKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem ls = lstKhachHang.SelectedItems[0];
                string s = ls.SubItems[2].Text;
                KhachHang_SuaKhachHang kh = new KhachHang_SuaKhachHang(s);
                kh.ShowDialog();
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            int count = 1;
            lstKhachHang.Items.Clear();
            foreach (DataRow i in BLL_KhachHang.Instance.GetAllKH().Rows)
            {
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaKhachHang"].ToString());
                ls.SubItems.Add(i["TenKhachHang"].ToString());
                ls.SubItems.Add(i["GioiTinh"].ToString());
                ls.SubItems.Add(i["CMND"].ToString());
                ls.SubItems.Add(i["NgaySinh"].ToString());
                ls.SubItems.Add(i["Email"].ToString());
                ls.SubItems.Add(i["SDT"].ToString());
                ls.SubItems.Add(i["LoaiKhachHang"].ToString());
                ls.SubItems.Add(i["NgayDangKy"].ToString());
                lstKhachHang.Items.Add(ls);
                count++;
            }
        }
    }
}
