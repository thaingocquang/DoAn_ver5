using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.DTO;

namespace DoAn_ver5.DAL
{
    class DAL_Phim
    {
        private static DAL_Phim _Instance;
        public static DAL_Phim Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Phim();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetPhimHaveSuatPhimByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            string query = @"select p.TenPhim from dbo.Phim p join dbo.SuatChieu sc
                            on p.MaPhim = sc.MaPhim
                            where sc.NgayGio = '" + date.Date.ToString() +"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetAllPhim()
        {
            DataTable dt = new DataTable();
            string query = "select * from Phim ";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }       
        public DataTable GetPhimByTenPhim(string TenPhim)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.Phim where TenPhim = N'" + TenPhim + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }       
         public DataTable GetPhimByDate1(string dt1, string dt2)
        {
            DataTable dt = new DataTable();
            string query = "select * from Phim where NgayRaMat between '" + dt1 + "' and '" + dt2 + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetPhimByMaPhim(string MaPhim)
        {
            DataTable dt = new DataTable();
            string query = "select * from Phim where MaPhim = N'" + MaPhim + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }

        public bool InsertPhim(string MaPhim, string TenPhim, int ThoiLuong, int Namsx,
        int DoTuoi, string NgayRaMat,  string DienVien, string Nuocsx,
        string Nhasx, int DoanhThu, string TomTat)
        {
            try
            {
                string query = "insert into Phim values " +
                    "('" + MaPhim + "', N'" + TenPhim + "', " + ThoiLuong + ", " + Namsx + ", " + DoTuoi + ", '" + NgayRaMat + "', N'" + DienVien + "',N'" + Nuocsx + "',N'" + Nhasx + "'," + DoanhThu + ", N'" + TomTat + "')";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdatePhim(string MaPhim, string TenPhim, int ThoiLuong, int Namsx,
        int DoTuoi, string NgayRaMat, string DienVien, string Nuocsx,
        string Nhasx, int DoanhThu, string TomTat)
        {
            try
            {
                string query = "update Phim set TenPhim = N'" + TenPhim + "', ThoiLuong = " + ThoiLuong + ", NamSanXuat = " + Namsx 
                    + ",GioiHanTuoi = " + DoTuoi + ", NgayRaMat = '" + NgayRaMat + "', DienVien = N'" + DienVien 
                    + "', NuocSanXuat = N'" + Nuocsx + "', NhaSanXuat = N'" + Nhasx + "', DoanhThu = " + DoanhThu + ",TomTat = N'" + TomTat + "' where MaPhim = '"+ MaPhim + "'";                
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool InsertSuatPhim(string MaSP, string MaPhim, string DinhDang, string HinhThuc, string NgonNgu)
        {
            try
            {
                string query = "insert into SuatPhim values ('"+MaSP+"', '"+MaPhim+"', '"+DinhDang+"',N'"+ HinhThuc+"', N'"+NgonNgu+"')";
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
