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
    public partial class SuatChieu_ThemSuatChieu : Form
    {
        public SuatChieu_ThemSuatChieu(string Ten)
        {
            InitializeComponent();
            GUI(Ten);
        }

       
        public void GUI(string Ten)
        {
            foreach ()
            {

            }
            if (BLL_SuatChieu.Instance.GetSuatChieusByTenPhim(Ten) != null)
            {
                DataTable dt = BLL_SuatChieu.Instance.GetSuatChieusByTenPhim(Ten);
                foreach(DataRow i in dt.Rows)
                {
                    ListViewItem ls = new ListViewItem(i["MaPhim"].ToString());
                    ls.SubItems.Add(i["DinhDang"].ToString());
                    ls.SubItems.Add(i["HinhThuc"].ToString());
                    ls.SubItems.Add(i["NgonNgu"].ToString());
                    listView1.Items.Add(ls);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //DAL_SuatChieu
            this.Close();
        }

        private void SuatChieu_ThemSuatChieu_Load(object sender, EventArgs e)
        {

        }
    }
}
