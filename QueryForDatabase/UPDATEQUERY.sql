USE QUANLYDAILY

GO

create proc [dbo].[USP_GetMaDaiLy]
as
begin
	select MaDaiLy
	from DAILY
end;

CREATE FUNCTION [dbo].[fuConvertToUnsign1]
( @strInput NVARCHAR(4000) )
RETURNS NVARCHAR(4000) 
AS
BEGIN
IF @strInput IS NULL
RETURN @strInput
IF @strInput = ''
RETURN @strInput
DECLARE @RT NVARCHAR(4000)
DECLARE @SIGN_CHARS NCHAR(136)
DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208)
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int 
DECLARE @COUNTER1 int
SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
BEGIN 
SET @COUNTER1 = 1
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
BEGIN 
IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
BEGIN 
IF @COUNTER=1 
SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)
ELSE 
SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK
END SET @COUNTER1 = @COUNTER1 +1 
END SET @COUNTER = @COUNTER +1
END SET @strInput = replace(@strInput,' ','-') 
RETURN @strInput 
END

--------------------------------
create proc [dbo].[USP_GetDaiLyInfo]
as
begin
	SELECT MaDaiLy, TenDaiLy,MaLoaiDaiLy, DienThoai, DiaChi,Email,MaQuan,NgayTiepNhan, TongNo
    FROM DAILY
end;
-------------------------------
ALTER procedure [dbo].[Insert_DaiLy]
	@TenDaiLy varchar(10),
	@MaLoaiDaiLy varchar(10),
	@DienThoai varchar(10),
	@DiaChi varchar(200),
	@Email varchar(255),
	@MaQuan varchar(10),
	@NgayTiepNhan date,
	@TongNo money
as
begin
	insert into DAILY(TenDaiLy,MaLoaiDaiLy, DienThoai, DiaChi, Email, MaQuan, NgayTiepNhan, TongNo)
	values
	(@TenDaiLy, @MaLoaiDaiLy, @DienThoai, @DiaChi, @Email, @MaQuan, @NgayTiepNhan, @TongNo);
end;
--------------------------------------
CREATE proc [dbo].[Update_DAILY]
@MaDaiLy varchar(10),
@TenDaiLy varchar(200),
@MaLoaiDaiLy varchar(10),
@DienThoai varchar(10),
@Email varchar(255),
@MaQuan varchar(10)
as
begin
	update DAILY
	set		TenDaiLy = @TenDaiLy,
			MaLoaiDaiLy = @MaLoaiDaiLy,
			DienThoai = @DienThoai,
			Email = @Email,
			MaQuan = @MaQuan
	where MaDaiLy = @MaDaiLy
end;
--------------------------------------------
CREATE proc [dbo].[Delete_DAILY]
	@MaDaiLy varchar(10)
as
begin
	delete from DAILY where @MaDaiLy = MaDaiLy
end;

--------------------------------Lay thong tin danh sach ten loai dai ly
create proc USP_GetAllTenLoaiDaiLy
as
begin
	select TenLoaiDaiLy
	from LOAIDAILY
end;
--------------------------
create proc USP_GetMaQuan
as
begin
	select MaQuan
	from QUAN
end;
--Lay thong tin danh sach ten quan
create proc USP_GetAllTenQuan
as
begin
	select TenQuan
	from QUAN
end;
--------------------------Tim thong tin dai ly thong qua tim so dien thoai
alter proc USP_FindDaiLy
	@DienThoai varchar(10)
as
begin
	SELECT TenDaiLy,TenLoaiDaiLy, DienThoai, DiaChi,Email,TenQuan,NgayTiepNhan, TongNo
    FROM DAILY inner join QUAN ON DAILY.MaQuan = QUAN.MaQuan
	INNER JOIN LOAIDAILY ON DAILY.MaLoaiDaiLy = LOAIDAILY.MaLoaiDaiLy
	where @DienThoai = DienThoai
end;
GO

--Lay tat ca ma dai ly, ten dai ly thuoc 1 quan nao do
alter proc USP_GetDaiLyInfoThroughMaQuan
	@MaQuan varchar(10)
