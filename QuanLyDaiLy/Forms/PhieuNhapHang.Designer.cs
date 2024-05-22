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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhapHang));
            this.SPN = new System.Windows.Forms.TextBox();
            this.SLN = new System.Windows.Forms.TextBox();
            this.DGN = new System.Windows.Forms.TextBox();
            this.ThemPNH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NNH = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MMH = new System.Windows.Forms.ComboBox();
            this.MDVT = new System.Windows.Forms.ComboBox();
            this.TDVT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TMH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SPN
            // 
            this.SPN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPN.Location = new System.Drawing.Point(225, 108);
            this.SPN.Name = "SPN";
            this.SPN.Size = new System.Drawing.Size(204, 33);
            this.SPN.TabIndex = 2;
            // 
            // SLN
            // 
            this.SLN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLN.Location = new System.Drawing.Point(227, 187);
            this.SLN.Name = "SLN";
            this.SLN.Size = new System.Drawing.Size(204, 33);
            this.SLN.TabIndex = 4;
            // 
            // DGN
            // 
            this.DGN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGN.Location = new System.Drawing.Point(632, 187);
            this.DGN.Name = "DGN";
            this.DGN.Size = new System.Drawing.Size(204, 33);
            this.DGN.TabIndex = 5;
            // 
            // ThemPNH
            // 
            this.ThemPNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemPNH.Location = new System.Drawing.Point(577, 414);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(71, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label2.Location = new System.Drawing.Point(488, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(69, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số lượng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(488, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(69, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày nhập hàng";
            // 
            // NNH
            // 
            this.NNH.AllowDrop = true;
            this.NNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NNH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NNH.Location = new System.Drawing.Point(227, 264);
            this.NNH.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.NNH.Name = "NNH";
            this.NNH.Size = new System.Drawing.Size(204, 33);
            this.NNH.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(488, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã đơn vị tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(71, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tên đơn vị tính";
            // 
            // MMH
            // 
            this.MMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MMH.FormattingEnabled = true;
            this.MMH.Location = new System.Drawing.Point(632, 108);
            this.MMH.Name = "MMH";
            this.MMH.Size = new System.Drawing.Size(204, 33);
            this.MMH.TabIndex = 29;
            this.MMH.SelectedIndexChanged += new System.EventHandler(this.MMH_SelectedIndexChanged);
            // 
            // MDVT
            // 
            this.MDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MDVT.FormattingEnabled = true;
            this.MDVT.Location = new System.Drawing.Point(632, 267);
            this.MDVT.Name = "MDVT";
            this.MDVT.Size = new System.Drawing.Size(204, 33);
            this.MDVT.TabIndex = 30;
            this.MDVT.SelectedIndexChanged += new System.EventHandler(this.MDVT_SelectedIndexChanged);
            // 
            // TDVT
            // 
            this.TDVT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDVT.Location = new System.Drawing.Point(227, 339);
            this.TDVT.Name = "TDVT";
            this.TDVT.ReadOnly = true;
            this.TDVT.Size = new System.Drawing.Size(204, 33);
            this.TDVT.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(746, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TMH
            // 
            this.TMH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMH.Location = new System.Drawing.Point(632, 339);
            this.TMH.Name = "TMH";
            this.TMH.ReadOnly = true;
            this.TMH.Size = new System.Drawing.Size(204, 33);
            this.TMH.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(488, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tên mặt hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(343, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 31);
            this.label9.TabIndex = 111;
            this.label9.Text = "Phiếu Nhập Hàng";
            // 
            // PhieuNhapHang
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TMH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MDVT);
            this.Controls.Add(this.MMH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TDVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NNH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemPNH);
            this.Controls.Add(this.DGN);
            this.Controls.Add(this.SLN);
            this.Controls.Add(this.SPN);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(929, 534);
            this.MinimumSize = new System.Drawing.Size(929, 534);
            this.Name = "PhieuNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox SLN;
        private System.Windows.Forms.TextBox DGN;
        private System.Windows.Forms.Button ThemPNH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NNH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MMH;
        private System.Windows.Forms.ComboBox MDVT;
        private System.Windows.Forms.TextBox TDVT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TMH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}