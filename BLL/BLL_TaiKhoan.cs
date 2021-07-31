using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DAL;

namespace DoAn_ver5.BLL
{
    class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan _Instance;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TaiKhoan();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetAllTaiKhoan()
        {
            return DAL_TaiKhoan.Instance.GetAllTaiKhoan();
        }
        public string GetMaNhanVien(string TaiKhoan, string MatKhau)
        {
            //string MaNV;
            foreach(DataRow row in DAL_TaiKhoan.Instance.GetAllTaiKhoan().Rows)
            {
                if (row["TenDangNhap"].ToString() == TaiKhoan && row["MatKhau"].ToString() == MatKhau)
                {
                    return(row["MaNhanVien"].ToString());
                }
            }
            return "";
        }
    }
}
