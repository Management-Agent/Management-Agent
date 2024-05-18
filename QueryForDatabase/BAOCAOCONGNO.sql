USE QUANLYDAILY
GO
--table BAOCAOCONGNO
CREATE TABLE BAOCAOCONGNO
(
MaDaiLy varchar(10) not null,
Thang int not null ,
Nam int not null ,
NoDau money constraint CK_BAOCAOCONGNO_NoDau CHECK(NoDau > = 0) ,
PhatSinh money ,
NoCuoi As (NoDau + PhatSinh) PERSISTED,
)
GO
 
ALTER TABLE BAOCAOCONGNO
ADD CONSTRAINT PK_BAOCAOCONGNO PRIMARY KEY(MaDaiLy,Thang,Nam);
 GO

