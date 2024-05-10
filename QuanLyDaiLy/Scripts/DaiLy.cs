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
        public string MaLoaiDaiLy { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string MaQuan { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public SqlMoney TongNo { get; set; }
        public DaiLy(string TenDaiLy, string MaLoaiDaiLy, string DienThoai, string DiaChi, string Email, string MaQuan, DateTime NgayTiepNhan)
        {
            this.TenDaiLy = TenDaiLy;
            this.MaLoaiDaiLy = MaLoaiDaiLy;
            this.MaQuan = MaQuan;
            this.DienThoai = DienThoai;
            this.Email = Email;
            this.DiaChi = DiaChi;
            this.NgayTiepNhan = NgayTiepNhan;
            this.TongNo = 0;
        }
    }
}
