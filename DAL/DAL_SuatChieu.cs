using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_SuatChieu
    {
        private static DAL_SuatChieu _Instance;
        public static DAL_SuatChieu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_SuatChieu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetSuatChieuByMaSuatChieu(string MaSuatChieu)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.SuatChieu where MaSuatChieu = '" + MaSuatChieu + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetSuatChieusByTenPhim(string tenPhim)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.SuatChieu join dbo.Phim on SuatChieu.MaPhim = Phim.MaPhim where Phim.TenPhim = N'" + tenPhim + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetDoanhThuByTimePeriod(string TenPhim, string TuNgay, string DenNgay)
        {
            DataTable dt = new DataTable();
            string query = @"select p.MaPhim, p.TenPhim, hdv.MaGhe, hdv.MaKhachHang, hdv.NgayBanVe, hdv.GiaVe from dbo.Phim p join dbo.SuatChieu sc
                            on p.MaPhim = sc.MaPhim join dbo.HoaDonVe hdv
                            on sc.MaSuatChieu = hdv.MaSuatChieu
                            where p.TenPhim = N'" + TenPhim + "' and hdv.NgayBanVe >= '" + TuNgay + "' and hdv.NgayBanVe <= '" + DenNgay + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetSuatChieuByDate(string TuNgay, string DenNgay)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.SuatChieu join dbo.Phim on SuatChieu.MaPhim = Phim.MaPhim where NgayGio between '" + TuNgay + "'and'" + DenNgay + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetAllSuatChieu()
        {
            DataTable dt = new DataTable();
            string query = "select * from SuatChieu join Phim on SuatChieu.MaPhim = Phim.MaPhim";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }

        public bool InsertSuatChieu()
        {
            try
            {
                string query = "insert into";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateSuatChieu(string MaPhim, string TenPhim, int ThoiLuong, int Namsx,
        int DoTuoi, string NgayRaMat, string TrangThai, string DienVien, string Nuocsx, string NN,
        string Nhasx, int DoanhThu, string TomTat)
        {
            try
            {
                string query = "update SuatChieu set TenPhim = N'" + TenPhim + "', ThoiLuong = " + ThoiLuong + ", NamSanXuat = " + Namsx + "," +
                    " GioiHanTuoi = " + DoTuoi + ",NgayRaMat = '" + NgayRaMat + "',TrangThai = '" + TrangThai + "', DienVien = N'" + DienVien
                    + "', NuocSanXuat = N'" + Nuocsx + "', NgonNgu = N'" + NN + "', NhaSanXuat = N'" + Nhasx + "', DoanhThu = " + DoanhThu + ",TomTat = N'" + TomTat + "' where MaPhim = '" + MaPhim + "'";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
