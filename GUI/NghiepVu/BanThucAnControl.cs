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
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class BanThucAnControl : UserControl
    {
        private static BanThucAnControl _instance;
        public static BanThucAnControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BanThucAnControl();
                return _instance;
            }
        }
        public BanThucAnControl()
        {
            InitializeComponent();
        }

        List<DTO_ThucAn> listTA;

        int ThanhTien = 0;

        private void chkDoAn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoAn.Checked == true)
            {
                foreach(DTO_ThucAn TA in listTA)
                {
                    if (TA.LoaiThucAn == "Đồ ăn")
                    {
                        ListViewItem lvi = new ListViewItem(TA.TenThucAn);
                        lvi.SubItems.Add(TA.KichCo);
                        lvi.SubItems.Add(TA.GiaBan + "");
                        lstDoAn.Items.Add(lvi);
                        lvi.Tag = TA.LoaiThucAn;
                    }
                }
            }
            if(chkDoAn.Checked == false)
            {
                foreach(ListViewItem lvi in lstDoAn.Items)
                {
                    if((string)lvi.Tag == "Đồ ăn")
                    {
                        lstDoAn.Items.Remove(lvi);
                    }

                }
            }
        }

        private void chkNuocUong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuocUong.Checked == true)
            {
                foreach (DTO_ThucAn TA in listTA)
                {
                    if (TA.LoaiThucAn == "Nước uống")
                    {
                        ListViewItem lvi = new ListViewItem(TA.TenThucAn);
                        lvi.SubItems.Add(TA.KichCo);
                        lvi.SubItems.Add(TA.GiaBan + "");
                        lstDoAn.Items.Add(lvi);
                        lvi.Tag = TA.LoaiThucAn;
                    }
                }
            }
            if (chkNuocUong.Checked == false)
            {
                foreach (ListViewItem lvi in lstDoAn.Items)
                {
                    if ((string)lvi.Tag == "Nước uống")
                    {
                        lstDoAn.Items.Remove(lvi);
                    }
                }
            }
        }

        private void BanThucAnControl_Load(object sender, EventArgs e)
        {
            listTA = BLL_ThucAn.Instance.GetListThucAn();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int soLuong = (int)numericUpDownSoLuong.Value;
            int thanhTien = soLuong * int.Parse(lstDoAn.SelectedItems[0].SubItems[2].Text);

            ListViewItem lvi = new ListViewItem(lstDoAn.SelectedItems[0].Tag + "");
            lvi.SubItems.Add(lstDoAn.SelectedItems[0].SubItems[0].Text);
            lvi.SubItems.Add(lstDoAn.SelectedItems[0].SubItems[1].Text);
            lvi.SubItems.Add(lstDoAn.SelectedItems[0].SubItems[2].Text);
            lvi.SubItems.Add(soLuong + "");
            lvi.SubItems.Add(thanhTien + "");
            lstBanDoAn.Items.Add(lvi);

            ThanhTien += thanhTien;
            lblTongTien.Text = ThanhTien + "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstBanDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // nothing
    }
}
