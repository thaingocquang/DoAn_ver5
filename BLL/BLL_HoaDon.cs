using DoAn_ver5.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.BLL
{
    class BLL_HoaDon
    {
        private static BLL_HoaDon _Instance;
        public static BLL_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDon();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetHoaDon()
        {
            return DAL_HoaDonThucAn.Instance.GetHoaDon(); 
        }
        public DataTable GetHoaDonByMaHD(string Ma)
        {
            return DAL_HoaDonThucAn.Instance.GetHoaDonByMaHD(Ma);
        }
        public DataTable GetHoaDonByDate(string dt1, string dt2)
        {
            return DAL_HoaDonThucAn.Instance.GetHoaDonByDate(dt1, dt2);
        }
        public DataTable GetThucAnByMaHD(string Ma)
        {
            return DAL_HoaDonThucAn.Instance.GetThucAnByMaHD(Ma);
        }
        public int GetTongTienByMHD(string MHD)
        {
            int TongTien = 0;           
            foreach(DataRow i in DAL_HoaDonThucAn.Instance.GetThucAnByMaHD(MHD).Rows)
            {
                int SoLuong = int.Parse(i["SoLuong"].ToString());
                int DonGia = int.Parse(i["GiaBan"].ToString());
                TongTien += SoLuong * DonGia;
            }
            return TongTien;
        }       
    }
}
