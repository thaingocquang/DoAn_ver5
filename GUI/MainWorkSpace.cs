using DoAn_ver5.GUI.DanhMuc;
using DoAn_ver5.GUI.HeThong;
using DoAn_ver5.GUI.NghiepVu;
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

namespace DoAn_ver5.GUI
{
    public partial class MainWorkSpace : Form
    {
        public MainWorkSpace()
        {
            InitializeComponent();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(SuatChieuControl.Instance))
            {
                panel4.Controls.Add(SuatChieuControl.Instance);
                SuatChieuControl.Instance.Dock = DockStyle.Fill;
                SuatChieuControl.Instance.BringToFront();
            }
            else
                SuatChieuControl.Instance.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(!panel4.Controls.Contains(PhimControl.Instance))
            {
                panel4.Controls.Add(PhimControl.Instance);
                PhimControl.Instance.Dock = DockStyle.Fill;
                PhimControl.Instance.BringToFront();
            }
            else
                PhimControl.Instance.BringToFront();
        }

        private void MainWorkSpace_Load(object sender, EventArgs e)
        {
            lblThongTinNhanVien.Text = "Xin chào, " + BLL_NhanVien.Instance.GetNhanVienByMaNhanVien(BLL_TaiKhoan.Instance.MaNhanVien).Rows[0]["HoVaTen"].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(ThucAnControl.Instance))
            {
                panel4.Controls.Add(ThucAnControl.Instance);
                ThucAnControl.Instance.Dock = DockStyle.Fill;
                ThucAnControl.Instance.BringToFront();
            }
            else
                ThucAnControl.Instance.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(NhanVienControl.Instance))
            {
                panel4.Controls.Add(NhanVienControl.Instance);
                NhanVienControl.Instance.Dock = DockStyle.Fill;
                NhanVienControl.Instance.BringToFront();
            }
            else
                NhanVienControl.Instance.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(BanVeControl.Instance))
            {
                panel6.Controls.Add(BanVeControl.Instance);
                BanVeControl.Instance.Dock = DockStyle.Fill;
                BanVeControl.Instance.BringToFront();
            }
            else
                BanVeControl.Instance.BringToFront();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(BanThucAnControl.Instance))
            {
                panel6.Controls.Add(BanThucAnControl.Instance);
                BanThucAnControl.Instance.Dock = DockStyle.Fill;
                BanThucAnControl.Instance.BringToFront();
            }
            else
                BanThucAnControl.Instance.BringToFront();
        }

        private void labelHoaDon_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(HoaDonControl.Instance))
            {
                panel4.Controls.Add(HoaDonControl.Instance);
                HoaDonControl.Instance.Dock = DockStyle.Fill;
                HoaDonControl.Instance.BringToFront();
            }
            else
                HoaDonControl.Instance.BringToFront();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(KhachHangControl.Instance))
            {
                panel4.Controls.Add(KhachHangControl.Instance);
                KhachHangControl.Instance.Dock = DockStyle.Fill;
                KhachHangControl.Instance.BringToFront();
            }
            else
                KhachHangControl.Instance.BringToFront();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (!panel4.Controls.Contains(VeControl.Instance))
            {
                panel4.Controls.Add(VeControl.Instance);
                VeControl.Instance.Dock = DockStyle.Fill;
                VeControl.Instance.BringToFront();
            }
            else
                VeControl.Instance.BringToFront();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(DoanhThu_KhoangThoiGianControl.Instance))
            {
                panel6.Controls.Add(DoanhThu_KhoangThoiGianControl.Instance);
                DoanhThu_KhoangThoiGianControl.Instance.Dock = DockStyle.Fill;
                DoanhThu_KhoangThoiGianControl.Instance.BringToFront();
            }
            else
                DoanhThu_KhoangThoiGianControl.Instance.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(DoanhThu_KhachHangControl.Instance))
            {
                panel6.Controls.Add(DoanhThu_KhachHangControl.Instance);
                DoanhThu_KhachHangControl.Instance.Dock = DockStyle.Fill;
                DoanhThu_KhachHangControl.Instance.BringToFront();
            }
            else
                DoanhThu_KhachHangControl.Instance.BringToFront();
        }

        

        private void label11_Click(object sender, EventArgs e)
        {
            if (BLL_NhanVien.Instance.IsQuyenQuanTri() == false)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
                return;
            }
            KetNoiCSDL frm = new KetNoiCSDL();
            frm.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(TaiKhoanControl.Instance))
            {
                panel2.Controls.Add(TaiKhoanControl.Instance);
                TaiKhoanControl.Instance.Dock = DockStyle.Fill;
                TaiKhoanControl.Instance.BringToFront();
            }
            else
                TaiKhoanControl.Instance.BringToFront();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblSaoLuuPhucHoi_Click(object sender, EventArgs e)
        {
            if (BLL_NhanVien.Instance.IsQuyenQuanTri() == false)
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
                return;
            }
            SaoLuuPhucHoi slph = new SaoLuuPhucHoi();
            slph.Show();
        }

        private void lblThongTinNhanVien_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien frm = new ThongTinNhanVien(BLL_TaiKhoan.Instance.MaNhanVien);
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(DoanhThu_HangThangControl.Instance))
            {
                panel6.Controls.Add(DoanhThu_HangThangControl.Instance);
                DoanhThu_HangThangControl.Instance.Dock = DockStyle.Fill;
                DoanhThu_HangThangControl.Instance.BringToFront();
            }
            else
                DoanhThu_HangThangControl.Instance.BringToFront();
        }
    }
}
