using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_PhongChieu
    {
        private static DAL_PhongChieu _Instance;
        public static DAL_PhongChieu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_PhongChieu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetPhongChieuByTenPhongChieu(string TenPhongChieu)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.PhongChieu where TenPhongChieu = N'"+ TenPhongChieu +"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetAllPhongChieu()
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.PhongChieu ";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
    }
}
