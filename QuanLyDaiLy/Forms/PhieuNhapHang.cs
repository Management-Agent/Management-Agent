using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class PhieuNhapHang : Form
    {
        public PhieuNhapHang()
        {
            InitializeComponent();
        }
        private void ThemPNH_Click(object sender, EventArgs e)
        {
            DataAccess.Instance.AddPNH(SPN.Text, MMH.Text, SLN.Text, DGN.Text, TT.Text);
        }

        private void PhieuNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
