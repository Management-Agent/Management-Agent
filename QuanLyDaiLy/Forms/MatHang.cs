using QuanLyDaiLy.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.Forms
{
    public partial class MatHang : Form
    {
        DataTable data;
        string[] listMaDVT;
        List<DataGridViewRow> needDelete = new List<DataGridViewRow>();
        List<DataGridViewRow> needUpdate = new List<DataGridViewRow>();
        bool check = false;
        
        public MatHang()
        { 
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

            string query = @"Select MaDVT from DVT";
            DataTable maDVTTable = DataProvider.Instance.ExecuteQuery(query);
            listMaDVT = maDVTTable.AsEnumerable()
                     .Select(row => row.Field<string>("MaDVT"))
                     .ToArray();

            DataGridViewComboBoxColumn maDVTColumn = new DataGridViewComboBoxColumn();
            maDVTColumn.Items.Clear();
            maDVTColumn.Items.AddRange(listMaDVT);
            maDVTColumn.Name = "MaDVT";



            query = @"Select MATHANG.MaDVT as MaDVT from MATHANG left join DVT on MATHANG.MaDVT = DVT.MaDVT ";
            DataTable dataForDVTColumn = DataProvider.Instance.ExecuteQuery(query);
            string[] valueForDVTColumn = dataForDVTColumn.AsEnumerable()
                     .Select(row => row.Field<string>("MaDVT"))
                     .ToArray();

            if (!check)
            {
                dataGridView1.Columns.Add(maDVTColumn);
                check  = true;
            }


            //
            query = @"Select MaMatHang,TenMatHang,TenDVT,SoLuongTon from MATHANG left join DVT on MATHANG.MaDVT = DVT.MaDVT ";
            this.data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = data;


            //


            int i = 0;
            int lentgh = valueForDVTColumn.Length;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i >= lentgh)
                    break;

                

                int index = IndexOfItem(maDVTColumn, valueForDVTColumn[i]);
                i++;
                if (index == -1)
                {
                    continue;
                    
                }
                
                row.Cells["MaDVT"].Value = maDVTColumn.Items[index];
                
                  
            }
            needDelete.Clear();
            needUpdate.Clear();
        }

        private void LoadMaDVTColumn()
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO MATHANG(TenMatHang,MaDVT,SoLuongTon) values (null,null,0)";
            DataProvider.Instance.ExecuteNonQuery(query);
            MatHang_Load(sender, e);
        }

        private int IndexOfItem(DataGridViewComboBoxColumn column, string valueText)
        {
            for(int i = 0; i<column.Items.Count; i++)
            {
                if (column.Items[i].ToString() == valueText)
                    return i;
            }
            return -1;
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
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa mặt hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(selectedRow);
                    buttonSave_Click(sender, e);
                }
                
            }
            else
            {
                MessageBox.Show("Hãy chọn một mặt hàng để xóa.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MatHang_Load(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in needUpdate)
            {

                //string i1 = dataGridView1.Columns[0].Name;
                //string i2 = dataGridView1.Columns[1].Name;
                //string i3 = dataGridView1.Columns[2].Name;
                //string i4 = dataGridView1.Columns[3].Name;

                //MessageBox.Show(i1 + i2 + i3 + i4);


                string maMatHang = row.Cells[1].Value.ToString();
                string tenMatHang = row.Cells[2].Value.ToString();
                object maDVTvalue = row.Cells[0].Value;
                string maDVT;
                if(maDVTvalue != null)
                {
                    maDVT = maDVTvalue.ToString();
                }
                else
                {
                    maDVT = "null";
                }
                int soLuongTon = int.Parse(row.Cells[4].Value.ToString());

                if (tenMatHang == "") tenMatHang = "Undefine";

                string query = @"USP_UpdateMatHang @MaMatHang , @TenMatHang , @MaDVT , @SoLuongTon ";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { maMatHang, tenMatHang, maDVT, soLuongTon });
            }

            foreach (DataGridViewRow row in needDelete)
            {


                string maMatHang = row.Cells[1].Value.ToString();
                string query = @"USP_DeleteMatHang @MaMatHang ";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { maMatHang });
                MessageBox.Show("Xóa thành công!");

            }

            if(needDelete.Count == 0 && needUpdate.Count == 0)
            {
                MessageBox.Show("Không có sự thay đổi nào!");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            MatHang_Load(sender, e);
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
    }
}
