USE QuanLySinhVien
GO
CREATE TABLE KhachHang
(
	KhachhangId VARCHAR(100) NOT NULL PRIMARY KEY,
	Ho NVARCHAR(100),
	Tenlot NVARCHAR(100),
	Ten NVARCHAR(100),
	Gioitinh NVARCHAR(5),
	Email VARCHAR(100),
	SDT VARCHAR(100),
	Diachi NVARCHAR(100)
)
GO
CREATE TABLE NhaCungCap
(
	NhacungcapId VARCHAR(100) NOT NULL PRIMARY KEY,
	Ten NVARCHAR(100),
	HangHoaCungCap NVARCHAR(100),
	NhomHanghoaId VARCHAR(100),
	SDT VARCHAR(100),
	Diachi NVARCHAR(100)
)
GO
CREATE TABLE Banhang
(
	ID VARCHAR NOT NULL PRIMARY KEY,
	Soluong int,
	Ngay date,

)
GO
CREATE TABLE HangHoaConvert(
	[HanghoaId] [nvarchar](50) NOT NULL primary key,
	[TenHanghoa] [nvarchar](200) NULL,
	[GiaBan] [float] NULL,
	[Mota] [nvarchar](500) NULL,
	[SoLuongTonKho] [int] NULL,
	[NhomHanghoaId] [nvarchar](50) NULL
)
GO
CREATE TABLE PhieuBanHang
(
	MaHD VARCHAR(100) NOT NULL PRIMARY KEY,
	Nhanvien NVARCHAR(100),
	Ngaytao date,
	Tongtien int,
	Ghichu NVARCHAR(100),
	TongHangHoa1N int
)
GO
CREATE TABLE PhieuMuaHang
(
	MaHD VARCHAR(100) NOT NULL PRIMARY KEY,
	Khachhang NVARCHAR(100),
	Ngaytao date,
	Tongtien int,
	Ghichu NVARCHAR(100),
	SoLuongMua1N int
)
GO
CREATE TABLE ThuChi
(
	Ngay date,
	Thu int,
	Chi int
)
ALTER TABLE KhachHang
ALTER COLUMN Gioitinh bit
GO
INSERT INTO KhachHang
VALUES('kh01',N'Nguyễn',N'Hoàng',N'Duy','1','nguyenhoangduy1997@gmail.com','01674404746','Q8')

INSERT INTO KhachHang
VALUES('kh02',N'Trần',N'Quang',N'Tiến','1','tranquangtien@gmail.com','0123465789','Q7')

INSERT INTO KhachHang
VALUES('kh03',N'Ngô',N'Vũ',N'Linh','1','ngovulinh@gmail.com','0987654321','Q6')

INSERT INTO NhaCungCap
VALUES('ncc01',N'Pepsi',N'Nước uống','nh002','19001500',N'Q.Thủ Đức')

INSERT INTO NhaCungCap
VALUES('ncc02',N'POCA',N'Snack','nh001','19001870',N'Q.Thủ Đức')

INSERT INTO HangHoaConvert 
VALUES (N'sp001', N'Cocacola', 15000, N'Nước uống', 0, N'nh002');

INSERT INTO HangHoaConvert 
VALUES (N'sp002', N'Nước suối', 12000, NULL, 2, N'nh002');

INSERT INTO HangHoaConvert 
VALUES (N'sp003', N'Mì gói', 7000, NULL, 5, N'nh001');

INSERT INTO HangHoaConvert  
VALUES (N'sp004', N'Test', 25000, NULL, NULL, NULL);

INSERT INTO Nhanvien
VALUES('nv001',N'Nguyễn Hoàng',N'Duy','1997-08-03','2017-11-16')

INSERT INTO Nhanvien
VALUES('nv002',N'Trần Quang',N'Tiến','1997-08-03','2017-11-16')

INSERT INTO Nhanvien
VALUES('nv003',N'Ngô Vũ',N'Linh','1997-08-03','2017-11-16')

INSERT INTO PhieuBanHang
VALUES('pbh001',N'Nguyễn Hoàng Duy','2017-11-16','2000000','','10')

INSERT INTO PhieuBanHang
VALUES('pbh002',N'Trần Quang Tiến','2017-11-20','2000000','','5')

INSERT INTO PhieuBanHang
VALUES('pbh003',N'Ngô Vũ Linh','2017-02-14','2000000','','4')

INSERT INTO PhieuMuaHang
VALUES('pmh001',N'Nguyễn Hoàng Duy','2017-11-16','2000000','','14')

INSERT INTO PhieuMuaHang
VALUES('pmh002',N'Trần Quang Tiến','2017-11-20','2000000','','16')

INSERT INTO PhieuMuaHang
VALUES('pmh003',N'Ngô Vũ Linh','2017-02-14','2000000','','2')

INSERT INTO ThuChi
VALUES('2017-11-16','50000','2000000')

INSERT INTO ThuChi
VALUES('2017-4-16','1500000','50000')

INSERT INTO ThuChi
VALUES('2017-02-14','60000','50000000')