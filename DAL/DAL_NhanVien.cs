using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.DAL
{
    class DAL_NhanVien
    {
        private static DAL_NhanVien _Instance;
        public static DAL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_NhanVien();
                return _Instance;
            }
            set { }
        }
        private DAL_NhanVien()
        {

        }
        public DataTable GetAllNV()
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetNhanVienByTen(string Ten)
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien where HovaTen = N'" + Ten + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetNhanVienByChucVu(string ChucVu)
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien where ChucVu = N'" + ChucVu + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetNhanVienByCMND(string CMND)
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien where CMND = '" + CMND + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetNhanVienByMaNhanVien(string MaNV)
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien where MaNhanVien = '" + MaNV + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public bool InsertNhanVien(string MaNhanVien, string HovaTen, string NgaySinh, string GioiTinh, string DiaChi, int CMND, string Email, string SDT, string ChucVu, string NgayVaoLam, string TenDangNhap, string MatKhau, string TrangThai)
        {
            try
            {
                string query = "insert into NhanVien values  ('" + MaNhanVien + "', N'"+ HovaTen +"', '"+ NgaySinh + "', N'" + GioiTinh + "'," +
                    "N'" + DiaChi + "', " + CMND + ", N'" + Email + "', '" + SDT + "', N'" + ChucVu + "','"+ NgayVaoLam +"')";
                string s = "insert into TaiKhoan values ('"+MaNhanVien+"','"+TenDangNhap+"','"+MatKhau+"','"+TrangThai+"')";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool UpdateNhanVien(string HovaTen, string NgaySinh, string GioiTinh, string DiaChi,
            int CMND, string Email, string SDT, string ChucVu, string NgayVaoLam, string MaNhanVien)
        {
            try
            {
                
                string query = "update NhanVien set HovaTen = N'" + HovaTen+ "',NgaySinh = '" + NgaySinh+ "', GioiTinh = N'" + GioiTinh+ "', DiaChi = N'" + DiaChi 
                                                                + "', CMND = " + CMND + ", Email = '" + Email + "', SDT = '" + SDT + "', ChucVu = N'" 
                                                                + ChucVu + "', NgayVaoLam = '" + NgayVaoLam + "' where MaNhanVien='"+MaNhanVien+"'";
                
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
