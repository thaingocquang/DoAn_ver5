using DoAn_ver5.BLL;
using DoAn_ver5.DAL;
using DoAn_ver5.DTO;
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
       
        public SuatChieu_SuaSuatChieu(string Ma)
        {
            InitializeComponent();
            GUI(Ma);
        }

        public void GUI(string Ma)
        {
            txtMaSC.Text = Ma;
            foreach (DataRow i in BLL_Phim.Instance.GetAllPhim().Rows)
            {
                cbbTenPhim.Items.Add(new CbbItem() { ID = i["MaPhim"].ToString(), Name = i["TenPhim"].ToString() });
            }
            foreach (DataRow i in BLL_PhongChieu.Instance.GetAllPhongChieu().Rows)
            {
                cbbPhong.Items.Add(new CbbItem() { ID = i["MaPhongChieu"].ToString(), Name = i["TenPhongChieu"].ToString() });
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_SuatChieu.Instance.UpdateSuatChieu
                (
                    ((CbbItem)cbbTenPhim.SelectedItem).ID.Trim(),
                    txtMaSC.Text.Trim(),
                    txtMaSP.Text.Trim(),
                    ((CbbItem)cbbPhong.SelectedItem).ToString().Trim(),
                    dtpThoigian.Value.ToString(),
                    cbbTrangThai.SelectedItem.ToString().Trim(),
                    listView1.SelectedItems[0].SubItems[1].Text.Trim(),
                    listView1.SelectedItems[0].SubItems[2].Text.Trim(),
                    listView1.SelectedItems[0].SubItems[3].Text.Trim(),
                    int.Parse(txtGiaVe.Text.Trim())
                );
            this.Close();
        }

        private void cbbTenPhim_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string MaPhim = ((CbbItem)cbbTenPhim.SelectedItem).ID.Trim();
            foreach (DataRow i in BLL_SuatChieu.Instance.GetSuatPhimByMaPhim(MaPhim).Rows)
            {
                ListViewItem ls = new ListViewItem(i["MaSuatPhim"].ToString());
                ls.SubItems.Add(i["DinhDang"].ToString());
                ls.SubItems.Add(i["HinhThuc"].ToString());
                ls.SubItems.Add(i["NgonNgu"].ToString());
                listView1.Items.Add(ls);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtMaSP.Text = listView1.SelectedItems[0].SubItems[0].Text.Trim();
            }
        }

        private void SuatChieu_SuaSuatChieu_Load(object sender, EventArgs e)
        {

        }

        private void cbbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