as
begin
	SELECT TenDaiLy
	from DAILY
	where @MaQuan = MaQuan
end;
GO

--Lay thong tin danh sach cong no
CREATE PROCEDURE USP_GetCongNoInfo
@Thang int,
@Nam int
AS
BEGIN
    SELECT TenDaiLy, NoDau, PhatSinh, NoCuoi
    FROM DAILY inner join BAOCAOCONGNO ON DAILY.MaDaiLy = BAOCAOCONGNO.MaDaiLy
END;
GO
----------------
CREATE proc [dbo].[USP_GetLoaiDaiLy]
as
begin
	select MaLoaiDaiLy
	from LOAIDAILY
end;
GO
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
---------------------
CREATE PROCEDURE Search_CT_PNH
	@SoPhieuNhap VARCHAR(10),
	@MaMatHang VARCHAR(50)
AS
BEGIN
	SELECT CT_PNH.SoPhieuNhap, CT_PNH.MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien, MATHANG.MaDVT as 'Mã đơn vị tính', TenDVT 'Tên đơn vị tính'
    FROM CT_PNH
	JOIN MATHANG on MATHANG.MaMatHang = CT_PNH.MaMatHang
	JOIN DVT on DVT.MaDVT = MATHANG.MaDVT
	WHERE SoPhieuNhap = @SoPhieuNhap and CT_PNH.MaMatHang = @MaMatHang
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
 ----------------------------

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
    END

--- Cập nhật NoDau cho bản ghi mới chèn
	set @N = @N -1;
    SELECT @NoCuoiThangTruoc = NoCuoi 
    FROM BAOCAOCONGNO 
    WHERE MaDaiLy = @MaDaiLy  AND Nam = ((@N - 1)/12) And Thang = ((@N - 1) %12 +1)

    UPDATE BAOCAOCONGNO
    SET NoDau = ISNULL(@NoCuoiThangTruoc, 0)
    WHERE MaDaiLy = @MaDaiLy AND Thang = @Thang AND Nam = @Nam;
END
GO

--------------------------------
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
GO

-------
Create procedure USP_PHIEUXUATHANG_BAOCAOCONGNO
@MaDaiLy varchar(10),
@ThoiGian datetime,
@ThayDoiConLai money
AS
BEGIN
	Declare @Thang Int ;Set @Thang = month(@ThoiGian);
	Declare @Nam Int; Set @Nam = year(@ThoiGian);

	IF(@MaDaiLy is null)
		return;

	IF(Exists (select * from BAOCAOCONGNO where MaDaiLy = @MaDaiLy and Nam =  @Nam and Thang = @Thang))
	Begin
		Update BAOCAOCONGNO
		set PhatSinh += @ThayDoiConLai
		Where MaDaiLy = @MaDaiLy and Nam =  @Nam and Thang = @Thang;
	end
	Else
	Begin
		Insert Into BAOCAOCONGNO(MaDaiLy,Thang,Nam,PhatSinh)
		values (@MaDaiLy,@Thang,@Nam,@ThayDoiConLai);
	end
END

-------
Create TRIGGER TRG_INSERT_PXH_ThayDoiBaoCaoCongNo
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

	IF(Exists (select * from BAOCAOCONGNO where MaDaiLy = @MaDaiLy1))
	Begin
	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy1 , @ThoiGian = @NgayXuatHang  , @ThayDoiConLai = @ConLai
	end

END
-----
create TRIGGER TRG_UDATE_PXH_ThayDoiBaoCaoCongNo
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
<<<<<<< Updated upstream
create PROCEDURE Search_All_PXH
	@SoPhieuXuat VARCHAR(10)
AS
BEGIN
    SELECT SoPhieuXuat, NgayXuatHang, TongTien, MaDaiLy
    FROM PHIEUXUATHANG
END
----------------------------------------------
create PROCEDURE Search_Info_PXH
	@SoPhieuXuat VARCHAR(10)
AS
BEGIN
    SELECT SoPhieuXuat, NgayXuatHang, TongTien, MaDaiLy
    FROM PHIEUXUATHANG
	WHERE @SoPhieuXuat = SoPhieuXuat		
