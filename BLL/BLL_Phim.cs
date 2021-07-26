using DoAn_ver5.DAL;
using DoAn_ver5.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.BLL
{
    class BLL_Phim
    {
        private static BLL_Phim _Instance;
        public static BLL_Phim Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Phim();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        public DataTable GetPhimByDate(DateTime date)
        {
            return DAL_Phim.Instance.GetPhimByDate(date);           
        }
        public DTO_Phim GetPhimByTenPhim(string TenPhim)
        {
            DataTable dt = DAL_Phim.Instance.GetPhimByTenPhim(TenPhim);
            DataRow r = dt.Rows[0];
            return new DTO_Phim(r);
        }
       public DataTable GetAllPhim()
        {
            return DAL_Phim.Instance.GetAllPhim();
        }
        public DataTable GetPhimByTenPhim1(string Name)
        {
            return DAL_Phim.Instance.GetPhimByTenPhim(Name);
        }
        public DataTable GetPhimByDate1(string dt1, string dt2)
        {
            return DAL_Phim.Instance.GetPhimByDate1(dt1, dt2);
        }
        public DataTable GetPhimByMaPhim(string MaPhim)
        {
            return DAL_Phim.Instance.GetPhimByMaPhim(MaPhim);
        }
    }
}
