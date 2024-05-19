USE QUANLYDAILY
GO

CREATE TABLE PHIEUXUATHANG(
SoPhieuXuat varchar(10) NOT NULL PRIMARY KEY,
MaDaiLy varchar(10),
NgayXuatHang date,
TongTien money,
SoTienTra money,
ConLai  As(TongTien - SoTienTra) persisted
);
GO


CREATE TABLE CT_PXH(
SoPhieuXuat varchar(10) NOT NULL FOREIGN KEY REFERENCES PHIEUXUATHANG(SoPhieuXuat),
MaMatHangXuat varchar(50) NOT NULL FOREIGN KEY REFERENCES MATHANG(MaMatHang),
SoLuongXuat int,
DonGiaXuat money, 
ThanhTien money DEFAULT 0,
);
GO

ALTER TABLE	CT_PXH
ADD CONSTRAINT ck_SlXuat CHECK (CT_PXH.SoLuongXuat >= 0);
GO

--TRIGGER
CREATE TRIGGER tr_NXH
ON PHIEUXUATHANG 
AFTER INSERT
AS 
BEGIN
DECLARE @NgayNhapHang DATETIME
DECLARE @NgayXuatHang DATETIME
SELECT @NgayXuatHang = NgayXuatHang
FROM inserted
SELECT @NgayNhapHang = NgayNhapHang FROM PHIEUNHAPHANG INNER JOIN CT_PNH ON PHIEUNHAPHANG.SoPhieuNhap = CT_PNH.SoPhieuNhap INNER JOIN
MATHANG ON MATHANG.MaMatHang = CT_PNH.MaMatHang INNER JOIN CT_PXH ON CT_PXH.MaMatHangXuat = MATHANG.MaMatHang INNER JOIN PHIEUXUATHANG
ON PHIEUXUATHANG.SoPhieuXuat = CT_PXH.SoPhieuXuat
if(@NgayNhapHang < @NgayXuatHang)
BEGIN
ROLLBACK TRANSACTION
END
END
GO
------------------------------------------------
CREATE TRIGGER tr_PHIEUXUATHANG_TongTien
ON CT_PXH
AFTER INSERT, UPDATE, DELETE
AS
BEGIN 
IF EXISTS (SELECT 1 FROM inserted)
BEGIN 
UPDATE PHIEUXUATHANG
SET TongTien =(
Select sum(ThanhTien)
FROM CT_PXH
WHERE CT_PXH.SoPhieuXuat = PHIEUXUATHANG.SoPhieuXuat
)
WHERE PHIEUXUATHANG.SoPhieuXuat IN
(SELECT SoPhieuXuat FROM inserted)
END
ELSE
BEGIN 
UPDATE PHIEUXUATHANG
SET TongTien =(
select sum(ThanhTien)
FROM CT_PXH
WHERE CT_PXH.SoPhieuXuat = PHIEUXUATHANG.SoPhieuXuat
)
WHERE PHIEUXUATHANG.SoPhieuXuat IN
(SELECT SoPhieuXuat FROM deleted)
END
END;
GO

--------------------------------------
CREATE TRIGGER tr_ThanhTien 
ON CT_PXH  
AFTER  INSERT, DELETE 
AS
BEGIN 
UPDATE CT_PXH 
SET ThanhTien = inserted.DonGiaXuat * inserted.SoLuongXuat 
FROM CT_PXH 
jOIN inserted ON inserted.SoPhieuXuat = CT_PXH.SoPhieuXuat AND inserted.MaMatHangXuat = CT_PXH.MaMatHangXuat 
UPDATE CT_PXH 
SET ThanhTien = deleted.DonGiaXuat * deleted.SoLuongXuat 
FROM CT_PXH 
JOIN deleted ON deleted.SoPhieuXuat = CT_PXH.SoPhieuXuat AND deleted.MaMatHangXuat = CT_PXH.MaMatHangXuat 
END;
GO
-----------------------------------------------------------------------------------
CREATE TRIGGER tr_ThanhTien_Update
ON CT_PXH
AFTER UPDATE
AS
BEGIN
UPDATE CT_PXH
SET CT_PXH.ThanhTien = CT_PXH.DonGiaXuat * CT_PXH.SoLuongXuat
END;
GO
DROP TRIGGER IF EXISTS tr_PXH_SotienTra;
ALTER TABLE PHIEUXUATHANG DROP COLUMN ConLai;
ALTER TABLE PHIEUXUATHANG ADD COLUMN ConLai DECIMAL(10, 2) AS (TongTien - SoTienTra) PERSISTED
