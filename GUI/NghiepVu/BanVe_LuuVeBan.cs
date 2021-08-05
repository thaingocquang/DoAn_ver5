using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.DTO;
using DoAn_ver5.DAL;
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class BanVe_LuuVeBan : Form
    {
        DTO_Phim Phim;
        DTO_SuatChieu SuatChieu;
        DTO_PhongChieu PhongChieu;
        List<Button> listGheDaChon;
        public BanVe_LuuVeBan(DTO_Phim phim, DTO_SuatChieu suatChieu, DTO_PhongChieu phongChieu, List<Button> list)
        {
            InitializeComponent();
            Phim = phim;
            SuatChieu = suatChieu;
            PhongChieu = phongChieu;
            listGheDaChon = list;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BanVe_LuuVeBan_Load(object sender, EventArgs e)
        {
            txtMaSuatChieu.Text = SuatChieu.MaSuatChieu;
            txtTenPhim.Text = Phim.TenPhim;
            txtPhongChieu.Text = PhongChieu.TenPhongChieu;
            txtGioChieu.Text = SuatChieu.NgayGio.ToString();
            
            foreach(Button btn in listGheDaChon)
            {
                ListViewItem lvi = new ListViewItem(btn.Text);
                lvi.SubItems.Add(SuatChieu.GiaVe + "");
                lstVeDaChon.Items.Add(lvi);
            }
        }                      

        private void txtKiemTra_Click(object sender, EventArgs e)
        {            
            CheckKhuyenMai();
            CheckTongTien();
        }

        private void CheckTongTien()
        {
            if (txtKhuyenMai.Text == "Không")
            {
                txtTongTien.Text = (SuatChieu.GiaVe*listGheDaChon.Count).ToString();
            }
            if (txtKhuyenMai.Text == "VIP")
            {
                txtTongTien.Text = (SuatChieu.GiaVe * listGheDaChon.Count/2).ToString();
            }
            if (txtKhuyenMai.Text == "Thường")
            {
                txtTongTien.Text = ((SuatChieu.GiaVe * listGheDaChon.Count * 75) / 100).ToString();
            }
        }

        private void CheckKhuyenMai()
        {
            if (txtMaKH.Text == "")
                txtKhuyenMai.Text = "Không";
            if (BLL_KhachHang.Instance.CheckIsKhachHang(txtMaKH.Text))
            {
                txtKhuyenMai.Text = BLL_KhachHang.Instance.GetLoaiKhachHangByMaKH(txtMaKH.Text);
            }
            else
            {
                txtKhuyenMai.Text = "Không";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (Button btn in listGheDaChon)
            {
                DAL_HoaDonVe.Instance.InsertHoaDonVe(txtMaSuatChieu.Text, btn.Text, dateTimePicker1.Value.Date.ToString(), "TNQ", float.Parse(txtTongTien.Text)/listGheDaChon.Count, txtMaKH.Text);
                DAL_Ve.Instance.SetTrangThaiVe(btn.Tag.ToString());
            }
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