END
--------------------------------------------------
create PROCEDURE Delete_Info_PXH
	@SoPhieuXuat VARCHAR(10)
AS
BEGIN
	DELETE CT_PXH
	WHERE SoPhieuXuat = @SoPhieuXuat
    DELETE PHIEUXUATHANG
	WHERE SoPhieuXuat = @SoPhieuXuat
END
---------------------------------------------
create PROCEDURE Update_CT_PXH_SLX
	@SoPhieuXuat VARCHAR(10),
	@MaMatHangXuat VARCHAR(50),
	@SoLuongXuat BIGINT
AS
BEGIN
	UPDATE CT_PXH
	SET SoLuongXuat = @SoLuongXuat
	WHERE SoPhieuXuat = @SoPhieuXuat and MaMatHangXuat = @MaMatHangXuat
END
-------------------------------------------------
create PROCEDURE Update_CT_PXH_DGX
	@SoPhieuXuat VARCHAR(10),
	@MaMatHangXuat VARCHAR(50),
	@DonGiaXuat Money
AS
BEGIN
	UPDATE CT_PXH
	SET DonGiaXuat = @DonGiaXuat 
	WHERE SoPhieuXuat = @SoPhieuXuat and MaMatHangXuat = @MaMatHangXuat
END
-------------------------------------------------
CREATE PROCEDURE Search_CT_PXH
	@SoPhieuXuat VARCHAR(10),
	@MaMatHangXuat VARCHAR(50)
AS 
BEGIN
	SELECT SoPhieuXuat, MaMatHangXuat, SoLuongXuat, DonGiaXuat, ThanhTien
	FROM CT_PXH
	WHERE SoPhieuXuat = @SoPhieuXuat And @MaMatHangXuat = MaMatHangXuat
END
------------------------------------------------
CREATE PROCEDURE Search_CT_PXH_All 
AS 
BEGIN
	SELECT SoPhieuXuat, MaMatHangXuat, SoLuongXuat, DonGiaXuat, ThanhTien
	FROM CT_PXH
END
--------------------------------------
CREATE PROCEDURE Search_All_PTT
	@SoPhieuThu VARCHAR(10)
AS
BEGIN
	SELECT SoPhieuThu, MaDaiLy, NgayThuTien, SoTienTHu
	FROM PHIEUTHUTIEN
END
-------------------------------------
CREATE PROCEDURE Search_Info_PTT
	@SoPhieuThu VARCHAR(10)
AS
BEGIN
	SELECT SoPhieuThu, MaDaiLy, NgayThuTien, SoTienTHu
	FROM PHIEUTHUTIEN
	WHERE 	@SoPhieuThu = SoPhieuThu
END
----------------------------------------
CREATE PROCEDURE Delete_Info_PTT
	@SoPhieuThu VARCHAR(10)
AS
BEGIN
	DELETE FROM PHIEUTHUTIEN 
	WHERE @SoPhieuThu = SoPhieuThu
END
----------------------------------------
CREATE PROCEDURE Update_PTT_STT
	@SoPhieuThu VARCHAR(10),
	@MaDaiLy VARCHAR(10),
	@SoTienThu Money
AS 
BEGIN 
	UPDATE PHIEUTHUTIEN
	SET SoTienThu = @SoTienThu
	where SoPhieuThu = @SoPhieuThu and MaDaiLy = @MaDaiLy
END
---------------------------------------
=======
CREATE PROCEDURE Update_CT_PNH_DVT
	@SoPhieuNhap VARCHAR(10),
	@MaMatHang VARCHAR(50),
	@MaDVT VARCHAR(10)
AS
BEGIN
	UPDATE MATHANG
	SET MaDVT = @MaDVT
	WHERE MaMatHang = @MaMatHang
END
>>>>>>> Stashed changes

--------------------------------
INSERT INTO THAMSO(TenThamSo,GiaTri)
VALUES
('SoLoaiDaiLy',2),
('SoMatHang',5),
('SoDonViTinh',2)
	

