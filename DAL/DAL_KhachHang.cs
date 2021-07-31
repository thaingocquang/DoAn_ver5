using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.DAL
{
    class DAL_KhachHang
    {
        private static DAL_KhachHang _Instance;
        public static DAL_KhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_KhachHang();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetAllKhachHang()
        {
            DataTable data = new DataTable();
            string query = "select * from dbo.KhachHang";
            data = DataProvider.Instance.GetRecords(query);
            return data;
        }
        public DataTable GetKhachHangByMaKH(string MaKH)
        {
            DataTable data = new DataTable();
            string query = "select * from dbo.KhachHang where MaKhachHang = '" + MaKH + "'";
            data = DataProvider.Instance.GetRecords(query);
            return data;
        }
        public DataTable GetDoanhThuKH()
        {
            DataTable data = new DataTable();
            string query = @"select kh.MaKhachHang, kh.TenKhachHang, kh.NgayDangKy, kh.LoaiKhachHang, sum(hdv.GiaVe) as [DoanhThu] from dbo.SuatChieu sc join dbo.HoaDonVe hdv
                            on sc.MaSuatChieu = hdv.MaSuatChieu join dbo.KhachHang kh
                            on hdv.MaKhachHang = kh.MaKhachHang
                            group by kh.MaKhachHang, kh.TenKhachHang, kh.NgayDangKy, kh.LoaiKhachHang, hdv.GiaVe";
            data = DataProvider.Instance.GetRecords(query);
            return data;
        }
        public DataTable GetKhachHangByTenKH(string Ten)
        {
            DataTable data = new DataTable();
            string query = "select * from KhachHang where TenKhachHang = N'"+ Ten + "'";
            data = DataProvider.Instance.GetRecords(query);
            return data;
        }

        public DataTable GetKhachHangByTCMND(string CMND)
        {
            DataTable data = new DataTable();
            string query = "select * from KhachHang where CMND = '" + CMND + "'";
            data = DataProvider.Instance.GetRecords(query);
            return data;
        }
        public bool InsertKhachHang(string MaKhachHang, string TenKhachHang, string GioiTinh, int CMND, string NgaySinh, string Email, string SDT, string NgayDangKi)
        {
            try
            {
                string query = "insert into KhachHang (MaKhachHang, TenKhachHang, GioiTinh, CMND, NgaySinh, Email, SDT, NgayDangKi) values ( N'" + MaKhachHang + "',N'" + TenKhachHang + "',N'" + GioiTinh + "'," + CMND + ",'" + NgaySinh +
                    "','" + Email + "',N'" + SDT + "','" + NgayDangKi + "')";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateKhachHang( string TenKhachHang, string GioiTinh, string NgaySinh, string Email, string SDT, string NgayDangKi, int CMND, string MaKhachHang)
        {
            try
            {
                string query = "update KhachHang set TenKhachHang = N'" + TenKhachHang + "', GioiTinh = N'" + GioiTinh +"' , NgaySinh = '" + NgaySinh +"', Email = '" + Email + "', SDT = N'" + SDT + "', NgayDangKy = '" + NgayDangKi + "', CMND = " + CMND + " where MaKhachHang = N'" + MaKhachHang +"'" ;
                MessageBox.Show(query);
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
