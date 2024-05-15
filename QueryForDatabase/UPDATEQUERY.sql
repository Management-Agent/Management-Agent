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
    @TenDVT VARCHAR(10),
	@TenMatHang VARCHAR(10)
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

	IF NOT EXISTS (SELECT * FROM MATHANG WHERE MaMatHang = @MaMatHang)
    BEGIN
        INSERT INTO MATHANG (MaMatHang, TenMatHang, MaDVT)
        VALUES (@MaMatHang, @TenMatHang, @MaDVT)
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
-------------------------
CREATE PROCEDURE Search_Info_PNH
	@SoPhieuNhap VARCHAR(10)
AS
BEGIN
    SELECT *
    FROM PHIEUNHAPHANG
	WHERE SoPhieuNhap = @SoPhieuNhap
END
-------------------------
CREATE PROCEDURE Delete_Info_PNH
	@SoPhieuNhap VARCHAR(10)
AS
BEGIN
	DELETE CT_PNH
	WHERE SoPhieuNhap = @SoPhieuNhap
    DELETE PHIEUNHAPHANG
	WHERE SoPhieuNhap = @SoPhieuNhap
END
-------------------------
CREATE PROCEDURE Search_All_PNH
	@SoPhieuNhap VARCHAR(10)
AS
BEGIN
    SELECT *
    FROM PHIEUNHAPHANG
END
-------------------------
CREATE PROCEDURE Update_CT_PNH_SLN
	@SoPhieuNhap VARCHAR(10),
	@MaMatHang VARCHAR(50),
	@SoLuongNhap BIGINT
AS
BEGIN
	UPDATE CT_PNH
	SET SoLuongNhap = @SoLuongNhap
	WHERE SoPhieuNhap = @SoPhieuNhap and MaMatHang = @MaMatHang
END
-------------------------
CREATE PROCEDURE Update_CT_PNH_DGN
	@SoPhieuNhap VARCHAR(10),
	@MaMatHang VARCHAR(50),
	@DonGiaNhap MONEY
AS
BEGIN
	UPDATE CT_PNH
	SET DonGiaNhap = @DonGiaNhap
	WHERE SoPhieuNhap = @SoPhieuNhap and MaMatHang = @MaMatHang
END
-------------------------
CREATE PROCEDURE Search_CT_PNH_All
	@SoPhieuNhap VARCHAR(10)
AS
BEGIN
	SELECT CT_PNH.SoPhieuNhap, CT_PNH.MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien, MATHANG.MaDVT as 'Mã đơn vị tính', TenDVT 'Tên đơn vị tính'
    FROM CT_PNH
	JOIN MATHANG on MATHANG.MaMatHang = CT_PNH.MaMatHang
	JOIN DVT on DVT.MaDVT = MATHANG.MaDVT
END
----------------------------
CREATE TRIGGER TR_AFTERINSERT_DAILY
ON DAILY 
AFTER INSERT
AS
BEGIN
	DECLARE @MaDaiLy varchar(10);
	DECLARE @NgayTiepNhan date;
	
	SELECT @MaDaiLy = MaDaiLy , @NgayTiepNhan = NgayTiepNhan from inserted

	INSERT INTO BAOCAOCONGNO(MaDaiLy,Thang,Nam,NoDau,PhatSinh)
	VALUES (@MaDaiLy, MONTH(@NgayTiepNhan), YEAR(@NgayTiepNhan), 0, 0)
END

-----------------------------
drop table BAOCAOCONGNO
GO
Create TABLE BAOCAOCONGNO
(
MaDaiLy varchar(10) not null,
Thang int not null constraint CK_BAOCAOCONGNO_Thang check(Thang >= 1 and Thang <= 12),
Nam int not null constraint  CK_BAOCAOCONGNO_Nam check(Nam >= 0),
NoDau money constraint CK_BAOCAOCONGNO_NoDau CHECK(NoDau > = 0) ,
PhatSinh money ,
NoCuoi As (NoDau + PhatSinh) PERSISTED,
)
GO
ALTER TABLE BAOCAOCONGNO
ADD CONSTRAINT PK_BAOCAOCONGNO PRIMARY KEY(MaDaiLy,Thang,Nam);
 GO
