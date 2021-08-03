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
using DoAn_ver5.DTO;
namespace DoAn_ver5.GUI
{
    public partial class SuatChieu_ThemSuatChieu : Form
    {
        public SuatChieu_ThemSuatChieu()
        {
            InitializeComponent();
            GUI();
        }

       
        public void GUI()
        {
            foreach( DataRow i in BLL_Phim.Instance.GetAllPhim().Rows)
            {
                cbbTenPhim.Items.Add( new CbbItem() {  ID = i["MaPhim"].ToString(), Name = i["TenPhim"].ToString()});
            }
            foreach(DataRow i in BLL_PhongChieu.Instance.GetAllPhongChieu().Rows)
            {
                cbbPhong.Items.Add(new CbbItem (){ ID = i["MaPhongChieu"].ToString(), Name = i["TenPhongChieu"].ToString() });
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

        private void cbbTenPhim_TextChanged(object sender, EventArgs e)
        {

            string MaPhim = ((CbbItem)cbbTenPhim.SelectedItem).ID.Trim();           
            foreach(DataRow i in BLL_SuatChieu.Instance.GetSuatPhimByMaPhim(MaPhim).Rows)
            {
                ListViewItem ls = new ListViewItem(i["MaSuatPhim"].ToString());
                ls.SubItems.Add(i["DinhDang"].ToString());
                ls.SubItems.Add(i["HinhThuc"].ToString());
                ls.SubItems.Add(i["NgonNgu"].ToString());
                listView1.Items.Add(ls);
            }
         
            MessageBox.Show(MaPhim);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                txtMaSP.Text = listView1.SelectedItems[0].SubItems[0].Text.Trim();
            }
        }
    }
}
