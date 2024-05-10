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
        public static DataAccess Instance {  get; private set; }
        public static bool IsInstantiated => Instance != null;
        public DataAccess() 
        {
            Instance = (DataAccess)this;
            _con.ConnectionString = Helper.CnnVal("DAILYDUCDAT");
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
            using (_con)
            {
                _con.Execute("insert into THAMSO(TenThamSo, GiaTri)\r\nvalues\r\n('Test', 5)");
            }    
        }
        public List<ThamSo> getThamSo()
        {
            using (_con)
            {
                var ouput = _con.Query<ThamSo>($"select * from THAMSO").ToList();
                return ouput;
            }
        }
        public void hamTest()
        {
            MessageBox.Show("Test!");
        }

        public void AddDaiLy(string TenDaiLy, string MaLoaiDaiLy, string DienThoai, string DiaChi, string Email,string MaQuan, DateTime NgayTiepNhan)
        {
            DaiLy newDaiLy = new DaiLy(TenDaiLy, MaLoaiDaiLy, DienThoai, DiaChi, Email, MaQuan, NgayTiepNhan);

        }
    }
}
