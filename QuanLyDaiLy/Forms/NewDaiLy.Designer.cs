namespace QuanLyDaiLy
{
    partial class NewDaiLy
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
            this.NgayTiepNhanBox = new System.Windows.Forms.DateTimePicker();
            this.TenDaiLyBox = new System.Windows.Forms.TextBox();
            this.DienThoaiBox = new System.Windows.Forms.TextBox();
            this.DiaChiBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoaiDaiLyBox = new System.Windows.Forms.ComboBox();
            this.MaQuanBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NgayTiepNhanBox
            // 
            this.NgayTiepNhanBox.AllowDrop = true;
            this.NgayTiepNhanBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTiepNhanBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayTiepNhanBox.Location = new System.Drawing.Point(223, 257);
            this.NgayTiepNhanBox.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.NgayTiepNhanBox.Name = "NgayTiepNhanBox";
            this.NgayTiepNhanBox.Size = new System.Drawing.Size(204, 33);
            this.NgayTiepNhanBox.TabIndex = 0;
            this.NgayTiepNhanBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TenDaiLyBox
            // 
            this.TenDaiLyBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDaiLyBox.Location = new System.Drawing.Point(223, 105);
            this.TenDaiLyBox.Name = "TenDaiLyBox";
            this.TenDaiLyBox.Size = new System.Drawing.Size(611, 33);
            this.TenDaiLyBox.TabIndex = 1;
            this.TenDaiLyBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DienThoaiBox
            // 
            this.DienThoaiBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DienThoaiBox.Location = new System.Drawing.Point(223, 156);
            this.DienThoaiBox.Name = "DienThoaiBox";
            this.DienThoaiBox.Size = new System.Drawing.Size(204, 33);
            this.DienThoaiBox.TabIndex = 2;
            this.DienThoaiBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DiaChiBox
            // 
            this.DiaChiBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiBox.Location = new System.Drawing.Point(223, 204);
            this.DiaChiBox.Name = "DiaChiBox";
            this.DiaChiBox.Size = new System.Drawing.Size(204, 33);
            this.DiaChiBox.TabIndex = 3;
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(630, 209);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(204, 33);
            this.EmailBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên đại lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Điện thoại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loại đại lý";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã quận";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày tiếp nhận";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(528, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 58);
            this.button2.TabIndex = 17;
            this.button2.Text = "Hoàn tác";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LoaiDaiLyBox
            // 
            this.LoaiDaiLyBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiDaiLyBox.FormattingEnabled = true;
            this.LoaiDaiLyBox.Location = new System.Drawing.Point(630, 156);
            this.LoaiDaiLyBox.Name = "LoaiDaiLyBox";
            this.LoaiDaiLyBox.Size = new System.Drawing.Size(204, 33);
            this.LoaiDaiLyBox.TabIndex = 18;
            // 
            // MaQuanBox
            // 
            this.MaQuanBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaQuanBox.FormattingEnabled = true;
            this.MaQuanBox.Location = new System.Drawing.Point(630, 257);
            this.MaQuanBox.Name = "MaQuanBox";
            this.MaQuanBox.Size = new System.Drawing.Size(204, 33);
            this.MaQuanBox.TabIndex = 19;
            // 
            // NewDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 484);
            this.Controls.Add(this.MaQuanBox);
            this.Controls.Add(this.LoaiDaiLyBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.DiaChiBox);
            this.Controls.Add(this.DienThoaiBox);
            this.Controls.Add(this.TenDaiLyBox);
            this.Controls.Add(this.NgayTiepNhanBox);
            this.Name = "NewDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewDaiLy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker NgayTiepNhanBox;
        private System.Windows.Forms.TextBox TenDaiLyBox;
        private System.Windows.Forms.TextBox DienThoaiBox;
        private System.Windows.Forms.TextBox DiaChiBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox LoaiDaiLyBox;
        private System.Windows.Forms.ComboBox MaQuanBox;
    }
}