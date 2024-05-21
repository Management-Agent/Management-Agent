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
        DataTable data;
        private Dictionary<int, List<object>> originalRowData = new Dictionary<int, List<object>>();
        List<DataGridViewRow> needDelete = new List<DataGridViewRow>();
        List<DataGridViewRow> needUpdate = new List<DataGridViewRow>();

        public LoaiDaiLy()
        {
            InitializeComponent();
        }

        private void LoaiDaiLy_Load(object sender, EventArgs e)
        {
            string query = @"Select * from LoaiDaiLy";
            data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO LOAIDAILY(TenLoaiDaiLy,SoNoToiDa) values (null,0)";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoaiDaiLy_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoaiDaiLy_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in needUpdate)
            {
                string maLoaiDaiLy = row.Cells[0].Value.ToString();
                string tenLoaiDaiLy = row.Cells[1].Value.ToString();
                string soNoToiDaString = row.Cells[2].Value.ToString();
                decimal soNoToiDa;
                if(soNoToiDaString == "")
                {
                    soNoToiDa = 0;
                }
                else
                {
                    soNoToiDa = decimal.Parse(soNoToiDaString);
                }

               

                string query = @"USP_UpdateLoaiDaiLy @MaLoaiDaiLy , @TenLoaiDaiLy , @SoNoToiDa ";
                DataProvider.Instance.ExecuteNonQuery(query,new object[] {maLoaiDaiLy,tenLoaiDaiLy,soNoToiDa});
            }

            foreach (DataGridViewRow row in needDelete)
            {
                
                
                string maLoaiDaiLy = row.Cells[0].Value.ToString();
                string query = @"USP_DeleteLoaiDaiLy @MaLoaiDaiLy ";
                DataProvider.Instance.ExecuteNonQuery(query,new object[] {maLoaiDaiLy});

            }
            needDelete.Clear();
            needUpdate.Clear();
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            

            
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

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
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
    }
}
