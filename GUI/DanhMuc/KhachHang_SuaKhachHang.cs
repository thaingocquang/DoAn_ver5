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
    public partial class KhachHang_SuaKhachHang : Form
    {
        public KhachHang_SuaKhachHang(string Ten)
        {
            InitializeComponent();
            GUI(Ten);
        }

        public void GUI(string Ten)
        {
            if(BLL_KhachHang.Instance.GetKHByTenKH(Ten) != null)
            {
                DataTable dt = BLL_KhachHang.Instance.GetKHByTenKH(Ten);
                foreach(DataRow i in dt.Rows)
                {
                    txtMa.Text = i["MaKhachHang"].ToString();
                    txtTen.Text = i["TenKhachHang"].ToString();
                    txtCMND.Text = i["CMND"].ToString();
                    txtEmail.Text = i["Email"].ToString();
                    if (i["GioiTinh"].ToString() == rdNam.Text) rdNam.Checked = true;
                    else rdNu.Checked = true;
                    dtpNgayDK.Value = Convert.ToDateTime(i["NgayDangKy"].ToString());
                    txtSDT.Text = i["SDT"].ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(i["NgaySinh"].ToString());
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_KhachHang.Instance.UpdateKhachHang
                (                  
                    txtTen.Text.Trim(),
                    rdNam.Checked == true ? rdNam.Text : rdNu.Text,
                    dtpNgaySinh.Value.ToString("yyyy/MM/dd"),
                    txtEmail.Text.Trim(),
                    txtSDT.Text.Trim(),
                    dtpNgaySinh.Value.ToString("yyyy/MM/dd"),
                    int.Parse(txtCMND.Text.Trim()),
                    txtMa.Text.Trim()
                );
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
