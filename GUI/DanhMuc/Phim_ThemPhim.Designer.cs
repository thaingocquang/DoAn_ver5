
namespace DoAn_ver5.GUI
{
    partial class Phim_ThemPhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.txtTomTat = new System.Windows.Forms.TextBox();
            this.cbbNhaSX = new System.Windows.Forms.ComboBox();
            this.cbbNN = new System.Windows.Forms.ComboBox();
            this.cbbNuocSX = new System.Windows.Forms.ComboBox();
            this.cbbDoTuoi = new System.Windows.Forms.ComboBox();
            this.ThoiLuong = new System.Windows.Forms.NumericUpDown();
            this.NamSX = new System.Windows.Forms.NumericUpDown();
            this.txtDienVien = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstSuatphim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbHinhthuc = new System.Windows.Forms.ComboBox();
            this.txtNgonngu = new System.Windows.Forms.TextBox();
            this.txtDinhdang = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThoiLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamSX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_ver5.Properties.Resources.themPhimIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(115, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(16, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 429);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpNgayChieu);
            this.tabPage1.Controls.Add(this.txtTomTat);
            this.tabPage1.Controls.Add(this.cbbNhaSX);
            this.tabPage1.Controls.Add(this.cbbNN);
            this.tabPage1.Controls.Add(this.cbbNuocSX);
            this.tabPage1.Controls.Add(this.cbbDoTuoi);
            this.tabPage1.Controls.Add(this.ThoiLuong);
            this.tabPage1.Controls.Add(this.NamSX);
            this.tabPage1.Controls.Add(this.txtDienVien);
            this.tabPage1.Controls.Add(this.txtTenPhim);
            this.tabPage1.Controls.Add(this.txtMaPhim);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Location = new System.Drawing.Point(399, 234);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(173, 26);
            this.dtpNgayChieu.TabIndex = 7;
            // 
            // txtTomTat
            // 
            this.txtTomTat.Location = new System.Drawing.Point(107, 324);
            this.txtTomTat.Multiline = true;
            this.txtTomTat.Name = "txtTomTat";
            this.txtTomTat.Size = new System.Drawing.Size(465, 70);
            this.txtTomTat.TabIndex = 6;
            // 
            // cbbNhaSX
            // 
            this.cbbNhaSX.FormattingEnabled = true;
            this.cbbNhaSX.Items.AddRange(new object[] {
            "Mavel",
            "Truyền hình Việt Nam"});
            this.cbbNhaSX.Location = new System.Drawing.Point(399, 201);
            this.cbbNhaSX.Name = "cbbNhaSX";
            this.cbbNhaSX.Size = new System.Drawing.Size(121, 28);
            this.cbbNhaSX.TabIndex = 5;
            // 
            // cbbNN
            // 
            this.cbbNN.FormattingEnabled = true;
            this.cbbNN.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Việt"});
            this.cbbNN.Location = new System.Drawing.Point(399, 162);
            this.cbbNN.Name = "cbbNN";
            this.cbbNN.Size = new System.Drawing.Size(121, 28);
            this.cbbNN.TabIndex = 5;
            // 
            // cbbNuocSX
            // 
            this.cbbNuocSX.FormattingEnabled = true;
            this.cbbNuocSX.Items.AddRange(new object[] {
            "Mỹ ",
            "Việt Nam"});
            this.cbbNuocSX.Location = new System.Drawing.Point(399, 11);
            this.cbbNuocSX.Name = "cbbNuocSX";
            this.cbbNuocSX.Size = new System.Drawing.Size(121, 28);
            this.cbbNuocSX.TabIndex = 5;
            // 
            // cbbDoTuoi
            // 
            this.cbbDoTuoi.FormattingEnabled = true;
            this.cbbDoTuoi.Items.AddRange(new object[] {
            "16",
            "18",
            "20"});
            this.cbbDoTuoi.Location = new System.Drawing.Point(107, 233);
            this.cbbDoTuoi.Name = "cbbDoTuoi";
            this.cbbDoTuoi.Size = new System.Drawing.Size(121, 28);
            this.cbbDoTuoi.TabIndex = 5;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.Location = new System.Drawing.Point(107, 162);
            this.ThoiLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.Size = new System.Drawing.Size(120, 26);
            this.ThoiLuong.TabIndex = 4;
            // 
            // NamSX
            // 
            this.NamSX.Location = new System.Drawing.Point(107, 201);
            this.NamSX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NamSX.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NamSX.Name = "NamSX";
            this.NamSX.Size = new System.Drawing.Size(120, 26);
            this.NamSX.TabIndex = 4;
            this.NamSX.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtDienVien
            // 
            this.txtDienVien.Location = new System.Drawing.Point(399, 64);
            this.txtDienVien.Multiline = true;
            this.txtDienVien.Name = "txtDienVien";
            this.txtDienVien.Size = new System.Drawing.Size(173, 79);
            this.txtDienVien.TabIndex = 2;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(107, 64);
            this.txtTenPhim.Multiline = true;
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(173, 79);
            this.txtTenPhim.TabIndex = 2;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(107, 16);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(100, 26);
            this.txtMaPhim.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tóm tắt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày chiếu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới hạn tuổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm sản suất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời lượng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(295, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nhà sản xuất";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ngôn ngữ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nước sản xuất";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Diễn viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phim";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstSuatphim);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suất phim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstSuatphim
            // 
            this.lstSuatphim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstSuatphim.FullRowSelect = true;
            this.lstSuatphim.GridLines = true;
            this.lstSuatphim.HideSelection = false;
            this.lstSuatphim.Location = new System.Drawing.Point(18, 153);
            this.lstSuatphim.Name = "lstSuatphim";
            this.lstSuatphim.Size = new System.Drawing.Size(549, 237);
            this.lstSuatphim.TabIndex = 1;
            this.lstSuatphim.UseCompatibleStateImageBehavior = false;
            this.lstSuatphim.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Định dạng";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hình thức";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngôn Ngữ";
            this.columnHeader4.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbbHinhthuc);
            this.groupBox1.Controls.Add(this.txtNgonngu);
            this.groupBox1.Controls.Add(this.txtDinhdang);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(18, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(449, 72);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(351, 72);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbHinhthuc
            // 
            this.cbbHinhthuc.FormattingEnabled = true;
            this.cbbHinhthuc.Items.AddRange(new object[] {
            "Phụ đề",
            "Lồng tiếng"});
            this.cbbHinhthuc.Location = new System.Drawing.Point(385, 26);
            this.cbbHinhthuc.Name = "cbbHinhthuc";
            this.cbbHinhthuc.Size = new System.Drawing.Size(125, 28);
            this.cbbHinhthuc.TabIndex = 5;
            // 
            // txtNgonngu
            // 
            this.txtNgonngu.Location = new System.Drawing.Point(140, 76);
            this.txtNgonngu.Name = "txtNgonngu";
            this.txtNgonngu.Size = new System.Drawing.Size(119, 26);
            this.txtNgonngu.TabIndex = 4;
            // 
            // txtDinhdang
            // 
            this.txtDinhdang.Location = new System.Drawing.Point(140, 26);
            this.txtDinhdang.Name = "txtDinhdang";
            this.txtDinhdang.Size = new System.Drawing.Size(119, 26);
            this.txtDinhdang.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(297, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Hình thức";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Ngôn ngữ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Định dạng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 54);
            this.panel2.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(487, 12);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 30);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(389, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Phim_ThemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Phim_ThemPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phim_ThemPhim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThoiLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamSX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTomTat;
        private System.Windows.Forms.ComboBox cbbNhaSX;
        private System.Windows.Forms.ComboBox cbbNN;
        private System.Windows.Forms.ComboBox cbbNuocSX;
        private System.Windows.Forms.ComboBox cbbDoTuoi;
        private System.Windows.Forms.NumericUpDown ThoiLuong;
        private System.Windows.Forms.NumericUpDown NamSX;
        private System.Windows.Forms.TextBox txtDienVien;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.ListView lstSuatphim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbHinhthuc;
        private System.Windows.Forms.TextBox txtNgonngu;
        private System.Windows.Forms.TextBox txtDinhdang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}