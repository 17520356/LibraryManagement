CREATE DATABASE LibraryManagement
GO
USE LibraryManagement
GO
SET DATEFORMAT DMY
GO

--TABLE
GO 


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
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe,Ngayhethan, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 1 ,N'A' ,'03-06-2000',N'A' ,'1' ,1,GETDATE(),DATEADD(MONTH,2,GETDATE()),'E' , 0 , 0,1  )
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe,Ngayhethan, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 2 ,N'B' ,'03-06-2000' ,N'A' ,'1' ,2,GETDATE(),DATEADD(MONTH,2,GETDATE()),'E' , 0 , 0,2  )
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe,Ngayhethan, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 1 ,N'C' ,'03-06-2000',N'A' ,'1' ,1,GETDATE(),DATEADD(MONTH,2,GETDATE()),'E' , 0 , 0,0  )
INSERT INTO dbo.DOC_GIA ( Maloaidg, Hoten, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe,Ngayhethan, Email, Sosachmuon,Tongno , tinhtrang)
	VALUES  ( 2 ,N'D' ,'03-06-2000' ,N'A' ,'1' ,1,GETDATE(),DATEADD(MONTH,2,GETDATE()),'E' , 0 , 0,1  )

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
GO 
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
GO 

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
	INSERT INTO dbo.DAUSACH	( Tendausach ,Matheloai ,MaNXB ,Mangonngu , Trigia ,Soluong ,Namxuatban)
		VALUES  ( N'Cơ Sở Dữ Liệu' , 1 , 1 , 1 , 10000 ,1 ,GETDATE())
	INSERT INTO dbo.DAUSACH	( Tendausach ,Matheloai ,MaNXB ,Mangonngu , Trigia ,Soluong ,Namxuatban)
		VALUES  ( N'Nhập Môn Mạng Máy Tính' , 2 , 2 ,	2 ,	12000 ,1 ,GETDATE())
	INSERT INTO dbo.DAUSACH	( Tendausach ,Matheloai ,MaNXB ,Mangonngu , Trigia ,Soluong ,Namxuatban)
		VALUES  ( N'OOP' , 3 , 3 ,	3 ,	15000 ,1 ,GETDATE())
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
INSERT INTO dbo.TACGIA_DAUSACH ( Matacgia, Madausach )
	VALUES  ( 1, 1  )
INSERT INTO dbo.TACGIA_DAUSACH ( Matacgia, Madausach )
	VALUES  ( 2, 2  )
INSERT INTO dbo.TACGIA_DAUSACH ( Matacgia, Madausach )
	VALUES  ( 3, 3  )

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
INSERT INTO dbo.CUONSACH ( Madausach, Matinhtrang, Ngaynhap )
		VALUES  ( 1 , 1 ,GETDATE())
INSERT INTO dbo.CUONSACH ( Madausach, Matinhtrang, Ngaynhap )
		VALUES  ( 2 , 1 ,GETDATE())
INSERT INTO dbo.CUONSACH ( Madausach, Matinhtrang, Ngaynhap )
		VALUES  ( 3 , 1 ,GETDATE())

GO 
CREATE TABLE tinhtrangsachkhimuon
(
	matinhtrang INT IDENTITY PRIMARY KEY,
	tinhtrang	NVARCHAR(30),
)
GO 
INSERT INTO dbo.tinhtrangsachkhimuon ( tinhtrang )VALUES  (  N'Đã Trả' )
INSERT INTO dbo.tinhtrangsachkhimuon ( tinhtrang )VALUES  (  N'Chưa Trả' )
INSERT INTO dbo.tinhtrangsachkhimuon ( tinhtrang )VALUES  (  N'Quá Hạn' )

