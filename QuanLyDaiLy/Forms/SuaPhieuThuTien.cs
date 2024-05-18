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
    public partial class SuaPhieuThuTien : Form
    {
        public SuaPhieuThuTien()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxSPT.Text) && !string.IsNullOrWhiteSpace(tbxMDL.Text))
            {
                string queryString = "exec Update_PTT_STT @SoPhieuThu , @MaDaiLy , @SoTienThu ";
                DataProvider.Instance.ExecuteNonQuery(queryString, new object[] { tbxSPT.Text, tbxMDL.Text, tbxSTT.Text });
            }
            TraCuuPTT_SPT(tbxSPT.Text);
        }
        private void TraCuuPTT_SPT(string SPT)
        {
            string queryString = "";

            queryString = "exec Search_All_PTT @SoPhieuThu ";

//            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new object[] { SPT, maDaiLy });
  //          dgvSPTT.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaPhieuThuTien_Load(object sender, EventArgs e)
        {
            string queryString = "exec Search_All_PTT @SoPhieuThu";
            DataTable data = DataProvider.Instance.ExecuteQuery(queryString, new Object[] { tbxSPT.Text });
            dgvSPTT.DataSource = data;
        }
    }
}