/*
CREATE PROCEDURE sp_GetBaoCaoDoanhSo
    @Thang INT,
    @Nam INT
AS
BEGIN
    SELECT 
        ROW_NUMBER() OVER (ORDER BY MaDaily) AS STT,
        MaDaily AS [Đại Lý],
        COUNT(*) AS [Số Phiếu Xuất],
        SUM(ThanhTien) AS [Tổng Trị Giá],
        (SUM(TongTriGia) / (SELECT SUM(TongTriGia) FROM BAOCAODOANHSO WHERE Thang = @Thang AND Nam = @Nam)) * 100 AS [Tỷ Lệ]
    FROM 
        BAOCAODOANHSO BCDS
		join 
    WHERE 
        Thang = @Thang AND Nam = @Nam
    GROUP BY 
        MaDaily
END
*/	

	
CREATE PROCEDURE BCDS_month
    @Thang INT,
    @Nam INT
AS
BEGIN   
    DECLARE @TongTriGiaTatCa FLOAT;
    SELECT 
        @TongTriGiaTatCa = SUM(CTPX.ThanhTien)
    FROM 
        PHIEUXUATHANG PX
        JOIN CT_PXH CTPX ON PX.SoPhieuXuat = CTPX.SoPhieuXuat
    WHERE 
        MONTH(PX.NgayXuatHang) = @Thang AND YEAR(PX.NgayXuatHang) = @Nam;

    SELECT 
        ROW_NUMBER() OVER (ORDER BY PX.MaDaiLy) AS 'STT',
        PX.MaDaiLy,
        COUNT(*) AS 'Số Phiếu Xuất',
        SUM(CTPX.ThanhTien) AS 'Tổng trị giá',
        (SUM(CTPX.ThanhTien) / @TongTriGiaTatCa) * 100 AS 'Tỉ Lệ'
    FROM 
        PHIEUXUATHANG PX
        JOIN CT_PXH CTPX ON PX.SoPhieuXuat = CTPX.SoPhieuXuat
    WHERE 
        MONTH(PX.NgayXuatHang) = @Thang AND YEAR(PX.NgayXuatHang) = @Nam  
    GROUP BY 
        PX.MaDaiLy
END


-----------------------------------

CREATE PROCEDURE Update_LoaiDaiLy_Ten
	@MaLoaiDaiLy VARCHAR(10),
	@TenLoaiDaiLy VARCHAR(100)
AS 
BEGIN 
	UPDATE LOAIDAILY
	SET TenLoaiDaiLy = @TenLoaiDaiLy
	where MaLoaiDaiLy = @MaLoaiDaiLy
END

-------------------------------------


CREATE PROCEDURE Update_LoaiDaiLy_SoNoToiDa
	@MaLoaiDaiLy varchar(10),
	@SoNoToiDa money
AS 
BEGIN 
	UPDATE LOAIDAILY
	SET SoNoToiDa = @SoNoToiDa
	where MaLoaiDaiLy = @MaLoaiDaiLy
END




CREATE PROCEDURE datagridview_loaidaily
AS
BEGIN
	select MaLoaiDaiLy,TenLoaiDaiLy,SoNoToiDa
	from LOAIDAILY
END
-----------------------------------
create procedure datagridview_Quan
as
begin
	select MaQuan,TenQuan
	from QUAN
end

------------------------------------------
CREATE PROCEDURE Update_TenQuan
	@MaQuan varchar(10),
	@TenQuan varchar(100)
AS 
BEGIN 
	UPDATE QUAN
	SET TenQuan = @TenQuan
	where MaQuan = @MaQuan
END
-------------------------------

CREATE PROCEDURE Insert_LoaiDaiLy
@MaLoaiDaiLy varchar(10),
@TenLoaiDaiLy varchar(100),
@SoNoToiDa money
AS
BEGIN
	INSERT INTO LOAIDAILY(MaLoaiDaiLy,TenLoaiDaiLy,SoNoToiDa) values (@MaLoaiDaiLy, @TenLoaiDaiLy, @SoNoToiDa)
END
-----------------------------------------


