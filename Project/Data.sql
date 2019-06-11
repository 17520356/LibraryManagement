CREATE DATABASE LibraryManagement
GO
USE LibraryManagement
GO
SET DATEFORMAT DMY
GO

--TABLE
GO 
/*
CREATE TABLE LOAI_DG
(
	Maloaidg			Int IDENTITY PRIMARY KEY,
	Tenloai				Nvarchar(15) NOT NULL,
	Ghichu				Nvarchar(15)
)
GO 
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
	Gioitinh			INT DEFAULT '1',--1 Nam 0 Nữ
	Ngaylapthe			Date NOT NULL DEFAULT GETDATE(),
	Ngayhethan			DATE ,
	Email				Char(20),
	Sosachmuon			Int DEFAULT '0',
	Tongno				Money DEFAULT '0',
	tinhtrang			Int DEFAULT '1',--0: không thể mượn -- 1: có thể mượn --2: Thẻ đã hết hạn 
		FOREIGN KEY (Maloaidg) REFERENCES LOAI_DG(Maloaidg)
) 
GO 
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 1 ,N'A' ,'03-06-2000',N'A' ,'1' ,1,GETDATE(),'E' , 0 , NULL,1  )
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 2 ,N'B' ,'03-06-2000' ,N'A' ,'1' ,2,GETDATE(),'E' , 0 , NULL,2  )
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 1 ,N'C' ,'03-06-2000',N'A' ,'1' ,1,GETDATE(),'E' , 0 , NULL,0  )
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 2 ,N'D' ,'03-06-2000' ,N'A' ,'1' ,1,GETDATE(),'E' , 0 , NULL,1  )

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
INSERT INTO dbo.TAC_GIA ( Tentacgia ,Diachi ,Sodienthoai ,Ngaysinh )VALUES  ( N'TG1' ,N'S' ,'1' ,'03-06-2000' )
INSERT INTO dbo.TAC_GIA ( Tentacgia ,Diachi ,Sodienthoai ,Ngaysinh )VALUES  ( N'TG2' ,N'F' ,'1' ,'03-06-2000' )
INSERT INTO dbo.TAC_GIA ( Tentacgia ,Diachi ,Sodienthoai ,Ngaysinh )VALUES  ( N'TG3' ,N'E' ,'1' ,'03-06-2000' )
GO 
CREATE TABLE NHA_XUAT_BAN
(
	MaNXB				INT IDENTITY PRIMARY KEY,
	TenNXB				Nvarchar(30) NOT NULL,
	Diachi				Nvarchar(30),
	Email				Nvarchar(15)

)
GO 
INSERT INTO dbo.NHA_XUAT_BAN ( TenNXB, Diachi, Email )VALUES  ( N'NXB1', N'A', N'E' )
INSERT INTO dbo.NHA_XUAT_BAN ( TenNXB, Diachi, Email )VALUES  ( N'NXB2', N'A', N'E' )
INSERT INTO dbo.NHA_XUAT_BAN ( TenNXB, Diachi, Email )VALUES  ( N'NXB3', N'A', N'E' )
GO 
CREATE TABLE NGON_NGU
(
	Mangonngu			INT IDENTITY PRIMARY KEY,
	Ngonngu				Nvarchar(15),
)
GO
INSERT INTO dbo.NGON_NGU ( Ngonngu )VALUES  ( N'Việt')
INSERT INTO dbo.NGON_NGU ( Ngonngu )VALUES  ( N'Anh')
INSERT INTO dbo.NGON_NGU ( Ngonngu )VALUES  ( N'Trung')

CREATE TABLE DAUSACH
(
	Madausach			INT IDENTITY PRIMARY KEY,
	Tendausach			Nvarchar(50),
	Matheloai			INT  NOT NULL,
	MaNXB				INT  NOT NULL,
	Mangonngu			INT NOT NULL,
	Trigia				Money,
	Soluong				INT DEFAULT 0,
	Namxuatban			DATETIME,
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
CREATE TABLE tinhtrangsachkhimuon
(
	matinhtrang INT IDENTITY PRIMARY KEY,
	tinhtrang	NVARCHAR(30),
)
INSERT INTO dbo.tinhtrangsachkhimuon ( tinhtrang )VALUES  (  N'Đã Trả' )
INSERT INTO dbo.tinhtrangsachkhimuon ( tinhtrang )VALUES  (  N'Chưa Trả' )
INSERT INTO dbo.tinhtrangsachkhimuon ( tinhtrang )VALUES  (  N'Quá Hạn' )
INSERT INTO dbo.tinhtrangsachkhimuon ( tinhtrang )VALUES  (  N'Đã Gia Hạn' )
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
	tinhtrang			INT,			 -- 1: đã trả -- 2: chưa trả 3--quá hạn -- 4 Đã Gia hạn // Thêm 1 bảng tình trạng sách trong phiếu mượn
		PRIMARY KEY (Maphieumuon,Masach),
		FOREIGN KEY (Masach) REFERENCES CUONSACH(Masach),
		FOREIGN KEY (Maphieumuon) REFERENCES PHIEU_MUON(Maphieumuon),
		FOREIGN KEY(tinhtrang) REFERENCES dbo.tinhtrangsachkhimuon(matinhtrang)

)
GO


CREATE TABLE PHIEU_TRA
(
	Maphieutra			INT IDENTITY PRIMARY KEY, --thêm mã phiếu mượn
	Madocgia			INT NOT NULL,
	Ngaytra				Date NOT NULL DEFAULT GETDATE(),
	Tienphat			MONEY DEFAULT '0',
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA(Madocgia),
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
	Tongnolucthu		MONEY,
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
*/
GO 
--TRIGGER -
GO 
/*
CREATE TRIGGER tg_capnhatngayhethan
ON dbo.DOC_GIA
FOR INSERT,UPDATE
AS 
BEGIN
	DECLARE @Ngayhethan DATE,@Ngaylapthe DATE,@Madocgia INT ;
	
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
	DECLARE @Ngayhethan DATE, @Madocgia INT ;
	
	SELECT @Ngayhethan=Inserted.Ngayhethan,@Madocgia=Inserted.Madocgia
	FROM Inserted
	IF(@Ngayhethan<GETDATE())
		BEGIN
			UPDATE dbo.DOC_GIA
			SET tinhtrang='2'
			WHERE @Madocgia=Madocgia;
		END 
	ELSE 
		BEGIN 
			UPDATE dbo.DOC_GIA
			SET tinhtrang='1'
			WHERE @Madocgia=Madocgia;
		END 
END 
GO
*/
GO 
--PROCEDURE
GO
/*
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

CREATE PROC update_docgia
@madocgia INT,@hoten NVARCHAR(100),@maloaidg INT ,@ngaysinh DATE,@gioitinh INT,@diachi NVARCHAR(100),@sodt CHAR(15), @email CHAR(20)
AS
BEGIN 
	UPDATE dbo.DOC_GIA SET Hoten=@hoten,Maloaidg=@maloaidg,Gioitinh=@gioitinh,Diachi=@diachi,Sodienthoai=@sodt,Email=@email,Ngaysinh=@ngaysinh
	WHERE Madocgia=@madocgia
END 

	
GO 

CREATE PROC delete_docgia
@madocgia int 
AS
BEGIN
	DECLARE @checkphieumuon INT , @checkphieutra INT ,@checkphieuthu INT
		
	SELECT @checkphieumuon=COUNT(*) FROM dbo.PHIEU_MUON WHERE dbo.PHIEU_MUON.Madocgia=@madocgia
	SELECT @checkphieutra=COUNT(*) FROM dbo.PHIEU_TRA WHERE dbo.PHIEU_TRA.Madocgia=@madocgia
	SELECT @checkphieuthu=COUNT(*) FROM dbo.PHIEU_THU WHERE dbo.PHIEU_THU.Madocgia=@madocgia

	IF (@checkphieumuon>0)				--Có Phiếu Mượn
	BEGIN	
		DELETE dbo.CHITIET_PHIEUMUON FROM dbo.CHITIET_PHIEUMUON,dbo.PHIEU_MUON WHERE dbo.CHITIET_PHIEUMUON.Maphieumuon=dbo.PHIEU_MUON.Maphieumuon AND Madocgia=@madocgia
		DELETE dbo.PHIEU_MUON WHERE Madocgia=@madocgia
	END 
	IF(@checkphieutra>0)			--Có Phiếu Trả
	BEGIN 
		DELETE dbo.CHITIET_PHIEUTRA FROM dbo.CHITIET_PHIEUTRA,dbo.PHIEU_TRA WHERE dbo.CHITIET_PHIEUTRA.Maphieutra=dbo.PHIEU_TRA.Maphieutra AND Madocgia=@madocgia
		DELETE dbo.PHIEU_TRA WHERE Madocgia=@madocgia
	END 		
	IF(@checkphieuthu>0)		--Có Phiếu Thu
	BEGIN
		DELETE dbo.PHIEU_THU WHERE Madocgia=@madocgia
	END
	DELETE dbo.DOC_GIA WHERE Madocgia=@madocgia
END 

GO

CREATE PROC insert_docgia
@hoten NVARCHAR(100),@maloaidg INT ,@ngaysinh DATE,@gioitinh INT,@diachi NVARCHAR(100),@sodt CHAR(15), @email CHAR(20),@ngaylapthe DATETIME,@ngayhethan DATETIME
AS
BEGIN
	INSERT INTO dbo.DOC_GIA( Hoten, Maloaidg, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe, Ngayhethan, Email )VALUES  (@hoten,@maloaidg,@ngaysinh,@diachi,@sodt,@gioitinh,@ngaylapthe,@ngayhethan,@email)
END
 
GO 

CREATE PROC SachDangMuon
@madocgia INT 
AS 
BEGIN 
	SELECT D.Madocgia [Mã Độc Giả],D.Hoten [Họ Tên],C.Masach [Mã Sách],S.Tendausach [Tên Đầu Sách],T.Ngayhethan[Ngày Hết Hạn]
	FROM dbo.DOC_GIA D,dbo.CUONSACH C,dbo.PHIEU_MUON P,dbo.CHITIET_PHIEUMUON T ,dbo.DAUSACH S
	WHERE D.Madocgia=P.Madocgia
	AND P.Maphieumuon=T.Maphieumuon
	AND C.Masach=T.Masach
	AND C.Madausach=S.Madausach
	AND T.tinhtrang=1
	AND D.Madocgia=@madocgia
END 

GO

CREATE PROC hienthisach
AS
BEGIN
	SELECT C.Masach[Mã Sách],D.Tendausach[Tên Đầu Sách],T.Ten [Thể Loại],Tinhtrang [Tình Trạng],dbo.NHA_XUAT_BAN.TenNXB [Nhà Xuất Bản]
	FROM dbo.CUONSACH C,dbo.DAUSACH D,dbo.THE_LOAI T,dbo.TINHTRANG_SACH,dbo.NHA_XUAT_BAN
	WHERE C.Madausach=D.Madausach 
	AND T.Matheloai=D.Matheloai
	AND dbo.TINHTRANG_SACH.Matinhtrang=C.Matinhtrang
	AND dbo.NHA_XUAT_BAN.MaNXB=D.MaNXB
END 

GO 


CREATE PROC hienthisachchomuon
AS
BEGIN
SELECT Masach[Mã Sách],Tendausach[Tên Đầu Sách],Tinhtrang [Tình Trạng],Ten [Thể Loại],Ngonngu[Ngôn Ngữ],Trigia[Trị Giá],Namxuatban[Năm Xuất Bản]
FROM dbo.CUONSACH,dbo.DAUSACH,dbo.TINHTRANG_SACH,dbo.THE_LOAI,dbo.NGON_NGU
WHERE CUONSACH.Madausach=DAUSACH.Madausach 
AND CUONSACH.Matinhtrang=TINHTRANG_SACH.Matinhtrang
AND DAUSACH.Matheloai=THE_LOAI.Matheloai
AND DAUSACH.Mangonngu=NGON_NGU.Mangonngu
AND CUONSACH.Matinhtrang=1
AND Soluong>0

END 

GO
CREATE PROC xoasach
@masach INT 
AS 
BEGIN
	DECLARE @ktphieumuon INT,@ktphieutra INT ,@kttinhtrang INT ,@ktbaocao INT 

	SELECT @ktphieumuon=COUNT(*) FROM dbo.CHITIET_PHIEUMUON WHERE Masach=@masach
	SELECT @ktphieutra=COUNT(*) FROM dbo.CHITIET_PHIEUTRA WHERE Masach=@masach
	SELECT @ktbaocao=COUNT(*) FROM dbo.CHITIET_BAOCAO_TRATRE WHERE Masach=@masach

	IF(@ktphieumuon>0)
		BEGIN 
			DELETE dbo.CHITIET_PHIEUMUON WHERE Masach=@masach
		END
	IF(@ktphieutra>0)
		BEGIN 
			DELETE dbo.CHITIET_PHIEUTRA WHERE Masach=@masach
		END 
	IF(@ktbaocao>0)
		BEGIN 
			DELETE dbo.CHITIET_BAOCAO_TRATRE WHERE Masach=@masach
		END
	DELETE dbo.CUONSACH WHERE Masach=@masach

END 
GO


GO
CREATE PROC phieumuon
@masach INT,@madausach INT 
AS
BEGIN 

	--cursor--Duyệt từng phần tử trong tác giả
	DECLARE @tentacgia NVARCHAR(100),@ten NVARCHAR(100)=NULL 
	DECLARE mycursor CURSOR FOR 
		SELECT Tentacgia
		FROM dbo.TAC_GIA,dbo.TACGIA_DAUSACH 
		WHERE TAC_GIA.Matacgia=TACGIA_DAUSACH.Matacgia 
		AND Madausach=@madausach

	OPEN mycursor

	FETCH NEXT FROM mycursor INTO @tentacgia

	WHILE(@@FETCH_STATUS=0)
	BEGIN
	IF(@ten IS NULL)
		BEGIN 
		SELECT @ten=@tentacgia
		END 
	ELSE
		BEGIN 
		SELECT @ten=CONCAT(@ten,', ',@tentacgia)
		END 
		FETCH NEXT FROM mycursor
		INTO @tentacgia
	END 
	CLOSE mycursor
	DEALLOCATE mycursor
	----------
	SELECT Masach[Mã Sách],Tendausach [Tên Sách],Ten [Thể Loại],@ten [Tên Tác Giả]
	FROM dbo.CUONSACH,dbo.DAUSACH,dbo.THE_LOAI
	WHERE CUONSACH.Madausach=DAUSACH.Madausach 
	AND DAUSACH.Matheloai=THE_LOAI.Matheloai 
	AND Masach=@masach
END 
GO
CREATE PROC themphieumuon
@madocgia INT,@ngaymuon DATETIME
AS
BEGIN 
	INSERT INTO dbo.PHIEU_MUON( Madocgia, Ngaymuon )VALUES  ( @madocgia, @ngaymuon)
	
END 

GO 

CREATE PROC themchitietphieumuon
@maphieumuon INT,@masach INT ,@ngayhethan DATETIME
AS
BEGIN
	INSERT INTO dbo.CHITIET_PHIEUMUON  ( Maphieumuon , Masach ,  Ngayhethan ,  tinhtrang  )VALUES  ( @maphieumuon ,   @masach , @ngayhethan, 1  )
END 
GO 

CREATE PROC themdausach
@tendausach Nvarchar(100),@matheloai INT ,@manhaxb INT, @mangonngu INT ,@trigia CHAR(100),@namxb DATETIME
AS
BEGIN
	INSERT INTO dbo.DAUSACH (Tendausach, Matheloai, MaNXB, Mangonngu, Trigia,Soluong, Namxuatban)VALUES  ( @tendausach , @matheloai, @manhaxb , @mangonngu ,@trigia, 0 , @namxb )
END
GO 

GO

CREATE PROC capnhatdausach
@madausach INT , @tendausach NVARCHAR(100),@matheloai INT,@manxb INT , @mangonngu INT,@trigia CHAR(100),@namxuatban DATETIME
AS
BEGIN 
	UPDATE dbo.DAUSACH SET Tendausach=@tendausach,Matheloai=@matheloai,MaNXB=@manxb,Mangonngu=@mangonngu,Trigia=@trigia,Namxuatban=@namxuatban WHERE Madausach=@madausach
END 

GO
alter PROC hienthiphieuthu
AS
BEGIN 
	SELECT Maphieuthu [Mã Phiếu Thu],Hoten [Họ Tên],Tongno[Tổng Nợ],Tongnolucthu[Tổng nợ lúc thu],Sotienthu [Số Tiền Thu],(Tongnolucthu-Sotienthu) [Còn Lại], ngaythu [Ngày Thu] 
	FROM dbo.PHIEU_THU,dbo.DOC_GIA  
	WHERE DOC_GIA.Madocgia=dbo.PHIEU_THU.Madocgia
END 

*/


SELECT * FROM dbo.TACGIA_DAUSACH

SELECT * FROM dbo.CUONSACH
SELECT * FROM dbo.PHIEU_MUON
SELECT * FROM dbo.CHITIET_PHIEUMUON
SELECT * FROM dbo.PHIEU_TRA
SELECT * FROM dbo.CHITIET_PHIEUTRA
SELECT * FROM dbo.DOC_GIA
SELECT * FROM dbo.TACGIA_DAUSACH ORDER BY Madausach
SELECT * FROM dbo.DAUSACH
GO 


SELECT * FROM dbo.PHIEU_THU

DELETE dbo.PHIEU_THU WHERE Maphieuthu='5'

SELECT * FROM dbo.PHIEU_MUON,dbo.CHITIET_PHIEUMUON WHERE CHITIET_PHIEUMUON.Maphieumuon=dbo.PHIEU_MUON.Maphieumuon

