
namespace DoAn_ver5.GUI.NghiepVu
{
    partial class BanVeControl
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
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstListSuatChieu = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstListPhim = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChon = new System.Windows.Forms.Button();
            this.dtpChonNgay = new System.Windows.Forms.DateTimePicker();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hình thức";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giờ chiếu";
            this.columnHeader3.Width = 200;
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
            // lstListSuatChieu
            // 
            this.lstListSuatChieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader10});
            this.lstListSuatChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListSuatChieu.FullRowSelect = true;
            this.lstListSuatChieu.GridLines = true;
            this.lstListSuatChieu.HideSelection = false;
            this.lstListSuatChieu.Location = new System.Drawing.Point(0, 0);
            this.lstListSuatChieu.Name = "lstListSuatChieu";
            this.lstListSuatChieu.Size = new System.Drawing.Size(1051, 531);
            this.lstListSuatChieu.TabIndex = 0;
            this.lstListSuatChieu.UseCompatibleStateImageBehavior = false;
            this.lstListSuatChieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Định dạng";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngôn ngữ";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phòng";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Trạng thái";
            this.columnHeader10.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstListSuatChieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(269, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 531);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnChonGhe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 44);
            this.panel2.TabIndex = 4;
            // 
            // btnChonGhe
            // 
            this.btnChonGhe.Location = new System.Drawing.Point(968, 7);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(80, 31);
            this.btnChonGhe.TabIndex = 0;
            this.btnChonGhe.Text = "Chọn";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bán vé";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lstListPhim);
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Controls.Add(this.dtpChonNgay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 575);
            this.panel1.TabIndex = 3;
            // 
            // lstListPhim
            // 
            this.lstListPhim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lstListPhim.FullRowSelect = true;
            this.lstListPhim.GridLines = true;
            this.lstListPhim.HideSelection = false;
            this.lstListPhim.Location = new System.Drawing.Point(3, 73);
            this.lstListPhim.Name = "lstListPhim";
            this.lstListPhim.Size = new System.Drawing.Size(260, 499);
            this.lstListPhim.TabIndex = 3;
            this.lstListPhim.UseCompatibleStateImageBehavior = false;
            this.lstListPhim.View = System.Windows.Forms.View.Details;
            this.lstListPhim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstListPhim_MouseClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STT";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên phim";
            this.columnHeader9.Width = 190;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(188, 44);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dtpChonNgay
            // 
            this.dtpChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChonNgay.Location = new System.Drawing.Point(3, 44);
            this.dtpChonNgay.Name = "dtpChonNgay";
            this.dtpChonNgay.Size = new System.Drawing.Size(179, 23);
            this.dtpChonNgay.TabIndex = 1;
            // 
            // BanVeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanVeControl";
            this.Size = new System.Drawing.Size(1320, 575);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstListSuatChieu;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstListPhim;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DateTimePicker dtpChonNgay;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}
