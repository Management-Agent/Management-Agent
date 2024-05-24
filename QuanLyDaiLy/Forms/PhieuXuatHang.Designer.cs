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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMDVT = new System.Windows.Forms.ComboBox();
            this.cbMMH = new System.Windows.Forms.ComboBox();
            this.dtpNXH = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemPXH = new System.Windows.Forms.Button();
            this.tbxDGX = new System.Windows.Forms.TextBox();
            this.tbxSLX = new System.Windows.Forms.TextBox();
            this.tbxSPX = new System.Windows.Forms.TextBox();
            this.tbxMDL = new System.Windows.Forms.TextBox();
            this.lblmdl = new System.Windows.Forms.Label();
            this.tbxSTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(340, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 110;
            this.label2.Text = "Phiếu Xuất Hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(699, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 138;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbMDVT
            // 
            this.cbMDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMDVT.FormattingEnabled = true;
            this.cbMDVT.Location = new System.Drawing.Point(607, 285);
            this.cbMDVT.Name = "cbMDVT";
            this.cbMDVT.Size = new System.Drawing.Size(204, 34);
            this.cbMDVT.TabIndex = 137;
            // 
            // cbMMH
            // 
            this.cbMMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMMH.FormattingEnabled = true;
            this.cbMMH.Location = new System.Drawing.Point(607, 122);
            this.cbMMH.Name = "cbMMH";
            this.cbMMH.Size = new System.Drawing.Size(204, 34);
            this.cbMMH.TabIndex = 136;
            // 
            // dtpNXH
            // 
            this.dtpNXH.AllowDrop = true;
            this.dtpNXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNXH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNXH.Location = new System.Drawing.Point(202, 283);
            this.dtpNXH.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpNXH.Name = "dtpNXH";
            this.dtpNXH.Size = new System.Drawing.Size(204, 33);
            this.dtpNXH.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label5.Location = new System.Drawing.Point(456, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 132;
            this.label5.Text = "Mã đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label3.Location = new System.Drawing.Point(462, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 133;
            this.label3.Text = "Đơn giá xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(463, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "Mã mặt hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label9.Location = new System.Drawing.Point(47, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 129;
            this.label9.Text = "Số lượng xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label8.Location = new System.Drawing.Point(33, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 130;
            this.label8.Text = "Ngày xuất hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label7.Location = new System.Drawing.Point(46, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 131;
            this.label7.Text = "Số phiếu xuất";
            // 
            // btnThemPXH
            // 
            this.btnThemPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPXH.Location = new System.Drawing.Point(530, 429);
            this.btnThemPXH.Name = "btnThemPXH";
            this.btnThemPXH.Size = new System.Drawing.Size(130, 50);
            this.btnThemPXH.TabIndex = 128;
            this.btnThemPXH.Text = "Thêm";
            this.btnThemPXH.UseVisualStyleBackColor = true;
            this.btnThemPXH.Click += new System.EventHandler(this.btnThemPXH_Click);
            // 
            // tbxDGX
            // 
            this.tbxDGX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDGX.Location = new System.Drawing.Point(607, 206);
            this.tbxDGX.Name = "tbxDGX";
            this.tbxDGX.Size = new System.Drawing.Size(204, 33);
            this.tbxDGX.TabIndex = 127;
            // 
            // tbxSLX
            // 
            this.tbxSLX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSLX.Location = new System.Drawing.Point(202, 206);
            this.tbxSLX.Name = "tbxSLX";
            this.tbxSLX.Size = new System.Drawing.Size(204, 33);
            this.tbxSLX.TabIndex = 126;
            // 
            // tbxSPX
            // 
            this.tbxSPX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSPX.Location = new System.Drawing.Point(200, 127);
            this.tbxSPX.Name = "tbxSPX";
            this.tbxSPX.Size = new System.Drawing.Size(204, 33);
            this.tbxSPX.TabIndex = 125;
            // 
            // tbxMDL
            // 
            this.tbxMDL.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMDL.Location = new System.Drawing.Point(202, 367);
            this.tbxMDL.Name = "tbxMDL";
            this.tbxMDL.Size = new System.Drawing.Size(204, 33);
            this.tbxMDL.TabIndex = 126;
            // 
            // lblmdl
            // 
            this.lblmdl.AutoSize = true;
            this.lblmdl.BackColor = System.Drawing.Color.Transparent;
            this.lblmdl.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblmdl.Location = new System.Drawing.Point(47, 372);
            this.lblmdl.Name = "lblmdl";
            this.lblmdl.Size = new System.Drawing.Size(108, 25);
            this.lblmdl.TabIndex = 129;
            this.lblmdl.Text = "Mã Đại Lý";
            // 
            // tbxSTT
            // 
            this.tbxSTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSTT.Location = new System.Drawing.Point(598, 364);
            this.tbxSTT.Name = "tbxSTT";
            this.tbxSTT.Size = new System.Drawing.Size(204, 33);
            this.tbxSTT.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label4.Location = new System.Drawing.Point(473, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 129;
            this.label4.Text = "Số tiên trả";
            // 
            // PhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMDVT);
            this.Controls.Add(this.cbMMH);
            this.Controls.Add(this.dtpNXH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmdl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThemPXH);
            this.Controls.Add(this.tbxDGX);
            this.Controls.Add(this.tbxSTT);
            this.Controls.Add(this.tbxMDL);
            this.Controls.Add(this.tbxSLX);
            this.Controls.Add(this.tbxSPX);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(882, 554);
            this.MinimumSize = new System.Drawing.Size(882, 554);
            this.Name = "PhieuXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhieuXuatHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbMDVT;
        private System.Windows.Forms.ComboBox cbMMH;
        private System.Windows.Forms.DateTimePicker dtpNXH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemPXH;
        private System.Windows.Forms.TextBox tbxDGX;
        private System.Windows.Forms.TextBox tbxSLX;
        private System.Windows.Forms.TextBox tbxSPX;
        private System.Windows.Forms.TextBox tbxMDL;
        private System.Windows.Forms.Label lblmdl;
        private System.Windows.Forms.TextBox tbxSTT;
        private System.Windows.Forms.Label label4;
    }
}