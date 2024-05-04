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
        public static DataAccess Instance {  get; private set; }
        public static bool IsInstantiated => Instance != null;
        public DataAccess() 
        {
            if(IsInstantiated && Instance != (DataAccess)this)
            {
                Instance = (DataAccess)this;
                MessageBox.Show("DataAccess thanh cong!");
                return;
            }
            Instance = (DataAccess)this;
        }

        ~DataAccess() 
        {
            if(Instance == (DataAccess)this)
            {
                Instance = null;
            }
        }

        IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DAILYDUCDAT"));
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
        public void hamTest()
        {
            MessageBox.Show("Test!");

        }
    }
}
