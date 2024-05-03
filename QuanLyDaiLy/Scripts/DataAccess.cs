using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace QuanLyDaiLy
{
    public class DataAccess
    {
        IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DAILY"));
        public void themThamSo()
        {
            using (connection)
            {
                connection.Execute("insert into THAMSO(TenThamSo, GiaTri)\r\nvalues\r\n('Test', 5)");
            }    
        }
        public List<ThamSo> getThamSo()
        {
            using (connection)
            {
                var ouput = connection.Query<ThamSo>($"select * from THAMSO").ToList();
                return ouput;
            }
        }
    }
}
