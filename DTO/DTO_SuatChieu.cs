using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    public class DTO_SuatChieu
    {
        public string MaSuatChieu { get; set; }
        public string MaPhim { get; set; }
        public DateTime NgayGio { get; set; }
        public int GiaVe { get; set; }
        public string PhongChieu { get; set; }
        public DTO_SuatChieu() { }
        public DTO_SuatChieu(string MSC, string MP, DateTime NG, int GV, string PC)
        {
            this.MaSuatChieu = MSC;
            this.MaPhim = MP;
            this.NgayGio = NG;
            this.GiaVe = GV;
            this.PhongChieu = PC;
        }
    }
}
