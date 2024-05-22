﻿using QuanLyDaiLy.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.Forms
{
    public partial class BaoCaoCongNo : Form
    {
        public BaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void BaoCaoCongNo_Load(object sender, EventArgs e)
        {
            //
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;
            //load data
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCongNoInfo @Thang , @Nam ",new object[] {month,year});
            DataColumn columnSTT = new DataColumn();
            dataGridView1.DataSource = data;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells["STT"].Value = i;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BaoCaoCongNo_Load(sender,e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells["STT"].Value = i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(PhieuGhiNo phieuGhiNo = new PhieuGhiNo())
            {
                phieuGhiNo.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime currentDate = dateTimePicker1.Value;

            // Thay đổi giá trị lên 1 tháng
            DateTime newDate = currentDate.AddMonths(-1);

            // Cập nhật giá trị của DateTimePicker
            dateTimePicker1.Value = newDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime currentDate = dateTimePicker1.Value;

            // Thay đổi giá trị lên 1 tháng
            DateTime newDate = currentDate.AddMonths(1);

            // Cập nhật giá trị của DateTimePicker
            dateTimePicker1.Value = newDate;
        }
    }
}
