using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DAL;
using System.Data;

namespace DoAn_ver5.BLL
{
    class BLL_KhachHang
    {
        private static BLL_KhachHang _Instance;
        public static BLL_KhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_KhachHang();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public bool CheckIsKhachHang(string MaKH)
        {
            foreach(DataRow row in DAL_KhachHang.Instance.GetAllKhachHang().Rows)
            {
                if (row["MaKhachHang"].ToString() == MaKH)
                    return true;
            }
            return false;
        }
        public string GetLoaiKhachHangByMaKH(string MaKH)
        {                        
            foreach (DataRow row in DAL_KhachHang.Instance.GetAllKhachHang().Rows)
            {
                if (row["MaKhachHang"].ToString() == MaKH)
                    return row["LoaiKhachHang"].ToString();
            }
            return null;
        }
        public DataTable GetlistDoanhThuKH(string tuNgay, string denNgay)
        {
            return DAL_KhachHang.Instance.GetlistDoanhThuKH(tuNgay, denNgay);
        }
        
        public DataTable GetAllKH()
        {
            return DAL_KhachHang.Instance.GetAllKhachHang();
        }
        public DataTable GetKHByTenKH(string TenKH)
        {
            return DAL_KhachHang.Instance.GetKhachHangByTenKH(TenKH);
        }
        public DataTable GetKHByCMND(string CMND)
        {
           return DAL_KhachHang.Instance.GetKhachHangByTCMND(CMND);
        }

    }
}
