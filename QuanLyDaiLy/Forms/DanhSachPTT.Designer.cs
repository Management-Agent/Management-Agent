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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPTT));
            this.dgvDSPTT = new System.Windows.Forms.DataGridView();
            this.colSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTCPTT = new System.Windows.Forms.Button();
            this.btnXPTT = new System.Windows.Forms.Button();
            this.btnTPTT = new System.Windows.Forms.Button();
            this.tbxTCPTT = new System.Windows.Forms.TextBox();
            this.tbxXPTT = new System.Windows.Forms.TextBox();
            this.NTT = new System.Windows.Forms.TextBox();
            this.SPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MDL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPTT
            // 
            this.dgvDSPTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPTT.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvDSPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPN,
            this.colMMH,
            this.colSLN,
            this.colDGN});
            this.dgvDSPTT.Location = new System.Drawing.Point(4, 77);
            this.dgvDSPTT.Name = "dgvDSPTT";
            this.dgvDSPTT.RowHeadersWidth = 51;
            this.dgvDSPTT.RowTemplate.Height = 24;
            this.dgvDSPTT.Size = new System.Drawing.Size(407, 258);
            this.dgvDSPTT.TabIndex = 63;
            this.dgvDSPTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPTT_CellContentClick);
            // 
            // colSPN
            // 
            this.colSPN.DataPropertyName = "SoPhieuThu";
            this.colSPN.HeaderText = "Số phiếu thu";
            this.colSPN.MinimumWidth = 6;
            this.colSPN.Name = "colSPN";
            this.colSPN.ReadOnly = true;
            // 
            // colMMH
            // 
            this.colMMH.DataPropertyName = "MaDaiLy";
            this.colMMH.HeaderText = "Mã Đại lý";
            this.colMMH.MinimumWidth = 6;
            this.colMMH.Name = "colMMH";
            this.colMMH.ReadOnly = true;
            // 
            // colSLN
            // 
            this.colSLN.DataPropertyName = "NgayThuTien";
            this.colSLN.HeaderText = "Ngày thu tiền";
            this.colSLN.MinimumWidth = 6;
            this.colSLN.Name = "colSLN";
            // 
            // colDGN
            // 
            this.colDGN.DataPropertyName = "SoTienThu";
            this.colDGN.HeaderText = "Số tiền thu";
            this.colDGN.MinimumWidth = 6;
            this.colDGN.Name = "colDGN";
            // 
            // btnTCPTT
            // 
            this.btnTCPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCPTT.Location = new System.Drawing.Point(417, 11);
            this.btnTCPTT.Name = "btnTCPTT";
            this.btnTCPTT.Size = new System.Drawing.Size(136, 33);
            this.btnTCPTT.TabIndex = 64;
            this.btnTCPTT.Text = "Tra cứu phiếu thu tiền";
            this.btnTCPTT.UseVisualStyleBackColor = true;
            this.btnTCPTT.Click += new System.EventHandler(this.btnTCPTT_Click);
            // 
            // btnXPTT
            // 
            this.btnXPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPTT.Location = new System.Drawing.Point(417, 363);
            this.btnXPTT.Name = "btnXPTT";
            this.btnXPTT.Size = new System.Drawing.Size(136, 33);
            this.btnXPTT.TabIndex = 64;
            this.btnXPTT.Text = "Xóa phiếu thu tiền";
            this.btnXPTT.UseVisualStyleBackColor = true;
            this.btnXPTT.Click += new System.EventHandler(this.btnXPTT_Click);
            // 
            // btnTPTT
            // 
            this.btnTPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTT.Location = new System.Drawing.Point(4, 354);
            this.btnTPTT.Name = "btnTPTT";
            this.btnTPTT.Size = new System.Drawing.Size(203, 50);
            this.btnTPTT.TabIndex = 64;
            this.btnTPTT.Text = "Thêm phiếu thu tiền";
            this.btnTPTT.UseVisualStyleBackColor = true;
            this.btnTPTT.Click += new System.EventHandler(this.btnTPTT_Click);
            // 
            // tbxTCPTT
            // 
            this.tbxTCPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTCPTT.Location = new System.Drawing.Point(559, 12);
            this.tbxTCPTT.Name = "tbxTCPTT";
            this.tbxTCPTT.Size = new System.Drawing.Size(155, 33);
            this.tbxTCPTT.TabIndex = 65;
            // 
            // tbxXPTT
            // 
            this.tbxXPTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxXPTT.Location = new System.Drawing.Point(559, 363);
            this.tbxXPTT.Name = "tbxXPTT";
            this.tbxXPTT.Size = new System.Drawing.Size(155, 33);
            this.tbxXPTT.TabIndex = 65;
            // 
            // NTT
            // 
            this.NTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTT.Location = new System.Drawing.Point(559, 248);
            this.NTT.Name = "NTT";
            this.NTT.Size = new System.Drawing.Size(155, 33);
            this.NTT.TabIndex = 69;
            // 
            // SPT
            // 
            this.SPT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPT.Location = new System.Drawing.Point(559, 131);
            this.SPT.Name = "SPT";
            this.SPT.ReadOnly = true;
            this.SPT.Size = new System.Drawing.Size(155, 33);
            this.SPT.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã đại lý";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(417, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 25);
            this.label10.TabIndex = 70;
            this.label10.Text = "Số phiếu thu";
            // 
            // MDL
            // 
            this.MDL.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDL.Location = new System.Drawing.Point(559, 187);
            this.MDL.Name = "MDL";
            this.MDL.Size = new System.Drawing.Size(155, 33);
            this.MDL.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Ngày thu tiền";
            // 
            // STT
            // 
            this.STT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.Location = new System.Drawing.Point(559, 302);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(155, 33);
            this.STT.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Số tiền thu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 37);
            this.label6.TabIndex = 74;
            this.label6.Text = "Danh Sách Phiếu Thu Tiền";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 50);
            this.button1.TabIndex = 75;
            this.button1.Text = "Sửa phiếu thu tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanhSachPTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(726, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.STT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NTT);
            this.Controls.Add(this.SPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MDL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxXPTT);
            this.Controls.Add(this.tbxTCPTT);
            this.Controls.Add(this.btnTPTT);
            this.Controls.Add(this.btnXPTT);
            this.Controls.Add(this.btnTCPTT);
            this.Controls.Add(this.dgvDSPTT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 481);
            this.MinimumSize = new System.Drawing.Size(744, 481);
            this.Name = "DanhSachPTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachPTT";
            this.Load += new System.EventHandler(this.DanhSachPTT_Load);
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
        private System.Windows.Forms.TextBox tbxTCPTT;
        private System.Windows.Forms.TextBox tbxXPTT;
        private System.Windows.Forms.TextBox NTT;
        private System.Windows.Forms.TextBox SPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MDL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox STT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}