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

namespace DoAn_ver5.GUI
{
    public partial class ThucAn_ThemThucAn : Form
    {
        public ThucAn_ThemThucAn()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_ThucAn.Instance.InsertThucAn
            (
                txtMa.Text.Trim(),
                cbbLoai.SelectedItem.ToString(),
                txtTen.Text.Trim()
            );
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThucAn_ThemThucAn_Load(object sender, EventArgs e)
        {
            txtMa.Text = "TA" + (DataProvider.Instance.GetRowCount(BLL_ThucAn.Instance.GetThucAn())+1);
        }
    }
}
