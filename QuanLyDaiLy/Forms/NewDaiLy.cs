﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class NewDaiLy : Form
    {
        public NewDaiLy()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theDate = NgayTiepNhanBox.Value.ToString("yyyy-MM-dd");
            DataAccess.Instance.AddDaiLy(TenDaiLyBox.Text, LoaiDaiLyBox.Text, DienThoaiBox.Text, DiaChiBox.Text, EmailBox.Text, QuanBox.Text, theDate);
        }
    }
}
