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
            string query = "select * from HoaDonThucAn";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetHoaDonByMaHD(string Ma)
        {
            DataTable dt = new DataTable();
            string query = "select * from HoaDonThucAn where MaHoaDon = '" + Ma + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetHoaDonByDate(string dt1, string dt2)
        {
            DataTable dt = new DataTable();
            string query = "select * from HoaDonThucAn where NgayTao between '" + dt1 + "' and '" + dt2 + "'";
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
        public bool InsertMaHoaDon(string MaHD, string NgayTao, string MaNV)
        {
            try
            {
                string query = "insert into HoaDonThucAn values ('" + MaHD + "', '" + NgayTao + "', '" + MaNV + "')";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool InsertMaHoaDon(string MaHD, string MaSP, int SL)
        {
            try
            {
                string query = "insert into ChiTietHDTA values ('" + MaHD + "', '" + MaSP + "', " + SL + ")";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public DataTable GetDoanhThuThucAn(int thang)
        {
            DataTable dt = new DataTable();
            string query = @"select count(HDTA.MaHoaDon) as SoLuongHD, sum(CTHD.SoLuong) as SoLuongSP, sum(SP.GiaBan) as DoanhThu from HoaDonThucAn HDTA join ChiTietHDTA CTHD
                            on HDTA.MaHoaDon = CTHD.MaHoaDon join Size_Price SP
                            on CTHD.MaSP = sp.MaSP join ThucAn TA
                            on SP.MaThucAn = TA.MaThucAn
                            where month(HDTA.NgayTao) = " + thang;
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
    }
}
