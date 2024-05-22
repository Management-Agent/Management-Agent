namespace QuanLyDaiLy.Forms
{
    partial class SuaPXH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaPXH));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSLX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDGX = new System.Windows.Forms.TextBox();
            this.dataGridViewCTPXH = new System.Windows.Forms.DataGridView();
            this.colSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxMMHX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxSPX = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPXH)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label4.Location = new System.Drawing.Point(12, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Mã mặt hàng xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label3.Location = new System.Drawing.Point(30, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Số phiếu Xuất";
            // 
            // tbxSLX
            // 
            this.tbxSLX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSLX.Location = new System.Drawing.Point(210, 338);
            this.tbxSLX.Name = "tbxSLX";
            this.tbxSLX.Size = new System.Drawing.Size(204, 33);
            this.tbxSLX.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label2.Location = new System.Drawing.Point(30, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Đơn giá xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(30, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Số lượng xuất";
            // 
            // tbxDGX
            // 
            this.tbxDGX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDGX.Location = new System.Drawing.Point(210, 390);
            this.tbxDGX.Name = "tbxDGX";
            this.tbxDGX.Size = new System.Drawing.Size(204, 33);
            this.tbxDGX.TabIndex = 63;
            // 
            // dataGridViewCTPXH
            // 
            this.dataGridViewCTPXH.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewCTPXH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTPXH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPN,
            this.colMMH,
            this.colSLN,
            this.colDGN,
            this.colTT});
            this.dataGridViewCTPXH.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewCTPXH.Name = "dataGridViewCTPXH";
            this.dataGridViewCTPXH.RowHeadersWidth = 51;
            this.dataGridViewCTPXH.RowTemplate.Height = 24;
            this.dataGridViewCTPXH.Size = new System.Drawing.Size(810, 124);
            this.dataGridViewCTPXH.TabIndex = 62;
            // 
            // colSPN
            // 
            this.colSPN.DataPropertyName = "SoPhieuXuat";
            this.colSPN.HeaderText = "Số phiếu xuất";
            this.colSPN.MinimumWidth = 6;
            this.colSPN.Name = "colSPN";
            this.colSPN.ReadOnly = true;
            this.colSPN.Width = 150;
            // 
            // colMMH
            // 
            this.colMMH.DataPropertyName = "MaMatHangXuat";
            this.colMMH.HeaderText = "Mã mặt hàng xuất";
            this.colMMH.MinimumWidth = 6;
            this.colMMH.Name = "colMMH";
            this.colMMH.ReadOnly = true;
            this.colMMH.Width = 150;
            // 
            // colSLN
            // 
            this.colSLN.DataPropertyName = "SoLuongXuat";
            this.colSLN.HeaderText = "Số lượng xuất";
            this.colSLN.MinimumWidth = 6;
            this.colSLN.Name = "colSLN";
            this.colSLN.Width = 150;
            // 
            // colDGN
            // 
            this.colDGN.DataPropertyName = "DonGiaXuat";
            this.colDGN.HeaderText = "Đơn giá xuất";
            this.colDGN.MinimumWidth = 6;
            this.colDGN.Name = "colDGN";
            this.colDGN.Width = 150;
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "ThanhTien";
            this.colTT.HeaderText = "Thành tiền";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            this.colTT.Width = 150;
            // 
            // tbxMMHX
            // 
            this.tbxMMHX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMMHX.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxMMHX.Location = new System.Drawing.Point(210, 288);
            this.tbxMMHX.Name = "tbxMMHX";
            this.tbxMMHX.Size = new System.Drawing.Size(204, 33);
            this.tbxMMHX.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 60;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(512, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxSPX
            // 
            this.tbxSPX.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSPX.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSPX.Location = new System.Drawing.Point(210, 240);
            this.tbxSPX.Name = "tbxSPX";
            this.tbxSPX.Size = new System.Drawing.Size(204, 33);
            this.tbxSPX.TabIndex = 58;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 50);
            this.button3.TabIndex = 57;
            this.button3.Text = "Tra cứu chi tiết phiếu xuất hàng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SuaPXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSLX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDGX);
            this.Controls.Add(this.dataGridViewCTPXH);
            this.Controls.Add(this.tbxMMHX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxSPX);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(852, 497);
            this.MinimumSize = new System.Drawing.Size(852, 497);
            this.Name = "SuaPXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuaPXH";
            this.Load += new System.EventHandler(this.SuaPXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPXH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSLX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDGX;
        private System.Windows.Forms.DataGridView dataGridViewCTPXH;
        private System.Windows.Forms.TextBox tbxMMHX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxSPX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
    }
}