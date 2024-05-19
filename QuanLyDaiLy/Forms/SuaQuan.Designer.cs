namespace QuanLyDaiLy.Forms
{
    partial class SuaQuan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLoaiDaiLy = new System.Windows.Forms.DataGridView();
            this.lbMaQuan = new System.Windows.Forms.Label();
            this.txtMaQuan = new System.Windows.Forms.TextBox();
            this.LuuQuan = new System.Windows.Forms.Button();
            this.txtHuy = new System.Windows.Forms.Button();
            this.lbTenQuan = new System.Windows.Forms.Label();
            this.txtTenQuan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "Sửa Quận";
            // 
            // dataGridViewLoaiDaiLy
            // 
            this.dataGridViewLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiDaiLy.Location = new System.Drawing.Point(118, 83);
            this.dataGridViewLoaiDaiLy.Name = "dataGridViewLoaiDaiLy";
            this.dataGridViewLoaiDaiLy.RowHeadersWidth = 51;
            this.dataGridViewLoaiDaiLy.RowTemplate.Height = 24;
            this.dataGridViewLoaiDaiLy.Size = new System.Drawing.Size(552, 150);
            this.dataGridViewLoaiDaiLy.TabIndex = 82;
            // 
            // lbMaQuan
            // 
            this.lbMaQuan.AutoSize = true;
            this.lbMaQuan.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lbMaQuan.Location = new System.Drawing.Point(113, 280);
            this.lbMaQuan.Name = "lbMaQuan";
            this.lbMaQuan.Size = new System.Drawing.Size(100, 25);
            this.lbMaQuan.TabIndex = 83;
            this.lbMaQuan.Text = "Mã Quận:";
            this.lbMaQuan.Click += new System.EventHandler(this.lbMaQuan_Click);
            // 
            // txtMaQuan
            // 
            this.txtMaQuan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuan.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMaQuan.Location = new System.Drawing.Point(246, 277);
            this.txtMaQuan.Name = "txtMaQuan";
            this.txtMaQuan.Size = new System.Drawing.Size(204, 33);
            this.txtMaQuan.TabIndex = 84;
            // 
            // LuuQuan
            // 
            this.LuuQuan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuuQuan.Location = new System.Drawing.Point(540, 260);
            this.LuuQuan.Name = "LuuQuan";
            this.LuuQuan.Size = new System.Drawing.Size(130, 50);
            this.LuuQuan.TabIndex = 88;
            this.LuuQuan.Text = "Lưu";
            this.LuuQuan.UseVisualStyleBackColor = true;
            this.LuuQuan.Click += new System.EventHandler(this.LuuQuan_Click);
            // 
            // txtHuy
            // 
            this.txtHuy.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuy.Location = new System.Drawing.Point(540, 358);
            this.txtHuy.Name = "txtHuy";
            this.txtHuy.Size = new System.Drawing.Size(130, 50);
            this.txtHuy.TabIndex = 89;
            this.txtHuy.Text = "Hủy";
            this.txtHuy.UseVisualStyleBackColor = true;
            this.txtHuy.Click += new System.EventHandler(this.txtHuy_Click);
            // 
            // lbTenQuan
            // 
            this.lbTenQuan.AutoSize = true;
            this.lbTenQuan.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lbTenQuan.Location = new System.Drawing.Point(113, 347);
            this.lbTenQuan.Name = "lbTenQuan";
            this.lbTenQuan.Size = new System.Drawing.Size(105, 25);
            this.lbTenQuan.TabIndex = 90;
            this.lbTenQuan.Text = "Tên Quận:";
            // 
            // txtTenQuan
            // 
            this.txtTenQuan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQuan.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTenQuan.Location = new System.Drawing.Point(246, 344);
            this.txtTenQuan.Name = "txtTenQuan";
            this.txtTenQuan.Size = new System.Drawing.Size(204, 33);
            this.txtTenQuan.TabIndex = 91;
            // 
            // SuaQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenQuan);
            this.Controls.Add(this.lbTenQuan);
            this.Controls.Add(this.txtHuy);
            this.Controls.Add(this.LuuQuan);
            this.Controls.Add(this.txtMaQuan);
            this.Controls.Add(this.lbMaQuan);
            this.Controls.Add(this.dataGridViewLoaiDaiLy);
            this.Controls.Add(this.label1);
            this.Name = "SuaQuan";
            this.Text = "SuaQuan";
            this.Load += new System.EventHandler(this.SuaQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiDaiLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLoaiDaiLy;
        private System.Windows.Forms.Label lbMaQuan;
        private System.Windows.Forms.TextBox txtMaQuan;
        private System.Windows.Forms.Button LuuQuan;
        private System.Windows.Forms.Button txtHuy;
        private System.Windows.Forms.Label lbTenQuan;
        private System.Windows.Forms.TextBox txtTenQuan;
    }
}