﻿using System;
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
        public DateTime NgayNhapHang { get; set; }
        public string MaDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }
        public PhieuNhap(string SoPhieuNhap, string MaMatHang, string SoLuongNhap, string DonGiaNhap, DateTime NgayNhapHang, string DonViTinh, string TenDonViTinh)
        {
            this.SoPhieuNhap = SoPhieuNhap;
            this.MaMatHang = MaMatHang;
            this.SoLuongNhap = SoLuongNhap;
            this.DonGiaNhap = DonGiaNhap;
            this.NgayNhapHang = NgayNhapHang;
            this.MaDonViTinh = DonViTinh;
            this.TenDonViTinh = DonViTinh;
        }
    }
}
