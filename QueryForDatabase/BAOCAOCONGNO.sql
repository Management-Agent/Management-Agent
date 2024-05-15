USE QUANLYDAILY
GO
--table BAOCAOCONGNO
CREATE TABLE BAOCAOCONGNO
(
MaDaiLy varchar(10) not null,
Thang int not null ,-- constraint CK_BAOCAOCONGNO_Thang check(Thang >= 1 and Thang <= 12),
Nam int not null ,--constraint  CK_BAOCAOCONGNO_Nam check(Nam >= 0),
NoDau money constraint CK_BAOCAOCONGNO_NoDau CHECK(NoDau > = 0) ,
PhatSinh money ,--constraint CK_BAOCAOCONGNO_PhatSinh CHECK(PhatSinh > = 0),
NoCuoi As (NoDau + PhatSinh) PERSISTED,
)
GO
 
ALTER TABLE BAOCAOCONGNO
ADD CONSTRAINT PK_BAOCAOCONGNO PRIMARY KEY(MaDaiLy,Thang,Nam);
 GO

