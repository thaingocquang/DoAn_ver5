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
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class BanVe_ChonGhe : Form
    {
        DTO_SuatChieu SuatChieu;
        DTO_Phim Phim;
        DTO_PhongChieu PhongChieu;

        int SizeGhe = 30;
        int KhoangCachGhe = 7;

        List<DTO_GheNgoi> listGhe = new List<DTO_GheNgoi>();
        List<Button> listGheDaChon = new List<Button>();
        List<string> listMaGheDaChon = new List<string>();

        public BanVe_ChonGhe(string MaSuatChieu)
        {
            InitializeComponent();
            SuatChieu = BLL_SuatChieu.Instance.GetSuatChieuByMaSuatChieu(MaSuatChieu);
            Phim = BLL_Phim.Instance.GetDTOPhimByMaPhim(SuatChieu.MaPhim);
            PhongChieu = BLL_PhongChieu.Instance.GetPhongChieuByMaPhongChieu(SuatChieu.PhongChieu);
        }

        private void BanVe_ChonGhe_Load(object sender, EventArgs e)
        {
            lblThongTin.Text = "PBL3 Movie Theater Project | "
                + PhongChieu.TenPhongChieu + " | " + Phim.TenPhim;
            lblThoiGian.Text = SuatChieu.NgayGio.Date.ToString();
            LoadPhongChieu(SuatChieu.PhongChieu);
            listGhe = BLL_Ve.Instance.GetListGheBySuatChieu(SuatChieu.MaSuatChieu);
            LoadGhe(listGhe);
        }

        private void LoadGhe(List<DTO_GheNgoi> listGhe)
        {
            int a = 0;
            int count = 0;
            char[] Alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'L', 'M', 'N', 'O' };
            panelChonGhe.Controls.Clear();
            for(int i=0; i<PhongChieu.SoHangGhe; i++)
            {
                for(int j=0; j<PhongChieu.SoGheTren1Hang; j++)
                {
                    Button btnSeat = new Button() { Width = SizeGhe + 20, Height = SizeGhe };
                    btnSeat.Text = Alpha[a] + j.ToString();
                    if (listGhe[count++].TinhTrang == true)
                        btnSeat.BackColor = Color.Red;
                    else
                        btnSeat.BackColor = Color.White;
                    btnSeat.Click += BtnSeat_Click;
                    panelChonGhe.Controls.Add(btnSeat);

                    btnSeat.Tag = listGhe[i].MaGhe;
                }
                a++;
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Color.White)
            {             
                btnSeat.BackColor = Color.Yellow;
                listGheDaChon.Add(btnSeat);
            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                btnSeat.BackColor = Color.White;
                listGheDaChon.Remove(btnSeat);
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }   
        }

        private void LoadPhongChieu(string phongChieu)
        {
            DTO_PhongChieu PhongChieu = BLL_PhongChieu.Instance.GetPhongChieuByMaPhongChieu(SuatChieu.PhongChieu);
            int row = PhongChieu.SoHangGhe;
            int col = PhongChieu.SoGheTren1Hang;
            panelChonGhe.Size = new Size((SizeGhe + 20 + KhoangCachGhe) * col, (SizeGhe + KhoangCachGhe) * row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi thanh toán!");
                return;
            }
            BanVe_LuuVeBan frm = new BanVe_LuuVeBan(Phim, SuatChieu, PhongChieu,listGheDaChon);
            frm.ShowDialog();
            ReLoad();
        }

        private void ReLoad()
        {
            LoadPhongChieu(SuatChieu.PhongChieu);
            listGhe = BLL_Ve.Instance.GetListGheBySuatChieu(SuatChieu.MaSuatChieu);
            LoadGhe(listGhe);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
