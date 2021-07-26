using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_HoaDonThucAn
    {
        private static DAL_HoaDonThucAn _Instance;
        public static DAL_HoaDonThucAn Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HoaDonThucAn();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        public DataTable GetHoaDon()
        {
            DataTable dt = new DataTable();
            string query = "select MaHoaDon, NgayTao, MaNhanVien from HoaDonThucAn";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetHoaDonByMaHD(string Ma)
        {
            DataTable dt = new DataTable();
            string query = "select MaHoaDon, NgayTao, MaNhanVien from HoaDonThucAn where MaHoaDon = '" + Ma + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetHoaDonByDate(string dt1, string dt2)
        {
            DataTable dt = new DataTable();
            string query = "select MaHoaDon, NgayTao, MaNhanVien from HoaDonThucAn where NgayTao between '" + dt1 + "' and '" + dt2 + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetThucAnByMaHD(string MaHD)
        {
            DataTable dt = new DataTable();
            string query = "select TA.MaThucAn, TA.TenThucAn, CT.Soluong, SP.KichCo, SP.GiaBan from HoaDonThucAn HDTA join ChiTietHDTA CT " +
                "on HDTA.MaHoaDon = CT.MaHoaDon join Size_Price SP " +
                "on CT.MaSP = SP.MaSP join ThucAn TA " +
                "on SP.MaThucAn = TA.MaThucAn where HDTA.MaHoaDon = '" + MaHD + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }     
        public DataTable GetTA()
        {
            DataTable dt = new DataTable();
            string query = "select TA.MaThucAn, TA.TenThucAn, CT.Soluong, SP.KichCo, SP.GiaBan from HoaDonThucAn HDTA join ChiTietHDTA CT " +
                "on HDTA.MaHoaDon = CT.MaHoaDon join Size_Price SP " +
                "on CT.MaSP = SP.MaSP join ThucAn TA " +
                "on SP.MaThucAn = TA.MaThucAn";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
    }
}
