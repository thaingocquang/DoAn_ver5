
namespace DoAn_ver5.GUI.DanhMuc
{
    partial class Phim_SuaPhim
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
            this.Phim = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.txtTomTat = new System.Windows.Forms.TextBox();
            this.txtDienVien = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.nmGioiHanTuoi = new System.Windows.Forms.NumericUpDown();
            this.Phim.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGioiHanTuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // Phim
            // 
            this.Phim.Controls.Add(this.tabPage1);
            this.Phim.Controls.Add(this.tabPage2);
            this.Phim.Location = new System.Drawing.Point(16, 108);
            this.Phim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phim.Name = "Phim";
            this.Phim.SelectedIndex = 0;
            this.Phim.Size = new System.Drawing.Size(595, 430);
            this.Phim.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nmGioiHanTuoi);
            this.tabPage1.Controls.Add(this.txtNhaSX);
            this.tabPage1.Controls.Add(this.txtNuocSX);
            this.tabPage1.Controls.Add(this.dtpNgayChieu);
            this.tabPage1.Controls.Add(this.txtTomTat);
            this.tabPage1.Controls.Add(this.txtDienVien);
            this.tabPage1.Controls.Add(this.txtTenPhim);
            this.tabPage1.Controls.Add(this.txtMaPhim);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.numericUpDown3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(587, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(400, 14);
            this.dtpNgayChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(167, 23);
            this.dtpNgayChieu.TabIndex = 33;
            // 
            // txtTomTat
            // 
            this.txtTomTat.Location = new System.Drawing.Point(108, 319);
            this.txtTomTat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTomTat.Multiline = true;
            this.txtTomTat.Name = "txtTomTat";
            this.txtTomTat.Size = new System.Drawing.Size(465, 70);
            this.txtTomTat.TabIndex = 32;
            // 
            // txtDienVien
            // 
            this.txtDienVien.Location = new System.Drawing.Point(400, 59);
            this.txtDienVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDienVien.Multiline = true;
            this.txtDienVien.Name = "txtDienVien";
            this.txtDienVien.Size = new System.Drawing.Size(167, 79);
            this.txtDienVien.TabIndex = 23;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(108, 59);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhim.Multiline = true;
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(173, 79);
            this.txtTenPhim.TabIndex = 21;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Enabled = false;
            this.txtMaPhim.Location = new System.Drawing.Point(108, 11);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(173, 23);
            this.txtMaPhim.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(108, 158);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(173, 23);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(108, 196);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(173, 23);
            this.numericUpDown3.TabIndex = 25;
            this.numericUpDown3.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tóm tắt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày chiếu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giới hạn tuổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Năm sản suất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thời lượng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Nhà sản xuất";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Nước sản xuất";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(307, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Diễn viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã phim";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstSuatphim);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(587, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suất Phim";
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
            this.lstSuatphim.Location = new System.Drawing.Point(19, 151);
            this.lstSuatphim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSuatphim.Name = "lstSuatphim";
            this.lstSuatphim.Size = new System.Drawing.Size(549, 237);
            this.lstSuatphim.TabIndex = 3;
            this.lstSuatphim.UseCompatibleStateImageBehavior = false;
            this.lstSuatphim.View = System.Windows.Forms.View.Details;
            this.lstSuatphim.SelectedIndexChanged += new System.EventHandler(this.lstSuatphim_SelectedIndexChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(549, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(449, 71);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(351, 71);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cbbHinhthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHinhthuc.Name = "cbbHinhthuc";
            this.cbbHinhthuc.Size = new System.Drawing.Size(125, 24);
            this.cbbHinhthuc.TabIndex = 5;
            // 
            // txtNgonngu
            // 
            this.txtNgonngu.Location = new System.Drawing.Point(140, 76);
            this.txtNgonngu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgonngu.Name = "txtNgonngu";
            this.txtNgonngu.Size = new System.Drawing.Size(119, 23);
            this.txtNgonngu.TabIndex = 4;
            // 
            // txtDinhdang
            // 
            this.txtDinhdang.Location = new System.Drawing.Point(140, 26);
            this.txtDinhdang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDinhdang.Name = "txtDinhdang";
            this.txtDinhdang.Size = new System.Drawing.Size(119, 23);
            this.txtDinhdang.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(297, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Hình thức";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Ngôn ngữ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 54);
            this.panel2.TabIndex = 11;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(487, 12);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(117, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sửa phim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_ver5.Properties.Resources.themPhimIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(411, 181);
            this.txtNuocSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(156, 23);
            this.txtNuocSX.TabIndex = 34;
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(411, 232);
            this.txtNhaSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(156, 23);
            this.txtNhaSX.TabIndex = 35;
            // 
            // nmGioiHanTuoi
            // 
            this.nmGioiHanTuoi.Location = new System.Drawing.Point(108, 233);
            this.nmGioiHanTuoi.Name = "nmGioiHanTuoi";
            this.nmGioiHanTuoi.Size = new System.Drawing.Size(173, 23);
            this.nmGioiHanTuoi.TabIndex = 36;
            // 
            // Phim_SuaPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 620);
            this.Controls.Add(this.Phim);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phim_SuaPhim";
            this.Text = "Phim_SuaPhim";
            this.Phim.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGioiHanTuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Phim;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTomTat;
        private System.Windows.Forms.TextBox txtDienVien;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.ListView lstSuatphim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbHinhthuc;
        private System.Windows.Forms.TextBox txtNgonngu;
        private System.Windows.Forms.TextBox txtDinhdang;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.NumericUpDown nmGioiHanTuoi;
    }
}