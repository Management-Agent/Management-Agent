USE QUANLYDAILY
GO
--table BAOCAOCONGNO
CREATE TABLE BAOCAOCONGNO
(
MaDaiLy varchar(10) not null,
Thang int not null  constraint CK_BAOCAOCONGNO_Thang check(Thang >= 1 and Thang <= 12),
Nam int not null constraint  CK_BAOCAOCONGNO_Nam check(Nam >= 0),
NoDau money constraint CK_BAOCAOCONGNO_NoDau CHECK(NoDau > = 0) ,
PhatSinh money constraint CK_BAOCAOCONGNO_PhatSinh CHECK(PhatSinh > = 0),
NoCuoi As (NoDau + PhatSinh) PERSISTED,
)
GO
 
ALTER TABLE BAOCAOCONGNO
ADD CONSTRAINT PK_BAOCAOCONGNO PRIMARY KEY(MaDaiLy,Thang,Nam);
 GO

--Trigger cho bang BAOCAOCONGNO 
CREATE TRIGGER TR_INSERT_BAOCAOCONGNO ON BAOCAOCONGNO
FOR INSERT 
AS
BEGIN
DECLARE @MaDaiLy varchar(10),@NoCuoi money
 
SELECT @MaDaiLy = MaDaiLy , @NoCuoi = NoCuoi FROM inserted 
 
UPDATE DAILY
SET TongNo = TongNo + @NoCuoi
Where MaDaiLy = @MaDaiLy
END
 GO
 -------------------------------------------------
CREATE TRIGGER TR_DELETE_BAOCAOCONGNO ON BAOCAOCONGNO
FOR DELETE 
AS
BEGIN
DECLARE @MaDaiLy varchar(10),@NoCuoi money
 
SELECT @MaDaiLy = MaDaiLy , @NoCuoi = NoCuoi FROM inserted 
 
UPDATE DAILY
SET TongNo = TongNo - @NoCuoi
Where MaDaiLy = @MaDaiLy
END
 GO
 -----------------------------------------------------------
CREATE TRIGGER TR_UPDATE_BAOCAOCONGNO ON BAOCAOCONGNO
FOR UPDATE 
AS
BEGIN
DECLARE @MaDaiLy varchar(10),@NoCuoiMoi money,@NoCuoiCu money
 
SELECT @MaDaiLy = MaDaiLy , @NoCuoiMoi = NoCuoi FROM inserted 
 
SELECT @NoCuoiCu = NoCuoi FROM deleted
 
 
UPDATE DAILY
SET TongNo = TongNo -@NoCuoiCu + @NoCuoiMoi
Where MaDaiLy = @MaDaiLy
END
GO