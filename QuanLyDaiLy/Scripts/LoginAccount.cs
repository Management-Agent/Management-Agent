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
            string stringQuery = "Useraccount_Login @Username , @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(stringQuery, new object[] {Username, Password });
            return result.Rows.Count > 0;
        }
    }
}