-----------------------------
CREATE TRIGGER trgAfterInsertOnBAOCAOCONGNO
ON BAOCAOCONGNO
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaDaiLy VARCHAR(10);
    DECLARE @Thang INT;
    DECLARE @Nam INT;
    DECLARE @NoCuoiThangTruoc MONEY;

    SELECT @MaDaiLy = MaDaiLy, @Thang = Thang, @Nam = Nam
    FROM inserted;

    -- Loop through missing months and insert records
	Declare @N Int;
	Set @N = @Nam * 12 + @Thang;
    DECLARE @CurrentThang INT;
    DECLARE @CurrentNam INT;
	Declare @CurrentN Int;
	

	-- TIM THANG VA NAM CUA THOI GIAN MOI NHAT TRONG BANG KO TINH BO VUA MOI INSERT
	
		Select  @CurrentN = Isnull( max(Nam * 12 + Thang),0) from BAOCAOCONGNO

		WHERE  MaDaiLy = @MaDaiLy and (nam != @Nam or thang != @Thang)
	--
	if(@CurrentN = 0)
	return;
     -- Loop through missing months and insert records
   
    WHILE @CurrentN < @N - 1
    BEGIN
        SELECT @NoCuoiThangTruoc = NoCuoi FROM BAOCAOCONGNO WHERE MaDaiLy = @MaDaiLy AND Nam = ((@CurrentN - 1)/12) And Thang = ((@CurrentN - 1) %12 +1)
        INSERT INTO BAOCAOCONGNO (MaDaiLy, Thang,Nam, NoDau, PhatSinh)
        VALUES (@MaDaiLy, ((@CurrentN +1 - 1) %12 +1),((@CurrentN + 1 - 1)/12), @NoCuoiThangTruoc, 0);

        SET @CurrentN = @CurrentN + 1;
    END;

    -- Cập nhật NoDau cho bản ghi mới chèn
	set @N = @N -1;
    SELECT @NoCuoiThangTruoc = NoCuoi 
    FROM BAOCAOCONGNO 
    WHERE MaDaiLy = @MaDaiLy  AND Nam = ((@N - 1)/12) And Thang = ((@N - 1) %12 +1)

    UPDATE BAOCAOCONGNO
    SET NoDau = ISNULL(@NoCuoiThangTruoc, 0)
    WHERE MaDaiLy = @MaDaiLy AND Thang = @Thang AND Nam = @Nam;
END;

------------
CREATE TRIGGER trgAfterUpdateOnBAOCAOCONGNO
ON BAOCAOCONGNO
For Update
AS
BEGIN
    DECLARE @MaDaiLy VARCHAR(10);
    DECLARE @Thang INT;
    DECLARE @Nam INT;
	DECLARE @PhatSinhCu money;
	DECLARE @PhatSinhMoi money;

    SELECT @MaDaiLy = MaDaiLy, @Thang = Thang, @Nam = Nam,@PhatSinhMoi = PhatSinh
    FROM inserted;

	Select @PhatSinhCu = PhatSinh from deleted

	DECLARE @N int;
	set @N = @Nam * 12 + @Thang;

	Update BAOCAOCONGNO
	set NoDau += (@PhatSinhMoi - @PhatSinhCu)
	where MaDaiLy = @MaDaiLy and (Nam*12 + Thang > @N)
END;

-------
create procedure USP_PHIEUXUATHANG_BAOCAOCONGNO
@MaDaiLy varchar(10),
@ThoiGian datetime,
@ThayDoiConLai money
AS
BEGIN
	Declare @Thang Int ;Set @Thang = month(@ThoiGian);
	Declare @Nam Int; Set @Nam = year(@ThoiGian);

	IF(Exists (select * from BAOCAOCONGNO where MaDaiLy = @MaDaiLy and Nam =  @Nam and Thang = @Thang))
	Begin
		Update BAOCAOCONGNO
		set PhatSinh += @ThayDoiConLai;
	end
	Else
	Begin
		Insert Into BAOCAOCONGNO(MaDaiLy,Thang,Nam,PhatSinh)
		values (@MaDaiLy,@Thang,@Nam,@ThayDoiConLai);
	end
END

-------
drop  TRIGGER TRG_INSERT_PXH_ThayDoiBaoCaoCongNo

CREATE TRIGGER TRG_INSERT_PXH_ThayDoiBaoCaoCongNo
ON PHIEUXUATHANG
AFTER INSERT
AS
BEGIN
	DECLARE @MaDaiLy1 varchar(10);
	DECLARE @NgayXuatHang DATETIME;
	Declare @ConLai money;

	SELECT @MaDaiLy1 = MaDaiLy ,@NgayXuatHang = NgayXuatHang, @ConLai = TongTien - SoTienTra
	FROM inserted


	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy1 , @ThoiGian = @NgayXuatHang , @ThayDoiConLai = @ConLai;

END

---
CREATE TRIGGER TRG_DELETE_PXH_ThayDoiBaoCaoCongNo
ON PHIEUXUATHANG
AFTER DELETE
AS
BEGIN
	DECLARE @MaDaiLy1 varchar(10);
	DECLARE @NgayXuatHang DATETIME;
	Declare @ConLai money;

	SELECT @MaDaiLy1 = MaDaiLy ,@NgayXuatHang = NgayXuatHang,@ConLai = SoTienTra - TongTien
	FROM deleted

	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy1 , @ThoiGian = @NgayXuatHang  , @ThayDoiConLai = @ConLai

END
-----
drop TRIGGER TRG_UDATE_PXH_ThayDoiBaoCaoCongNo
CREATE TRIGGER TRG_UDATE_PXH_ThayDoiBaoCaoCongNo
ON PHIEUXUATHANG
for UPDATE
AS
BEGIN
	DECLARE @MaDaiLy1 varchar(10);
	DECLARE @NgayXuatHang DATETIME;
	Declare @ConLaiCu money;
	Declare @ConLaiMoi money;
	Declare @ThayDoi money;

	SELECT @MaDaiLy1 = MaDaiLy ,@NgayXuatHang = NgayXuatHang , @ConLaiMoi = TongTien - SoTienTra
	FROM inserted;

	select @ConLaiCu = TongTien - SoTienTra from deleted;

	Set @ThayDoi = @ConLaiMoi - @ConLaiCu;

	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy1 , @ThoiGian = @NgayXuatHang  , @ThayDoiConLai = @ThayDoi;

END

----------------------------------------------

