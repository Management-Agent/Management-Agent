USE QUANLYDAILY
GO

--TABLE THAMSO
create table THAMSO(
	TenThamSo varchar(50) NOT NULL PRIMARY KEY,
	GiaTri int
);
GO

insert into THAMSO(TenThamSo, GiaTri)
values
('SoDaiLyToiDa', 4),
('TiLeTinhDonGiaXuat', 102),
('ApDungQDKiemTraSoTienThu', 1);
GO