GO
CREATE TABLE PHIEU_MUON
(
	Maphieumuon			INT IDENTITY PRIMARY KEY,
	Madocgia			INT NOT NULL,
	Ngaymuon			Date NOT NULL DEFAULT GETDATE(),
	
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA(Madocgia)
)
GO
INSERT INTO dbo.PHIEU_MUON( Madocgia, Ngaymuon )
         VALUES  ( 1,  GETDATE() )
INSERT INTO dbo.PHIEU_MUON( Madocgia, Ngaymuon )
         VALUES  ( 2,  GETDATE() )
INSERT INTO dbo.PHIEU_MUON( Madocgia, Ngaymuon )
         VALUES  ( 3,  GETDATE() )

GO


CREATE TABLE CHITIET_PHIEUMUON
(
	Maphieumuon			INT NOT NULL ,
	Masach				INT NOT NULL ,
	Ngayhethan			Date,
	tinhtrang			INT,			 -- Thêm 1 bảng tình trạng sách trong phiếu mượn
	giahan				INT DEFAULT '1' --1 chưa gia hạn---2 đã gia hạn

		PRIMARY KEY (Maphieumuon,Masach),
		FOREIGN KEY (Masach) REFERENCES CUONSACH(Masach),
		FOREIGN KEY (Maphieumuon) REFERENCES PHIEU_MUON(Maphieumuon),
		FOREIGN KEY(tinhtrang) REFERENCES dbo.tinhtrangsachkhimuon(matinhtrang)

)
GO 
INSERT INTO dbo.CHITIET_PHIEUMUON ( Maphieumuon , Masach ,Ngayhethan , tinhtrang ,giahan  )
          VALUES  ( 1 , 1 ,  DATEADD(DAY,4,GETDATE()) , 2 , 1  )
INSERT INTO dbo.CHITIET_PHIEUMUON ( Maphieumuon , Masach ,Ngayhethan , tinhtrang ,giahan  )
          VALUES  ( 2 , 2 ,  DATEADD(DAY,4,GETDATE()) , 2 , 1  )
INSERT INTO dbo.CHITIET_PHIEUMUON ( Maphieumuon , Masach ,Ngayhethan , tinhtrang ,giahan  )
          VALUES  ( 3 , 3 ,  DATEADD(DAY,4,GETDATE()) , 2 , 1  )

GO


CREATE TABLE PHIEU_TRA
(
	Maphieutra			INT IDENTITY PRIMARY KEY, 
	Madocgia			INT NOT NULL,
	Ngaytra				Date NOT NULL DEFAULT GETDATE(),
	Tienphat			MONEY DEFAULT 0,
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA(Madocgia),
)
GO


