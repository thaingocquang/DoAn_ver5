using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    public class DTO_Phim
    {
        public string MaPhim {get;set;}
        public string TenPhim { get; set; }
        public int ThoiLuong { get; set; }
        public string NhaSanXuat { get; set; }
        public int NamSanXuat { get; set; }
        public DateTime NgayRaMat { get; set; }
        public string NuocSanXuat { get; set; }
        public int DoanhThu { get; set; }
        public string CacDienVien { get; set; }
        public string TomTat { get; set; }

        public DTO_Phim()
        {
        }
        //public DTO_Phim(DataRow row)
        //{
        //    MaPhim = row["MaPhim"].ToString();
        //    TenPhim = row["TenPhim"].ToString();
        //}
        public DTO_Phim(string MaPhim, string TenPhim, int ThoiLuong, string NhaSanXuat, int NamSanXuat, DateTime NgayRaMat, string NuocSanXuat, int DoanhThu, string CacDienVien, string TomTat)
        {
            this.MaPhim = MaPhim;
            this.TenPhim = TenPhim;
            this.ThoiLuong = ThoiLuong;
            this.NhaSanXuat = NhaSanXuat;
            this.NgayRaMat = NgayRaMat;
            this.NuocSanXuat = NuocSanXuat;
            this.CacDienVien = CacDienVien;
            this.TomTat = TomTat;
        }
    }

}
