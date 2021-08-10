using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.DAL;

namespace DoAn_ver5.GUI.HeThong
{
    public partial class KetNoiCSDL : Form
    {
        public KetNoiCSDL()
        {
            InitializeComponent();
        }

        private void KetNoiCSDL_Load(object sender, EventArgs e)
        {
            textBox1.Text = @".\SQLEXPRESS";
            textBox1.Enabled = false;
            foreach (string csdl in DataProvider.Instance.GetDatabaseList())
            {
                comboBox1.Items.Add(csdl);
            }
            comboBox1.SelectedItem = DataProvider.Instance.NameDatabase;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.NameDatabase = comboBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
