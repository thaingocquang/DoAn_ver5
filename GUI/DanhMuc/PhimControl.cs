using DoAn_ver5.BLL;
using DoAn_ver5.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI
{
    public partial class PhimControl : UserControl
    {
        private static PhimControl _instance;
        public static PhimControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PhimControl();
                return _instance;
            }
        }
        public PhimControl()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Phim_ThemPhim frm = new Phim_ThemPhim();
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
      
}
