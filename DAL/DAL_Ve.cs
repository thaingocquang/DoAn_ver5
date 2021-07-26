using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_Ve
    {
        private static DAL_Ve _Instance;
        public static DAL_Ve Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Ve();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetListVeBySuatChieu(string MaSuatChieu)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.GheNgoi join dbo.SuatChieu on GheNgoi.MaSuatChieu = SuatChieu.MaSuatChieu";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public void SetTrangThaiVe(string maVe)
        {
            string query = "update dbo.GheNgoi set TinhTrang = 'true' where MaGhe = '" + maVe + "'";
            DataProvider.Instance.ExcuteDB(query);
        }
        public DataTable GetVe()
        {
            DataTable dt = new DataTable();
            string query = "select HDV.MaHoaDonVe, HDV.MaSuatChieu, HDV.MaGhe, HDV.NgayBanVe, HDV.GiaVe, NV.HovaTen, KH.TenKhachHang from HoaDonVe HDV" +
                " join NhanVien NV on HDV.MaNhanVien = NV.MaNhanVien " +
                " join KhachHang KH on HDV.MaKhachHang = KH.MaKhachHang";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetVeByMaVe(string Ma)
        {
            DataTable dt = new DataTable();
            string query = "select HDV.MaHoaDonVe, HDV.MaSuatChieu, HDV.MaGhe, HDV.NgayBanVe, HDV.GiaVe, NV.HovaTen, KH.TenKhachHang from HoaDonVe HDV" +
                " join NhanVien NV on HDV.MaNhanVien = NV.MaNhanVien " +
                " join KhachHang KH on HDV.MaKhachHang = KH.MaKhachHang where HDV.MaHoaDonVe = " + Ma ;
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetVeByTenKH(string TenKH)
        {
            DataTable dt = new DataTable();
            string query = "select HDV.MaHoaDonVe,HDV.MaSuatChieu, HDV.MaGhe, HDV.NgayBanVe, HDV.GiaVe, NV.HovaTen, KH.TenKhachHang from HoaDonVe HDV" +
                " join NhanVien NV on HDV.MaNhanVien = NV.MaNhanVien " +
                " join KhachHang KH on HDV.MaKhachHang = KH.MaKhachHang where KH.TenKhachHang = N'" + TenKH + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetVeByDate(string dt1, string dt2)
        {
            DataTable dt = new DataTable();
            string query = "select HDV.MaHoaDonVe, HDV.MaSuatChieu, HDV.MaGhe, HDV.NgayBanVe, HDV.GiaVe, NV.HovaTen, KH.TenKhachHang from HoaDonVe HDV" +
                " join NhanVien NV on HDV.MaNhanVien = NV.MaNhanVien " +
                " join KhachHang KH on HDV.MaKhachHang = KH.MaKhachHang where HDV.NgayBanVe between '" + dt1 + "' and '" + dt2 + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
    }
}
