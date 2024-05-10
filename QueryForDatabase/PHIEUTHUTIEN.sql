USE QUANLYDAILY
GO

--TABLE PHIEUTHUTIEN
create table PHIEUTHUTIEN(
SoPhieuThu varchar(10) not null primary key,
MaDaiLy varchar(10) FOREIGN KEY REFERENCES DAILY(MaDaiLy),
NgayThuTien date,
SoTienThu money
);
GO
