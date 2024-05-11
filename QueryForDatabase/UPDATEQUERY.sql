USE QUANLYDAILY
GO
-----Lay thong tin danh sach dai ly
CREATE PROCEDURE USP_GetDaiLyInfo
AS
BEGIN
    SELECT TenDaiLy, TenLoaiDaiLy, TenQuan, TongNo
    FROM DAILY inner join QUAN ON DAILY.MaQuan = QUAN.MaQuan
	INNER JOIN LOAIDAILY ON DAILY.MaLoaiDaiLy = LOAIDAILY.MaLoaiDaiLy
END;
