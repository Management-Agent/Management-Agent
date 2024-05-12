using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy
{
    public class PhieuNhap
    {
        public string SoPhieuNhap { get; set; }
        public string MaMatHang { get; set; }
        public string SoLuongNhap { get; set; }
        public string DonGiaNhap { get; set; }
        public string ThanhTien { get; set; }
        public PhieuNhap(string SoPhieuNhap, string MaMatHang, string SoLuongNhap, string DonGiaNhap, string ThanhTien)
        {
            this.SoPhieuNhap = SoPhieuNhap;
            this.MaMatHang = MaMatHang;
            this.SoLuongNhap = SoLuongNhap;
            this.DonGiaNhap = DonGiaNhap;
            this.ThanhTien = ThanhTien;
        }
    }
}
