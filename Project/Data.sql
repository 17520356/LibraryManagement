CREATE DATABASE LibraryManagement
GO
USE LibraryManagement
GO
SET DATEFORMAT DMY
GO

CREATE TABLE LOAI_DG
(
	Maloaidg			Int IDENTITY PRIMARY KEY,
	Tenloai				Nvarchar(15) NOT NULL,
	Ghichu				Nvarchar(15)
)
INSERT INTO dbo.LOAI_DG ( Tenloai)VALUES  ( N'X')
INSERT INTO dbo.LOAI_DG ( Tenloai)VALUES  ( N'Y')
GO

CREATE TABLE DOC_GIA
(
	Madocgia			Int IDENTITY PRIMARY KEY,
	Maloaidg			Int NOT NULL,
	Hoten				Nvarchar(25) NOT NULL,
	Ngaysinh			Date,
	Diachi				Nvarchar(40),
	Sodienthoai			Char(15),
	Gioitinh			INT ,--1 Nam 0 Nữ
	Ngaylapthe			Date NOT NULL DEFAULT GETDATE(),
	Ngayhethan			DATE ,
	Email				Char(20),
	Sosachmuon			Int DEFAULT '0',
	Tongno				Money DEFAULT '0',
	tinhtrang			Int DEFAULT '1',--0: không thể mượn -- 1: có thể mượn --2: Thẻ đã hết hạn 
		FOREIGN KEY (Maloaidg) REFERENCES LOAI_DG(Maloaidg)
) 


GO

CREATE TABLE TINHTRANG_SACH
(
	Matinhtrang			INT IDENTITY PRIMARY KEY, --1: có thể cho mượn  --2: không thể cho mượn
	Tinhtrang			Nvarchar(20)
)
GO 
INSERT INTO dbo.TINHTRANG_SACH ( Tinhtrang )VALUES  ( N'Có Thể Cho Mượn')
INSERT INTO dbo.TINHTRANG_SACH ( Tinhtrang )VALUES  ( N'Không Thể Cho Mượn')
GO

CREATE TABLE THE_LOAI
(
	Matheloai			INT IDENTITY PRIMARY KEY,
	Ten					Nvarchar(20),
)
INSERT INTO dbo.THE_LOAI ( Ten ) VALUES  ( N'A')
INSERT INTO dbo.THE_LOAI ( Ten ) VALUES  ( N'B')
INSERT INTO dbo.THE_LOAI ( Ten ) VALUES  ( N'C')

GO

CREATE TABLE TAC_GIA
(
	Matacgia			INT IDENTITY PRIMARY KEY,
	Tentacgia			Nvarchar(20) NOT NULL,
	Diachi				Nvarchar(30),
	Sodienthoai			char(15),
	Ngaysinh			Date,
	Ghichu				Nvarchar(30)
)
GO

CREATE TABLE NHA_XUAT_BAN
(
	MaNXB				INT IDENTITY PRIMARY KEY,
	TenNXB				Nvarchar(30) NOT NULL,
	Diachi				Nvarchar(30),
	Email				Nvarchar(15)

)
GO 

CREATE TABLE NGON_NGU
(
	Mangonngu			INT IDENTITY PRIMARY KEY,
	Ngonngu				Nvarchar(15),
)
GO

CREATE TABLE DAUSACH
(
	Madausach			INT IDENTITY PRIMARY KEY,
	Tendausach			Nvarchar(50),
	Matheloai			INT  NOT NULL,
	MaNXB				INT  NOT NULL,
	Mangonngu			INT NOT NULL,
	Trigia				Money,
	Soluong				Int,
	Namxuatban			Int,
		FOREIGN KEY (Matheloai) REFERENCES THE_LOAI (Matheloai),
		FOREIGN KEY (MaNXB) REFERENCES NHA_XUAT_BAN(MaNXB),
		FOREIGN KEY (Mangonngu) REFERENCES NGON_NGU(Mangonngu)
)
GO

CREATE TABLE TACGIA_DAUSACH
(
	Matacgia			INT NOT NULL,
	Madausach			INT NOT NULL,
	PRIMARY KEY(Matacgia,Madausach),
		FOREIGN KEY (Matacgia) REFERENCES TAC_GIA(Matacgia),
		FOREIGN KEY (Madausach) REFERENCES DAUSACH(Madausach)
)




GO

CREATE TABLE CUONSACH
(
	Masach				INT IDENTITY PRIMARY KEY,
	Madausach			INT NOT NULL,
	Matinhtrang			INT NOT NULL,
	Ngaynhap			Date NOT NULL DEFAULT GETDATE(),
	
		FOREIGN KEY (Matinhtrang) REFERENCES TINHTRANG_SACH(Matinhtrang),
		FOREIGN KEY (Madausach) REFERENCES DAUSACH(Madausach)
	
)
GO

CREATE TABLE PHIEU_MUON
(
	Maphieumuon			INT IDENTITY PRIMARY KEY,
	Madocgia			INT NOT NULL,
	Ngaymuon			Date NOT NULL DEFAULT GETDATE(),
	
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA(Madocgia)
)
GO

