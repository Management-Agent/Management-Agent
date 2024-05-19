using QuanLyDaiLy.Scripts;
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
    public partial class BaoCaoDoanhSo : Form
    {
        public BaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BaoCaoDoanhSo_Load(sender, e);
        }

        private void BaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;
            string querystring = "exec BCDS_month @Thang , @Nam";
            DataTable data = DataProvider.Instance.ExecuteQuery(querystring, new object[] { month, year });
            dataGridViewBCDS.DataSource = data;
        }
    }
}
