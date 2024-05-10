USE QUANLYDAILY
GO

CREATE TABLE DVT
(
MaDVT varchar(10) constraint PK_DVT PRIMARY KEY,
TenDVT varchar(10)
)
go
 
CREATE TABLE MATHANG
(
MaMatHang varchar(50) constraint PK_MATHANG PRIMARY KEY,
TenMatHang varchar(10),
MaDVT varchar(10) constraint FK_MATHANG_DVT FOREIGN KEY REFERENCES DVT(MaDVT),
SoLuongTon int constraint CK_MATHANG_SoLuongton	check(SoLuongTon>=0)
)
go