CREATE PROCEDURE Delete_LoaiDaiLy
@MaLoaiDaiLy varchar(10)
AS
BEGIN
	DELETE FROM LOAIDAILY
	WHERE MaLoaiDaiLy = @MaLoaiDaiLy 
END
----------------------------------------


CREATE PROCEDURE Search_LoaiDaiLy
@MaLoaiDaiLy varchar(10)
AS
BEGIN
	SELECT MaLoaiDaiLy,TenLoaiDaiLy,SoNoToiDa
	from LOAIDAILY
END

------------------------------

CREATE PROCEDURE load_Quan
AS
BEGIN
	SELECT MaQuan,TenQuan
	from QUAN	
END

-------------------------------

CREATE PROCEDURE Insert_TenQuan
@MaQuan varchar(10),
@TenQuan varchar(100)
AS
BEGIN
	INSERT INTO QUAN(MaQuan,TenQuan) values (@MaQuan, @TenQuan)
END

--------------------------------

CREATE PROCEDURE Delete_Quan
@MaQuan varchar(10)
AS
BEGIN
	DELETE FROM QUAN
	WHERE MaQuan = @MaQuan 
END

-----------------------------------------------
CREATE TRIGGER TRG_INSERT_PTT_ThayDoiBaoCaoCongNo
ON PHIEUTHUTIEN
AFTER INSERT
AS
BEGIN
	DECLARE @MaDaiLy varchar(10);
	DECLARE @NgayThu DATETIME;
	Declare @ThayDoiNo money;

	SELECT @MaDaiLy = MaDaiLy ,@NgayThu = NgayThuTien, @ThayDoiNo =  SoTienThu * (-1)
	FROM inserted


	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy , @ThoiGian = @NgayThu , @ThayDoiConLai = @ThayDoiNo

END

-----------------------------------------------
CREATE TRIGGER TRG_DELETE_PTT_ThayDoiBaoCaoCongNo
ON PHIEUTHUTIEN
AFTER DELETE
AS
BEGIN
	DECLARE @MaDaiLy varchar(10);
	DECLARE @NgayThu DATETIME;
	Declare @ThayDoiNo money;

	SELECT @MaDaiLy = MaDaiLy ,@NgayThu = NgayThuTien, @ThayDoiNo =  SoTienThu
	FROM deleted


	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy , @ThoiGian = @NgayThu , @ThayDoiConLai = @ThayDoiNo

END

--------------------------------------------------
CREATE TRIGGER TRG_UPDATE_PTT_ThayDoiBaoCaoCongNo
ON PHIEUTHUTIEN
AFTER UPDATE
AS
BEGIN
	DECLARE @MaDaiLy varchar(10);
	DECLARE @NgayThu DATETIME;
	Declare @SoTienThuMoi money;
	Declare @SoTienThuCu money;
	Declare @ThayDoiNo money;



	SELECT @MaDaiLy = MaDaiLy ,@NgayThu = NgayThuTien, @SoTienThuMoi = SoTienThu
	FROM inserted

	Select @SoTienThuCu = SoTienThu
	From deleted

	Set @ThayDoiNo = @SoTienThuCu - @SoTienThuMoi;

	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy , @ThoiGian = @NgayThu , @ThayDoiConLai = @ThayDoiNo

END

---------------------------------
create trigger TR_GenerateMaLoaiDaiLy
on LOAIDAILY
instead of insert
as
begin
	declare @Prefix varchar(4) = 'MLDL'
	declare @Length int = 4

	declare @MaxMaLoaiDaiLy int
	select @MaxMaLoaiDaiLy = ISNULL(max(cast(substring(MaLoaiDaiLy, len(@Prefix) + 1, @Length)
	as int)), 0)
	from LOAIDAILY

	insert into LOAIDAILY(MaLoaiDaiLy, TenLoaiDaiLy, SoNoToiDa)
	select @Prefix + right('0000' + cast(@MaxMaLoaiDaiLy + row_number() over (order by(select null)) as varchar), @Length),
	i.TenLoaiDaiLy, i.SoNoToiDa
	from inserted i

