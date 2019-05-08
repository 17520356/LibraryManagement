CREATE DATABASE LibraryManagement
GO
USE LibraryManagement
GO
SET DATEFORMAT DMY
GO

CREATE TABLE LOAI_DG
(
	Maloaidg			Char(6) NOT NULL PRIMARY KEY,
	Tenloai				Nvarchar(15) NOT NULL,
	Ghichu				Nvarchar(15)
)

GO
CREATE TABLE DOC_GIA
(
	Madocgia			Char(6) NOT NULL PRIMARY KEY,
	Maloaidg			Char(6) NOT NULL,
	Hoten				Nvarchar(25) NOT NULL,
	Ngaysinh			Date,
	Diachi				Nvarchar(40),
	Sodienthoai			Char(15),
	Gioitinh			Char(20),
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
	Matinhtrang			Char(6) NOT NULL PRIMARY KEY,--0: không thể cho mượn --1: có thể cho mượn
	Tinhtrang			Nvarchar(20)
)
GO
CREATE TABLE THE_LOAI
(
	Matheloai			Char(6) NOT NULL PRIMARY KEY,
	Ten					Nvarchar(20),
)
GO
CREATE TABLE TAC_GIA
(
	Matacgia			Char(6) NOT NULL PRIMARY KEY,
	Tentacgia			Nvarchar(20) NOT NULL,
	Diachi				Nvarchar(30),
	Sodienthoai			char(15),
	Ngaysinh			Date,
	Ghichu				Nvarchar(30)
)
GO
CREATE TABLE NHA_XUAT_BAN
(
	MaNXB				Char(6) NOT NULL PRIMARY KEY,
	TenNXB				Nvarchar(30) NOT NULL,
	Diachi				Nvarchar(30),
	Email				Nvarchar(15)

)
CREATE TABLE NGON_NGU
(
	Mangonngu			Char(6) NOT NULL PRIMARY KEY,
	Ngonngu				Nvarchar(15),
)
GO
CREATE TABLE DAUSACH
(
	Madausach			Char(6) NOT NULL PRIMARY KEY,
	Tendausach			Nvarchar(50),
	Matheloai			Char(6) NOT NULL,
	Matacgia			Char(6) NOT NULL,
	MaNXB				Char(6) NOT NULL,
	Mangonngu			Char(6) NOT NULL,
	Trigia				Money,
	Soluong				Int,
	Namxuatban			Int,
		FOREIGN KEY (Matheloai) REFERENCES THE_LOAI (Matheloai),
		FOREIGN KEY (Matacgia) REFERENCES TAC_GIA (Matacgia),
		FOREIGN KEY (MaNXB) REFERENCES NHA_XUAT_BAN(MaNXB),
		FOREIGN KEY (Mangonngu) REFERENCES NGON_NGU(Mangonngu)
)
GO
CREATE TABLE CUONSACH
(
	Masach				Char(6) NOT NULL PRIMARY KEY,
	Madausach			Char(6) NOT NULL,
	Matinhtrang			Char(6) NOT NULL,
	Ngaynhap			Date NOT NULL DEFAULT GETDATE(),
	
		FOREIGN KEY (Matinhtrang) REFERENCES TINHTRANG_SACH(Matinhtrang),
		FOREIGN KEY (Madausach) REFERENCES DAUSACH(Madausach)
	
)
GO

CREATE TABLE PHIEU_MUON
(
	Maphieumuon			Char(6) NOT NULL PRIMARY KEY,
	Madocgia			Char(6) NOT NULL,
	Ngaymuon			Date NOT NULL DEFAULT GETDATE(),
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA(Madocgia)
)
GO
CREATE TABLE CHITIET_PHIEUMUON
(
	Maphieumuon			Char(6) NOT NULL ,
	Masach				Char(6) NOT NULL ,
	Ngayhethan			Date,
		PRIMARY KEY (Maphieumuon,Masach),
		FOREIGN KEY (Masach) REFERENCES CUONSACH(Masach),
		FOREIGN KEY (Maphieumuon) REFERENCES PHIEU_MUON(Maphieumuon)
)
GO
CREATE TABLE PHIEU_TRA
(
	Maphieutra			Char(6) NOT NULL PRIMARY KEY, --thêm mã phiếu mượn
	Madocgia			Char(6) NOT NULL,
	Ngaytra				Date NOT NULL DEFAULT GETDATE(),
	Tienphat			money,
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA(Madocgia)
)
GO
CREATE TABLE CHITIET_PHIEUTRA
(
	Maphieutra			Char(6) NOT NULL,
	Masach				Char(6) NOT NULL,
	Tienphattungsach	Money,
		PRIMARY KEY(Maphieutra,Masach),
		FOREIGN KEY (Masach) REFERENCES CUONSACH(Masach),
		FOREIGN KEY (Maphieutra) REFERENCES PHIEU_TRA(Maphieutra)
)
GO
CREATE TABLE PHIEU_THU
(
	Maphieuthu			Char(6) NOT NULL PRIMARY KEY,
	Madocgia			Char(6) NOT NULL,
	Ngaythu				date	NOT NULL DEFAULT GETDATE(),
	Sotienthu			Money,	
		FOREIGN KEY (Madocgia) REFERENCES DOC_GIA (Madocgia)
)
GO 
CREATE TABLE THAM_SO
(
	Tenthamso				NvarChar(50),
	Giatri				Int,
)
GO
CREATE TABLE BAOCAO_MUONSACH_THELOAI
(
	Mabaocaotheotheloai			Char(6) NOT NULL PRIMARY KEY,
	Thang						Int,
	Nam							Int,
	Tongluotmuon				Int,

)

GO 
CREATE TABLE CHITIET_BAOCAO_THELOAI
(
	Mabaocaotheotheloai			Char(6) NOT NULL,
	Matheloai					Char(6) NOT NULL,
	Luotmuon					Int,
	Tile						float,
		PRIMARY KEY (Mabaocaotheotheloai,Matheloai),
		FOREIGN KEY (Matheloai) REFERENCES THE_LOAI(Matheloai),
		FOREIGN KEY (Mabaocaotheotheloai) REFERENCES BAOCAO_MUONSACH_THELOAI(Mabaocaotheotheloai)
)
GO
CREATE TABLE BAOCAO_SACH_TRATRE
(
	Mabaocaosachtratre			Char(6) NOT NULL PRIMARY KEY,
	Ngay						Int,
	Thang						Int,
	Nam							Int,

)
GO
CREATE TABLE CHITIET_BAOCAO_TRATRE
(
	Mabaocaosachtratre			Char(6) NOT NULL,
	Masach						Char(6) NOT NULL,
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
DROP TRIGGER dbo.tg_capnhatngayhethan
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

	
	DECLARE cursorDate CURSOR FOR
	SELECT   dbo.DOC_GIA.Madocgia,  dbo.DOC_GIA.Ngayhethan 
	FROM dbo.DOC_GIA
	OPEN cursorDate
	DECLARE  @Madocgia CHAR(6), @Ngayhethan DATE
	FETCH NEXT FROM cursorDate INTO @Madocgia,@Ngayhethan
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF(@Ngayhethan<GETDATE())
			BEGIN
				UPDATE dbo.DOC_GIA
				SET dbo.DOC_GIA.tinhtrang='2'
				WHERE dbo.DOC_GIA.Madocgia=@Madocgia;
			END 
		FETCH NEXT FROM cursorDate INTO @Madocgia,@Ngayhethan
    END 
	CLOSE cursorDate
	DEALLOCATE cursorDate

	SELECT * FROM dbo.DOC_GIA
