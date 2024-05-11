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
('sa', '000');