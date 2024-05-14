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

--Lay thong tin danh sach cong no
CREATE PROCEDURE USP_GetCongNoInfo
@Thang int,
@Nam int
AS
BEGIN
    SELECT TenDaiLy, NoDau, PhatSinh, NoCuoi
    FROM DAILY inner join BAOCAOCONGNO ON DAILY.MaDaiLy = BAOCAOCONGNO.MaDaiLy
END;


---------------
CREATE PROCEDURE Insert_PNH
    @SoPhieuNhap VARCHAR(10),
    @MaMatHang VARCHAR(50),
    @SoLuongNhap BIGINT,
    @DonGiaNhap MONEY,
	@NgayNhapHang DATE,
    @MaDVT VARCHAR(10),
    @TenDVT VARCHAR(10)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM PHIEUNHAPHANG WHERE SoPhieuNhap = @SoPhieuNhap)
    BEGIN
        INSERT INTO PHIEUNHAPHANG (SoPhieuNhap, NgayNhapHang)
        VALUES (@SoPhieuNhap, @NgayNhapHang)
    END

    IF NOT EXISTS (SELECT * FROM DVT WHERE MaDVT = @MaDVT)
    BEGIN
        INSERT INTO DVT (MaDVT, TenDVT)
        VALUES (@MaDVT, @TenDVT)
    END

    IF NOT EXISTS (SELECT * FROM CT_PNH WHERE SoPhieuNhap = @SoPhieuNhap AND MaMatHang = @MaMatHang)
    BEGIN
        INSERT INTO CT_PNH (SoPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap)
        VALUES (@SoPhieuNhap, @MaMatHang, @SoLuongNhap, @DonGiaNhap)
    END
END
>>>>>>> Update PhieuNhapHang

--------------------
ALTER PROCEDURE USP_GetCongNoInfo
@Thang int,
@Nam int
AS
BEGIN
    SELECT TenDaiLy, NoDau, PhatSinh, NoCuoi
    FROM DAILY inner join BAOCAOCONGNO ON DAILY.MaDaiLy = BAOCAOCONGNO.MaDaiLy
	WHERE BAOCAOCONGNO.Thang = @Thang AND BAOCAOCONGNO.Nam = @Nam
END;

--------------------
CREATE PROCEDURE USP_AddCongNo
    @MaDaiLy varchar(10),
    @Thang int,
    @Nam int,
    @NoDau money,
    @PhatSinh money,
    @ErrorMessage NVARCHAR(1000) OUTPUT
AS
BEGIN
    IF EXISTS(
        SELECT * FROM BAOCAOCONGNO
        WHERE MaDaiLy = @MaDaiLy
            and Thang = @Thang
            and Nam = @Nam)
    BEGIN
        SET @ErrorMessage = 'Da ton tai phieu ghi no cung thang, nam cua cong ty nay';
        RETURN; -- Kết thúc procedure
    END
    
    INSERT INTO BAOCAOCONGNO (MaDaiLy, Thang, Nam, NoDau, PhatSinh)
    VALUES (@MaDaiLy, @Thang, @Nam, @NoDau, @PhatSinh)

    SET @ErrorMessage = NULL;
END;

--------
CREATE PROCEDURE USP_GetTenDaiLy
    @MaDaiLy varchar(10)
AS
BEGIN
    SELECT TenDaiLy FROM DAILY
	WHERE MaDaiLy = @MaDaiLy
END;

-------------------------
create proc Useraccount_Login
	@Username varchar(50),
	@Password varchar(50)
as
begin
	select * from USERACCOUNT where Username = @Username and Password = @Password
end;
-------------------------
create proc Delete_DAILY
	@TenDaiLy varchar(10),
	@DiaChi varchar(200)
as
begin
	delete from DAILY where TenDaiLy = @TenDaiLy and DiaChi = @DiaChi
end;
-------------------------
alter table DAILY
alter column DiaChi varchar(200) not null
alter table DAILY
alter column TenDaiLy varchar(10) not null
alter table DAILY
alter column MaLoaiDaiLy varchar(10) not null
alter table DAILY
alter column DienThoai varchar(10) not null
