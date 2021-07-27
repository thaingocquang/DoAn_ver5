﻿using DoAn_ver5.BLL;
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
    public partial class ThucAnControl : UserControl
    {
        private static ThucAnControl _instance;
        public static ThucAnControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ThucAnControl();
                return _instance;
            }
        }
        public ThucAnControl()
        {
            InitializeComponent();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            int count = 1;
            listView1.Items.Clear();
            listView2.Items.Clear();
            foreach (DataRow i in BLL_ThucAn.Instance.GetThucAn().Rows)
            {
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaThucAn"].ToString());
                ls.SubItems.Add(i["TenThucAn"].ToString());
                ls.SubItems.Add(i["LoaiThucAn"].ToString());
                listView1.Items.Add(ls);
                count++;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem ls = listView1.SelectedItems[0];
            int count = 1;
            listView2.Items.Clear();

            foreach (DataRow i in BLL_ThucAn.Instance.GetGiaTAByTenThucAN(ls.SubItems[2].Text).Rows)
            {
                ListViewItem sl = new ListViewItem(i["KichCo"].ToString());
                sl.SubItems.Add(i["GiaBan"].ToString());
                listView2.Items.Add(sl);
                count++;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int count = 1;
            string Ten = txtTen.Text;
            if (chkTen.Checked == true)
            {
                listView1.Items.Clear();
                listView2.Items.Clear();
                foreach (DataRow i in BLL_ThucAn.Instance.GetThucAnByTenThucAn(Ten).Rows)
                {
                    ListViewItem ls1 = new ListViewItem(count.ToString());
                    ls1.SubItems.Add(i["MaThucAn"].ToString());
                    ls1.SubItems.Add(i["TenThucAn"].ToString());
                    ls1.SubItems.Add(i["LoaiThucAn"].ToString());
                    listView1.Items.Add(ls1);
                    count++;
                }
            }
            if (chkLoai.Checked == true)
            {
                listView1.Items.Clear();
                listView2.Items.Clear();
                foreach (DataRow i in BLL_ThucAn.Instance.GetThucAnByLoaiTA(cbbLoai.SelectedItem.ToString()).Rows)
                {
                    ListViewItem ls1 = new ListViewItem(count.ToString());
                    ls1.SubItems.Add(i["MaThucAn"].ToString());
                    ls1.SubItems.Add(i["TenThucAn"].ToString());
                    ls1.SubItems.Add(i["LoaiThucAn"].ToString());
                    listView1.Items.Add(ls1);
                    count++;
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkTen.Checked = false;
            chkLoai.Checked = false;
            txtTen.Text = "";
            cbbLoai.SelectedItem = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThucAn_ThemThucAn t = new ThucAn_ThemThucAn();
            t.ShowDialog();
        }
    }
}
