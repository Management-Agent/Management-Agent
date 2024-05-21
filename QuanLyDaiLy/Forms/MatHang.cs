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
    public partial class MatHang : Form
    {
        DataTable data;
        public MatHang()
        {
            
            List<DataGridViewRow> needDelete = new List<DataGridViewRow>();
            List<DataGridViewRow> needUpdate = new List<DataGridViewRow>();
            InitializeComponent();
        }

        private DataGridViewRow CloneDataGridViewRow(DataGridViewRow sourceRow)
        {
            // Tạo một hàng mới với cùng số lượng ô
            DataGridViewRow newRow = (DataGridViewRow)sourceRow.Clone();

            // Sao chép giá trị từ từng ô của hàng gốc vào hàng mới
            for (int i = 0; i < sourceRow.Cells.Count; i++)
            {
                newRow.Cells[i].Value = sourceRow.Cells[i].Value;
            }

            return newRow;
        }

        private void MatHang_Load(object sender, EventArgs e)
        {
            string query = @"Select MaMatHang,TenMatHang,TenDVT,SoLuongTon from MATHANG left join DVT on MATHANG.MaDVT = DVT.MaDVT ";
            this.data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = data;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO MATHANG(TenMatHang,MaDVT,SoLuongTon) values (null,null,0)";
            DataProvider.Instance.ExecuteNonQuery(query);
            MatHang_Load(sender, e);
        }
    }
}
