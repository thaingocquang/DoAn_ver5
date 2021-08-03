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
    class BLL_PhongChieu
    {
        private static BLL_PhongChieu _Instance;
        public static BLL_PhongChieu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PhongChieu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DTO_PhongChieu GetPhongChieuByName(string name)
        {
            DataRow row = DAL_PhongChieu.Instance.GetPhongChieuByTenPhongChieu(name).Rows[0];
            return new DTO_PhongChieu()
            {
                MaPhongChieu = row["MaPhongChieu"].ToString(),
                TenPhongChieu = row["TenPhongChieu"].ToString(),
                SoHangGhe = (int)row["SoHangGhe"],
                SoGheTren1Hang = (int)row["SoGhe1Hang"]
                 
            };
        }
        public DataTable GetAllPhongChieu()
        {
            DAL_PhongChieu
        }
    }
}
