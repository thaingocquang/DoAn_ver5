using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_HoaDonVe
    {
        private static DAL_HoaDonVe _Instance;
        public static DAL_HoaDonVe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HoaDonVe();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public bool InsertHoaDonVe(string maSuatChieu, int maGhe, string ngayBanVe, string tenNV, float giaVe, string tenKH)
        {
            try
            {
                string query = "insert into dbo.HoaDonVe values " +
                    "('"+ maSuatChieu +"', "+ maGhe +", '"+ngayBanVe.ToString()+"', '"+ tenNV +"', " + giaVe + ", '"+tenKH+"')";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public DataTable GetAllHoaDonVe()
        {
            DataTable data = new DataTable();
            string query = "select * from dbo.HoaDonVe";
            data = DataProvider.Instance.GetRecords(query);
            return data;
        }
    }
}
