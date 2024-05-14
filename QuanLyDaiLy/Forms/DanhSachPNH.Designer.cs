namespace QuanLyDaiLy.Forms
{
    partial class DanhSachPNH
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPNH = new System.Windows.Forms.DataGridView();
            this.ThemPNH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SearchPNH = new System.Windows.Forms.TextBox();
            this.colSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletePNH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPNH
            // 
            this.dataGridViewPNH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSPN,
            this.colNNH,
            this.colTT});
            this.dataGridViewPNH.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewPNH.Name = "dataGridViewPNH";
            this.dataGridViewPNH.ReadOnly = true;
            this.dataGridViewPNH.RowHeadersWidth = 51;
            this.dataGridViewPNH.RowTemplate.Height = 24;
            this.dataGridViewPNH.Size = new System.Drawing.Size(775, 249);
            this.dataGridViewPNH.TabIndex = 0;
            // 
            // ThemPNH
            // 
            this.ThemPNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemPNH.Location = new System.Drawing.Point(13, 388);
            this.ThemPNH.Name = "ThemPNH";
            this.ThemPNH.Size = new System.Drawing.Size(368, 50);
            this.ThemPNH.TabIndex = 18;
            this.ThemPNH.Text = "Thêm phiếu nhập hàng";
            this.ThemPNH.UseVisualStyleBackColor = true;
            this.ThemPNH.Click += new System.EventHandler(this.ThemPNH_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Xóa phiếu nhập hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(408, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Sửa phiếu nhập hàng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "Tra cứu phiếu nhập hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchPNH
            // 
            this.SearchPNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPNH.Location = new System.Drawing.Point(408, 268);
            this.SearchPNH.Name = "SearchPNH";
            this.SearchPNH.Size = new System.Drawing.Size(368, 33);
            this.SearchPNH.TabIndex = 28;
            // 
            // colSPN
            // 
            this.colSPN.DataPropertyName = "SoPhieuNhap";
            this.colSPN.HeaderText = "Số phiếu nhập hàng";
            this.colSPN.MinimumWidth = 6;
            this.colSPN.Name = "colSPN";
            this.colSPN.ReadOnly = true;
            this.colSPN.Width = 200;
            // 
            // colNNH
            // 
            this.colNNH.DataPropertyName = "NgayNhapHang";
            this.colNNH.HeaderText = "Ngày nhập hàng";
            this.colNNH.MinimumWidth = 6;
            this.colNNH.Name = "colNNH";
            this.colNNH.ReadOnly = true;
            this.colNNH.Width = 200;
            // 
            // colTT
            // 
            this.colTT.DataPropertyName = "TongTien";
            this.colTT.HeaderText = "Tổng tiền";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            this.colTT.Width = 200;
            // 
            // DeletePNH
            // 
            this.DeletePNH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePNH.Location = new System.Drawing.Point(408, 334);
            this.DeletePNH.Name = "DeletePNH";
            this.DeletePNH.Size = new System.Drawing.Size(368, 33);
            this.DeletePNH.TabIndex = 29;
            // 
            // DanhSachPNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeletePNH);
            this.Controls.Add(this.SearchPNH);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThemPNH);
            this.Controls.Add(this.dataGridViewPNH);
            this.Name = "DanhSachPNH";
            this.Text = "DanhSachPNH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPNH;
        private System.Windows.Forms.Button ThemPNH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SearchPNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.TextBox DeletePNH;
    }
}