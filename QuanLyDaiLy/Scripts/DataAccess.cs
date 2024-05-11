﻿using System;
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
        private SqlConnection _con = new SqlConnection();
        private string _queryString;
        private SqlCommand _command = new SqlCommand();
        public static DataAccess Instance {  get; private set; }
        public static bool IsInstantiated => Instance != null;
        public DataAccess() 
        {
            Instance = (DataAccess)this;
            _con.ConnectionString = Helper.CnnVal("DAILYDUCDAT");
            _command.Connection = _con;
        }

        ~DataAccess() 
        {
            if(Instance == (DataAccess)this)
            {
                Instance = null;
            }
        }

        private void Execute(string lineOfCode = "")
        {
            if (lineOfCode == "")
            {
                MessageBox.Show("Something wrong! Source: DataAccess/Execute");
                return;
            }
            _con.Open();


        }
        public void hamTest()
        {
            MessageBox.Show("Test!");
        }

        public void AddDaiLy(string TenDaiLy, string MaLoaiDaiLy, string DienThoai, string DiaChi, string Email,string MaQuan, string NgayTiepNhan)
        {
            _con.Open();
            _queryString = "exec Insert_DaiLy '"+TenDaiLy+"', '"+MaLoaiDaiLy+"', '"+ DienThoai + "', '"+ DiaChi + "', '"+ Email + "', '"+ MaQuan + "', '"+ NgayTiepNhan + "', 0 ";
            _command.CommandText = _queryString;
            _command.ExecuteNonQuery();
            _con.Close();
        }
    }
}
