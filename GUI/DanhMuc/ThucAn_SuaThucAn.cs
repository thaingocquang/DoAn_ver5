using DoAn_ver5.BLL;
using DoAn_ver5.DAL;
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
    public partial class ThucAn_SuaThucAn : Form
    {
        public ThucAn_SuaThucAn(string Ma)
        {
            InitializeComponent();
            GUI(Ma);
        }
        public void GUI(string MaThucAn)
        {
            if (BLL_ThucAn.Instance.GetTAByMaThucAn(MaThucAn) != null)
            {
                DataTable dt = BLL_ThucAn.Instance.GetTAByMaThucAn(MaThucAn);
                foreach (DataRow i in dt.Rows)
                {
                    txtMa.Text = i["MaThucAn"].ToString();
                    cbbLoai.SelectedItem = i["LoaiThucAn"].ToString();
                    txtTen.Text = i["TenThucAn"].ToString();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_ThucAn.Instance.UpdateThucAn
            (
                txtMa.Text.Trim(),
                cbbLoai.SelectedItem.ToString(),
                txtTen.Text.Trim()
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