CREATE TABLE CHITIET_PHIEUTRA
(
	Maphieutra			int NOT NULL,
	Masach				INT NOT NULL,
	Ngaymuon			DATETIME,
	Songaytre			INT DEFAULT '0',
	Tienphattungsach	Money ,

	
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
GO 
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

GO 
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


GO 
--TRIGGER -
GO


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

CREATE TRIGGER capnhattinhtrangphieumuon
ON dbo.CHITIET_PHIEUMUON
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @ngayhethan DATETIME,@masach INT,@tinhtrang INT, @maphieumuon INT 
	SELECT @ngayhethan = Inserted.Ngayhethan,@masach =Inserted.Masach,@tinhtrang = Inserted.tinhtrang
	FROM Inserted

	IF(@tinhtrang!=1)
	BEGIN 
	IF(@ngayhethan<GETDATE())
	BEGIN
    	UPDATE dbo.CHITIET_PHIEUMUON SET tinhtrang=3 WHERE Masach=@masach AND Maphieumuon=@maphieumuon
	END
	ELSE
    BEGIN 
    	UPDATE dbo.CHITIET_PHIEUMUON SET tinhtrang=2 WHERE Masach=@masach AND Maphieumuon=@maphieumuon
	END 
	END 
END 



GO 
--PROCEDURE
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

CREATE PROC update_quidinh_docgia -- cập nhật qui định tác giả
 @thamso NVARCHAR(100), @giatri INT 
 AS
 BEGIN
	UPDATE dbo.THAM_SO SET Giatri=@giatri WHERE Tenthamso= @thamso;
 END

GO 

CREATE PROC update_docgia  -- cập nhật độc giả
@madocgia INT,@hoten NVARCHAR(100),@maloaidg INT ,@ngaysinh DATE,@gioitinh INT,@diachi NVARCHAR(100),@sodt CHAR(15), @email CHAR(20)
AS
BEGIN 
	UPDATE dbo.DOC_GIA SET Hoten=@hoten,Maloaidg=@maloaidg,Gioitinh=@gioitinh,Diachi=@diachi,Sodienthoai=@sodt,Email=@email,Ngaysinh=@ngaysinh
	WHERE Madocgia=@madocgia
END 

	
GO 

CREATE PROC delete_docgia -- xóa độc giả
@madocgia int 
AS
BEGIN
	DECLARE @checkphieumuon INT , @checkphieutra INT ,@checkphieuthu INT
		
	SELECT @checkphieumuon=COUNT(*) FROM dbo.PHIEU_MUON WHERE dbo.PHIEU_MUON.Madocgia=@madocgia
	SELECT @checkphieutra=COUNT(*) FROM dbo.PHIEU_TRA WHERE dbo.PHIEU_TRA.Madocgia=@madocgia
	SELECT @checkphieuthu=COUNT(*) FROM dbo.PHIEU_THU WHERE dbo.PHIEU_THU.Madocgia=@madocgia

	IF(@checkphieutra>0)			--Có Phiếu Trả -- xóa chi tiết phiếu trả -> xóa phiếu trả
	BEGIN 
		DELETE dbo.CHITIET_PHIEUTRA 
			FROM dbo.CHITIET_PHIEUTRA,dbo.PHIEU_TRA 
			WHERE dbo.CHITIET_PHIEUTRA.Maphieutra=dbo.PHIEU_TRA.Maphieutra 
			AND Madocgia=@madocgia
		DELETE dbo.PHIEU_TRA WHERE Madocgia=@madocgia
	END 	

	IF (@checkphieumuon>0)				--Có Phiếu Mượn -- xóa chi tiết phiếu mượn -> xóa phiếu mượn
	BEGIN	
		DELETE dbo.CHITIET_PHIEUMUON 
			FROM dbo.CHITIET_PHIEUMUON,dbo.PHIEU_MUON 
			WHERE dbo.CHITIET_PHIEUMUON.Maphieumuon=dbo.PHIEU_MUON.Maphieumuon 
			AND Madocgia=@madocgia
		DELETE dbo.PHIEU_MUON 
			WHERE Madocgia=@madocgia
	END 
	
	IF(@checkphieuthu>0)		--Có Phiếu Thu  -- xóa phiếu thu
	BEGIN
		DELETE dbo.PHIEU_THU WHERE Madocgia=@madocgia

	END
	DELETE dbo.DOC_GIA WHERE Madocgia=@madocgia -- xóa độc giả
END 

GO



CREATE PROC insert_docgia -- thêm mới độc giả
@hoten NVARCHAR(100),@maloaidg INT ,@ngaysinh DATE,@gioitinh INT,@diachi NVARCHAR(100),@sodt CHAR(15), @email CHAR(20),@ngaylapthe DATETIME,@ngayhethan DATETIME
AS
BEGIN
	INSERT INTO dbo.DOC_GIA( Hoten, Maloaidg, Ngaysinh, Diachi, Sodienthoai, Gioitinh, Ngaylapthe, Ngayhethan, Email )VALUES  (@hoten,@maloaidg,@ngaysinh,@diachi,@sodt,@gioitinh,@ngaylapthe,@ngayhethan,@email)
END
 
GO 

CREATE PROC SachDangMuon -- hiển thị những sách mà độc giả đang mượn
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


CREATE PROC hienthisachchomuon  -- hiển thị các sách có thể cho mượn
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

CREATE PROC xoasach  -- xóa sách
@masach INT 
AS 
BEGIN
	DECLARE @ktphieumuon INT,@ktphieutra INT ,@kttinhtrang INT ,@ktbaocao INT 

	SELECT @ktphieumuon=COUNT(*) FROM dbo.CHITIET_PHIEUMUON WHERE Masach=@masach
	SELECT @ktphieutra=COUNT(*) FROM dbo.CHITIET_PHIEUTRA WHERE Masach=@masach
	SELECT @ktbaocao=COUNT(*) FROM dbo.CHITIET_BAOCAO_TRATRE WHERE Masach=@masach

	IF(@ktphieumuon>0)
		BEGIN 
			DELETE dbo.CHITIET_PHIEUMUON WHERE Masach=@masach  -- xóa sách trong phiếu mượn 
		END
	IF(@ktphieutra>0)
		BEGIN 
			DELETE dbo.CHITIET_PHIEUTRA WHERE Masach=@masach -- xóa sách trong phiếu trả
		END 
	IF(@ktbaocao>0)
		BEGIN 
			DELETE dbo.CHITIET_BAOCAO_TRATRE WHERE Masach=@masach -- xóa sách trong báo cáo
		END
	DELETE dbo.CUONSACH WHERE Masach=@masach  -- xóa sách

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
	INSERT INTO dbo.CHITIET_PHIEUMUON  ( Maphieumuon , Masach ,  Ngayhethan ,  tinhtrang  )VALUES  ( @maphieumuon ,   @masach , @ngayhethan, 2  )
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

CREATE PROC hienthiphieuthu
AS
BEGIN 
	SELECT Maphieuthu [Mã Phiếu Thu],Hoten [Họ Tên],Tongno[Tổng Nợ],Tongnolucthu[Tổng nợ lúc thu],Sotienthu [Số Tiền Thu],(Tongnolucthu-Sotienthu) [Còn Lại], ngaythu [Ngày Thu] 
	FROM dbo.PHIEU_THU,dbo.DOC_GIA  
	WHERE DOC_GIA.Madocgia=dbo.PHIEU_THU.Madocgia
END 

GO

CREATE PROC chitietphieumuon
@maphieumuon INT 
AS
BEGIN 
	SELECT dbo.CUONSACH.Masach[Mã Sách],dbo.DAUSACH.Tendausach[Tên Sách],Ngayhethan[Ngày Hết hạn],tinhtrangsachkhimuon.tinhtrang[Tình Trạng] 
	FROM dbo.CHITIET_PHIEUMUON,dbo.tinhtrangsachkhimuon,dbo.CUONSACH,dbo.DAUSACH 
	WHERE CHITIET_PHIEUMUON.tinhtrang=dbo.tinhtrangsachkhimuon.matinhtrang
	AND CHITIET_PHIEUMUON.Masach=CUONSACH.Masach
	AND CUONSACH.Madausach=DAUSACH.Madausach
	AND Maphieumuon=@maphieumuon
END 

GO

CREATE PROC hienthiphieutra
@madocgia INT 
AS
BEGIN 
	SELECT CHITIET_PHIEUMUON.Masach,Tendausach
	FROM dbo.PHIEU_MUON,dbo.CHITIET_PHIEUMUON,dbo.CUONSACH,dbo.DAUSACH
	WHERE CHITIET_PHIEUMUON.Masach=CUONSACH.Masach
	AND CHITIET_PHIEUMUON.Maphieumuon=PHIEU_MUON.Maphieumuon
	AND CUONSACH.Madausach=DAUSACH.Madausach
	AND tinhtrang !='1'
	AND Madocgia=@madocgia
END 

GO 

CREATE PROC hienthitinhtrangsach
AS
BEGIN 

SELECT CUONSACH.Masach [Mã Sách],Tendausach [Tên Sách],Ngayhethan[Ngày Hết Hạn],tinhtrang[Tình Trạng]
FROM dbo.CHITIET_PHIEUMUON,dbo.CUONSACH,dbo.DAUSACH 
WHERE tinhtrang!=1
AND CHITIET_PHIEUMUON.Masach=CUONSACH.Masach
AND CUONSACH.Madausach=DAUSACH.Madausach

END 

GO

CREATE PROC kiemtradocgiamuonsachquahan
@madocgia INT 
AS
BEGIN 
	SELECT * FROM dbo.DOC_GIA,dbo.CHITIET_PHIEUMUON,dbo.PHIEU_MUON
	WHERE CHITIET_PHIEUMUON.Maphieumuon=PHIEU_MUON.Maphieumuon
	AND DOC_GIA.Madocgia=PHIEU_MUON.Madocgia
	AND CHITIET_PHIEUMUON.tinhtrang='3'
	AND dbo.PHIEU_MUON.Madocgia=@madocgia
END 

GO

CREATE PROC LIST_phieutra
@masach INT
AS
BEGIN
	DECLARE @songay INT = 0 ,@tendausach NVARCHAR(50),@ngaymuon DATETIME,@tinhtrang INT ,@tienphat MONEY = '0'

	SELECT  @tendausach = Tendausach,@ngaymuon = Ngaymuon,@tinhtrang = tinhtrang
	FROM dbo.PHIEU_MUON,dbo.CHITIET_PHIEUMUON,dbo.CUONSACH,dbo.DAUSACH
	WHERE CHITIET_PHIEUMUON.Maphieumuon=PHIEU_MUON.Maphieumuon
	AND CHITIET_PHIEUMUON.Masach=CUONSACH.Masach
	AND CUONSACH.Madausach=DAUSACH.Madausach
	AND CHITIET_PHIEUMUON.Masach=@masach

	IF(@tinhtrang=3)
	BEGIN
		SELECT @songay = DATEDIFF(Dd,Ngayhethan,GETDATE()) 
		FROM dbo.CHITIET_PHIEUMUON 
		WHERE Masach=@masach
	END
	IF(@songay !=0)
	BEGIN
		SELECT @tienphat = @songay*1000
	END 
	SELECT @masach [Mã Sách],@tendausach [Tên Sách],@ngaymuon [Ngày Mượn],@songay [Số Ngày Trễ],@tienphat [Tiền Phạt]
END 

GO

CREATE PROC phieutra_datagridview
AS
BEGIN
	SELECT Maphieutra[Mã Phiếu Trả],DOC_GIA.Madocgia[Mã Độc Giả],Hoten[Họ Tên],Ngaytra[Ngày Trả]
	FROM dbo.PHIEU_TRA,dbo.DOC_GIA
	WHERE DOC_GIA.Madocgia=PHIEU_TRA.Madocgia
END 

GO 
CREATE PROC layngaymuon
@masach INT , @madocgia INT
AS
BEGIN
	SELECT Ngaymuon
	FROM dbo.PHIEU_MUON,dbo.CHITIET_PHIEUMUON
	WHERE CHITIET_PHIEUMUON.Maphieumuon=PHIEU_MUON.Maphieumuon
	AND tinhtrang !='1'
	AND Madocgia=@madocgia
	AND Masach=@masach
END 


GO 
CREATE PROC chitietphieutra
@maphieutra INT 
AS
BEGIN 
	SELECT DISTINCT CUONSACH.Masach [Mã Sách],Tendausach [Tên Sách], dbo.CHITIET_PHIEUTRA.Ngaymuon [Ngày Mượn],Songaytre [Số Ngày Trễ],Tienphattungsach [Tiền Phạt]
	FROM dbo.CHITIET_PHIEUTRA,dbo.PHIEU_TRA,dbo.CUONSACH,dbo.DAUSACH
	WHERE CHITIET_PHIEUTRA.Maphieutra=PHIEU_TRA.Maphieutra
	AND CHITIET_PHIEUTRA.Masach=CUONSACH.Masach
	AND DAUSACH.Madausach=CUONSACH.Madausach
	AND CHITIET_PHIEUTRA.Maphieutra=@maphieutra

END 

GO 
CREATE PROC laymaphieumuon
@masach INT , @madocgia INT
AS
BEGIN
	SELECT PHIEU_MUON.Maphieumuon
	FROM dbo.PHIEU_MUON,dbo.CHITIET_PHIEUMUON
	WHERE CHITIET_PHIEUMUON.Maphieumuon=PHIEU_MUON.Maphieumuon
	AND tinhtrang !='1'
	AND Madocgia=@madocgia
	AND Masach=@masach
END 
GO
GO
SELECT * FROM dbo.TACGIA_DAUSACH

SELECT * FROM dbo.CUONSACH
SELECT * FROM dbo.PHIEU_MUON
SELECT * FROM dbo.CHITIET_PHIEUMUON
SELECT * FROM dbo.PHIEU_TRA
SELECT * FROM dbo.CHITIET_PHIEUTRA
SELECT * FROM dbo.DOC_GIA
SELECT * FROM dbo.TACGIA_DAUSACH ORDER BY Madausach
SELECT * FROM dbo.DAUSACH

/*timdocgia*/
GO 
CREATE PROC timdocgiabangiD
@madocgia INT 
AS
BEGIN
	SELECT Madocgia [Mã Độc Giả],Hoten [Họ Tên],Tenloai [Loại Độc Giả],Ngaylapthe[Ngày Lập Thẻ],Ngayhethan[Ngày Hết Hạn],Sosachmuon[Số Sách Mượn],Tongno [Tổng Nợ] 
	FROM dbo.DOC_GIA,dbo.LOAI_DG 
	WHERE DOC_GIA.Maloaidg=dbo.LOAI_DG.Maloaidg 
	AND DOC_GIA.Madocgia=@madocgia
END
GO

SELECT * FROM dbo.DOC_GIA
GO 
CREATE PROC timkiemdocgia
@hoten NVARCHAR(100)
AS
BEGIN 
SELECT Madocgia 
FROM dbo.DOC_GIA,dbo.LOAI_DG
WHERE dbo.DOC_GIA.Hoten=@hoten
END 
GO
EXEC dbo.timkiemdocgia @hoten = N'a' -- nvarchar(100)

EXEC dbo.timdocgiabangiD @madocgia = 5 -- int
GO
SELECT*FROM dbo.PHIEU_MUON WHERE Maphieumuon=1

/*timphieumuon*/
SELECT*FROM dbo.PHIEU_MUON
SELECT*FROM dbo.CHITIET_PHIEUMUON
SELECT*FROM dbo.tinhtrangsachkhimuon
GO
CREATE PROC timkiem
@maphieumuon INT
AS
BEGIN 
	SELECT  Maphieumuon[Mã Phiếu Mượn],DOC_GIA.Madocgia[Mã Độc Giả],Hoten [Họ Tên],Ngaymuon[Ngày Mượn] 
	FROM dbo.PHIEU_MUON,dbo.DOC_GIA
	 WHERE DOC_GIA.Madocgia=PHIEU_MUON.Madocgia AND dbo.PHIEU_MUON.Maphieumuon=@maphieumuon
END 
GO
CREATE PROC timkiemphieumuon
@hoten NVARCHAR(100)
AS
BEGIN
SELECT PHIEU_MUON.Maphieumuon
FROM dbo.PHIEU_MUON,dbo.DOC_GIA
WHERE dbo.PHIEU_MUON.Madocgia=dbo.DOC_GIA.Madocgia AND dbo.DOC_GIA.Hoten=@hoten 
END
GO 
EXEC dbo.timkiemphieumuon @hoten = N'Hoàng Hồng Đức' -- nvarchar(100)
EXEC dbo.timkiem @maphieumuon = 2-- int


/*timphieutra*/
SELECT*FROM dbo.PHIEU_TRA
GO
CREATE PROC timkiempt
@maphieutra INT
AS
BEGIN
	SELECT Maphieutra[Mã Phiếu Trả],DOC_GIA.Madocgia[Mã Độc Giả],Hoten[Họ Tên],Ngaytra[Ngày Trả]
	FROM dbo.PHIEU_TRA,dbo.DOC_GIA
	WHERE DOC_GIA.Madocgia=PHIEU_TRA.Madocgia AND dbo.PHIEU_TRA.Maphieutra=@maphieutra
END 

GO
CREATE PROC timkiemphieutra
@hoten NVARCHAR(100)
AS 
BEGIN
SELECT dbo.PHIEU_TRA.Maphieutra
FROM dbo.PHIEU_TRA,dbo.DOC_GIA
WHERE dbo.PHIEU_TRA.Madocgia=DOC_GIA.Madocgia AND dbo.DOC_GIA.Hoten=@hoten
END
EXEC dbo.timkiemphieutra @hoten = N'a' -- nvarchar(100)
EXEC dbo.timkiempt @maphieutra = 1 -- int


/*tim phiếu thu*/

GO
CREATE PROC timkiempthu
@maphieuthu INT
AS
BEGIN 
	SELECT Maphieuthu [Mã Phiếu Thu],Hoten [Họ Tên],Tongno[Tổng Nợ],Tongnolucthu[Tổng nợ lúc thu],Sotienthu [Số Tiền Thu],(Tongnolucthu-Sotienthu) [Còn Lại], ngaythu [Ngày Thu] 
	FROM dbo.PHIEU_THU,dbo.DOC_GIA  
	WHERE DOC_GIA.Madocgia=dbo.PHIEU_THU.Madocgia AND dbo.PHIEU_THU.Maphieuthu=@maphieuthu
END 

GO
CREATE PROC timkiemphieuthu
@hoten NVARCHAR(100)
AS 
BEGIN
SELECT dbo.PHIEU_THU.Maphieuthu
FROM dbo.PHIEU_THU,dbo.DOC_GIA
WHERE dbo.PHIEU_THU.Madocgia=DOC_GIA.Madocgia AND dbo.DOC_GIA.Hoten=@hoten
END
EXEC dbo.timkiemphieuthu @hoten = N'a' -- nvarchar(100)

EXEC dbo.timkiempthu @maphieuthu =1-- int



/*timdausach*/
SELECT*FROM dbo.DAUSACH
SELECT*FROM dbo.CUONSACH
SELECT*FROM dbo.THE_LOAI
SELECT*FROM dbo.NHA_XUAT_BAN
GO 
CREATE PROC timdausachbangiD
@madausach INT 
AS
BEGIN
SELECT Madausach[Mã Đầu Sách], Tendausach[Tên Đầu Sách], Ten[Thể Loại], Trigia[Trị Giá], Soluong[Số Lượng]
 FROM dbo.DAUSACH,dbo.THE_LOAI
  WHERE dbo.THE_LOAI.Matheloai = dbo.DAUSACH.Matheloai AND dbo.DAUSACH.Madausach=@madausach
END 

GO
CREATE PROC timkiemsachtheotends
@tendausach NVARCHAR(100)
AS
BEGIN 
SELECT dbo.DAUSACH.Madausach
FROM dbo.DAUSACH,dbo.THE_LOAI
WHERE dbo.DAUSACH.Tendausach=@tendausach
END
GO 
CREATE PROC timsachbangiDtlds
@matheloai INT 
AS
BEGIN
SELECT Madausach[Mã Đầu Sách], Tendausach[Tên Đầu Sách], Ten[Thể Loại], Trigia[Trị Giá], Soluong[Số Lượng]
 FROM dbo.DAUSACH,dbo.THE_LOAI
  WHERE THE_LOAI.Matheloai = DAUSACH.Matheloai AND dbo.THE_LOAI.Matheloai=@matheloai
END 

GO
CREATE PROC timkiemsachtheotlds
@tentheloai NVARCHAR(100)
AS
BEGIN 
SELECT dbo.THE_LOAI.Matheloai
FROM dbo.DAUSACH,dbo.THE_LOAI
WHERE dbo.THE_LOAI.Ten=@tentheloai
END
GO

EXEC dbo.timdausachbangiD @madausach = 1 -- int
EXEC dbo.timkiemsachtheotends @tendausach = N'oop' -- nvarchar(100)
EXEC dbo.timsachbangiDtlds @matheloai = 1 -- int
EXEC dbo.timkiemsachtheotlds @tentheloai = N'a' -- nvarchar(100)

/*timsach*/
GO 
CREATE PROC timsachbangiD
@madausach INT 
AS
BEGIN
	SELECT C.Masach[Mã Sách],D.Tendausach[Tên Đầu Sách],T.Ten [Thể Loại],Tinhtrang [Tình Trạng],dbo.NHA_XUAT_BAN.TenNXB [Nhà Xuất Bản]
	FROM dbo.CUONSACH C,dbo.DAUSACH D,dbo.THE_LOAI T,dbo.TINHTRANG_SACH,dbo.NHA_XUAT_BAN
	WHERE C.Madausach=D.Madausach
	AND T.Matheloai=D.Matheloai
	AND dbo.TINHTRANG_SACH.Matinhtrang=C.Matinhtrang
	AND dbo.NHA_XUAT_BAN.MaNXB=D.MaNXB
	AND c.Madausach=@madausach
END 

GO
CREATE PROC timkiemsachtheoten
@tendausach NVARCHAR(100)
AS
BEGIN 
SELECT dbo.CUONSACH.Madausach
FROM dbo.DAUSACH,dbo.CUONSACH
WHERE dbo.CUONSACH.Madausach=dbo.DAUSACH.Madausach AND dbo.DAUSACH.Tendausach=@tendausach
END
GO 
CREATE PROC timsachbangiDtl
@matheloai INT 
AS
BEGIN
	SELECT C.Masach[Mã Sách],D.Tendausach[Tên Đầu Sách],T.Ten [Thể Loại],Tinhtrang [Tình Trạng],dbo.NHA_XUAT_BAN.TenNXB [Nhà Xuất Bản]
	FROM dbo.CUONSACH C,dbo.DAUSACH D,dbo.THE_LOAI T,dbo.TINHTRANG_SACH,dbo.NHA_XUAT_BAN
	WHERE C.Madausach=D.Madausach 
	AND T.Matheloai=D.Matheloai
	AND dbo.TINHTRANG_SACH.Matinhtrang=C.Matinhtrang
	AND dbo.NHA_XUAT_BAN.MaNXB=D.MaNXB
	AND D.Matheloai=@matheloai
END 

GO
CREATE PROC timkiemsachtheotl
@tentheloai NVARCHAR(100)
AS
BEGIN 
SELECT dbo.THE_LOAI.Matheloai
FROM dbo.CUONSACH,dbo.THE_LOAI
WHERE dbo.THE_LOAI.Ten=@tentheloai
END
GO
EXEC dbo.timsachbangiD @madausach = 1 -- int
EXEC dbo.timkiemsachtheoten @tendausach = N'cơ sở dữ liệu' -- nvarchar(100)
EXEC dbo.timsachbangiDtl @matheloai = 1 -- int
EXEC dbo.timkiemsachtheotl @tentheloai = N'a' -- nvarchar(100) 
GO
