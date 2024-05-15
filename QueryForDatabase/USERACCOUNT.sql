USE QUANLYDAILY
GO
--Table USERACCOUNT
create table USERACCOUNT
(
	Username varchar(50) not null primary key,
	Password varchar(50) not null
);
--The very first account
insert into USERACCOUNT(Username, Password)
values
('sa', '1982408718410113214846658453255177250147212');
--Mat khau tren la duoc ma hoa tu 000
--Nhap trong form
--Tk: sa
--Mk: 000
--alter value of Password
alter table USERACCOUNT
alter column Password varchar(500) not null