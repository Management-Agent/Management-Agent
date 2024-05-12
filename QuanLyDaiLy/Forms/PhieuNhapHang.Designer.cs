namespace QuanLyDaiLy
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
            this.SPN = new System.Windows.Forms.TextBox();
            this.MMH = new System.Windows.Forms.TextBox();
            this.SLN = new System.Windows.Forms.TextBox();
            this.DGN = new System.Windows.Forms.TextBox();
            this.TT = new System.Windows.Forms.TextBox();
            this.ThemPNH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SPN
            // 
            this.SPN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPN.Location = new System.Drawing.Point(269, 109);
            this.SPN.Name = "SPN";
            this.SPN.Size = new System.Drawing.Size(611, 33);
            this.SPN.TabIndex = 2;
            // 
            // MMH
            // 
            this.MMH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMH.Location = new System.Drawing.Point(269, 188);
            this.MMH.Name = "MMH";
            this.MMH.Size = new System.Drawing.Size(204, 33);
            this.MMH.TabIndex = 3;
            // 
            // SLN
            // 
            this.SLN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLN.Location = new System.Drawing.Point(676, 188);
            this.SLN.Name = "SLN";
            this.SLN.Size = new System.Drawing.Size(204, 33);
            this.SLN.TabIndex = 4;
            // 
            // DGN
            // 
            this.DGN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGN.Location = new System.Drawing.Point(269, 272);
            this.DGN.Name = "DGN";
            this.DGN.Size = new System.Drawing.Size(204, 33);
            this.DGN.TabIndex = 5;
            // 
            // TT
            // 
            this.TT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TT.Location = new System.Drawing.Point(676, 272);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(204, 33);
            this.TT.TabIndex = 6;
            // 
            // ThemPNH
            // 
            this.ThemPNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemPNH.Location = new System.Drawing.Point(574, 398);
            this.ThemPNH.Name = "ThemPNH";
            this.ThemPNH.Size = new System.Drawing.Size(130, 50);
            this.ThemPNH.TabIndex = 17;
            this.ThemPNH.Text = "Thêm";
            this.ThemPNH.UseVisualStyleBackColor = true;
            this.ThemPNH.Click += new System.EventHandler(this.ThemPNH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(127, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label2.Location = new System.Drawing.Point(127, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số lượng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Thành tiền";
            // 
            // PhieuNhapHang
            // 
            this.ClientSize = new System.Drawing.Size(993, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemPNH);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.DGN);
            this.Controls.Add(this.SLN);
            this.Controls.Add(this.MMH);
            this.Controls.Add(this.SPN);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.Name = "PhieuNhapHang";
            this.Text = "PhieuNhapHang";
            this.Load += new System.EventHandler(this.PhieuNhapHang_Load);
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
        private System.Windows.Forms.TextBox SPN;
        private System.Windows.Forms.TextBox MMH;
        private System.Windows.Forms.TextBox SLN;
        private System.Windows.Forms.TextBox DGN;
        private System.Windows.Forms.TextBox TT;
        private System.Windows.Forms.Button ThemPNH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}