using System;
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
        public DataTable GetSuatChieusByTenPhim(string TenPhim)
        {
            DataTable dt = new DataTable();
            string query = "select sc.MaSuatChieu, sc.MaPhim, p.TenPhim, sc.NgayGio, sp.DinhDang, sp.HinhThuc, sp.NgonNgu, pc.TenPhongChieu, sc.TrangThai," +
                " sp.MaSuatPhim from SuatChieu sc join Phim  p on sc.MaPhim = p.MaPhim join SuatPhim sp on sc.MaSuatPhim = sp.MaSuatPhim " +
                "join PhongChieu pc on pc.MaPhongChieu = sc.MaPhongChieu where TenPhim = '" + TenPhim + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetSuatChieusByTenPhimAndDate(string tenPhim, DateTime Ngay)
        {
            DataTable dt = new DataTable();
            //string query = @"select sc.MaSuatChieu, sc.NgayGio, sp.DinhDang, sp.HinhThuc, sp.NgonNgu, pc.TenPhongChieu, sc.TrangThai 
            //                from dbo.SuatChieu sc join dbo.Phim p
            //                on sc.MaPhim = p.MaPhim
            //                join dbo.SuatPhim sp
            //                on sp.MaSuatChieu = sc.MaSuatChieu
            //                join dbo.PhongChieu pc
            //                on pc.MaPhongChieu = sc.MaPhongChieu
            //                where p.TenPhim = N'"+ tenPhim +"' and sc.NgayGio = '"+ Ngay.Date.ToString() +"'";
            string query = @"select sc.MaSuatChieu, sc.NgayGio, sp.DinhDang, sp.HinhThuc, sp.NgonNgu, pc.TenPhongChieu, sc.TrangThai 
                            from dbo.SuatChieu sc join dbo.SuatPhim sp
                            on sc.MaSuatPhim = sp.MaSuatPhim
                            join dbo.Phim p
                            on sp.MaPhim = p.MaPhim
                            join dbo.PhongChieu pc
                            on pc.MaPhongChieu = sc.MaPhongChieu
                            where p.TenPhim = N'" + tenPhim + "' and convert(date, sc.NgayGio) = '" + Ngay.Date.ToString() +"'";
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
            string query = "select sc.MaSuatChieu, sc.MaPhim, p.TenPhim, sc.NgayGio, sp.DinhDang, sp.HinhThuc, sp.NgonNgu, pc.TenPhongChieu, sc.TrangThai," +
                " sp.MaSuatPhim from SuatChieu sc join Phim  p on sc.MaPhim = p.MaPhim join SuatPhim sp on sc.MaSuatPhim = sp.MaSuatPhim " +
                "join PhongChieu pc on pc.MaPhongChieu = sc.MaPhongChieu where NgayGio between '" + TuNgay + "'and'" + DenNgay + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetAllSuatChieu()
        {
            DataTable dt = new DataTable();
            string query = "select* from SuatChieu sc join SuatPhim sp on sc.MaSuatPhim = sp.MaSuatPhim join Phim p on p.MaPhim = sp.MaPhim join PhongChieu pc on pc.MaPhongChieu = sc.MaPhongChieu";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public DataTable GetSuatPhimByMaPhim(string MaPhim)
        {
            //DataTable dt = new DataTable();
            ////string query = "select MaSuatPhim, DinhDang, HinhThuc, NgonNgu from Phim p join SuatPhim sp on p.MaPhim = sp.MaPhim where p.MaPhim = '"+ MaPhim +"'";
            //string query = @"select sp.MaSuatPhim, sp.DinhDang, sp.HinhThuc, sp.NgonNgu from Phim p join SuatChieu sc
            //                on p.MaPhim = sc.MaPhim
            //                join SuatPhim sp on sc.MaSuatPhim = sp.MaSuatPhim
            //                where p.MaPhim = '"+ MaPhim +"'";
            //dt = DataProvider.Instance.GetRecords(query);
            //return dt;
            DataTable dt = new DataTable();
            //string query = "select MaSuatPhim, DinhDang, HinhThuc, NgonNgu from Phim p join SuatPhim sp on p.MaPhim = sp.MaPhim where p.MaPhim = '"+ MaPhim +"'";
            string query = @"select sp.MaSuatPhim, sp.DinhDang, sp.HinhThuc, sp.NgonNgu from Phim p join SuatPhim sp on p.MaPhim = sp.MaPhim where p.MaPhim = '"+MaPhim+"'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }

        public DataTable GetALlSuatPhim()
        {
            DataTable dt = new DataTable();
            string query = "select * from SuatPhim";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public bool InsertSuatChieu(string MaSuatPhim,  string MaSC, string Phong, string ThoiGian, string TrangThai, int GiaVe)
        {
            try
            {
                string query = "insert into SuatChieu values ('"+MaSuatPhim+"','"+MaSC+"','"+ThoiGian+"', N'"+TrangThai+"','"+Phong+"',"+GiaVe+")";
                DataProvider.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool InsertSuatPhimByMaPhim(string MaSP, string DinhDang, string HinhThuc, string NgonNgu, string MaPhim)
        {
            try
            {
                string query = "insert into SuatPhim values ('" + MaSP + "','" + DinhDang + "',N'" + HinhThuc + "', N'"+NgonNgu+"', '"+MaPhim+"')";
                DataProvider.Instance.ExcuteDB(query);
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
                string query = "update SuatChieu set MaPhim = '"+MaPhim+"', NgayGio = '"+ThoiGian+"', TrangThai = N'"+TrangThai+"', TenPhongChieu = N'"+Phong+"', GiaVe = "+GiaVe+", MaSuatPhim = '"+MaSP+"' where MaSuatChieu = '" + MaSC + "'";
                string s = "update SuatPhim set DinhDang = '"+DinhDang+"', HinhThuc = N'"+HinhThuc+"', NgonNgu = N'"+NgonNgu+"' where MaSuatPhim = '"+MaSP+"'";
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
        public bool InsertGheNgoi(string MaSuatChieu, string TinhTrang, string MaPhongChieu )
        {
            try
            {
                string query = "insert into GheNgoi (MaSuatChieu, TinhTrang, MaPhongChieu) values ('"+MaSuatChieu+"', '"+TinhTrang+"', '"+MaPhongChieu+"')";
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
