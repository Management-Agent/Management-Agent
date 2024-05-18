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
            this.modifyButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridViewDaiLy = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TenDaiLyBox = new System.Windows.Forms.TextBox();
            this.SDTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TienNoBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoaiDaiLyComboBox = new System.Windows.Forms.ComboBox();
            this.TenQuanComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DiaChiBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaDaiLyBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaiLy)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(596, 17);
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
            this.deleteButton.Location = new System.Drawing.Point(784, 17);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Xoá đại lý";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyButton.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.modifyButton.Location = new System.Drawing.Point(920, 17);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(162, 50);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Sửa thông tin";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RefreshButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.modifyButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 82);
            this.panel2.TabIndex = 5;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(12, 17);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(182, 50);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Làm mới";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridViewDaiLy
            // 
            this.dataGridViewDaiLy.AllowUserToAddRows = false;
            this.dataGridViewDaiLy.AllowUserToDeleteRows = false;
            this.dataGridViewDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDaiLy.ColumnHeadersHeight = 29;
            this.dataGridViewDaiLy.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDaiLy.Name = "dataGridViewDaiLy";
            this.dataGridViewDaiLy.RowHeadersWidth = 51;
            this.dataGridViewDaiLy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDaiLy.RowTemplate.Height = 24;
            this.dataGridViewDaiLy.Size = new System.Drawing.Size(640, 479);
            this.dataGridViewDaiLy.TabIndex = 9;
            this.dataGridViewDaiLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaiLy_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đại lý";
            // 
            // TenDaiLyBox
            // 
            this.TenDaiLyBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDaiLyBox.Location = new System.Drawing.Point(828, 72);
            this.TenDaiLyBox.Name = "TenDaiLyBox";
            this.TenDaiLyBox.Size = new System.Drawing.Size(183, 33);
            this.TenDaiLyBox.TabIndex = 11;
            // 
            // SDTBox
            // 
            this.SDTBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTBox.Location = new System.Drawing.Point(828, 133);
            this.SDTBox.Name = "SDTBox";
            this.SDTBox.Size = new System.Drawing.Size(183, 33);
            this.SDTBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(712, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Loại đại lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(712, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quận";
            // 
            // TienNoBox
            // 
            this.TienNoBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienNoBox.Location = new System.Drawing.Point(828, 429);
            this.TienNoBox.Name = "TienNoBox";
            this.TienNoBox.ReadOnly = true;
            this.TienNoBox.Size = new System.Drawing.Size(183, 33);
            this.TienNoBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(712, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tiền nợ";
            // 
            // LoaiDaiLyComboBox
            // 
            this.LoaiDaiLyComboBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiDaiLyComboBox.FormattingEnabled = true;
            this.LoaiDaiLyComboBox.Location = new System.Drawing.Point(828, 195);
            this.LoaiDaiLyComboBox.Name = "LoaiDaiLyComboBox";
            this.LoaiDaiLyComboBox.Size = new System.Drawing.Size(183, 33);
            this.LoaiDaiLyComboBox.TabIndex = 45;
            this.LoaiDaiLyComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TenQuanComboBox
            // 
            this.TenQuanComboBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenQuanComboBox.FormattingEnabled = true;
            this.TenQuanComboBox.Location = new System.Drawing.Point(828, 257);
            this.TenQuanComboBox.Name = "TenQuanComboBox";
            this.TenQuanComboBox.Size = new System.Drawing.Size(183, 33);
            this.TenQuanComboBox.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 37);
            this.label6.TabIndex = 42;
            this.label6.Text = "Danh Sách Đại Lý";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tìm kiếm:";
            // 
            // FindBox
            // 
            this.FindBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBox.Location = new System.Drawing.Point(691, 11);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(294, 33);
            this.FindBox.TabIndex = 44;
            this.FindBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Location = new System.Drawing.Point(1007, 11);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 33);
            this.FindButton.TabIndex = 45;
            this.FindButton.Text = "Tìm";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.FindBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 56);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(828, 371);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(183, 33);
            this.EmailBox.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(712, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Email";
            // 
            // DiaChiBox
            // 
            this.DiaChiBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiBox.Location = new System.Drawing.Point(828, 317);
            this.DiaChiBox.Name = "DiaChiBox";
            this.DiaChiBox.Size = new System.Drawing.Size(183, 33);
            this.DiaChiBox.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(712, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Địa chỉ";
            // 
            // MaDaiLyBox
            // 
            this.MaDaiLyBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDaiLyBox.Location = new System.Drawing.Point(828, 16);
            this.MaDaiLyBox.Name = "MaDaiLyBox";
            this.MaDaiLyBox.ReadOnly = true;
            this.MaDaiLyBox.Size = new System.Drawing.Size(183, 33);
            this.MaDaiLyBox.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(712, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Mã đại lý";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.SDTBox);
            this.panel3.Controls.Add(this.dataGridViewDaiLy);
            this.panel3.Controls.Add(this.MaDaiLyBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.TenDaiLyBox);
            this.panel3.Controls.Add(this.DiaChiBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.EmailBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TenQuanComboBox);
            this.panel3.Controls.Add(this.TienNoBox);
            this.panel3.Controls.Add(this.LoaiDaiLyComboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 468);
            this.panel3.TabIndex = 53;
            // 
            // DanhSachDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachDaiLy";
            this.Load += new System.EventHandler(this.DanhSachDaiLy_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaiLy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDaiLy;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenDaiLyBox;
        private System.Windows.Forms.TextBox SDTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TienNoBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox LoaiDaiLyComboBox;
        private System.Windows.Forms.ComboBox TenQuanComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DiaChiBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaDaiLyBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
    }
}