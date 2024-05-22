namespace QuanLyDaiLy.Forms
{
    partial class SuaPhieuThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaPhieuThuTien));
            this.dgvSPTT = new System.Windows.Forms.DataGridView();
            this.colSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSTT = new System.Windows.Forms.TextBox();
            this.tbxMDL = new System.Windows.Forms.TextBox();
            this.tbxSPT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSPTT
            // 
            this.dgvSPTT.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvSPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPN,
            this.colMMH,
            this.colSLN,
            this.colDGN});
            this.dgvSPTT.Location = new System.Drawing.Point(68, 53);
            this.dgvSPTT.Name = "dgvSPTT";
            this.dgvSPTT.RowHeadersWidth = 51;
            this.dgvSPTT.RowTemplate.Height = 24;
            this.dgvSPTT.Size = new System.Drawing.Size(654, 124);
            this.dgvSPTT.TabIndex = 64;
            // 
            // colSPN
            // 
            this.colSPN.DataPropertyName = "SoPhieuThu";
            this.colSPN.HeaderText = "Số phiếu thu";
            this.colSPN.MinimumWidth = 6;
            this.colSPN.Name = "colSPN";
            this.colSPN.ReadOnly = true;
            this.colSPN.Width = 150;
            // 
            // colMMH
            // 
            this.colMMH.DataPropertyName = "MaDaiLy";
            this.colMMH.HeaderText = "Mã Đại lý";
            this.colMMH.MinimumWidth = 6;
            this.colMMH.Name = "colMMH";
            this.colMMH.ReadOnly = true;
            this.colMMH.Width = 150;
            // 
            // colSLN
            // 
            this.colSLN.DataPropertyName = "NgayThuTien";
            this.colSLN.HeaderText = "Ngày thu tiền";
            this.colSLN.MinimumWidth = 6;
            this.colSLN.Name = "colSLN";
            this.colSLN.Width = 150;
            // 
            // colDGN
            // 
            this.colDGN.DataPropertyName = "SoTienThu";
            this.colDGN.HeaderText = "Số tiền thu";
            this.colDGN.MinimumWidth = 6;
            this.colDGN.Name = "colDGN";
            this.colDGN.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label4.Location = new System.Drawing.Point(82, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Mã Đại lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label3.Location = new System.Drawing.Point(82, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Số phiếu thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label2.Location = new System.Drawing.Point(82, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Số tiền thu";
            // 
            // tbxSTT
            // 
            this.tbxSTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSTT.Location = new System.Drawing.Point(252, 297);
            this.tbxSTT.Name = "tbxSTT";
            this.tbxSTT.Size = new System.Drawing.Size(204, 33);
            this.tbxSTT.TabIndex = 71;
            // 
            // tbxMDL
            // 
            this.tbxMDL.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMDL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxMDL.Location = new System.Drawing.Point(252, 243);
            this.tbxMDL.Name = "tbxMDL";
            this.tbxMDL.ReadOnly = true;
            this.tbxMDL.Size = new System.Drawing.Size(204, 33);
            this.tbxMDL.TabIndex = 70;
            // 
            // tbxSPT
            // 
            this.tbxSPT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSPT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSPT.Location = new System.Drawing.Point(252, 195);
            this.tbxSPT.Name = "tbxSPT";
            this.tbxSPT.Size = new System.Drawing.Size(204, 33);
            this.tbxSPT.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 78;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(488, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "Sửa phiếu thu tiền";
            // 
            // SuaPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSTT);
            this.Controls.Add(this.tbxMDL);
            this.Controls.Add(this.tbxSPT);
            this.Controls.Add(this.dgvSPTT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 458);
            this.MinimumSize = new System.Drawing.Size(815, 458);
            this.Name = "SuaPhieuThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuaPhieuThuTien";
            this.Load += new System.EventHandler(this.SuaPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSPTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSTT;
        private System.Windows.Forms.TextBox tbxMDL;
        private System.Windows.Forms.TextBox tbxSPT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}