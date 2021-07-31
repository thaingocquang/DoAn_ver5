﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DTO;
using DoAn_ver5.DAL;
using System.Data;

namespace DoAn_ver5.BLL
{
    class BLL_ThucAn
    {
        private static BLL_ThucAn _Instance;
        public static BLL_ThucAn Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ThucAn();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public List<DTO_ThucAn> GetListThucAn()
        {
            List<DTO_ThucAn> list = new List<DTO_ThucAn>();            
            foreach(DataRow row in DAL_ThucAn.Instance.GetAllThucAn().Rows)
            {
                list.Add(new DTO_ThucAn(row["LoaiThucAn"].ToString(), row["TenThucAn"].ToString(), row["KichCo"].ToString(), (int)row["GiaBan"]));
            }
            return list;

        }
        public DataTable GetThucAnByTenThucAn(string Ten)
        {
            return DAL_ThucAn.Instance.GetThucAnByTenThucAn(Ten);
        }
        public DataTable GetGiaTAByTenThucAn(string Ten)
        {
            return DAL_ThucAn.Instance.GetGiaTAByTenThucAn(Ten);
        }
        public DataTable GetThucAnByLoaiTA(string Loai)
        {
            return DAL_ThucAn.Instance.GetThucAnByLoaiThucAn(Loai);
        }

        public DataTable GetTAByMaThucAn(string Ma)
        {
            return DAL_ThucAn.Instance.GetThucAnByMaThucAn(Ma);
        }
        public DataTable GetThucAn()
        {
            return DAL_ThucAn.Instance.GetThucAn();
        }
    }
}
