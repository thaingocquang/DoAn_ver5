using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DataTable GetPhimByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            string query = "exec USP_GetPhimByDateHaveParam @date";
            dt = DataProvider.Instance.ExecuteQueryParam(query, new object[] { date });
            return dt;
        }
        public DataTable GetAllPhim()
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.Phim";
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
        //public DataTable GetPhimByTimePeriod(DateTime time1, DateTime time2)
        //{
        //    DataTable dt = new DataTable();
        //    string query = 
        //}
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
        int DoTuoi, string NgayRaMat, string TrangThai, string DienVien, string Nuocsx, string NN,
        string Nhasx, int DoanhThu, string TomTat)
        {
            try
            {
                string query = "insert into Phim values " +
                    "('" + MaPhim + "', N'" + TenPhim + "', " + ThoiLuong + ", " + Namsx + ", " + DoTuoi + ", '" + NgayRaMat + "', " +
                    "'" + TrangThai + "', N'" + DienVien + "',N'" + Nuocsx + "',N'" + NN + "',N'" + Nhasx + "'," + DoanhThu + ", N'" + TomTat + "')";
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
        int DoTuoi, string NgayRaMat, string TrangThai, string DienVien, string Nuocsx, string NN,
        string Nhasx, int DoanhThu, string TomTat)
        {
            try
            {
                string query = "update Phim set TenPhim = N'" + TenPhim + "', ThoiLuong = " + ThoiLuong + ", NamSanXuat = " + Namsx + "," +
                    " GioiHanTuoi = " + DoTuoi + ",NgayRaMat = '" + NgayRaMat + "',TrangThai = '" + TrangThai + "', DienVien = N'" + DienVien 
                    + "', NuocSanXuat = N'" + Nuocsx + "', NgonNgu = N'" + NN + "', NhaSanXuat = N'" + Nhasx + "', DoanhThu = " + DoanhThu + ",TomTat = N'" + TomTat + "' where MaPhim = '"+ MaPhim + "'";
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
