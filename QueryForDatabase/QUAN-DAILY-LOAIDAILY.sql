create database QUANLYDAILY

USE QUANLYDAILY
GO

--TABLE LOAIDAILY
create table LOAIDAILY( 
MaLoaiDaiLy varchar(10) NOT NULL PRIMARY KEY, 
TenLoaiDaiLy varchar(100), 
SoNoToiDa money 
); 
GO
 
 --TABLE QUAN
create table QUAN( 
MaQuan varchar(10) NOT NULL PRIMARY KEY, 
TenQuan varchar(100) 
); 
GO

--TABLE DAILY
create table DAILY( 
MaDaiLy varchar(10) NOT NULL PRIMARY KEY, 
TenDaiLy varchar(10), 
MaLoaiDaiLy varchar(10) FOREIGN KEY REFERENCES LOAIDAILY(MaLoaiDaiLy), 
DienThoai varchar(10), 
DiaChi varchar(200), 
Email varchar(255), 
MaQuan varchar(10) FOREIGN KEY REFERENCES QUAN(MaQuan), 
NgayTiepNhan date, 
TongNo money 
); 
GO

alter table DAILY 
add constraint CHK_DLSDT check(len(DienThoai) = 10) 
GO

--TRIGGER PROCEDURE

----------------------------------------------------------
create trigger TR_GenerateMaDaiLy
on DAILY
instead of insert
as
begin
	declare @Prefix varchar(2) = 'DL'
	declare @Length int = 4

	declare @MaxMaDaiLy int
	select @MaxMaDaiLy = ISNULL(max(cast(substring(MaDaiLy, len(@Prefix) + 1, @Length)
	as int)), 0)
	from DAILY
	insert into DAILY(MaDaiLy, TenDaiLy, MaLoaiDaiLy, DienThoai, DiaChi, Email, MaQuan, NgayTiepNhan, TongNo)
	select @Prefix + right('0000' + cast(@MaxMaDaiLy + row_number() over (order by(select null)) as varchar), @Length),
	i.TenDaiLy, i.MaLoaiDaiLy, i.DienThoai, i.DiaChi, i.Email, i.MaQuan, i.NgayTiepNhan, i.TongNo
	from inserted i
end;
GO
-------------------------------------------------------------------
create procedure Insert_DaiLy
	@TenDaiLy varchar(10),
	@MaLoaiDaiLy varchar(10),
	@DienThoai varchar(10),
	@DiaChi varchar(200),
	@Email varchar(40),
	@MaQuan varchar(10),
	@NgayTiepNhan date,
	@TongNo money
as
begin
	insert into DAILY(TenDaiLy,MaLoaiDaiLy, DienThoai, DiaChi, Email, MaQuan, NgayTiepNhan, TongNo)
	values
	(@TenDaiLy, @MaLoaiDaiLy, @DienThoai, @DiaChi, @Email, @MaQuan, @NgayTiepNhan, @TongNo);
end;
GO
--------------------------------------------------------------------------------------------