end;
GO

--------------------------------
create procedure USP_DeleteLoaiDaiLy
@MaLoaiDaiLy varchar(10)
as
begin
	delete LOAIDAILY
	where MaLoaiDaiLy = @MaLoaiDaiLy
end

--------------------------------
create procedure USP_UpdateLoaiDaiLy
@MaLoaiDaiLy varchar(10),
@TenLoaiDaiLy varchar(100),
@SoNoToiDa money
as
begin
	Update LOAIDAILY
	Set
		TenLoaiDaiLy = @TenLoaiDaiLy,
		SoNoToiDa = @SoNoToiDa
	Where
		MaLoaiDaiLy  = @MaLoaiDaiLy
end
---------------------------------
create trigger TR_GenerateMaMatHang
on MATHANG
instead of insert
as
begin
	declare @Prefix varchar(3) = 'MMH'
	declare @Length int = 4

	declare @MaxMaMatHang int
	select @MaxMaMatHang = ISNULL(max(cast(substring(MaMatHang, len(@Prefix) + 1, @Length)
	as int)), 0)
	from MATHANG

	insert into MATHANG(MaMatHang, TenMatHang,MaDVT, SoLuongTon)
	select @Prefix + right('0000' + cast(@MaxMaMatHang + row_number() over (order by(select null)) as varchar), @Length),
	i.TenMatHang, i.MaDVT , i.SoLuongTon
	from inserted i

end;
GO

-------------------------------------
create procedure USP_DeleteMatHang
@MaMatHang varchar(10)
as
begin
	delete MATHANG
	where MaMatHang = @MaMatHang
end

-----------------------
create procedure USP_UpdateMatHang
@MaMatHang varchar(10),
@TenMatHang varchar(100),
@MaDVT varchar(10),
@SoLuongTon int
as
begin

	if(@MaDVT = 'null')
		Set @MaDVT = null;
	
	Update MATHANG
	Set
		TenMatHang = @TenMatHang,
		MaDVT = @MaDVT,
		SoLuongTon = @SoLuongTon
	Where
		MaMatHang  = @MaMatHang
end
--------------------------------
alter proc Insert_PXH;
create PROCEDURE Insert_PXH
    @SoPhieuXuat VARCHAR(10),
	@MaDaiLy VARCHAR(10),
	@NgayXuatHang DATE,
	@TongTien money,
	@SoTienTra money
AS
BEGIN
    Insert into PHIEUXUATHANG(SoPhieuXuat,MaDaiLy,NgayXuatHang,TongTien,SoTienTra)
	values (@SoPhieuXuat,@MaDaiLy,@NgayXuatHang,@TongTien,@SoTienTra);
END

-------------------------------------

create proc [dbo].[USP_GetMaDVT]
as
begin
	select MaDVT
	from DVT
end;


-----------------------------------------

create proc [dbo].[USP_GetMaMatHang]
as
begin
	select MaMatHang
	from MATHANG
end;
-----------------------------------------------------
alter PROCEDURE Insert_PNH
    @SoPhieuNhap VARCHAR(10),
    @MaMatHang VARCHAR(50),
    @SoLuongNhap BIGINT,
    @DonGiaNhap MONEY,
	@NgayNhapHang DATE,
    @MaDVT VARCHAR(10)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM PHIEUNHAPHANG WHERE SoPhieuNhap = @SoPhieuNhap)
    BEGIN
        INSERT INTO PHIEUNHAPHANG (SoPhieuNhap, NgayNhapHang)
        VALUES (@SoPhieuNhap, @NgayNhapHang)
    END

	IF NOT EXISTS (SELECT * FROM MATHANG WHERE MaMatHang = @MaMatHang)
    BEGIN
        INSERT INTO MATHANG (MaMatHang, MaDVT)
        VALUES (@MaMatHang, @MaDVT)
    END

    IF NOT EXISTS (SELECT * FROM CT_PNH WHERE SoPhieuNhap = @SoPhieuNhap AND MaMatHang = @MaMatHang)
    BEGIN
        INSERT INTO CT_PNH (SoPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap)
        VALUES (@SoPhieuNhap, @MaMatHang, @SoLuongNhap, @DonGiaNhap)
    END
