﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_SuatChieu
    {
        private static DAL_SuatChieu _Instance;
        public static DAL_SuatChieu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_SuatChieu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetSuatChieuByMaSuatChieu(string MaSuatChieu)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.SuatChieu where MaSuatChieu = '" + MaSuatChieu + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetSuatChieusByTenPhim(string tenPhim)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.SuatChieu join dbo.Phim on SuatChieu.MaPhim = Phim.MaPhim where Phim.TenPhim = N'" + tenPhim + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetDoanhThuByTimePeriod(string TenPhim, string TuNgay, string DenNgay)
        {
            DataTable dt = new DataTable();
            string query = @"select p.MaPhim, p.TenPhim, hdv.MaGhe, hdv.MaKhachHang, hdv.NgayBanVe, hdv.GiaVe from dbo.Phim p join dbo.SuatChieu sc
                            on p.MaPhim = sc.MaPhim join dbo.HoaDonVe hdv
                            on sc.MaSuatChieu = hdv.MaSuatChieu
                            where p.TenPhim = N'" + TenPhim + "' and hdv.NgayBanVe >= '" + TuNgay + "' and hdv.NgayBanVe <= '" + DenNgay + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetSuatChieuByDate(string TuNgay, string DenNgay)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.SuatChieu join dbo.Phim on SuatChieu.MaPhim = Phim.MaPhim where NgayGio between '" + TuNgay + "'and'" + DenNgay + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetAllSuatChieu()
        {
            DataTable dt = new DataTable();
            string query = "select * from SuatChieu sc join Phim  p on sc.MaPhim = p.MaPhim join SuatPhim sp on sc.MaSuatChieu = sp.MaSuatChieu";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }

        public DataTable GetSuatPhimByMaPhim(string MaPhim)
        {
            DataTable dt = new DataTable();
            string query = "select MaSuatPhim, DinhDang, HinhThuc, NgonNgu from Phim p join SuatPhim sp on p.MaPhim = sp.MaPhim where p.MaPhim = '"+ MaPhim +"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public bool InsertSuatChieu(string MaPhim, string MaSC, string MaSP, string Phong, string ThoiGian, string TrangThai,
            string DinhDang, string HinhThuc, string NgonNgu,int GiaVe)
        {
            try
            {
                string query = "insert into SuatChieu values ('" + MaPhim+"','"+ MaSC +"', '" + ThoiGian + "', N'" +TrangThai +"', N'"+Phong+"',"+GiaVe+", '"+MaSP+"')";
                string s = "insert into SuatPhim values ('"+MaSP+"', '"+DinhDang+"', N'"+HinhThuc+"', N'"+NgonNgu+"')";         
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

        public bool UpdateSuatChieu(string MaPhim, string MaSC, string MaSP, string Phong, string ThoiGian, string TrangThai,
            string DinhDang, string HinhThuc, string NgonNgu, int GiaVe)
        {
            try
            {
                string query = "update SuatChieu set MaPhim = '"+MaPhim+"', NgayGio = '"+ThoiGian+"', TrangThai = N'"+TrangThai+"', TenPhongChieu = N'"+Phong+"', GiaVe = "+GiaVe+" where MaSuatChieu = '" + MaSC + "'";
                string s = "update SuatPhim set  MaPhim = '"+MaPhim+"', DinhDang = '"+DinhDang+"', HinhThuc = N'"+HinhThuc+"', NgonNgu = N'"+NgonNgu+"' where MaSuatPhim = '"+MaSP+"'";
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
        public bool InsertGheNgoi(string MaSuatChieu, string MaGhe, string TinhTrang, string MaPhongChieu )
        {
            try
            {
                string query = "insert into GheNgoi values ('"+MaSuatChieu+"', '"+MaGhe+"', '"+TinhTrang+"', '"+MaPhongChieu+"')";
                DataProvider.Instance.ExcuteDB(query);
              
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
