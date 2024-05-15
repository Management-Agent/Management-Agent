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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewDaiLy = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TenDaiLyBox = new System.Windows.Forms.TextBox();
            this.SDTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoaiDaiLyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TenQuanBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(484, 17);
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
            this.deleteButton.Location = new System.Drawing.Point(672, 17);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Xoá đại lý";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modìyButton
            // 
            this.modìyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modìyButton.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.modìyButton.Location = new System.Drawing.Point(808, 17);
            this.modìyButton.Name = "modìyButton";
            this.modìyButton.Size = new System.Drawing.Size(162, 50);
            this.modìyButton.TabIndex = 3;
            this.modìyButton.Text = "Sửa thông tin";
            this.modìyButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 74);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(642, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 33);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "Tên đại lý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tìm kiếm:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 37);
            this.label6.TabIndex = 42;
            this.label6.Text = "Danh Sách Đại Lý";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RefreshButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.modìyButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 82);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewDaiLy
            // 
            this.dataGridViewDaiLy.AllowUserToAddRows = false;
            this.dataGridViewDaiLy.AllowUserToDeleteRows = false;
            this.dataGridViewDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDaiLy.ColumnHeadersHeight = 29;
            this.dataGridViewDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.DaiLy,
            this.SĐT,
            this.LoaiDaiLy,
            this.Quan,
            this.TienNo});
            this.dataGridViewDaiLy.Location = new System.Drawing.Point(0, 70);
            this.dataGridViewDaiLy.Name = "dataGridViewDaiLy";
            this.dataGridViewDaiLy.RowHeadersWidth = 51;
            this.dataGridViewDaiLy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDaiLy.RowTemplate.Height = 24;
            this.dataGridViewDaiLy.Size = new System.Drawing.Size(592, 395);
            this.dataGridViewDaiLy.TabIndex = 9;
            this.dataGridViewDaiLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaiLy_CellContentClick);
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
            // SĐT
            // 
            this.SĐT.HeaderText = "SDT";
            this.SĐT.MinimumWidth = 6;
            this.SĐT.Name = "SĐT";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đại lý";
            // 
            // TenDaiLyBox
            // 
            this.TenDaiLyBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDaiLyBox.Location = new System.Drawing.Point(753, 132);
            this.TenDaiLyBox.Name = "TenDaiLyBox";
            this.TenDaiLyBox.Size = new System.Drawing.Size(183, 33);
            this.TenDaiLyBox.TabIndex = 11;
            // 
            // SDTBox
            // 
            this.SDTBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTBox.Location = new System.Drawing.Point(753, 203);
            this.SDTBox.Name = "SDTBox";
            this.SDTBox.Size = new System.Drawing.Size(183, 33);
            this.SDTBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "SĐT";
            // 
            // LoaiDaiLyBox
            // 
            this.LoaiDaiLyBox.AllowDrop = true;
            this.LoaiDaiLyBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiDaiLyBox.Location = new System.Drawing.Point(753, 276);
            this.LoaiDaiLyBox.Name = "LoaiDaiLyBox";
            this.LoaiDaiLyBox.Size = new System.Drawing.Size(183, 33);
            this.LoaiDaiLyBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(637, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Loại đại lý";
            // 
            // TenQuanBox
            // 
            this.TenQuanBox.AllowDrop = true;
            this.TenQuanBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenQuanBox.Location = new System.Drawing.Point(753, 348);
            this.TenQuanBox.Name = "TenQuanBox";
            this.TenQuanBox.Size = new System.Drawing.Size(183, 33);
            this.TenQuanBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quận";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(32, 17);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(182, 50);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Làm mới";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // DanhSachDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.TenQuanBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoaiDaiLyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SDTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TenDaiLyBox);
            this.Controls.Add(this.label2);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modìyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDaiLy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SĐT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenDaiLyBox;
        private System.Windows.Forms.TextBox SDTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoaiDaiLyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TenQuanBox;
        private System.Windows.Forms.Label label5;
    }
}