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
            string query = @"INSERT INTO LOAIDAILY(TenLoaiDaiLy,SoNoToiDa) values (null,null)";
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
                needDelete.Add(selectedRow);
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
            foreach (DataRow row in dataGridView1.Rows)
            {
                if(WasUpdate(row))
                {
                    //get value
                    string maLoaiDaiLy = row[0].ToString();
                    string tenLoaiDaiLy = row[1].ToString();
                    decimal soTienNoToiDa = decimal.Parse(row[2].ToString());
                    //update this row in csdl 
                    string query = "UPDATE LOAIDAILY SET TenLoaiDaiLy=" + tenLoaiDaiLy +"Where MaLoaiDaiLy=" + maLoaiDaiLy;
                    DataProvider.Instance.ExecuteNonQuery(query);
                    query = "UPDATE LOAIDAILY SET SoTienNoToiDa=" + soTienNoToiDa + "Where MaLoaiDaiLy=" + maLoaiDaiLy;
                    DataProvider.Instance.ExecuteNonQuery(query);
                }
            }
        }

        private bool IsNewRow(DataRow testRow)
        {
            int maLoai = int.Parse(testRow.ItemArray[0].ToString());
            foreach(DataRow row in data.Rows)
            {
                if (int.Parse(row[0].ToString()) == maLoai)
                    return false;
            }
            return true;
        }

        private bool WasUpdate(DataRow testRow)
        {
            int maLoai = int.Parse(testRow[0].ToString());
            DataRow findRow = data.Rows.Find(testRow.ItemArray[0]);
            if (findRow.Equals(testRow))
                return false;
            else
                return true;
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)sender;
            needUpdate.Add(row);
        }
    }
}
