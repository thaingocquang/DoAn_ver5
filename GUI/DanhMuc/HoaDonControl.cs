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
    public partial class HoaDonControl : UserControl
    {
        private static HoaDonControl _instance;
        public static HoaDonControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonControl();
                return _instance;
            }
        }
        public HoaDonControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkMa.Checked = false;
            chkThoiGian.Checked = false;
            dtpTuNgay.Enabled = true;
            dtpDenNgay.Enabled = true;
            txtMa.Text = "";
            txtMa.Enabled = true;
            
        }

        private void chkMa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMa.Checked == true)
            {
                txtMa.Enabled = true;
                chkThoiGian.Checked = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void chkThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThoiGian.Checked == true)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
                chkMa.Checked = false;
                txtMa.Enabled = false;
            }
        }
    }
}
