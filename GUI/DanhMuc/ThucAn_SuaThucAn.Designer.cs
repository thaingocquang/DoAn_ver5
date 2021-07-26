
namespace DoAn_ver5.GUI.DanhMuc
{
    partial class ThucAn_SuaThucAn
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLoaiThucAn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaThucAn = new System.Windows.Forms.TextBox();
            this.tbTenThucAn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bntLuu);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 69);
            this.panel2.TabIndex = 17;
            // 
            // bntLuu
            // 
            this.bntLuu.Location = new System.Drawing.Point(143, 23);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(70, 23);
            this.bntLuu.TabIndex = 3;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = true;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(258, 23);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbLoaiThucAn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbMaThucAn);
            this.panel1.Controls.Add(this.tbTenThucAn);
            this.panel1.Location = new System.Drawing.Point(56, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 287);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thức ăn";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 207);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(234, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thức ăn";
            // 
            // cbbLoaiThucAn
            // 
            this.cbbLoaiThucAn.FormattingEnabled = true;
            this.cbbLoaiThucAn.Items.AddRange(new object[] {
            "Đồ Ăn",
            "Nước Uống"});
            this.cbbLoaiThucAn.Location = new System.Drawing.Point(106, 157);
            this.cbbLoaiThucAn.Name = "cbbLoaiThucAn";
            this.cbbLoaiThucAn.Size = new System.Drawing.Size(234, 24);
            this.cbbLoaiThucAn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại thức ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng thái";
            // 
            // tbMaThucAn
            // 
            this.tbMaThucAn.Enabled = false;
            this.tbMaThucAn.Location = new System.Drawing.Point(106, 66);
            this.tbMaThucAn.Name = "tbMaThucAn";
            this.tbMaThucAn.Size = new System.Drawing.Size(234, 22);
            this.tbMaThucAn.TabIndex = 2;
            // 
            // tbTenThucAn
            // 
            this.tbTenThucAn.Location = new System.Drawing.Point(106, 110);
            this.tbTenThucAn.Name = "tbTenThucAn";
            this.tbTenThucAn.Size = new System.Drawing.Size(234, 22);
            this.tbTenThucAn.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_ver5.Properties.Resources.foodIcon;
            this.pictureBox1.Location = new System.Drawing.Point(53, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(111, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sửa thức ăn";
            // 
            // ThucAn_SuaThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "ThucAn_SuaThucAn";
            this.Text = "ThucAn_SuaThucAn";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLoaiThucAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaThucAn;
        private System.Windows.Forms.TextBox tbTenThucAn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}