END

-------------------------------------
Alter procedure USP_PHIEUXUATHANG_BAOCAOCONGNO
@MaDaiLy varchar(10),
@ThoiGian datetime,
@ThayDoiConLai money
AS
BEGIN
	Declare @Thang Int ;Set @Thang = month(@ThoiGian);
	Declare @Nam Int; Set @Nam = year(@ThoiGian);

	IF(@MaDaiLy is null)
		return;

	If(@ThayDoiConLai is null)
	begin
		set @ThayDoiConLai = 0
	end

	IF(Exists (select * from BAOCAOCONGNO where MaDaiLy = @MaDaiLy and Nam =  @Nam and Thang = @Thang))
	Begin
		Update BAOCAOCONGNO
		set PhatSinh += @ThayDoiConLai
		Where MaDaiLy = @MaDaiLy and Nam =  @Nam and Thang = @Thang;
	end
	Else
	Begin
		Insert Into BAOCAOCONGNO(MaDaiLy,Thang,Nam,PhatSinh)
		values (@MaDaiLy,@Thang,@Nam,@ThayDoiConLai);
	end
END

-----------------------------------
Alter TRIGGER TRG_DELETE_PXH_ThayDoiBaoCaoCongNo
ON PHIEUXUATHANG
AFTER DELETE
AS
BEGIN
	DECLARE @MaDaiLy1 varchar(10);
	DECLARE @NgayXuatHang DATETIME;
	Declare @ConLai money;

	SELECT @MaDaiLy1 = MaDaiLy ,@NgayXuatHang = NgayXuatHang,@ConLai = SoTienTra - TongTien
	FROM deleted

	IF(Exists (select * from BAOCAOCONGNO where MaDaiLy = @MaDaiLy1))
	Begin
	EXEC USP_PHIEUXUATHANG_BAOCAOCONGNO @MaDaiLy = @MaDaiLy1 , @ThoiGian = @NgayXuatHang  , @ThayDoiConLai = @ConLai
	end

END

----------------------------
ALTER TABLE BAOCAOCONGNO
DROP CONSTRAINT CK_BAOCAOCONGNO_NoDau;
----------------------------------
create trigger TR_GenerateMaDVT
on DVT
instead of insert
as
begin
	declare @Prefix varchar(4) = 'MDVT'
	declare @Length int = 4

	declare @MaxMaDVT int
	select @MaxMaDVT = ISNULL(max(cast(substring(MaDVT, len(@Prefix) + 1, @Length)
	as int)), 0)
	from DVT

	insert into DVT(MaDVT, TenDVT)
	select @Prefix + right('0000' + cast(@MaxMaDVT + row_number() over (order by(select null)) as varchar), @Length),
	i.TenDVT
	from inserted i

end;
GO

-----------------------------------
create procedure USP_DeleteDVT
@MaDVT varchar(10)
as
begin
	delete DVT
	where MaDVT = @MaDVT
end

--------------------------------
create procedure USP_UpdateDVT
@MaDVT varchar(10),
@TenDVT varchar(100)
as
begin
	Update DVT
	set TenDVT =@TenDVT
	where MaDVT = @MaDVT
end
-------------------------------
create trigger TR_GenerateMaDVT
on DVT
instead of insert
as
begin
	declare @Prefix varchar(4) = 'MDVT'
	declare @Length int = 4

	declare @MaxMaDVT int
	select @MaxMaDVT = ISNULL(max(cast(substring(MaDVT, len(@Prefix) + 1, @Length)
	as int)), 0)
	from DVT

	insert into DVT(MaDVT, TenDVT)
	select @Prefix + right('0000' + cast(@MaxMaDVT + row_number() over (order by(select null)) as varchar), @Length),
	i.TenDVT
	from inserted i

end;
GO

-----------------------------------
create procedure USP_DeleteDVT
@MaDVT varchar(10)
as
begin
	delete DVT
	where MaDVT = @MaDVT
end

