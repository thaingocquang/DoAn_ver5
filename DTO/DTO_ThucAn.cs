using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    class DTO_ThucAn
    {
        public string MaSP { get; set; }
        public string LoaiThucAn { get; set; }
        public string TenThucAn { get; set; }
        public string KichCo { get; set; }
        public int GiaBan { get; set; }
        public DTO_ThucAn(string MaSP, string lta, string tta, string kc, int gb)
        {
            this.MaSP = MaSP;
            LoaiThucAn = lta;
            TenThucAn = tta;
            KichCo = kc;
            GiaBan = gb;
        }
    }
}
