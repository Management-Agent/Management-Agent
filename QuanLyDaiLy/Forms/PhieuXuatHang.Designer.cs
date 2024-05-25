namespace QuanLyDaiLy.Forms
{
    partial class PhieuXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuatHang));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpNXH = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemPXH = new System.Windows.Forms.Button();
            this.tbxMDL = new System.Windows.Forms.TextBox();
            this.lblmdl = new System.Windows.Forms.Label();
            this.tbxSTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(305, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 110;
            this.label2.Text = "Phiếu Xuất Hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 138;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpNXH
            // 
            this.dtpNXH.AllowDrop = true;
            this.dtpNXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNXH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNXH.Location = new System.Drawing.Point(263, 355);
            this.dtpNXH.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpNXH.Name = "dtpNXH";
            this.dtpNXH.Size = new System.Drawing.Size(204, 33);
            this.dtpNXH.TabIndex = 135;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label8.Location = new System.Drawing.Point(69, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 130;
            this.label8.Text = "Ngày xuất hàng";
            // 
            // btnThemPXH
            // 
            this.btnThemPXH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPXH.Location = new System.Drawing.Point(498, 420);
            this.btnThemPXH.Name = "btnThemPXH";
            this.btnThemPXH.Size = new System.Drawing.Size(130, 50);
            this.btnThemPXH.TabIndex = 128;
            this.btnThemPXH.Text = "Thêm";
            this.btnThemPXH.UseVisualStyleBackColor = true;
            this.btnThemPXH.Click += new System.EventHandler(this.btnThemPXH_Click);
            // 
            // tbxMDL
            // 
            this.tbxMDL.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMDL.Location = new System.Drawing.Point(263, 192);
            this.tbxMDL.Name = "tbxMDL";
            this.tbxMDL.Size = new System.Drawing.Size(494, 33);
            this.tbxMDL.TabIndex = 126;
            // 
            // lblmdl
            // 
            this.lblmdl.AutoSize = true;
            this.lblmdl.BackColor = System.Drawing.Color.Transparent;
            this.lblmdl.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblmdl.Location = new System.Drawing.Point(69, 195);
            this.lblmdl.Name = "lblmdl";
            this.lblmdl.Size = new System.Drawing.Size(108, 25);
            this.lblmdl.TabIndex = 129;
            this.lblmdl.Text = "Mã Đại Lý";
            // 
            // tbxSTT
            // 
            this.tbxSTT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSTT.Location = new System.Drawing.Point(263, 277);
            this.tbxSTT.Name = "tbxSTT";
            this.tbxSTT.Size = new System.Drawing.Size(494, 33);
            this.tbxSTT.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label4.Location = new System.Drawing.Point(69, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 129;
            this.label4.Text = "Số tiên trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(69, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 139;
            this.label1.Text = "Số phiếu xuất";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(263, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 33);
            this.textBox1.TabIndex = 140;
            // 
            // PhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpNXH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmdl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThemPXH);
            this.Controls.Add(this.tbxSTT);
            this.Controls.Add(this.tbxMDL);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(882, 554);
            this.MinimumSize = new System.Drawing.Size(882, 554);
            this.Name = "PhieuXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhieuXuatHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpNXH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemPXH;
        private System.Windows.Forms.TextBox tbxMDL;
        private System.Windows.Forms.Label lblmdl;
        private System.Windows.Forms.TextBox tbxSTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}