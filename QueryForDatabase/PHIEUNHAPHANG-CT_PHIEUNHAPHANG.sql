USE QUANLYDAILY
GO

CREATE TABLE PHIEUNHAPHANG(
SoPhieuNhap VARCHAR(10) NOT NULL PRIMARY KEY,
NgayNhapHang DATE,
TongTien MONEY
)
GO

CREATE TABLE CT_PNH(
SoPhieuNhap VARCHAR(10) NOT NULL,
MaMatHang VARCHAR(50) NOT NULL,
SoLuongNhap BIGINT,
DonGiaNhap money,
ThanhTien money,
CONSTRAINT PK_CTPNH PRIMARY KEY(SoPhieuNhap, MaMatHang)
--CONSTRAINT PK_CTPNH_SPN FOREIGN KEY(SoPhieuNhap) REFERENCES PHIEUNHAPHANG,
--CONSTRAINT PK_CTPNH_MMH FOREIGN KEY(MaMatHang) REFERENCES MATHANG
)
GO

--trigger

CREATE TRIGGER TR_CT_PNH_TongTien
ON CT_PNH
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE PHIEUNHAPHANG
        SET TongTien = (
            SELECT SUM(ThanhTien)
            FROM CT_PNH
            WHERE CT_PNH.SoPhieuNhap = PHIEUNHAPHANG.SoPhieuNhap
        )
        WHERE PHIEUNHAPHANG.SoPhieuNhap IN (
            SELECT SoPhieuNhap
            FROM inserted
        )
    END
    ELSE
    BEGIN
        UPDATE PHIEUNHAPHANG
        SET TongTien = (
            SELECT SUM(ThanhTien)
            FROM CT_PNH
            WHERE CT_PNH.SoPhieuNhap = PHIEUNHAPHANG.SoPhieuNhap
        )
        WHERE PHIEUNHAPHANG.SoPhieuNhap IN (
            SELECT SoPhieuNhap
            FROM deleted
        )
    END
END
GO
-------------------------------------------------------------------------------
CREATE TRIGGER TR_CT_PNH_Insert_Delete_ThanhTien
ON CT_PNH
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE CT_PNH
    SET ThanhTien = inserted.SoLuongNhap * inserted.DonGiaNhap
    FROM CT_PNH
    JOIN inserted ON CT_PNH.SoPhieuNhap = inserted.SoPhieuNhap AND CT_PNH.MaMatHang = inserted.MaMatHang
 
    UPDATE CT_PNH
    SET ThanhTien = deleted.SoLuongNhap * deleted.DonGiaNhap
    FROM CT_PNH
    JOIN deleted ON CT_PNH.SoPhieuNhap = deleted.SoPhieuNhap AND CT_PNH.MaMatHang = deleted.MaMatHang
END
GO
-----------------------------------------------------------------------
CREATE TRIGGER TR_CT_PNH_UpdateThanhTien
ON CT_PNH
AFTER UPDATE
AS
BEGIN
    UPDATE CT_PNH
    SET ThanhTien = SoLuongNhap * DonGiaNhap
END
GO
------------------------------------------------------------------------
CREATE TRIGGER TR_CT_PNH_CheckConstraint
ON CT_PNH
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT * FROM inserted WHERE SoLuongNhap <= 0)
    BEGIN
        RAISERROR ('SoLuongNhap must be greater than 0.', 16, 1)
        ROLLBACK TRANSACTION
    END
END
GO
---------------------------------------------------------------------
CREATE TRIGGER TR_CT_PNH_Insert
ON CT_PNH
AFTER INSERT
AS
BEGIN
    UPDATE MATHANG
    SET SoLuongTon = MATHANG.SoLuongTon + inserted.SoLuongNhap
    FROM MATHANG
    JOIN inserted ON MATHANG.MaMatHang = inserted.MaMatHang
END
GO
--------------------------------------------------
CREATE TRIGGER TR_CT_PNH_Delete
ON CT_PNH
AFTER DELETE
AS
BEGIN
    UPDATE MATHANG
    SET SoLuongTon = MATHANG.SoLuongTon - deleted.SoLuongNhap
    FROM MATHANG
    JOIN deleted ON MATHANG.MaMatHang = deleted.MaMatHang
END
GO
--------------------------------------------------------
CREATE TRIGGER TR_CT_PNH_Update
ON CT_PNH
AFTER UPDATE
AS
BEGIN
    UPDATE MATHANG
    SET SoLuongTon = MATHANG.SoLuongTon - deleted.SoLuongNhap + inserted.SoLuongNhap
    FROM MATHANG
    JOIN inserted ON MATHANG.MaMatHang = inserted.MaMatHang
    JOIN deleted ON MATHANG.MaMatHang = deleted.MaMatHang
WHERE MATHANG.SoLuongTon - deleted.SoLuongNhap + inserted.SoLuongNhap >= 0
END
GO
