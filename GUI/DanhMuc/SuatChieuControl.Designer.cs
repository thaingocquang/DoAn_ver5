
namespace DoAn_ver5.GUI
{
    partial class SuatChieuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstSuatChieu = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.chkThoiGian = new System.Windows.Forms.CheckBox();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Trạng thái";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Phòng";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ngôn ngữ";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hình thức";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Định dạng";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giờ";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên phim";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã phim";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã suất chiếu";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(89, 228);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(166, 26);
            this.dtpDenNgay.TabIndex = 8;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(89, 190);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(166, 26);
            this.dtpTuNgay.TabIndex = 7;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã suất phim";
            this.columnHeader11.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến ngày";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstSuatChieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(269, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 531);
            this.panel3.TabIndex = 8;
            // 
            // lstSuatChieu
            // 
            this.lstSuatChieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstSuatChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSuatChieu.FullRowSelect = true;
            this.lstSuatChieu.GridLines = true;
            this.lstSuatChieu.HideSelection = false;
            this.lstSuatChieu.Location = new System.Drawing.Point(0, 0);
            this.lstSuatChieu.Name = "lstSuatChieu";
            this.lstSuatChieu.Size = new System.Drawing.Size(1051, 531);
            this.lstSuatChieu.TabIndex = 0;
            this.lstSuatChieu.UseCompatibleStateImageBehavior = false;
            this.lstSuatChieu.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnHienTatCa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 44);
            this.panel2.TabIndex = 7;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(84, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 26);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(792, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cập nhật trạng thái";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(946, 12);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(102, 26);
            this.btnHienTatCa.TabIndex = 4;
            this.btnHienTatCa.Text = "Hiện tất cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 26);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDatLai);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.chkThoiGian);
            this.panel1.Controls.Add(this.chkTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 575);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ ngày";
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(111, 280);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(78, 26);
            this.btnDatLai.TabIndex = 4;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(30, 280);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(78, 26);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(17, 96);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(238, 26);
            this.txtTen.TabIndex = 2;
            // 
            // chkThoiGian
            // 
            this.chkThoiGian.AutoSize = true;
            this.chkThoiGian.Location = new System.Drawing.Point(17, 153);
            this.chkThoiGian.Name = "chkThoiGian";
            this.chkThoiGian.Size = new System.Drawing.Size(194, 24);
            this.chkThoiGian.TabIndex = 1;
            this.chkThoiGian.Text = "Theo khoảng thời gian";
            this.chkThoiGian.UseVisualStyleBackColor = true;
            this.chkThoiGian.CheckedChanged += new System.EventHandler(this.chkThoiGian_CheckedChanged);
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.Location = new System.Drawing.Point(17, 69);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(137, 24);
            this.chkTen.TabIndex = 1;
            this.chkTen.Text = "Theo tên phim";
            this.chkTen.UseVisualStyleBackColor = true;
            this.chkTen.CheckedChanged += new System.EventHandler(this.chkTen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra cứu suất chiếu";
            // 
            // SuatChieuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuatChieuControl";
            this.Size = new System.Drawing.Size(1320, 575);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstSuatChieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.CheckBox chkThoiGian;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.Label label1;
    }
}
