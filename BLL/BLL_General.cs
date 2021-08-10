using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DAL;

namespace DoAn_ver5.BLL
{
    class BLL_General
    {
        private static BLL_General _Instance;
        public static BLL_General Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_General();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public int GetRowCount(DataTable dt)
        {
            return DataProvider.Instance.GetRowCount(dt);
        }
    }
}
