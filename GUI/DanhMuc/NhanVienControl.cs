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
    public partial class NhanVienControl : UserControl
    {
        private static NhanVienControl _instance;
        public static NhanVienControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhanVienControl();
                return _instance;
            }
        }
        public NhanVienControl()
        {
            InitializeComponent();
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                txtTen.Enabled = true;
                chkChucVu.Checked = false;
                chkCMND.Checked = false;
                cbbChucVu.Enabled = false;
                txtCMND.Enabled = false;
            }
        }

        private void chkChucVu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChucVu.Checked == true)
            {
                cbbChucVu.Enabled = true;
                chkTen.Checked = false;
                txtTen.Enabled = false;
                txtCMND.Enabled = false;
                chkCMND.Checked = false;
            }
        }

        private void chkCMND_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCMND.Checked == true)
            {
                txtCMND.Enabled = true;
                chkChucVu.Checked = false;
                cbbChucVu.Enabled = false;
                chkTen.Checked = false;
                txtTen.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string Ten = txtTen.Text;
            string CMND = txtCMND.Text;
            int count = 1;
            if (chkTen.Checked == true)
            {
                listView1.Items.Clear();
                foreach (DataRow i in BLL_NhanVien.Instance.GetNhanVienByTen(Ten).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaNhanVien"].ToString());
                    ls.SubItems.Add(i["HovaTen"].ToString());
                    ls.SubItems.Add(i["NgaySinh"].ToString());
                    ls.SubItems.Add(i["GioiTinh"].ToString());
                    ls.SubItems.Add(i["DiaChi"].ToString());
                    ls.SubItems.Add(i["CMND"].ToString());
                    ls.SubItems.Add(i["Email"].ToString());
                    ls.SubItems.Add(i["SDT"].ToString());
                    ls.SubItems.Add(i["ChucVu"].ToString());
                    ls.SubItems.Add(i["NgayVaoLam"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }
            }
            if (chkChucVu.Checked == true)
            {
                listView1.Items.Clear();
                foreach (DataRow i in BLL_NhanVien.Instance.GetNhanVienByChucVu(cbbChucVu.SelectedItem.ToString()).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaNhanVien"].ToString());
                    ls.SubItems.Add(i["HovaTen"].ToString());
                    ls.SubItems.Add(i["NgaySinh"].ToString());
                    ls.SubItems.Add(i["GioiTinh"].ToString());
                    ls.SubItems.Add(i["DiaChi"].ToString());
                    ls.SubItems.Add(i["CMND"].ToString());
                    ls.SubItems.Add(i["Email"].ToString());
                    ls.SubItems.Add(i["SDT"].ToString());
                    ls.SubItems.Add(i["ChucVu"].ToString());
                    ls.SubItems.Add(i["NgayVaoLam"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }

            }
            if (chkCMND.Checked == true)
            {
                listView1.Items.Clear();
                foreach (DataRow i in BLL_NhanVien.Instance.GetNhanVienByCMND(CMND).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaNhanVien"].ToString());
                    ls.SubItems.Add(i["HovaTen"].ToString());
                    ls.SubItems.Add(i["NgaySinh"].ToString());
                    ls.SubItems.Add(i["GioiTinh"].ToString());
                    ls.SubItems.Add(i["DiaChi"].ToString());
                    ls.SubItems.Add(i["CMND"].ToString());
                    ls.SubItems.Add(i["Email"].ToString());
                    ls.SubItems.Add(i["SDT"].ToString());
                    ls.SubItems.Add(i["ChucVu"].ToString());
                    ls.SubItems.Add(i["NgayVaoLam"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtCMND.Text = "";
            txtTen.Text = "";
            txtTen.Enabled = true;
            txtCMND.Enabled = true;
            cbbChucVu.Enabled = true;
            cbbChucVu.SelectedItem = null;
            chkChucVu.Checked = false;
            chkCMND.Checked = false;
            chkTen.Checked = false;
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            int count = 1;
            listView1.Items.Clear();
            foreach (DataRow i in BLL_NhanVien.Instance.GetAllNhanVien().Rows)
            {

                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaNhanVien"].ToString());
                ls.SubItems.Add(i["HovaTen"].ToString());
                ls.SubItems.Add(i["NgaySinh"].ToString());
                ls.SubItems.Add(i["GioiTinh"].ToString());
                ls.SubItems.Add(i["DiaChi"].ToString());
                ls.SubItems.Add(i["CMND"].ToString());
                ls.SubItems.Add(i["Email"].ToString());
                ls.SubItems.Add(i["SDT"].ToString());
                ls.SubItems.Add(i["ChucVu"].ToString());
                ls.SubItems.Add(i["NgayVaoLam"].ToString());
                listView1.Items.Add(ls);
                count++;
            }
        }
    }
}
