namespace QuanLyDaiLy.Forms
{
    partial class SuaPNH
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
            this.button3 = new System.Windows.Forms.Button();
            this.SearchSPN = new System.Windows.Forms.TextBox();
            this.ThemPNH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchMMH = new System.Windows.Forms.TextBox();
            this.dataGridViewCTPNH = new System.Windows.Forms.DataGridView();
            this.colSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPNH)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 50);
            this.button3.TabIndex = 22;
            this.button3.Text = "Tra cứu chi tiết phiếu nhập hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchSPN
            // 
            this.SearchSPN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSPN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchSPN.Location = new System.Drawing.Point(420, 22);
            this.SearchSPN.Name = "SearchSPN";
            this.SearchSPN.Size = new System.Drawing.Size(158, 33);
            this.SearchSPN.TabIndex = 29;
            this.SearchSPN.Text = "Số phiếu nhập";
            // 
            // ThemPNH
            // 
            this.ThemPNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemPNH.Location = new System.Drawing.Point(401, 341);
            this.ThemPNH.Name = "ThemPNH";
            this.ThemPNH.Size = new System.Drawing.Size(130, 50);
            this.ThemPNH.TabIndex = 42;
            this.ThemPNH.Text = "Lưu";
            this.ThemPNH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(571, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 43;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchMMH
            // 
            this.SearchMMH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMMH.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchMMH.Location = new System.Drawing.Point(607, 22);
            this.SearchMMH.Name = "SearchMMH";
            this.SearchMMH.Size = new System.Drawing.Size(158, 33);
            this.SearchMMH.TabIndex = 44;
            this.SearchMMH.Text = "Mã mặt hàng";
            // 
            // dataGridViewCTPNH
            // 
            this.dataGridViewCTPNH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCTPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTPNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPN,
            this.colMMH,
            this.colSLN,
            this.colDGN,
            this.colTT});
            this.dataGridViewCTPNH.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewCTPNH.Name = "dataGridViewCTPNH";
            this.dataGridViewCTPNH.RowHeadersWidth = 51;
            this.dataGridViewCTPNH.RowTemplate.Height = 24;
            this.dataGridViewCTPNH.Size = new System.Drawing.Size(776, 230);
            this.dataGridViewCTPNH.TabIndex = 46;
            // 
            // colSPN
            // 
            this.colSPN.DataPropertyName = "SoPhieuNhap";
            this.colSPN.HeaderText = "Số phiếu nhập";
            this.colSPN.MinimumWidth = 6;
            this.colSPN.Name = "colSPN";
            this.colSPN.ReadOnly = true;
            this.colSPN.Width = 125;
            // 
            // colMMH
            // 
            this.colMMH.DataPropertyName = "MaMatHang";
            this.colMMH.HeaderText = "Mã mặt hàng";
            this.colMMH.MinimumWidth = 6;
            this.colMMH.Name = "colMMH";
            this.colMMH.Width = 125;
            // 
            // colSLN
            // 
            this.colSLN.DataPropertyName = "SoLuongNhap";
            this.colSLN.HeaderText = "Số lượng nhập";
            this.colSLN.MinimumWidth = 6;
            this.colSLN.Name = "colSLN";
            this.colSLN.Width = 125;
            // 
            // colDGN
            // 
            this.colDGN.DataPropertyName = "DonGiaNhap";
            this.colDGN.HeaderText = "Đơn giá nhập";
            this.colDGN.MinimumWidth = 6;
            this.colDGN.Name = "colDGN";
            this.colDGN.Width = 125;
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "ThanhTien";
            this.colTT.HeaderText = "Thành tiền";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.Width = 125;
            // 
            // SuaPNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCTPNH);
            this.Controls.Add(this.SearchMMH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThemPNH);
            this.Controls.Add(this.SearchSPN);
            this.Controls.Add(this.button3);
            this.Name = "SuaPNH";
            this.Text = "SuaPNH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SearchSPN;
        private System.Windows.Forms.Button ThemPNH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchMMH;
        private System.Windows.Forms.DataGridView dataGridViewCTPNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
    }
}