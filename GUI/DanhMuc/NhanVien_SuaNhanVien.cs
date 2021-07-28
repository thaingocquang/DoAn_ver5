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
    public partial class NhanVien_SuaNhanVien : Form
    {
        public NhanVien_SuaNhanVien(string Tennv)
        {
            InitializeComponent();
            SetGUI(Tennv);
        }

        public void SetGUI(string Tennv)
        {
            if (BLL_NhanVien.Instance.GetNhanVienByTen(Tennv) != null)
            {
                DataTable dt = BLL_NhanVien.Instance.GetNhanVienByTen(Tennv);
                foreach(DataRow i in dt.Rows)
                {
                    txtMaNV.Text = i["MaNhanVien"].ToString();
                    txtTen.Text = i["HovaTen"].ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(i["NgaySinh"].ToString());
                    txtDiaChi.Text = i["DiaChi"].ToString();
                    txtCMND.Text = i["CMND"].ToString();
                    if (i["GioiTinh"].ToString() == rdNam.Text) rdNam.Checked = true;
                    else rdNu.Checked = true;
                    txtEmail.Text = i["Email"].ToString();
                    txtSDT.Text = i["SDT"].ToString();
                    cbbChucVu.SelectedItem = i["ChucVu"].ToString();
                    dtpNgayLam.Value = Convert.ToDateTime(i["NgayVaoLam"].ToString());
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_NhanVien.Instance.UpdateNhanVien
                (
                    txtTen.Text.Trim(),
                    dtpNgaySinh.Value.Date.ToString("yyyy/MM/dd"),
                    rdNam.Checked == true ? rdNam.Text : rdNu.Text,
                    txtDiaChi.Text.Trim(),
                    int.Parse(txtCMND.Text.Trim()),
                    txtEmail.Text.Trim(),
                    txtSDT.Text.Trim(),
                    cbbChucVu.SelectedItem.ToString(),
                    dtpNgayLam.Value.Date.ToString("yyyy/MM/dd"),
                    txtMaNV.Text.Trim()
                );
            this.Close();
        }
    }
}
