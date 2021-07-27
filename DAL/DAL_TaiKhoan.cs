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
            string query = @"select tk.MaNhanVien, tk.TenDangNhap, tk.MatKhau, tk.TrangThai, nv.MaNhanVien, nv.HoVaTen from dbo.TaiKhoan tk join dbo.NhanVien nv
on tk.MaNhanVien = nv.MaNhanVien";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
    }
}
