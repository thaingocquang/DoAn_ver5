
namespace DoAn_ver5.GUI.HeThong
{
    partial class TaiKhoanControl
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
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lstTaiKhoan = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDatMKMacDinh = new System.Windows.Forms.Button();
            this.rdbTamNgung = new System.Windows.Forms.RadioButton();
            this.rdbKichHoat = new System.Windows.Forms.RadioButton();
            this.cbbQuyenHan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sdasd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã nhân viên";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đăng nhập";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lstTaiKhoan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1051, 531);
            this.panel4.TabIndex = 0;
            // 
            // lstTaiKhoan
            // 
            this.lstTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lstTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTaiKhoan.FullRowSelect = true;
            this.lstTaiKhoan.GridLines = true;
            this.lstTaiKhoan.HideSelection = false;
            this.lstTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lstTaiKhoan.Name = "lstTaiKhoan";
            this.lstTaiKhoan.Size = new System.Drawing.Size(1051, 531);
            this.lstTaiKhoan.TabIndex = 0;
            this.lstTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lstTaiKhoan.View = System.Windows.Forms.View.Details;
            this.lstTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lstTaiKhoan_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên nhân viên";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên quyền";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Trạng thái";
            this.columnHeader7.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(269, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 531);
            this.panel3.TabIndex = 5;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(6, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 26);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 44);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblTenDangNhap);
            this.panel1.Controls.Add(this.lblTenNhanVien);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnDatMKMacDinh);
            this.panel1.Controls.Add(this.rdbTamNgung);
            this.panel1.Controls.Add(this.rdbKichHoat);
            this.panel1.Controls.Add(this.cbbQuyenHan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sdasd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 575);
            this.panel1.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(127, 89);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(0, 17);
            this.lblTenDangNhap.TabIndex = 5;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTenNhanVien.Location = new System.Drawing.Point(26, 44);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(0, 25);
            this.lblTenNhanVien.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(22, 255);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(198, 27);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDatMKMacDinh
            // 
            this.btnDatMKMacDinh.Location = new System.Drawing.Point(22, 220);
            this.btnDatMKMacDinh.Name = "btnDatMKMacDinh";
            this.btnDatMKMacDinh.Size = new System.Drawing.Size(198, 29);
            this.btnDatMKMacDinh.TabIndex = 3;
            this.btnDatMKMacDinh.Text = "Đặt lại mật khẩu mặt định";
            this.btnDatMKMacDinh.UseVisualStyleBackColor = true;
            this.btnDatMKMacDinh.Click += new System.EventHandler(this.btnDatMKMacDinh_Click);
            // 
            // rdbTamNgung
            // 
            this.rdbTamNgung.AutoSize = true;
            this.rdbTamNgung.Location = new System.Drawing.Point(122, 181);
            this.rdbTamNgung.Name = "rdbTamNgung";
            this.rdbTamNgung.Size = new System.Drawing.Size(98, 21);
            this.rdbTamNgung.TabIndex = 2;
            this.rdbTamNgung.TabStop = true;
            this.rdbTamNgung.Text = "Tạm ngưng";
            this.rdbTamNgung.UseVisualStyleBackColor = true;
            this.rdbTamNgung.CheckedChanged += new System.EventHandler(this.rdbTamNgung_CheckedChanged);
            // 
            // rdbKichHoat
            // 
            this.rdbKichHoat.AutoSize = true;
            this.rdbKichHoat.Location = new System.Drawing.Point(31, 181);
            this.rdbKichHoat.Name = "rdbKichHoat";
            this.rdbKichHoat.Size = new System.Drawing.Size(85, 21);
            this.rdbKichHoat.TabIndex = 2;
            this.rdbKichHoat.TabStop = true;
            this.rdbKichHoat.Text = "Kích hoạt";
            this.rdbKichHoat.UseVisualStyleBackColor = true;
            this.rdbKichHoat.CheckedChanged += new System.EventHandler(this.rdbKichHoat_CheckedChanged);
            // 
            // cbbQuyenHan
            // 
            this.cbbQuyenHan.FormattingEnabled = true;
            this.cbbQuyenHan.Location = new System.Drawing.Point(96, 123);
            this.cbbQuyenHan.Name = "cbbQuyenHan";
            this.cbbQuyenHan.Size = new System.Drawing.Size(121, 24);
            this.cbbQuyenHan.TabIndex = 1;
            this.cbbQuyenHan.SelectedIndexChanged += new System.EventHandler(this.cbbQuyenHan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quyền hạn";
            // 
            // sdasd
            // 
            this.sdasd.AutoSize = true;
            this.sdasd.Location = new System.Drawing.Point(12, 89);
            this.sdasd.Name = "sdasd";
            this.sdasd.Size = new System.Drawing.Size(109, 17);
            this.sdasd.TabIndex = 0;
            this.sdasd.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // TaiKhoanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaiKhoanControl";
            this.Size = new System.Drawing.Size(1320, 575);
            this.Load += new System.EventHandler(this.TaiKhoanControl_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lstTaiKhoan;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDatMKMacDinh;
        private System.Windows.Forms.RadioButton rdbTamNgung;
        private System.Windows.Forms.RadioButton rdbKichHoat;
        private System.Windows.Forms.ComboBox cbbQuyenHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sdasd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblTenNhanVien;
    }
}
