using DoAn_ver5.DAL;
using DoAn_ver5.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.BLL
{
    class BLL_NhanVien
    {
        private static BLL_NhanVien _Instance;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_NhanVien();
                return _Instance;
            }
            set { }
        }
        private BLL_NhanVien()
        {

        }
       

        public DataTable GetAllNhanVien()
        {
            return DAL_NhanVien.Instance.GetAllNV();
        }
        public DataTable GetNhanVienByTen(string Ten)
        {
            return DAL_NhanVien.Instance.GetNhanVienByTen(Ten);
        }

        public DataTable GetNhanVienByChucVu(string ChucVu)
        {
            return DAL_NhanVien.Instance.GetNhanVienByChucVu(ChucVu);
        }

        public DataTable GetNhanVienByCMND(string CMND)
        {
            return DAL_NhanVien.Instance.GetNhanVienByCMND(CMND);
        }
        public DataTable GetNhanVienByMaNhanVien(string MaNV)
        {
            return DAL_NhanVien.Instance.GetNhanVienByMaNhanVien(MaNV);
        }
        public bool IsQuyenQuanTri()
        {
            DataTable dt = DAL_NhanVien.Instance.GetNhanVienByMaNhanVien(BLL_TaiKhoan.Instance.MaNhanVien);
            if (dt.Rows[0]["ChucVu"].ToString() == "Quản trị viên")

                return true;
            else
                return false;
        }
        public bool IsQuyenBanVe()
        {
            if (IsQuyenQuanTri() == true) return true;
            DataTable dt = DAL_NhanVien.Instance.GetNhanVienByMaNhanVien(BLL_TaiKhoan.Instance.MaNhanVien);
            if (dt.Rows[0]["ChucVu"].ToString() == "Bán vé")
                return true;
            else
                return false;
        }
        public bool IsQuyenBanThucAn()
        {
            if (IsQuyenQuanTri() == true) return true;
            DataTable dt = DAL_NhanVien.Instance.GetNhanVienByMaNhanVien(BLL_TaiKhoan.Instance.MaNhanVien);
            if (dt.Rows[0]["ChucVu"].ToString() == "Bán thức ăn")
                return true;
            else
                return false;
        }
    }
}
