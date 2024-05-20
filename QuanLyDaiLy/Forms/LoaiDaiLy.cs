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
    public partial class LoaiDaiLy : Form
    {
        public LoaiDaiLy()
        {
            InitializeComponent();
        }

        private void LoaiDaiLy_Load(object sender, EventArgs e)
        {
            string query = @"Select * from LoaiDaiLy";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO LOAIDAILY(TenLoaiDaiLy,SoNoToiDa) values (null,null)";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoaiDaiLy_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoaiDaiLy_Load(sender, e);

        }
    }
}
