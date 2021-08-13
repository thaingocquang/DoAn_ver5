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

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class DoanhThu_HangThangControl : UserControl
    {
        private static DoanhThu_HangThangControl _instance;
        public static DoanhThu_HangThangControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DoanhThu_HangThangControl();
                return _instance;
            }
        }
        public DoanhThu_HangThangControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            lstDoanhThuThang.Items.Clear();
            int TongDoanhThu = 0;
            for (int i = 1; i <= 12; i++)
            {
                DataTable data = BLL_HoaDon.Instance.GetDoanhThuThucAn(i);
                //string SoLuongSP = data.Rows[0]["SoLuongSP"].ToString();
                ListViewItem lvi = new ListViewItem("Tháng " + i);
                lvi.SubItems.Add(data.Rows[0]["SoLuongHD"].ToString());
                lvi.SubItems.Add(((data.Rows[0]["SoLuongSP"].ToString()=="")?"0": data.Rows[0]["SoLuongSP"].ToString()));
                lvi.SubItems.Add(((data.Rows[0]["DoanhThu"].ToString()=="")?"0": data.Rows[0]["DoanhThu"].ToString()));
                lstDoanhThuThang.Items.Add(lvi);
                TongDoanhThu += int.Parse(((data.Rows[0]["DoanhThu"].ToString() == "") ? "0" : data.Rows[0]["DoanhThu"].ToString()));
            }
            
            txtTongDoanhThu.Text = TongDoanhThu.ToString();
        }
    }
}
