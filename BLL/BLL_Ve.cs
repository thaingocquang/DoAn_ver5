using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DTO;
using System.Data;
using DoAn_ver5.DAL;

namespace DoAn_ver5.BLL
{
    class BLL_Ve
    {
        private static BLL_Ve _Instance;
        public static BLL_Ve Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Ve();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        public List<DTO_GheNgoi> GetListGheBySuatChieu(string MaSuatChieu)
        {
            List<DTO_GheNgoi> list = new List<DTO_GheNgoi>();
            DataTable dt = DAL_Ve.Instance.GetListGheBySuatChieu(MaSuatChieu);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO_GheNgoi
                {
                    MaSuatChieu = row["MaSuatChieu"].ToString(),
                    MaGhe = row["MaGhe"].ToString(),
                    TinhTrang = (bool)row["TinhTrang"],
                    MaPhongChieu = row["MaPhongChieu"].ToString()
                });
            }
            return list;
        }
        public DataTable GetVe()
        {
            return DAL_Ve.Instance.GetVe();
        }
        public DataTable GetVeByTenKH(string TenKH)
        {
           return DAL_Ve.Instance.GetVeByTenKH(TenKH);
        }
        public DataTable GetVeByDate(string dt1, string dt2)
        {
           return DAL_Ve.Instance.GetVeByDate(dt1,dt2);
        }
        public DataTable GetVeByMaVe(string Ma)
        {
            return DAL_Ve.Instance.GetVeByMaVe(Ma);
        }
    }
}
