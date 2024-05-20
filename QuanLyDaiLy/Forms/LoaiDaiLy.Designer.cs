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
            this.MaLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNoToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // MaLoaiDaiLy
            // 
            this.MaLoaiDaiLy.HeaderText = "Mã Loại Đại Lý";
            this.MaLoaiDaiLy.MinimumWidth = 6;
            this.MaLoaiDaiLy.Name = "MaLoaiDaiLy";
            this.MaLoaiDaiLy.ReadOnly = true;
            // 
            // TenLoaiDaiLy
            // 
            this.TenLoaiDaiLy.HeaderText = "Loại Đại Lý";
            this.TenLoaiDaiLy.MinimumWidth = 6;
            this.TenLoaiDaiLy.Name = "TenLoaiDaiLy";
            // 
            // SoNoToiDa
            // 
            this.SoNoToiDa.HeaderText = "Số Nợ Tối Đa";
            this.SoNoToiDa.MinimumWidth = 6;
            this.SoNoToiDa.Name = "SoNoToiDa";
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
            // 
            // LoaiDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LoaiDaiLy";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNoToiDa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}