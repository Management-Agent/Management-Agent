namespace QuanLyDaiLy.Forms
{
    partial class DanhSachPXH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPXH));
            this.tbxXPXH = new System.Windows.Forms.TextBox();
            this.tbxTTPXH = new System.Windows.Forms.TextBox();
            this.btnTCPXH = new System.Windows.Forms.Button();
            this.btnSPXH = new System.Windows.Forms.Button();
            this.btnXPXH = new System.Windows.Forms.Button();
            this.btnTPXH = new System.Windows.Forms.Button();
            this.dgvPXH = new System.Windows.Forms.DataGridView();
            this.colSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPXH)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxXPXH
            // 
            this.tbxXPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxXPXH.Location = new System.Drawing.Point(462, 334);
            this.tbxXPXH.Name = "tbxXPXH";
            this.tbxXPXH.Size = new System.Drawing.Size(368, 33);
            this.tbxXPXH.TabIndex = 36;
            // 
            // tbxTTPXH
            // 
            this.tbxTTPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTTPXH.Location = new System.Drawing.Point(462, 278);
            this.tbxTTPXH.Name = "tbxTTPXH";
            this.tbxTTPXH.Size = new System.Drawing.Size(368, 33);
            this.tbxTTPXH.TabIndex = 35;
            // 
            // btnTCPXH
            // 
            this.btnTCPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCPXH.Location = new System.Drawing.Point(42, 268);
            this.btnTCPXH.Name = "btnTCPXH";
            this.btnTCPXH.Size = new System.Drawing.Size(368, 50);
            this.btnTCPXH.TabIndex = 34;
            this.btnTCPXH.Text = "Tra cứu phiếu Xuất hàng";
            this.btnTCPXH.UseVisualStyleBackColor = true;
            this.btnTCPXH.Click += new System.EventHandler(this.btnTCPXH_Click);
            // 
            // btnSPXH
            // 
            this.btnSPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPXH.Location = new System.Drawing.Point(462, 388);
            this.btnSPXH.Name = "btnSPXH";
            this.btnSPXH.Size = new System.Drawing.Size(368, 50);
            this.btnSPXH.TabIndex = 33;
            this.btnSPXH.Text = "Sửa phiếu xuất hàng";
            this.btnSPXH.UseVisualStyleBackColor = true;
            this.btnSPXH.Click += new System.EventHandler(this.btnSPXH_Click);
            // 
            // btnXPXH
            // 
            this.btnXPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPXH.Location = new System.Drawing.Point(42, 324);
            this.btnXPXH.Name = "btnXPXH";
            this.btnXPXH.Size = new System.Drawing.Size(368, 50);
            this.btnXPXH.TabIndex = 32;
            this.btnXPXH.Text = "Xóa phiếu xuất hàng";
            this.btnXPXH.UseVisualStyleBackColor = true;
            this.btnXPXH.Click += new System.EventHandler(this.btnXPXH_Click);
            // 
            // btnTPXH
            // 
            this.btnTPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPXH.Location = new System.Drawing.Point(42, 388);
            this.btnTPXH.Name = "btnTPXH";
            this.btnTPXH.Size = new System.Drawing.Size(368, 50);
            this.btnTPXH.TabIndex = 31;
            this.btnTPXH.Text = "Thêm phiếu xuất hàng";
            this.btnTPXH.UseVisualStyleBackColor = true;
            this.btnTPXH.Click += new System.EventHandler(this.btnTPXH_Click);
            // 
            // dgvPXH
            // 
            this.dgvPXH.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvPXH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPXH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPN,
            this.colNNH,
            this.colTT,
            this.MaDaiLy});
            this.dgvPXH.Location = new System.Drawing.Point(13, 13);
            this.dgvPXH.Name = "dgvPXH";
            this.dgvPXH.ReadOnly = true;
            this.dgvPXH.RowHeadersWidth = 51;
            this.dgvPXH.RowTemplate.Height = 24;
            this.dgvPXH.Size = new System.Drawing.Size(817, 249);
            this.dgvPXH.TabIndex = 30;
            // 
            // colSPN
            // 
            this.colSPN.DataPropertyName = "SoPhieuXuat";
            this.colSPN.HeaderText = "Số phiếu Xuất hàng";
            this.colSPN.MinimumWidth = 6;
            this.colSPN.Name = "colSPN";
            this.colSPN.ReadOnly = true;
            this.colSPN.Width = 200;
            // 
            // colNNH
            // 
            this.colNNH.DataPropertyName = "NgayXuatHang";
            this.colNNH.HeaderText = "Ngày xuất hàng";
            this.colNNH.MinimumWidth = 6;
            this.colNNH.Name = "colNNH";
            this.colNNH.ReadOnly = true;
            this.colNNH.Width = 200;
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "TongTien";
            this.colTT.HeaderText = "Tổng tiền";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            this.colTT.Width = 200;
            // 
            // MaDaiLy
            // 
            this.MaDaiLy.DataPropertyName = "MaDaiLy";
            this.MaDaiLy.HeaderText = "Mã Đại Lý";
            this.MaDaiLy.MinimumWidth = 6;
            this.MaDaiLy.Name = "MaDaiLy";
            this.MaDaiLy.ReadOnly = true;
            this.MaDaiLy.Width = 170;
            // 
            // DanhSachPXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 457);
            this.Controls.Add(this.tbxXPXH);
            this.Controls.Add(this.tbxTTPXH);
            this.Controls.Add(this.btnTCPXH);
            this.Controls.Add(this.btnSPXH);
            this.Controls.Add(this.btnXPXH);
            this.Controls.Add(this.btnTPXH);
            this.Controls.Add(this.dgvPXH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 504);
            this.MinimumSize = new System.Drawing.Size(940, 504);
            this.Name = "DanhSachPXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachPXH";
            this.Load += new System.EventHandler(this.DanhSachPXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPXH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxXPXH;
        private System.Windows.Forms.TextBox tbxTTPXH;
        private System.Windows.Forms.Button btnTCPXH;
        private System.Windows.Forms.Button btnSPXH;
        private System.Windows.Forms.Button btnXPXH;
        private System.Windows.Forms.Button btnTPXH;
        private System.Windows.Forms.DataGridView dgvPXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDaiLy;
    }
}