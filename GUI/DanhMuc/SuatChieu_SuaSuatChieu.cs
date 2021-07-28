using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI.DanhMuc
{
    public partial class SuatChieu_SuaSuatChieu : Form
    {
        public SuatChieu_SuaSuatChieu(string MaSC)
        {
            InitializeComponent();
            GUI(MaSC);
        }

        public void GUI(string MaSC)
        {

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
