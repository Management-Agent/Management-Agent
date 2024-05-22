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
    public partial class DonViTinh : Form
    {
        DataTable data;
        List<DataGridViewRow> needDelete = new List<DataGridViewRow>();
        List<DataGridViewRow> needUpdate = new List<DataGridViewRow>();
        public DonViTinh()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO DVT(TenDVT) values (null)";
            DataProvider.Instance.ExecuteNonQuery(query);
            DonViTinh_Load(sender, e);
        }

        private void DonViTinh_Load(object sender, EventArgs e)
        {
            string query = @"Select * from DVT";
            data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = data;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DonViTinh_Load(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng đang được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DataGridViewRow clone = CloneDataGridViewRow(selectedRow);
                needDelete.Add(clone);
                // Xóa hàng khỏi DataGridView
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa.");
            }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in needUpdate)
            {
                string maDVT = row.Cells[0].Value.ToString();
                string tenDVT = row.Cells[1].Value.ToString();

                string query = @"USP_UpdateDVT @MaDVT , @TenDVT  ";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDVT, tenDVT });
            }

            foreach (DataGridViewRow row in needDelete)
            {


                string maDVT = row.Cells[0].Value.ToString();
                string query = @"USP_DeleteDVT @MaDVT ";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDVT });

            }
            needDelete.Clear();
            needUpdate.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow clone = CloneDataGridViewRow(dataGridView1.Rows[rowIndex]);

                needUpdate.Add(clone);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
