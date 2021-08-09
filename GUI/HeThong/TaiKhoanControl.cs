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

namespace DoAn_ver5.GUI.HeThong
{
    public partial class TaiKhoanControl : UserControl
    {
        string cbbQuyenHanText;
        bool KichHoatTK;
        private static TaiKhoanControl _instance;
        public static TaiKhoanControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaiKhoanControl();
                return _instance;
            }
        }
        public TaiKhoanControl()
        {
            InitializeComponent();
        }

        private void TaiKhoanControl_Load(object sender, EventArgs e)
        {
            cbbQuyenHan.Items.Add("Bán vé");
            cbbQuyenHan.Items.Add("Bán thức ăn");
            HienTatCaTaiKhoan();
        }

        private void HienTatCaTaiKhoan()
        {
                DataTable data = BLL_TaiKhoan.Instance.GetAllTaiKhoan();
                int i = 1;
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add(row["TenDangNhap"].ToString());
                    lvi.SubItems.Add(row["MaNhanVien"].ToString());
                    lvi.SubItems.Add(row["HoVaTen"].ToString());
                    lvi.SubItems.Add(row["ChucVu"].ToString());
                    lvi.SubItems.Add(((bool)row["TrangThai"]==true)?"Kích hoạt":"Tạm ngưng");
                    lstTaiKhoan.Items.Add(lvi);
                    i++;
                }
        }

        private void lstTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTaiKhoan.SelectedItems.Count == 0)
                return;
            lblTenNhanVien.Text = lstTaiKhoan.SelectedItems[0].SubItems[3].Text;
            lblTenDangNhap.Text = lstTaiKhoan.SelectedItems[0].SubItems[1].Text;
            cbbQuyenHan.Text = lstTaiKhoan.SelectedItems[0].SubItems[4].Text;
            if(lstTaiKhoan.SelectedItems[0].SubItems[5].Text=="Kích hoạt")
            {
                rdbKichHoat.Checked = true;
            }
            else
            {
                rdbTamNgung.Checked = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien form = new ThongTinNhanVien(lstTaiKhoan.SelectedItems[0].SubItems[2].Text);
            form.Show();
        }

        private void btnDatMKMacDinh_Click(object sender, EventArgs e)
        {
            if(BLL_TaiKhoan.Instance.UpdateMatKhau("12345", lstTaiKhoan.SelectedItems[0].SubItems[2].Text))
            {
                MessageBox.Show("Đặt lại mật khẩu mặc định thành công.");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(BLL_TaiKhoan.Instance.UpdateTrangThai(KichHoatTK.ToString(), lstTaiKhoan.SelectedItems[0].SubItems[2].Text) && BLL_TaiKhoan.Instance.UpdateThongTin("ChucVu", cbbQuyenHanText, lstTaiKhoan.SelectedItems[0].SubItems[2].Text))
            {
                MessageBox.Show("Lưu thành công.");
            }
        }

        private void cbbQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbQuyenHanText = cbbQuyenHan.SelectedItem.ToString();
        }

        private void rdbKichHoat_CheckedChanged(object sender, EventArgs e)
        {
            KichHoatTK = true;
        }

        private void rdbTamNgung_CheckedChanged(object sender, EventArgs e)
        {
            KichHoatTK = false;
        }
    }
}
