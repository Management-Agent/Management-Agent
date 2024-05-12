USE QUANLYDAILY
GO
-----Lay thong tin danh sach dai ly
CREATE PROCEDURE USP_GetDaiLyInfo
AS
BEGIN
    SELECT TenDaiLy, TenLoaiDaiLy, TenQuan, TongNo
    FROM DAILY inner join QUAN ON DAILY.MaQuan = QUAN.MaQuan
	INNER JOIN LOAIDAILY ON DAILY.MaLoaiDaiLy = LOAIDAILY.MaLoaiDaiLy
END;
<<<<<<< HEAD

--Lay thong tin danh sach cong no
CREATE PROCEDURE USP_GetCongNoInfo
@Thang int,
@Nam int
AS
BEGIN
    SELECT TenDaiLy, NoDau, PhatSinh, NoCuoi
    FROM DAILY inner join BAOCAOCONGNO ON DAILY.MaDaiLy = BAOCAOCONGNO.MaDaiLy
END;
=======
CREATE PROCEDURE Insert_PNH
    @SoPhieuNhap VARCHAR(10),
    @MaMatHang VARCHAR(50),
    @SoLuongNhap BIGINT,
    @DonGiaNhap MONEY,
	@NgayNhapHang DATE
AS
BEGIN
	INSERT INTO PHIEUNHAPHANG(SoPhieuNhap, NgayNhapHang)
	VALUES (@SoPhieuNhap, @NgayNhapHang)
    INSERT INTO CT_PNH (SoPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap)
	VALUES (@SoPhieuNhap, @MaMatHang, @SoLuongNhap, @DonGiaNhap)
END
>>>>>>> Update PhieuNhapHang