CREATE TABLE CHITIET_PHIEUMUON
(
	Maphieumuon			INT NOT NULL ,
	Masach				INT NOT NULL ,
	Ngayhethan			Date,
	tinhtrang			INT, -- 1: đã trả -- 0 : chưa trả
		PRIMARY KEY (Maphieumuon,Masach),
		FOREIGN KEY (Masach) REFERENCES CUONSACH(Masach),
		FOREIGN KEY (Maphieumuon) REFERENCES PHIEU_MUON(Maphieumuon)
)
GO

CREATE TABLE PHIEU_TRA
(
	Maphieutra			INT IDENTITY PRIMARY KEY, --thêm mã phiếu mượn
	Madocgia			INT NOT NULL,
	Maphieumuon			INT NOT NULL,
	Ngaytra				Date NOT NULL DEFAULT GETDATE(),
	Tienphat			money,
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA(Madocgia),
		FOREIGN KEY (Maphieumuon) REFERENCES dbo.PHIEU_MUON(Maphieumuon)
)
GO

CREATE TABLE CHITIET_PHIEUTRA
(
	Maphieutra			int NOT NULL,
	Masach				INT NOT NULL,
	Tienphattungsach	Money,
		PRIMARY KEY(Maphieutra,Masach),
		FOREIGN KEY (Masach) REFERENCES CUONSACH(Masach),
		FOREIGN KEY (Maphieutra) REFERENCES PHIEU_TRA(Maphieutra)
)
GO

CREATE TABLE PHIEU_THU
(
	Maphieuthu			INT IDENTITY PRIMARY KEY,
	Madocgia			INT NOT NULL,
	Ngaythu				date	NOT NULL DEFAULT GETDATE(),
	Sotienthu			Money,	
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA (Madocgia)
)
GO 

CREATE TABLE THAM_SO
(
	Tenthamso			NvarChar(50),
	Giatri				Int,
)
INSERT dbo.THAM_SO ( Tenthamso, Giatri )VALUES  ( N'tuoitoithieu', 18)
INSERT dbo.THAM_SO ( Tenthamso, Giatri )VALUES  ( N'tuoitoida', 55)
INSERT dbo.THAM_SO ( Tenthamso, Giatri )VALUES  ( N'thoihanthe', 6)
INSERT dbo.THAM_SO ( Tenthamso, Giatri )VALUES  ( N'soluongtheloai', 3)
INSERT dbo.THAM_SO ( Tenthamso, Giatri )VALUES  ( N'khoangcachnamxuatban', 8)
INSERT dbo.THAM_SO ( Tenthamso, Giatri )VALUES  ( N'soluongsachtoida', 5)
INSERT dbo.THAM_SO ( Tenthamso, Giatri )VALUES  ( N'songaymuontoida', 4)
GO

CREATE TABLE BAOCAO_MUONSACH_THELOAI
(
	Mabaocaotheotheloai			INT IDENTITY PRIMARY KEY,
	Thang						Int,
	Nam							Int,
	Tongluotmuon				Int,

)

GO 

CREATE TABLE CHITIET_BAOCAO_THELOAI
(
	Mabaocaotheotheloai			INT NOT NULL,
	Matheloai					INT  NOT NULL,
	Luotmuon					Int,
	Tile						float,
		PRIMARY KEY (Mabaocaotheotheloai,Matheloai),
		FOREIGN KEY (Matheloai) REFERENCES THE_LOAI(Matheloai),
		FOREIGN KEY (Mabaocaotheotheloai) REFERENCES BAOCAO_MUONSACH_THELOAI(Mabaocaotheotheloai)
)
GO

CREATE TABLE BAOCAO_SACH_TRATRE
(
	Mabaocaosachtratre			INT IDENTITY PRIMARY KEY,
	Ngay						Int,
	Thang						Int,
	Nam							Int,

)
GO

CREATE TABLE CHITIET_BAOCAO_TRATRE
(
	Mabaocaosachtratre			INT  NOT NULL,
	Masach						INT NOT NULL,
	Ngaymuon					Date,
	Songaytratre				Int,
		PRIMARY KEY(Mabaocaosachtratre,Masach),
		FOREIGN KEY (Mabaocaosachtratre) REFERENCES BAOCAO_SACH_TRATRE(Mabaocaosachtratre),
		FOREIGN KEY (Masach) REFERENCES CUONSACH(Masach)
)
GO

CREATE TABLE CHUC_NANG
(
	MaChucNang					Int Identity NOT NULL PRIMARY KEY,
	TenChucNang					Nvarchar(30) NOT NULL,
	TenManHinhDuocLoad			Nvarchar(30) NOT NULL
)
GO

CREATE TABLE NHOM_NGUOI_DUNG (
	 MaNhom						Int NOT NULL PRIMARY KEY, 
	 TenNhom					NVARCHAR(30) NOT NULL,	
)
GO

INSERT INTO dbo.NHOM_NGUOI_DUNG ( MaNhom, TenNhom ) VALUES  ( 1, N'Admin')
INSERT INTO dbo.NHOM_NGUOI_DUNG ( MaNhom, TenNhom ) VALUES  ( 2, N'Thủ Thư')
INSERT INTO dbo.NHOM_NGUOI_DUNG ( MaNhom, TenNhom ) VALUES  ( 3, N'Độc Giả')

