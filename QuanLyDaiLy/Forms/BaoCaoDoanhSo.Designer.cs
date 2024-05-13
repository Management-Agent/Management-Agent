namespace QuanLyDaiLy.Forms
{
    partial class BaoCaoDoanhSo
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
            this.dataGridViewBCDS = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.labelThang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBCDS
            // 
            this.dataGridViewBCDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBCDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colDaiLy,
            this.colSoPhieuXuat,
            this.colTongTriGia,
            this.colTyLe});
            this.dataGridViewBCDS.Location = new System.Drawing.Point(31, 105);
            this.dataGridViewBCDS.Name = "dataGridViewBCDS";
            this.dataGridViewBCDS.ReadOnly = true;
            this.dataGridViewBCDS.RowHeadersWidth = 51;
            this.dataGridViewBCDS.RowTemplate.Height = 24;
            this.dataGridViewBCDS.Size = new System.Drawing.Size(768, 318);
            this.dataGridViewBCDS.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 37);
            this.label6.TabIndex = 43;
            this.label6.Text = "Báo Cáo Doanh Số";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.Location = new System.Drawing.Point(246, 66);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(80, 25);
            this.labelThang.TabIndex = 44;
            this.labelThang.Text = "Tháng: ";
            this.labelThang.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "................";
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colDaiLy
            // 
            this.colDaiLy.HeaderText = "Đại Lý";
            this.colDaiLy.MinimumWidth = 6;
            this.colDaiLy.Name = "colDaiLy";
            this.colDaiLy.ReadOnly = true;
            this.colDaiLy.Width = 200;
            // 
            // colSoPhieuXuat
            // 
            this.colSoPhieuXuat.HeaderText = "Số Phiếu Xuất";
            this.colSoPhieuXuat.MinimumWidth = 6;
            this.colSoPhieuXuat.Name = "colSoPhieuXuat";
            this.colSoPhieuXuat.ReadOnly = true;
            this.colSoPhieuXuat.Width = 125;
            // 
            // colTongTriGia
            // 
            this.colTongTriGia.HeaderText = "Tổng Trị Giá";
            this.colTongTriGia.MinimumWidth = 6;
            this.colTongTriGia.Name = "colTongTriGia";
            this.colTongTriGia.ReadOnly = true;
            this.colTongTriGia.Width = 200;
            // 
            // colTyLe
            // 
            this.colTyLe.HeaderText = "Tỷ Lệ";
            this.colTyLe.MinimumWidth = 6;
            this.colTyLe.Name = "colTyLe";
            this.colTyLe.ReadOnly = true;
            this.colTyLe.Width = 75;
            // 
            // BaoCaoDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewBCDS);
            this.Name = "BaoCaoDoanhSo";
            this.Text = "BaoCaoDoanhSo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBCDS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTyLe;
    }
}