--------------------------------
create procedure USP_UpdateDVT
@MaDVT varchar(10),
@TenDVT varchar(100)
as
begin
	Update DVT
	set TenDVT =@TenDVT
	where MaDVT = @MaDVT
end


create procedure USP_insert_CT_PXH
@SoPhieuXuat varchar(10),
@MaMatHangXuat varchar(10),
@SoLuongXuat int,
@DonGiaXuat money,
@ThanhTien money
as
begin
	insert into CT_PXH(SoPhieuXuat,MaMatHangXuat,SoLuongXuat,DonGiaXuat,ThanhTien)
	values(@SoPhieuXuat,@MaMatHangXuat,@SoLuongXuat,@DonGiaXuat,@ThanhTien)
end
-------------------------------
create procedure USP_update_CT_PXH
@SoPhieuXuat varchar(10),
@MaMatHangXuat varchar(10),
@SoLuongXuat int,
@DonGiaXuat money,
@ThanhTien money
as
begin
	update  CT_PXH
	set
	soluongxuat = @SoLuongXuat,
	dongiaxuat = @DonGiaXuat,
	thanhtien = @ThanhTien
	where
	SoPhieuXuat = @SoLuongXuat
	and MaMatHangXuat =@MaMatHangXuat;
end

------------------------------
create TRIGGER trigger_insert_ct_pxh
ON CT_PXH
AFTER insert
AS
BEGIN
	declare @SoPhieuXuat varchar(10);
	declare @TongTien money;

	select @SoPhieuXuat = SoPhieuxuat ,@TongTien =thanhtien from inserted

	UPDATE PHIEUXUATHANG
	SET TongTien = TongTien + @TongTien
	where sophieuxuat =@SoPhieuXuat 	
END;
GO
-----------------------------------
create TRIGGER trigger_delete_ct_pxh
ON CT_PXH
AFTER delete
AS
BEGIN
	declare @SoPhieuXuat varchar(10);
	declare @TongTien money;

	select @SoPhieuXuat = SoPhieuXuat ,@TongTien =thanhtien from deleted

	UPDATE PHIEUXUATHANG
	SET TongTien = TongTien - @TongTien
	where sophieuxuat =@SoPhieuXuat 	
END;
GO
------------------------------------

create TRIGGER trigger_update_ct_pxh
ON CT_PXH
AFTER UPDATE
AS
BEGIN
	declare @SoPhieuXuat varchar(10);
	declare @TongTienCu money;
	declare @TongTienMoi money;

	select @SoPhieuXuat = SoPhieuxuat ,@TongTienMoi =thanhtien from inserted

	select @TongTienCu = thanhtien from deleted

	UPDATE PHIEUXUATHANG
	SET TongTien = TongTien + @TongTienMoi -@TongTienCu
	where sophieuxuat =@SoPhieuXuat 	
END;
GO
------------------------------
create procedure delete_ct_pxh
@SoPhieuXuat varchar(10),
@MaMatHangXuat varchar(10)
as
begin
	delete CT_PXH
	where
	SoPhieuXuat =@SoPhieuXuat and MaMatHangXuat =@MaMatHangXuat
end
---------------------------------

create procedure tongthanhtien
@SoPhieuXuat varchar(10)
as
begin
	select SUM( ThanhTien) as ketqua
	from CT_PXH
	where
	SoPhieuXuat =@SoPhieuXuat
end
----------------------
create procedure updatePXH
@SoPhieuXuat varchar(10),
@SoTienTra money
as
begin
	update PHIEUXUATHANG
	set SoTienTra = @SoTienTra
	where SoPhieuXuat =@SoPhieuXuat
end
---------------------------
create procedure deletePXH
@SoPhieuXuat varchar(10)
as
begin
	delete CT_PXH
	where SoPhieuXuat = @SoPhieuXuat

	delete PHIEUXUATHANG
	where SoPhieuXuat = @SoPhieuXuat


end

create proc delete_BAOCAOCONGNO
@MaDaiLy varchar(10)
as
begin
	delete BAOCAOCONGNO
	where MaDaiLy = @MaDaiLy
end
GO
