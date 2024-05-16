using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    public class DaiLy
    {
        public string TenDaiLy { get; set; }
        public string LoaiDaiLy { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Quan { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public SqlMoney TongNo { get; set; }
        public DaiLy(string TenDaiLy, string LoaiDaiLy, string DienThoai, string DiaChi, string Email, string Quan, DateTime NgayTiepNhan, SqlMoney TongNo)
        {
            this.TenDaiLy = TenDaiLy;
            this.LoaiDaiLy = LoaiDaiLy;
            this.Quan = Quan;
            this.DienThoai = DienThoai;
            this.Email = Email;
            this.DiaChi = DiaChi;
            this.NgayTiepNhan = NgayTiepNhan;
            this.TongNo = TongNo;
        }
    }
}
