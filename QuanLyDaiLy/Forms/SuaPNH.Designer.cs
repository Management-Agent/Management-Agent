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
            this.DGN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // 
            // SearchSPN
            // 
            this.SearchSPN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSPN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchSPN.Location = new System.Drawing.Point(210, 231);
            this.SearchSPN.Name = "SearchSPN";
            this.SearchSPN.Size = new System.Drawing.Size(204, 33);
            this.SearchSPN.TabIndex = 29;
            // 
            // ThemPNH
            // 
            this.ThemPNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemPNH.Location = new System.Drawing.Point(420, 371);
            this.ThemPNH.Name = "ThemPNH";
            this.ThemPNH.Size = new System.Drawing.Size(130, 50);
            this.ThemPNH.TabIndex = 42;
            this.ThemPNH.Text = "Lưu";
            this.ThemPNH.UseVisualStyleBackColor = true;
            this.ThemPNH.Click += new System.EventHandler(this.ThemPNH_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 371);
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
            this.SearchMMH.Location = new System.Drawing.Point(210, 279);
            this.SearchMMH.Name = "SearchMMH";
            this.SearchMMH.Size = new System.Drawing.Size(204, 33);
            this.SearchMMH.TabIndex = 44;
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
            this.dataGridViewCTPNH.Size = new System.Drawing.Size(776, 124);
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
            this.colMMH.ReadOnly = true;
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
            this.colTT.ReadOnly = true;
            this.colTT.Width = 125;
            // 
            // DGN
            // 
            this.DGN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGN.Location = new System.Drawing.Point(210, 381);
            this.DGN.Name = "DGN";
            this.DGN.Size = new System.Drawing.Size(204, 33);
            this.DGN.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(30, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Số lượng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label2.Location = new System.Drawing.Point(30, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Đơn giá nhập";
            // 
            // SLN
            // 
            this.SLN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLN.Location = new System.Drawing.Point(210, 329);
            this.SLN.Name = "SLN";
            this.SLN.Size = new System.Drawing.Size(204, 33);
            this.SLN.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label3.Location = new System.Drawing.Point(30, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Số phiếu nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label4.Location = new System.Drawing.Point(30, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Mã mặt hàng";
            // 
            // SuaPNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SLN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGN);
            this.Controls.Add(this.dataGridViewCTPNH);
            this.Controls.Add(this.SearchMMH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThemPNH);
            this.Controls.Add(this.SearchSPN);
            this.Controls.Add(this.button3);
            this.Name = "SuaPNH";
            this.Text = "SuaPNH";
            this.Load += new System.EventHandler(this.SuaPNH_Load);
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
        private System.Windows.Forms.TextBox DGN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}