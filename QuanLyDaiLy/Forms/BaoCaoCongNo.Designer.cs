﻿namespace QuanLyDaiLy.Forms
{
    partial class BaoCaoCongNo
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 33);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label1.Location = new System.Drawing.Point(324, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thời gian";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 111);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 37);
            this.label6.TabIndex = 41;
            this.label6.Text = "Báo Cáo Công Nợ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 89);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDaiLy,
            this.DaiLy,
            this.NoDau,
            this.PhatSinh,
            this.NoCuoi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(982, 353);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnDisplayIndexChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaDaiLy
            // 
            this.MaDaiLy.DataPropertyName = "MaDaiLy";
            this.MaDaiLy.HeaderText = "Mã đại lý";
            this.MaDaiLy.MinimumWidth = 6;
            this.MaDaiLy.Name = "MaDaiLy";
            this.MaDaiLy.ReadOnly = true;
            // 
            // DaiLy
            // 
            this.DaiLy.DataPropertyName = "TenDaiLy";
            this.DaiLy.HeaderText = "Đại lý";
            this.DaiLy.MinimumWidth = 6;
            this.DaiLy.Name = "DaiLy";
            this.DaiLy.ReadOnly = true;
            // 
            // NoDau
            // 
            this.NoDau.DataPropertyName = "NoDau";
            this.NoDau.HeaderText = "Nợ đầu";
            this.NoDau.MinimumWidth = 6;
            this.NoDau.Name = "NoDau";
            this.NoDau.ReadOnly = true;
            // 
            // PhatSinh
            // 
            this.PhatSinh.DataPropertyName = "PhatSinh";
            this.PhatSinh.HeaderText = "Phát sinh";
            this.PhatSinh.MinimumWidth = 6;
            this.PhatSinh.Name = "PhatSinh";
            this.PhatSinh.ReadOnly = true;
            // 
            // NoCuoi
            // 
            this.NoCuoi.DataPropertyName = "NoCuoi";
            this.NoCuoi.HeaderText = "Nợ cuối";
            this.NoCuoi.MinimumWidth = 6;
            this.NoCuoi.Name = "NoCuoi";
            this.NoCuoi.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(445, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 42;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(687, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 43;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoCongNo";
            this.Text = "BaoCaoCongNo";
            this.Load += new System.EventHandler(this.BaoCaoCongNo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCuoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}