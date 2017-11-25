USE [master]
GO
CREATE DATABASE [QuanlySinhvien]
GO
USE [QuanlySinhvien]
GO

CREATE TABLE [dbo].[Sinhvien](
	[Maso] [nvarchar](50) NOT NULL primary key,
	[Holot] [nvarchar](200) NULL,
	[Ten] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Gioitinh] [bit] NULL
 )

GO
INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv007', N'', N'', CAST(N'2016-05-06 12:52:23.000' AS DateTime), 0);

INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv01', N'Mai', N'Tới', CAST(N'2012-04-30 00:00:00.000' AS DateTime), 0);

INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv02', N'Nguyễn Văn', N'Tèo', CAST(N'2012-03-30 00:00:00.000' AS DateTime), 0);

INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv03', N'Đỗ', N'Mai', CAST(N'2012-02-20 00:00:00.000' AS DateTime), 1);

INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv04', N'add', N'dd', CAST(N'2012-02-21 00:00:00.000' AS DateTime), 1);

INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv05', N'd', N'd', CAST(N'2016-05-11 12:31:47.000' AS DateTime), 0);

INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv06', N'd', N'', NULL, 0);

INSERT [dbo].[Sinhvien] ([Maso], [Holot], [Ten], [Ngaysinh], [Gioitinh]) 
VALUES (N'sv08', N'', N'', NULL, 0);

CREATE TABLE [dbo].[Hanghoa](
	[HanghoaId] [nvarchar](50) NOT NULL primary key,
	[TenHanghoa] [nvarchar](200) NULL,
	[GiaBan] [float] NULL,
	[Mota] [nvarchar](500) NULL,
	[SoLuongTonKho] [int] NULL,
	[NhomHanghoaId] [nvarchar](50) NULL
)
GO
INSERT [dbo].[Hanghoa] ([HanghoaId], [TenHanghoa], [GiaBan], [Mota], [SoLuongTonKho], [NhomHanghoaId]) 
VALUES (N'sp001', N'Cocacola', 15000, N'Nước uống', 0, N'nh002');

INSERT [dbo].[Hanghoa] ([HanghoaId], [TenHanghoa], [GiaBan], [Mota], [SoLuongTonKho], [NhomHanghoaId]) 
VALUES (N'sp002', N'Nước suối', 12000, NULL, 2, N'nh002');

INSERT [dbo].[Hanghoa] ([HanghoaId], [TenHanghoa], [GiaBan], [Mota], [SoLuongTonKho], [NhomHanghoaId]) 
VALUES (N'sp003', N'Mì gói', 7000, NULL, 5, N'nh001');

INSERT [dbo].[Hanghoa] ([HanghoaId], [TenHanghoa], [GiaBan], [Mota], [SoLuongTonKho], [NhomHanghoaId]) 
VALUES (N'sp004', N'Test', 25000, NULL, NULL, NULL);

GO
CREATE TABLE [dbo].[NhomHanghoa](
	[NhomHanghoaId] [nvarchar](50) NOT NULL primary key,
	[TenNhomHanghoa] [nvarchar](200) NULL,
	[Ghichu] [nvarchar](500) NULL
)
GO

INSERT [dbo].[NhomHanghoa] ([NhomHanghoaId], [TenNhomHanghoa], [Ghichu]) 
VALUES (N'nh001', N'Thức ăn', NULL);

INSERT [dbo].[NhomHanghoa] ([NhomHanghoaId], [TenNhomHanghoa], [Ghichu]) 
VALUES (N'nh002', N'Nước uống', N'Không có cồn');
GO

CREATE TABLE [dbo].[Hoadon](
	[HoadonId] [nvarchar](50) NOT NULL primary key,
	[NhanvienId] [nvarchar](50) NULL,
	[NgayHoadon] [datetime] NULL,
	[Tongtien] [float] NULL,
	[Ghichu] [nvarchar](200) NULL
)
GO
CREATE TABLE [dbo].[Nhanvien](
	[NhanvienId] [nvarchar](50) NOT NULL primary key,
	[Holot] [nvarchar](200) NULL,
	[Ten] [nvarchar](200) NULL,
	[Ngaysinh] [datetime] NULL,
	[NgayVaolam] [datetime] NULL
)
GO
CREATE TABLE [dbo].[CTHoadon](
	[CTHoadonId] [nvarchar](50) NOT NULL,
	[HoadonId] [nvarchar](50) NOT NULL,
	[HanghoaId] [nvarchar](50) NULL,
	[TenHanghoa] [nvarchar](200) NULL,
	[Soluong] [float] NULL,
	[Dongia] [float] NULL,
	[Ghichu] [nvarchar](200) NULL,
	primary key (CTHoadonId, HoadonId)
)
GO