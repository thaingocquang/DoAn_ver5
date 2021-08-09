using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan _Instance;
        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_TaiKhoan();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetAllTaiKhoan()
        {
            DataTable dt = new DataTable();
            string query = @"select tk.MaNhanVien, tk.TenDangNhap, tk.MatKhau, tk.TrangThai, nv.MaNhanVien, nv.HoVaTen, nv.ChucVu from dbo.TaiKhoan tk join dbo.NhanVien nv
                            on tk.MaNhanVien = nv.MaNhanVien";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetNhanVienByUserAndPassword(string user, string pass)
        {
            DataTable dt = new DataTable();
            string query = @"select * from dbo.TaiKhoan where TenDangNhap = '" + user + "' and MatKhau = '"+pass+"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetTaiKhoanByMaNhanVien(string MaNV)
        {
            DataTable dt = new DataTable();
            string query = @"select * from dbo.TaiKhoan where MaNhanVien = '" + MaNV+"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public bool UpdateThongTin(string ThuocTinh, string Text, string MaNhanVien)
        {
            try
            {
                string query = "update NhanVien set " + ThuocTinh + " = " + Text + " where MaNhanVien = '" + MaNhanVien + "'";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool UpdateMatKhau(string MatKhau, string MaNhanVien) 
        {
            try
            {
                string query = "update TaiKhoan set MatKhau = '"+MatKhau+"' where MaNhanVien = '"+MaNhanVien+"'";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool UpdateTrangThai(string trangThai, string MaNhanVien)
        {
            try
            {
                string query = "update TaiKhoan set TrangThai = '" + trangThai + "' where MaNhanVien = '" + MaNhanVien + "'";
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
