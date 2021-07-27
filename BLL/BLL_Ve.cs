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

        public List<DTO_Ve> GetListVeBySuatChieu(string MaSuatChieu)
        {
            List<DTO_Ve> list = new List<DTO_Ve>();
            foreach (DataRow row in DAL_Ve.Instance.GetListVeBySuatChieu(MaSuatChieu).Rows)
            {
                list.Add(new DTO_Ve
                {
                    ChoNgoi = row["MaGhe"].ToString(),
                    Status = (bool)row["TinhTrang"]
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
