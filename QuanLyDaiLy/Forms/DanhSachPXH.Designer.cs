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
            this.tbxTCPXH = new System.Windows.Forms.TextBox();
            this.btnTCPXH = new System.Windows.Forms.Button();
            this.btnSPXH = new System.Windows.Forms.Button();
            this.btnXPXH = new System.Windows.Forms.Button();
            this.btnTPXH = new System.Windows.Forms.Button();
            this.dgvPXH = new System.Windows.Forms.DataGridView();
            this.SoPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // tbxTCPXH
            // 
            this.tbxTCPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTCPXH.Location = new System.Drawing.Point(462, 278);
            this.tbxTCPXH.Name = "tbxTCPXH";
            this.tbxTCPXH.Size = new System.Drawing.Size(368, 33);
            this.tbxTCPXH.TabIndex = 35;
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
            this.dgvPXH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPXH.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvPXH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPXH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuXuat,
            this.MaDaiLy,
            this.NgayXuatHang,
            this.TongTien,
            this.SoTienTra,
            this.ConLai});
            this.dgvPXH.Location = new System.Drawing.Point(13, 13);
            this.dgvPXH.MultiSelect = false;
            this.dgvPXH.Name = "dgvPXH";
            this.dgvPXH.ReadOnly = true;
            this.dgvPXH.RowHeadersWidth = 51;
            this.dgvPXH.RowTemplate.Height = 24;
            this.dgvPXH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPXH.Size = new System.Drawing.Size(817, 249);
            this.dgvPXH.TabIndex = 30;
            // 
            // SoPhieuXuat
            // 
            this.SoPhieuXuat.DataPropertyName = "SoPhieuXuat";
            this.SoPhieuXuat.HeaderText = "Số phiếu Xuất hàng";
            this.SoPhieuXuat.MinimumWidth = 6;
            this.SoPhieuXuat.Name = "SoPhieuXuat";
            this.SoPhieuXuat.ReadOnly = true;
            // 
            // MaDaiLy
            // 
            this.MaDaiLy.DataPropertyName = "MaDaiLy";
            this.MaDaiLy.HeaderText = "MaDaiLy";
            this.MaDaiLy.MinimumWidth = 6;
            this.MaDaiLy.Name = "MaDaiLy";
            this.MaDaiLy.ReadOnly = true;
            // 
            // NgayXuatHang
            // 
            this.NgayXuatHang.DataPropertyName = "NgayXuatHang";
            this.NgayXuatHang.HeaderText = "NgayXuathang";
            this.NgayXuatHang.MinimumWidth = 6;
            this.NgayXuatHang.Name = "NgayXuatHang";
            this.NgayXuatHang.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "TongTien";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // SoTienTra
            // 
            this.SoTienTra.DataPropertyName = "SoTienTra";
            this.SoTienTra.HeaderText = "SoTienTra";
            this.SoTienTra.MinimumWidth = 6;
            this.SoTienTra.Name = "SoTienTra";
            this.SoTienTra.ReadOnly = true;
            // 
            // ConLai
            // 
            this.ConLai.DataPropertyName = "ConLai";
            this.ConLai.HeaderText = "ConLai";
            this.ConLai.MinimumWidth = 6;
            this.ConLai.Name = "ConLai";
            this.ConLai.ReadOnly = true;
            // 
            // DanhSachPXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 457);
            this.Controls.Add(this.tbxXPXH);
            this.Controls.Add(this.tbxTCPXH);
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
        private System.Windows.Forms.TextBox tbxTCPXH;
        private System.Windows.Forms.Button btnTCPXH;
        private System.Windows.Forms.Button btnSPXH;
        private System.Windows.Forms.Button btnXPXH;
        private System.Windows.Forms.Button btnTPXH;
        private System.Windows.Forms.DataGridView dgvPXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConLai;
    }
}