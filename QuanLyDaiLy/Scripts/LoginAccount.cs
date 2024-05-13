using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy.Scripts
{
    public class LoginAccount
    {
        private static LoginAccount instance;
        public static LoginAccount Instance
        {
            get { if (instance == null) instance = new LoginAccount(); return instance; }
            private set { instance = value; }
        }
        private LoginAccount() { }

        public bool login(string Username, string Password)
        {
            string stringQuery = "SELECT * FROM USERACCOUNT WHERE Username='" + Username + "' AND Password='" + Password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(stringQuery);
            return result.Rows.Count > 0;
        }
    }
}
