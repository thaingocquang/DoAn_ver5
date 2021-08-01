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
    public partial class ThucAn_CoThucAn : Form
    {
        public ThucAn_CoThucAn(string Ma)
        {
            InitializeComponent();
            GUI(Ma);
        }

        public void GUI(string Ma)
        {
            if(BLL_ThucAn.Instance.GetTAByMaThucAn(Ma) != null)
            {
                DataTable dt = BLL_ThucAn.Instance.GetTAByMaThucAn(Ma);
                foreach(DataRow i in dt.Rows)
                {
                    txtMa.Text = i["MaThucAn"].ToString();
                    txtTen.Text = i["TenThucAn"].ToString();
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_ThucAn.Instance.InsertCoThucAn
                (
                    cbbKichco.SelectedItem.ToString(),
                    int.Parse(txtGia.Text.Trim()),
                    txtMaSP.Text.Trim(),
                    txtMa.Text.Trim()                                  
                );
                this.Close();
        }
    }
}