CREATE TABLE PHAN_QUYEN (
	MaNhom						Int NOT NULL,
	MaChucNang					Int NOT NULL,
		PRIMARY KEY (MaNhom,MaChucNang),
		FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom),
		FOREIGN KEY (MaChucNang) REFERENCES dbo.CHUC_NANG(MaChucNang)
)
GO

CREATE TABLE NGUOI_DUNG(
	TenDangNhap					Nvarchar(30) NOT NULL PRIMARY KEY,
	MatKhau						Nvarchar(30) NOT NULL,
	MaNhom						Int NOT NULL,
	FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom)
)
GO


INSERT INTO dbo.NGUOI_DUNG ( TenDangNhap, MatKhau, MaNhom )VALUES  ( N'admin', N'admin', 1 )
INSERT INTO dbo.NGUOI_DUNG ( TenDangNhap, MatKhau, MaNhom )VALUES  ( N'staff', N'staff', 2 )

GO 

CREATE TRIGGER tg_capnhatngayhethan
ON dbo.DOC_GIA
FOR INSERT,UPDATE
AS 
BEGIN
	DECLARE @Ngayhethan DATE,@Ngaylapthe DATE,@Madocgia CHAR(6);
	
	SELECT @Ngaylapthe = Inserted.Ngaylapthe,@Ngayhethan=Inserted.Ngayhethan,@Madocgia=Inserted.Madocgia
	FROM Inserted
	IF(@Ngayhethan IS NULL)
		BEGIN
			SET @Ngayhethan=DATEADD(MONTH,2,@Ngaylapthe)
			UPDATE dbo.DOC_GIA
			SET Ngayhethan = @Ngayhethan
			WHERE Madocgia=@Madocgia
		END
END


GO 

CREATE TRIGGER tg_capnhattinhtrangdocgiakhihethan
ON dbo.DOC_GIA
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @Ngayhethan DATE, @Madocgia CHAR(6);
	
	SELECT @Ngayhethan=Inserted.Ngayhethan,@Madocgia=Inserted.Madocgia
	FROM Inserted
	IF(@Ngayhethan<GETDATE())
		BEGIN
			UPDATE dbo.DOC_GIA
			SET tinhtrang='2'
			WHERE @Madocgia=Madocgia;
		END 
END 


GO

CREATE PROC usp_login
@username NVARCHAR(100),@password NVARCHAR(100)
AS 
BEGIN
	SELECT * FROM dbo.NGUOI_DUNG WHERE dbo.NGUOI_DUNG.TenDangNhap = @username AND dbo.NGUOI_DUNG.MatKhau = @password;
END 

GO

CREATE PROC usp_check_login
@username NVARCHAR(100)
AS
BEGIN
	SELECT dbo.NGUOI_DUNG.TenDangNhap FROM dbo.NGUOI_DUNG WHERE dbo.NGUOI_DUNG.TenDangNhap = @username ;
END 

GO

CREATE PROC usp_nhomnguoidung
@username NVARCHAR(100)
AS 
BEGIN
	SELECT dbo.NHOM_NGUOI_DUNG.TenNhom 
	FROM dbo.NHOM_NGUOI_DUNG,dbo.NGUOI_DUNG 
	WHERE dbo.NHOM_NGUOI_DUNG.MaNhom=dbo.NGUOI_DUNG.MaNhom 
	AND dbo.NGUOI_DUNG.TenDangNhap = @username;
END

GO

CREATE PROC usp_UpdateAccount
@username NVARCHAR(100), @password NVARCHAR(100), @newpassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isrightpass INT = 1;
	SELECT @isrightpass = COUNT (*) FROM dbo.NGUOI_DUNG WHERE TenDangNhap=@username AND MatKhau= @password;
	IF (@isrightpass >= 1)
	BEGIN
		IF(@newpassword!=NULL OR @newpassword!='')
		BEGIN
			UPDATE dbo.NGUOI_DUNG SET MatKhau = @newpassword WHERE TenDangNhap = @username;
        END 
	END 
END 

GO 
 CREATE PROC update_quidinh_docgia
 @thamso NVARCHAR(100), @giatri INT 
 AS
 BEGIN
	UPDATE dbo.THAM_SO SET Giatri=@giatri WHERE Tenthamso= @thamso;
 END

GO 





UPDATE dbo.NGUOI_DUNG SET MatKhau ='admin' WHERE TenDangNhap='admin'

INSERT dbo.NGUOI_DUNG ( TenDangNhap, MatKhau, MaNhom )VALUES  ( N'',N'1',0)

SELECT MaNhom FROM dbo.NGUOI_DUNG WHERE TenDangNhap='admin'
UPDATE dbo.NGUOI_DUNG SET MaNhom='' WHERE TenDangNhap=''

SELECT * FROM dbo.NGUOI_DUNG

DELETE dbo.NGUOI_DUNG WHERE TenDangNhap='docgia2'