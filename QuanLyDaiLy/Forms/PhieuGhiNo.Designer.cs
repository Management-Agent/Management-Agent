namespace QuanLyDaiLy.Forms
{
    partial class PhieuGhiNo
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
            this.HoanTacThongTinButton = new System.Windows.Forms.Button();
            this.ThemDaiLyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhatSinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNoCuoi = new System.Windows.Forms.TextBox();
            this.textBoxNoDau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HoanTacThongTinButton
            // 
            this.HoanTacThongTinButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoanTacThongTinButton.Location = new System.Drawing.Point(693, 335);
            this.HoanTacThongTinButton.Name = "HoanTacThongTinButton";
            this.HoanTacThongTinButton.Size = new System.Drawing.Size(130, 50);
            this.HoanTacThongTinButton.TabIndex = 33;
            this.HoanTacThongTinButton.Text = "Huỷ";
            this.HoanTacThongTinButton.UseVisualStyleBackColor = true;
            // 
            // ThemDaiLyButton
            // 
            this.ThemDaiLyButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemDaiLyButton.Location = new System.Drawing.Point(557, 335);
            this.ThemDaiLyButton.Name = "ThemDaiLyButton";
            this.ThemDaiLyButton.Size = new System.Drawing.Size(130, 50);
            this.ThemDaiLyButton.TabIndex = 32;
            this.ThemDaiLyButton.Text = "Thêm";
            this.ThemDaiLyButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nợ đầu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên đại lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPhatSinh
            // 
            this.textBoxPhatSinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhatSinh.Location = new System.Drawing.Point(554, 217);
            this.textBoxPhatSinh.Name = "textBoxPhatSinh";
            this.textBoxPhatSinh.Size = new System.Drawing.Size(269, 33);
            this.textBoxPhatSinh.TabIndex = 22;
            this.textBoxPhatSinh.TextChanged += new System.EventHandler(this.textBoxPhatSinh_TextChanged);
            this.textBoxPhatSinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DienThoaiBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Phát sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nợ cuối";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Thời gian";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(554, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 33);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // textBoxNoCuoi
            // 
            this.textBoxNoCuoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoCuoi.Location = new System.Drawing.Point(164, 301);
            this.textBoxNoCuoi.Name = "textBoxNoCuoi";
            this.textBoxNoCuoi.ReadOnly = true;
            this.textBoxNoCuoi.Size = new System.Drawing.Size(236, 33);
            this.textBoxNoCuoi.TabIndex = 38;
            // 
            // textBoxNoDau
            // 
            this.textBoxNoDau.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoDau.Location = new System.Drawing.Point(164, 217);
            this.textBoxNoDau.Name = "textBoxNoDau";
            this.textBoxNoDau.Size = new System.Drawing.Size(236, 33);
            this.textBoxNoDau.TabIndex = 39;
            this.textBoxNoDau.TextChanged += new System.EventHandler(this.textBoxNoDau_TextChanged);
            this.textBoxNoDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 37);
            this.label6.TabIndex = 40;
            this.label6.Text = "Phiếu Ghi Nợ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 33);
            this.comboBox1.TabIndex = 41;
            // 
            // PhieuGhiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 452);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNoDau);
            this.Controls.Add(this.textBoxNoCuoi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HoanTacThongTinButton);
            this.Controls.Add(this.ThemDaiLyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhatSinh);
            this.Name = "PhieuGhiNo";
            this.Text = "PhieuGhiNo";
            this.Load += new System.EventHandler(this.PhieuGhiNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HoanTacThongTinButton;
        private System.Windows.Forms.Button ThemDaiLyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhatSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxNoCuoi;
        private System.Windows.Forms.TextBox textBoxNoDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}