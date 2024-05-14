namespace QuanLyDaiLy.Forms
{
    partial class PhieuXuatHang
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpNXH = new System.Windows.Forms.DateTimePicker();
            this.lblSLX = new System.Windows.Forms.Label();
            this.lblMaMatHang = new System.Windows.Forms.Label();
            this.tbxNXH = new System.Windows.Forms.Label();
            this.lblSoPhieuNhap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoPhieuXuat = new System.Windows.Forms.Label();
            this.tbxSLX = new System.Windows.Forms.TextBox();
            this.tbxDGX = new System.Windows.Forms.TextBox();
            this.tbxMMHX = new System.Windows.Forms.TextBox();
            this.tbxSTT = new System.Windows.Forms.TextBox();
            this.tbxThanhTien = new System.Windows.Forms.TextBox();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.tbxConLai = new System.Windows.Forms.TextBox();
            this.tbxMDL = new System.Windows.Forms.TextBox();
            this.tbxSPX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(346, 445);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(247, 45);
            this.btnInsert.TabIndex = 93;
            this.btnInsert.Text = "Thêm Phiếu Xuất";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.TextChanged += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpNXH
            // 
            this.dtpNXH.AllowDrop = true;
            this.dtpNXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNXH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNXH.Location = new System.Drawing.Point(214, 230);
            this.dtpNXH.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpNXH.Name = "dtpNXH";
            this.dtpNXH.Size = new System.Drawing.Size(204, 33);
            this.dtpNXH.TabIndex = 92;
            // 
            // lblSLX
            // 
            this.lblSLX.AutoSize = true;
            this.lblSLX.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblSLX.Location = new System.Drawing.Point(469, 159);
            this.lblSLX.Name = "lblSLX";
            this.lblSLX.Size = new System.Drawing.Size(134, 25);
            this.lblSLX.TabIndex = 91;
            this.lblSLX.Text = "Số lượng xuất";
            // 
            // lblMaMatHang
            // 
            this.lblMaMatHang.AutoSize = true;
            this.lblMaMatHang.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblMaMatHang.Location = new System.Drawing.Point(447, 83);
            this.lblMaMatHang.Name = "lblMaMatHang";
            this.lblMaMatHang.Size = new System.Drawing.Size(168, 25);
            this.lblMaMatHang.TabIndex = 90;
            this.lblMaMatHang.Text = "Mã mặt hàng xuất";
            // 
            // tbxNXH
            // 
            this.tbxNXH.AutoSize = true;
            this.tbxNXH.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.tbxNXH.Location = new System.Drawing.Point(39, 238);
            this.tbxNXH.Name = "tbxNXH";
            this.tbxNXH.Size = new System.Drawing.Size(148, 25);
            this.tbxNXH.TabIndex = 88;
            this.tbxNXH.Text = "Ngày xuất hàng";
            // 
            // lblSoPhieuNhap
            // 
            this.lblSoPhieuNhap.AutoSize = true;
            this.lblSoPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblSoPhieuNhap.Location = new System.Drawing.Point(63, 160);
            this.lblSoPhieuNhap.Name = "lblSoPhieuNhap";
            this.lblSoPhieuNhap.Size = new System.Drawing.Size(125, 25);
            this.lblSoPhieuNhap.TabIndex = 87;
            this.lblSoPhieuNhap.Text = "Đơn giá xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label5.Location = new System.Drawing.Point(491, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Số tiền trả";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblTT.Location = new System.Drawing.Point(489, 236);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(104, 25);
            this.lblTT.TabIndex = 85;
            this.lblTT.Text = "Thành tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(511, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Còn Lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label6.Location = new System.Drawing.Point(77, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label3.Location = new System.Drawing.Point(77, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Mã đại lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(357, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 82;
            this.label2.Text = "Phiếu Xuất Hàng";
            // 
            // lblSoPhieuXuat
            // 
            this.lblSoPhieuXuat.AutoSize = true;
            this.lblSoPhieuXuat.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblSoPhieuXuat.Location = new System.Drawing.Point(60, 83);
            this.lblSoPhieuXuat.Name = "lblSoPhieuXuat";
            this.lblSoPhieuXuat.Size = new System.Drawing.Size(132, 25);
            this.lblSoPhieuXuat.TabIndex = 81;
            this.lblSoPhieuXuat.Text = "Số phiếu xuất";
            // 
            // tbxSLX
            // 
            this.tbxSLX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSLX.Location = new System.Drawing.Point(621, 156);
            this.tbxSLX.Name = "tbxSLX";
            this.tbxSLX.Size = new System.Drawing.Size(204, 33);
            this.tbxSLX.TabIndex = 80;
            this.tbxSLX.Text = "0";
            this.tbxSLX.TextChanged += new System.EventHandler(this.tbxSLX_TextChanged);
            // 
            // tbxDGX
            // 
            this.tbxDGX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDGX.Location = new System.Drawing.Point(214, 156);
            this.tbxDGX.Name = "tbxDGX";
            this.tbxDGX.Size = new System.Drawing.Size(204, 33);
            this.tbxDGX.TabIndex = 79;
            this.tbxDGX.Text = "0";
            this.tbxDGX.TextChanged += new System.EventHandler(this.tbxDGX_TextChanged);
            // 
            // tbxMMHX
            // 
            this.tbxMMHX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMMHX.Location = new System.Drawing.Point(621, 80);
            this.tbxMMHX.Name = "tbxMMHX";
            this.tbxMMHX.Size = new System.Drawing.Size(204, 33);
            this.tbxMMHX.TabIndex = 78;
            this.tbxMMHX.TextChanged += new System.EventHandler(this.tbxMMHX_TextChanged);
            // 
            // tbxSTT
            // 
            this.tbxSTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSTT.Location = new System.Drawing.Point(621, 314);
            this.tbxSTT.Name = "tbxSTT";
            this.tbxSTT.Size = new System.Drawing.Size(204, 33);
            this.tbxSTT.TabIndex = 76;
            this.tbxSTT.TextChanged += new System.EventHandler(this.tbxSTT_TextChanged);
            // 
            // tbxThanhTien
            // 
            this.tbxThanhTien.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbxThanhTien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxThanhTien.Location = new System.Drawing.Point(621, 233);
            this.tbxThanhTien.Name = "tbxThanhTien";
            this.tbxThanhTien.Size = new System.Drawing.Size(204, 33);
            this.tbxThanhTien.TabIndex = 75;
            this.tbxThanhTien.Text = "0";
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbxTongTien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTongTien.Location = new System.Drawing.Point(214, 392);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.Size = new System.Drawing.Size(204, 33);
            this.tbxTongTien.TabIndex = 74;
            // 
            // tbxConLai
            // 
            this.tbxConLai.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbxConLai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConLai.Location = new System.Drawing.Point(621, 392);
            this.tbxConLai.Name = "tbxConLai";
            this.tbxConLai.Size = new System.Drawing.Size(204, 33);
            this.tbxConLai.TabIndex = 73;
            // 
            // tbxMDL
            // 
            this.tbxMDL.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMDL.Location = new System.Drawing.Point(214, 314);
            this.tbxMDL.Name = "tbxMDL";
            this.tbxMDL.Size = new System.Drawing.Size(204, 33);
            this.tbxMDL.TabIndex = 77;
            // 
            // tbxSPX
            // 
            this.tbxSPX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSPX.Location = new System.Drawing.Point(214, 77);
            this.tbxSPX.Name = "tbxSPX";
            this.tbxSPX.Size = new System.Drawing.Size(204, 33);
            this.tbxSPX.TabIndex = 72;
            // 
            // PhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpNXH);
            this.Controls.Add(this.lblSLX);
            this.Controls.Add(this.lblMaMatHang);
            this.Controls.Add(this.tbxNXH);
            this.Controls.Add(this.lblSoPhieuNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSoPhieuXuat);
            this.Controls.Add(this.tbxSLX);
            this.Controls.Add(this.tbxDGX);
            this.Controls.Add(this.tbxMMHX);
            this.Controls.Add(this.tbxSTT);
            this.Controls.Add(this.tbxThanhTien);
            this.Controls.Add(this.tbxTongTien);
            this.Controls.Add(this.tbxConLai);
            this.Controls.Add(this.tbxMDL);
            this.Controls.Add(this.tbxSPX);
            this.Name = "PhieuXuatHang";
            this.Text = "PhieuXuatHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtpNXH;
        private System.Windows.Forms.Label lblSLX;
        private System.Windows.Forms.Label lblMaMatHang;
        private System.Windows.Forms.Label tbxNXH;
        private System.Windows.Forms.Label lblSoPhieuNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoPhieuXuat;
        private System.Windows.Forms.TextBox tbxSLX;
        private System.Windows.Forms.TextBox tbxDGX;
        private System.Windows.Forms.TextBox tbxMMHX;
        private System.Windows.Forms.TextBox tbxSTT;
        private System.Windows.Forms.TextBox tbxThanhTien;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.TextBox tbxConLai;
        private System.Windows.Forms.TextBox tbxMDL;
        private System.Windows.Forms.TextBox tbxSPX;
    }
}