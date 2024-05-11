namespace QuanLyDaiLy
{
    partial class DanhSachDaiLy
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
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modìyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewDaiLy = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(484, 23);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(182, 50);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Thêm đại lý";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.deleteButton.Location = new System.Drawing.Point(672, 23);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Xoá đại lý";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // modìyButton
            // 
            this.modìyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modìyButton.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.modìyButton.Location = new System.Drawing.Point(808, 23);
            this.modìyButton.Name = "modìyButton";
            this.modìyButton.Size = new System.Drawing.Size(162, 50);
            this.modìyButton.TabIndex = 3;
            this.modìyButton.Text = "Sửa thông tin";
            this.modìyButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 86);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 37);
            this.label6.TabIndex = 42;
            this.label6.Text = "Danh Sách Đại Lý";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.modìyButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 88);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewDaiLy
            // 
            this.dataGridViewDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.DaiLy,
            this.LoaiDaiLy,
            this.Quan,
            this.TienNo});
            this.dataGridViewDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDaiLy.Location = new System.Drawing.Point(0, 86);
            this.dataGridViewDaiLy.Name = "dataGridViewDaiLy";
            this.dataGridViewDaiLy.RowHeadersWidth = 51;
            this.dataGridViewDaiLy.RowTemplate.Height = 24;
            this.dataGridViewDaiLy.Size = new System.Drawing.Size(982, 379);
            this.dataGridViewDaiLy.TabIndex = 9;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // DaiLy
            // 
            this.DaiLy.DataPropertyName = "TenDaiLy";
            this.DaiLy.HeaderText = "Đại lý";
            this.DaiLy.MinimumWidth = 6;
            this.DaiLy.Name = "DaiLy";
            // 
            // LoaiDaiLy
            // 
            this.LoaiDaiLy.DataPropertyName = "TenLoaiDaiLy";
            this.LoaiDaiLy.HeaderText = "Loại đại lý";
            this.LoaiDaiLy.MinimumWidth = 6;
            this.LoaiDaiLy.Name = "LoaiDaiLy";
            // 
            // Quan
            // 
            this.Quan.DataPropertyName = "TenQuan";
            this.Quan.HeaderText = "Quận";
            this.Quan.MinimumWidth = 6;
            this.Quan.Name = "Quan";
            // 
            // TienNo
            // 
            this.TienNo.DataPropertyName = "TongNo";
            this.TienNo.HeaderText = "Tiền nợ";
            this.TienNo.MinimumWidth = 6;
            this.TienNo.Name = "TienNo";
            // 
            // DanhSachDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dataGridViewDaiLy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachDaiLy";
            this.Load += new System.EventHandler(this.DanhSachDaiLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaiLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modìyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
    }
}