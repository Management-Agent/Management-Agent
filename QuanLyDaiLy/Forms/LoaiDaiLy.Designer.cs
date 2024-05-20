namespace QuanLyDaiLy.Forms
{
    partial class LoaiDaiLy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MaLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNoToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiDaiLy,
            this.TenLoaiDaiLy,
            this.SoNoToiDa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.button1.Location = new System.Drawing.Point(556, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.button2.Location = new System.Drawing.Point(673, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Huỷ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.button3.Location = new System.Drawing.Point(12, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.button4.Location = new System.Drawing.Point(133, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "Xoá";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MaLoaiDaiLy
            // 
            this.MaLoaiDaiLy.DataPropertyName = "MaLoaiDaiLy";
            this.MaLoaiDaiLy.HeaderText = "Mã Loại Đại Lý";
            this.MaLoaiDaiLy.MinimumWidth = 6;
            this.MaLoaiDaiLy.Name = "MaLoaiDaiLy";
            this.MaLoaiDaiLy.ReadOnly = true;
            // 
            // TenLoaiDaiLy
            // 
            this.TenLoaiDaiLy.DataPropertyName = "TenLoaiDaiLy";
            this.TenLoaiDaiLy.HeaderText = "Loại Đại Lý";
            this.TenLoaiDaiLy.MinimumWidth = 6;
            this.TenLoaiDaiLy.Name = "TenLoaiDaiLy";
            // 
            // SoNoToiDa
            // 
            this.SoNoToiDa.DataPropertyName = "SoNoToiDa";
            this.SoNoToiDa.HeaderText = "Số Nợ Tối Đa";
            this.SoNoToiDa.MinimumWidth = 6;
            this.SoNoToiDa.Name = "SoNoToiDa";
            // 
            // LoaiDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LoaiDaiLy";
            this.Text = "LoaiDaiLy";
            this.Load += new System.EventHandler(this.LoaiDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNoToiDa;
    }
}