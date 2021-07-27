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

        private void ThucAn_ThemThucAn_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_ThucAn.Instance.InsertThucAn
            (
                tbMaThucAn.Text.Trim(),
                cbbLoaiThucAn.SelectedItem.ToString(),
                tbTenThucAn.Text.Trim()
            );
            this.Close();
        }
    }
}
