using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DTO;
using DoAn_ver5.DAL;

namespace DoAn_ver5.BLL
{
    class BLL_SuatChieu
    {
        private static BLL_SuatChieu _Instance;
        public static BLL_SuatChieu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SuatChieu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DTO_SuatChieu GetSuatChieuByMaSuatChieu(string MaSuatChieu)
        {
            DataRow row = DAL_SuatChieu.Instance.GetSuatChieuByMaSuatChieu(MaSuatChieu).Rows[0];
            return new DTO_SuatChieu
            {
                MaSuatChieu = row["MaSuatChieu"].ToString(),
                PhongChieu = row["TenPhongChieu"].ToString(),
                NgayGio = (DateTime)row["NgayGio"],
                GiaVe = int.Parse(row["GiaVe"].ToString())
            };
        }
        public DataTable GetSuatChieusByTenPhimAndDate(string tenPhim, DateTime Ngay)
        {
            return DAL_SuatChieu.Instance.GetSuatChieusByTenPhimAndDate(tenPhim, Ngay);
        }
        public DataTable GetSuatChieusByTenPhim(string tenPhim)
        {
            return DAL_SuatChieu.Instance.GetSuatChieusByTenPhim(tenPhim);
        }

        public DataTable GetDoanhThuByTimePeriod(string TenPhim, string TuNgay, string DenNgay)
        {
            return DAL_SuatChieu.Instance.GetDoanhThuByTimePeriod(TenPhim, TuNgay, DenNgay);
        }
        public DataTable GetSuatChieuByDate(string dt1, string dt2)
        {
            return DAL_SuatChieu.Instance.GetSuatChieuByDate(dt1, dt2);
        }

        public DataTable GetAllSuatChieu()
        {
            return DAL_SuatChieu.Instance.GetAllSuatChieu();
        }
        public DataTable GetSuatPhimByMaPhim(string s)
        {
            return DAL_SuatChieu.Instance.GetSuatPhimByMaPhim(s);
        }
    }
}
