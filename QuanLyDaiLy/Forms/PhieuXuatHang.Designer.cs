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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuatHang));
            this.cbMMHX = new System.Windows.Forms.ComboBox();
            this.tbxTMH = new System.Windows.Forms.TextBox();
            this.cbMDVT = new System.Windows.Forms.ComboBox();
            this.tbxTDVT = new System.Windows.Forms.TextBox();
            this.dtpNXH = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDGX = new System.Windows.Forms.TextBox();
            this.tbxTT = new System.Windows.Forms.TextBox();
            this.tbxMDL = new System.Windows.Forms.TextBox();
            this.tbxSLX = new System.Windows.Forms.TextBox();
            this.tbxSPX = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMMHX
            // 
            this.cbMMHX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMMHX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMMHX.FormattingEnabled = true;
            this.cbMMHX.Location = new System.Drawing.Point(610, 86);
            this.cbMMHX.Name = "cbMMHX";
            this.cbMMHX.Size = new System.Drawing.Size(204, 34);
            this.cbMMHX.TabIndex = 131;
            this.cbMMHX.SelectedIndexChanged += new System.EventHandler(this.cbMMHX_SelectedIndexChanged);
            // 
            // tbxTMH
            // 
            this.tbxTMH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTMH.Location = new System.Drawing.Point(610, 300);
            this.tbxTMH.Name = "tbxTMH";
            this.tbxTMH.ReadOnly = true;
            this.tbxTMH.Size = new System.Drawing.Size(204, 33);
            this.tbxTMH.TabIndex = 130;
            // 
            // cbMDVT
            // 
            this.cbMDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMDVT.FormattingEnabled = true;
            this.cbMDVT.Location = new System.Drawing.Point(610, 234);
            this.cbMDVT.Name = "cbMDVT";
            this.cbMDVT.Size = new System.Drawing.Size(204, 34);
            this.cbMDVT.TabIndex = 129;
            this.cbMDVT.SelectedIndexChanged += new System.EventHandler(this.cbMDVT_SelectedIndexChanged);
            // 
            // tbxTDVT
            // 
            this.tbxTDVT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTDVT.Location = new System.Drawing.Point(205, 300);
            this.tbxTDVT.Name = "tbxTDVT";
            this.tbxTDVT.ReadOnly = true;
            this.tbxTDVT.Size = new System.Drawing.Size(204, 33);
            this.tbxTDVT.TabIndex = 128;
            // 
            // dtpNXH
            // 
            this.dtpNXH.AllowDrop = true;
            this.dtpNXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNXH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNXH.Location = new System.Drawing.Point(205, 232);
            this.dtpNXH.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpNXH.Name = "dtpNXH";
            this.dtpNXH.Size = new System.Drawing.Size(204, 33);
            this.dtpNXH.TabIndex = 127;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label7.Location = new System.Drawing.Point(428, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 125;
            this.label7.Text = "Tên mặt hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label5.Location = new System.Drawing.Point(428, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 124;
            this.label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label4.Location = new System.Drawing.Point(428, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 126;
            this.label4.Text = "Đơn giá xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label8.Location = new System.Drawing.Point(41, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 119;
            this.label8.Text = "Tên đơn vị tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label6.Location = new System.Drawing.Point(41, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 120;
            this.label6.Text = "Ngày Xuất Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(428, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 123;
            this.label1.Text = "Mã mặt hàng xuất";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label10.Location = new System.Drawing.Point(41, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 121;
            this.label10.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label11.Location = new System.Drawing.Point(428, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 122;
            this.label11.Text = "Mã Đại lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label3.Location = new System.Drawing.Point(41, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 118;
            this.label3.Text = "Số lượng xuất";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label9.Location = new System.Drawing.Point(45, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 117;
            this.label9.Text = "Số phiếu xuất";
            // 
            // tbxDGX
            // 
            this.tbxDGX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDGX.Location = new System.Drawing.Point(610, 161);
            this.tbxDGX.Name = "tbxDGX";
            this.tbxDGX.Size = new System.Drawing.Size(204, 33);
            this.tbxDGX.TabIndex = 116;
            this.tbxDGX.TextChanged += new System.EventHandler(this.tbxDGX_TextChanged);
            // 
            // tbxTT
            // 
            this.tbxTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTT.Location = new System.Drawing.Point(205, 367);
            this.tbxTT.Name = "tbxTT";
            this.tbxTT.Size = new System.Drawing.Size(204, 33);
            this.tbxTT.TabIndex = 115;
            // 
            // tbxMDL
            // 
            this.tbxMDL.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMDL.Location = new System.Drawing.Point(610, 367);
            this.tbxMDL.Name = "tbxMDL";
            this.tbxMDL.ReadOnly = true;
            this.tbxMDL.Size = new System.Drawing.Size(204, 33);
            this.tbxMDL.TabIndex = 114;
            // 
            // tbxSLX
            // 
            this.tbxSLX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSLX.Location = new System.Drawing.Point(205, 161);
            this.tbxSLX.Name = "tbxSLX";
            this.tbxSLX.Size = new System.Drawing.Size(204, 33);
            this.tbxSLX.TabIndex = 113;
            this.tbxSLX.TextChanged += new System.EventHandler(this.tbcSLX_TextChanged);
            // 
            // tbxSPX
            // 
            this.tbxSPX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSPX.Location = new System.Drawing.Point(205, 87);
            this.tbxSPX.Name = "tbxSPX";
            this.tbxSPX.Size = new System.Drawing.Size(204, 33);
            this.tbxSPX.TabIndex = 112;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(311, 440);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(247, 45);
            this.btnInsert.TabIndex = 111;
            this.btnInsert.Text = "Thêm Phiếu Xuất";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(343, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 110;
            this.label2.Text = "Phiếu Xuất Hàng";
            // 
            // PhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.cbMMHX);
            this.Controls.Add(this.tbxTMH);
            this.Controls.Add(this.cbMDVT);
            this.Controls.Add(this.tbxTDVT);
            this.Controls.Add(this.dtpNXH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxDGX);
            this.Controls.Add(this.tbxTT);
            this.Controls.Add(this.tbxMDL);
            this.Controls.Add(this.tbxSLX);
            this.Controls.Add(this.tbxSPX);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(882, 554);
            this.MinimumSize = new System.Drawing.Size(882, 554);
            this.Name = "PhieuXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhieuXuatHang";
            this.Load += new System.EventHandler(this.PhieuXuatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMMHX;
        private System.Windows.Forms.TextBox tbxTMH;
        private System.Windows.Forms.ComboBox cbMDVT;
        private System.Windows.Forms.TextBox tbxTDVT;
        private System.Windows.Forms.DateTimePicker dtpNXH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDGX;
        private System.Windows.Forms.TextBox tbxTT;
        private System.Windows.Forms.TextBox tbxMDL;
        private System.Windows.Forms.TextBox tbxSLX;
        private System.Windows.Forms.TextBox tbxSPX;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
    }
}