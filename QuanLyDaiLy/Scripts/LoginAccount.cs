using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(Password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte b in hasData)
            {
                hasPass += b;
            }
            hasPass.Reverse();

            string stringQuery = "Useraccount_Login @Username , @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(stringQuery, new object[] {Username, hasPass });
            return result.Rows.Count > 0;
        }
    }
}
