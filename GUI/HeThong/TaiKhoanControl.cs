using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.HeThong
{
    public partial class TaiKhoanControl : UserControl
    {
        private static TaiKhoanControl _instance;
        public static TaiKhoanControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaiKhoanControl();
                return _instance;
            }
        }
        public TaiKhoanControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TaiKhoanControl_Load(object sender, EventArgs e)
        {
            HienTatCaTaiKhoan();
        }

        private void HienTatCaTaiKhoan()
        {
                DataTable data = BLL_TaiKhoan.Instance.GetAllTaiKhoan();
                int i = 1;
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add(row["TenDangNhap"].ToString());
                    lvi.SubItems.Add(row["MaNhanVien"].ToString());
                    lvi.SubItems.Add(row["HoVaTen"].ToString());
                    lvi.SubItems.Add(row["MatKhau"].ToString());
                    lvi.SubItems.Add(row["TrangThai"].ToString());
                    lstTaiKhoan.Items.Add(lvi);
                    i++;
                }
        }
    }
}
