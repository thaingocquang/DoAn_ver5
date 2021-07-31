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
    public partial class ThucAn_CoThucAn : Form
    {
        public ThucAn_CoThucAn(string Ma)
        {
            InitializeComponent();
            GUI(Ma);
        }

        public void GUI(string Ma)
        {

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
