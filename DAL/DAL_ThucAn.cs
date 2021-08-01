using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.DAL
{
    class DAL_ThucAn
    {
        private static DAL_ThucAn _Instance;
        public static DAL_ThucAn Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ThucAn();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetAllThucAn()
        {
            DataTable dt = new DataTable();
            string query = @"select TA.LoaiThucAn, TA.TenThucAn, KC.KichCo, KC.GiaBan from dbo.ThucAn TA join dbo.Size_Price KC on TA.MaThucAn = KC.MaThucAn";
            //join dbo.KichCoThucAn KC on TAs.MaKichCo = KC.MaKichCo";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetThucAnByTenThucAn(String Ten)
        {
            DataTable dt = new DataTable();
            string query = "select MaThucAn, TenThucAn, LoaiThucAn  from ThucAn where  TenThucAn = N'"+ Ten +"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetGiaTAByTenThucAn(string Ten)
        {
            DataTable dt = new DataTable();
            string query = "select SP.MaSP, SP.KichCo, SP.GiaBan from Size_Price SP join ThucAn TA on SP.MaThucAn = TA.MaThucAn where TA.TenThucAn " +
                " = N'" + Ten + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetThucAnByLoaiThucAn(string Loai)
        {
            DataTable dt = new DataTable();
            string query = "select MaThucAn, TenThucAn, LoaiThucAn from ThucAn where LoaiThucAn = N'" + Loai +"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        
        public DataTable GetThucAnByMaThucAn(string Ma)
        {
            DataTable dt = new DataTable();
            string query = "select MaThucAn, TenThucAn, LoaiThucAn from ThucAn where MaThucAn ='" + Ma +"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetThucAn()
        {
            DataTable dt = new DataTable();
            string query = "select MaThucAn, TenThucAn, LoaiThucAn from ThucAn ";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }

        public bool InsertThucAn(string MaThucAn, string LoaiThucAn, string TenThucAn)
        {
            try
            {
                string query = "insert into ThucAn values ('" + MaThucAn + "', N'"+ LoaiThucAn +"', N'"+ TenThucAn +"')";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool InsertCoThucAn(string KichCo, int GiaBan, string MaSP, string MaThucAn)
        {
            try
            {
                string query = "insert into Size_Price values ( N'"+ KichCo + "', "+ GiaBan +", '" + MaSP +"', '" + MaThucAn +"')";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

       

        public bool UpdateThucAn(string MaThucAn, string LoaiThucAn, string TenThucAn)
        {
            try
            {     
                string query = "update ThucAn set LoaiThucAn = N'"+ LoaiThucAn + "' , TenThucAn = N' "+ TenThucAn +"' where MaThucAn = '"+ MaThucAn + "'";    
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteCoThucAn(string MaSP, string KichCo, string MaTA)
        {
            try
            {
                string query = "delete from ChiTietHDTA where MaSP = '"  + MaSP + "'";
                string s = "delete from Size_Price where KichCo=N'" + KichCo + "' and MaThucAn='" + MaTA + "'";
                DataProvider.Instance.ExcuteDB(query);
                DataProvider.Instance.ExcuteDB(s);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
