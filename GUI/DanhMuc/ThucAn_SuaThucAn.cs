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
        public ThucAn_SuaThucAn(string m)
        {
            
            InitializeComponent();
            GUI(m);
        }
        public void GUI(string MaThucAn)
        {
            if (BLL_ThucAn.Instance.GetTAByMaThucAn(MaThucAn) != null)
            {
                DataTable dt = BLL_ThucAn.Instance.GetTAByMaThucAn(MaThucAn);
                foreach (DataRow i in dt.Rows)
                {
                    tbMaThucAn.Text = i["MaThucAn"].ToString();
                    cbbLoaiThucAn.SelectedItem = i["LoaiThucAn"].ToString();
                    tbTenThucAn.Text = i["TenThucAn"].ToString();
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            DAL_ThucAn.Instance.UpdateThucAn
            (
                tbMaThucAn.Text.Trim(),
                cbbLoaiThucAn.SelectedItem.ToString(),
                tbTenThucAn.Text.Trim()
            );
        }
    }
}
