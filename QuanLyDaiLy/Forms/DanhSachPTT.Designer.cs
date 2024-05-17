namespace QuanLyDaiLy.Forms
{
    partial class DanhSachPTT
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
            this.dgvDSPTT = new System.Windows.Forms.DataGridView();
            this.colSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTCPTT = new System.Windows.Forms.Button();
            this.btnXPTT = new System.Windows.Forms.Button();
            this.btnTPTT = new System.Windows.Forms.Button();
            this.btnSPTT = new System.Windows.Forms.Button();
            this.tbxTCPTT = new System.Windows.Forms.TextBox();
            this.tbxXPTT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPTT
            // 
            this.dgvDSPTT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPN,
            this.colMMH,
            this.colSLN,
            this.colDGN});
            this.dgvDSPTT.Location = new System.Drawing.Point(38, 68);
            this.dgvDSPTT.Name = "dgvDSPTT";
            this.dgvDSPTT.RowHeadersWidth = 51;
            this.dgvDSPTT.RowTemplate.Height = 24;
            this.dgvDSPTT.Size = new System.Drawing.Size(659, 124);
            this.dgvDSPTT.TabIndex = 63;
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
            // btnTCPTT
            // 
            this.btnTCPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCPTT.Location = new System.Drawing.Point(23, 228);
            this.btnTCPTT.Name = "btnTCPTT";
            this.btnTCPTT.Size = new System.Drawing.Size(260, 50);
            this.btnTCPTT.TabIndex = 64;
            this.btnTCPTT.Text = "Tra cứu phiếu thu tiền";
            this.btnTCPTT.UseVisualStyleBackColor = true;
            this.btnTCPTT.Click += new System.EventHandler(this.btnTCPTT_Click);
            // 
            // btnXPTT
            // 
            this.btnXPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPTT.Location = new System.Drawing.Point(23, 295);
            this.btnXPTT.Name = "btnXPTT";
            this.btnXPTT.Size = new System.Drawing.Size(260, 50);
            this.btnXPTT.TabIndex = 64;
            this.btnXPTT.Text = "Xóa phiếu thu tiền";
            this.btnXPTT.UseVisualStyleBackColor = true;
            this.btnXPTT.Click += new System.EventHandler(this.btnXPTT_Click);
            // 
            // btnTPTT
            // 
            this.btnTPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTT.Location = new System.Drawing.Point(393, 360);
            this.btnTPTT.Name = "btnTPTT";
            this.btnTPTT.Size = new System.Drawing.Size(260, 50);
            this.btnTPTT.TabIndex = 64;
            this.btnTPTT.Text = "Thêm phiếu thu tiền";
            this.btnTPTT.UseVisualStyleBackColor = true;
            this.btnTPTT.Click += new System.EventHandler(this.btnTPTT_Click);
            // 
            // btnSPTT
            // 
            this.btnSPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPTT.Location = new System.Drawing.Point(23, 360);
            this.btnSPTT.Name = "btnSPTT";
            this.btnSPTT.Size = new System.Drawing.Size(260, 50);
            this.btnSPTT.TabIndex = 64;
            this.btnSPTT.Text = "Sửa phiếu thu tiền";
            this.btnSPTT.UseVisualStyleBackColor = true;
            this.btnSPTT.Click += new System.EventHandler(this.btnSPTT_Click);
            // 
            // tbxTCPTT
            // 
            this.tbxTCPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTCPTT.Location = new System.Drawing.Point(337, 238);
            this.tbxTCPTT.Name = "tbxTCPTT";
            this.tbxTCPTT.Size = new System.Drawing.Size(326, 33);
            this.tbxTCPTT.TabIndex = 65;
            // 
            // tbxXPTT
            // 
            this.tbxXPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxXPTT.Location = new System.Drawing.Point(337, 305);
            this.tbxXPTT.Name = "tbxXPTT";
            this.tbxXPTT.Size = new System.Drawing.Size(326, 33);
            this.tbxXPTT.TabIndex = 65;
            // 
            // DanhSachPTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 471);
            this.Controls.Add(this.tbxXPTT);
            this.Controls.Add(this.tbxTCPTT);
            this.Controls.Add(this.btnSPTT);
            this.Controls.Add(this.btnTPTT);
            this.Controls.Add(this.btnXPTT);
            this.Controls.Add(this.btnTCPTT);
            this.Controls.Add(this.dgvDSPTT);
            this.Name = "DanhSachPTT";
            this.Text = "DanhSachPTT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGN;
        private System.Windows.Forms.Button btnTCPTT;
        private System.Windows.Forms.Button btnXPTT;
        private System.Windows.Forms.Button btnTPTT;
        private System.Windows.Forms.Button btnSPTT;
        private System.Windows.Forms.TextBox tbxTCPTT;
        private System.Windows.Forms.TextBox tbxXPTT;
    }
}