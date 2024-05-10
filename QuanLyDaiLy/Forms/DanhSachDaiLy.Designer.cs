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
            this.delete = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modìyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.DaiLy,
            this.Loai,
            this.Quan,
            this.TienNo});
            this.delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete.Location = new System.Drawing.Point(0, 0);
            this.delete.Name = "delete";
            this.delete.RowHeadersWidth = 51;
            this.delete.RowTemplate.Height = 24;
            this.delete.Size = new System.Drawing.Size(982, 481);
            this.delete.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // DaiLy
            // 
            this.DaiLy.HeaderText = "Đại Lý";
            this.DaiLy.MinimumWidth = 6;
            this.DaiLy.Name = "DaiLy";
            // 
            // Loai
            // 
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            // 
            // Quan
            // 
            this.Quan.HeaderText = "Quận";
            this.Quan.MinimumWidth = 6;
            this.Quan.Name = "Quan";
            // 
            // TienNo
            // 
            this.TienNo.HeaderText = "Tiền Nợ";
            this.TienNo.MinimumWidth = 6;
            this.TienNo.Name = "TienNo";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(484, 491);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(182, 50);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Thêm đại lý";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.deleteButton.Location = new System.Drawing.Point(672, 491);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Xoá đại lý";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // modìyButton
            // 
            this.modìyButton.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.modìyButton.Location = new System.Drawing.Point(808, 491);
            this.modìyButton.Name = "modìyButton";
            this.modìyButton.Size = new System.Drawing.Size(162, 50);
            this.modìyButton.TabIndex = 3;
            this.modìyButton.Text = "Sửa thông tin";
            this.modìyButton.UseVisualStyleBackColor = true;
            // 
            // DanhSachDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.modìyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delete);
            this.Name = "DanhSachDaiLy";
            this.Text = "DanhSachDaiLy";
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modìyButton;
    }
}