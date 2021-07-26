using DoAn_ver5.BLL;
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
    public partial class NhanVien_SuaNhanVien : Form
    {
        public NhanVien_SuaNhanVien(string Tennv)
        {
            InitializeComponent();
            SetGUI(Tennv);
        }

        public void SetGUI(string Tennv)
        {
            if (BLL_NhanVien.Instance.GetNhanVienByTen(Tennv) != null)
            {
                DataTable dt = BLL_NhanVien.Instance.GetNhanVienByTen(Tennv);
                foreach(DataRow i in dt.Rows)
                {

                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
