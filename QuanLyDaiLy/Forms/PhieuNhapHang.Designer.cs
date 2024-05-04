namespace QuanLyDaiLy.Forms
{
    partial class PhieuNhapHang
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
            this.textBoxPNH = new System.Windows.Forms.TextBox();
            this.textBoxTT = new System.Windows.Forms.TextBox();
            this.textBoxNNH = new System.Windows.Forms.TextBox();
            this.SoPhieuNhap = new System.Windows.Forms.Label();
            this.NgayNhapHang = new System.Windows.Forms.Label();
            this.TongTien = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPNH
            // 
            this.textBoxPNH.Location = new System.Drawing.Point(220, 107);
            this.textBoxPNH.Name = "textBoxPNH";
            this.textBoxPNH.Size = new System.Drawing.Size(100, 22);
            this.textBoxPNH.TabIndex = 0;
            // 
            // textBoxTT
            // 
            this.textBoxTT.Location = new System.Drawing.Point(220, 271);
            this.textBoxTT.Name = "textBoxTT";
            this.textBoxTT.Size = new System.Drawing.Size(100, 22);
            this.textBoxTT.TabIndex = 1;
            // 
            // textBoxNNH
            // 
            this.textBoxNNH.Location = new System.Drawing.Point(220, 183);
            this.textBoxNNH.Name = "textBoxNNH";
            this.textBoxNNH.Size = new System.Drawing.Size(100, 22);
            this.textBoxNNH.TabIndex = 2;
            // 
            // SoPhieuNhap
            // 
            this.SoPhieuNhap.AutoSize = true;
            this.SoPhieuNhap.Location = new System.Drawing.Point(122, 107);
            this.SoPhieuNhap.Name = "SoPhieuNhap";
            this.SoPhieuNhap.Size = new System.Drawing.Size(44, 16);
            this.SoPhieuNhap.TabIndex = 3;
            this.SoPhieuNhap.Text = "label1";
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.AutoSize = true;
            this.NgayNhapHang.Location = new System.Drawing.Point(122, 183);
            this.NgayNhapHang.Name = "NgayNhapHang";
            this.NgayNhapHang.Size = new System.Drawing.Size(44, 16);
            this.NgayNhapHang.TabIndex = 4;
            this.NgayNhapHang.Text = "label2";
            // 
            // TongTien
            // 
            this.TongTien.AutoSize = true;
            this.TongTien.Location = new System.Drawing.Point(122, 271);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(44, 16);
            this.TongTien.TabIndex = 5;
            this.TongTien.Text = "label3";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(262, 349);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Luu";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(374, 349);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Lam_moi";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.NgayNhapHang);
            this.Controls.Add(this.SoPhieuNhap);
            this.Controls.Add(this.textBoxNNH);
            this.Controls.Add(this.textBoxTT);
            this.Controls.Add(this.textBoxPNH);
            this.Name = "PhieuNhapHang";
            this.Text = "PhieuNhapHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPNH;
        private System.Windows.Forms.TextBox textBoxTT;
        private System.Windows.Forms.TextBox textBoxNNH;
        private System.Windows.Forms.Label SoPhieuNhap;
        private System.Windows.Forms.Label NgayNhapHang;
        private System.Windows.Forms.Label TongTien;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Reset;
    }
}