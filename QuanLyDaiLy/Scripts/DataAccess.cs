using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace QuanLyDaiLy
{
    public class DataAccess
    {
        public SqlConnection con = new SqlConnection();
        public static DataAccess Instance {  get; private set; }
        public static bool IsInstantiated => Instance != null;
        public DataAccess() 
        {
            Instance = (DataAccess)this;
            con.ConnectionString = Helper.CnnVal("DAILYDUCDAT");
        }

        ~DataAccess() 
        {
            if(Instance == (DataAccess)this)
            {
                Instance = null;
            }
        }
        
        public void themThamSo()
        {
            using (con)
            {
                con.Execute("insert into THAMSO(TenThamSo, GiaTri)\r\nvalues\r\n('Test', 5)");
            }    
        }
        public List<ThamSo> getThamSo()
        {
            using (con)
            {
                var ouput = con.Query<ThamSo>($"select * from THAMSO").ToList();
                return ouput;
            }
        }
        public void hamTest()
        {
            MessageBox.Show("Test!");

        }
    }
}
