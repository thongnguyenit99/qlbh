use master
GO
if (DB_ID('QLBH_Deploy99')) is not  null
	Drop Database QLBH_Deploy99
GO
create database QLBH_Deploy99
GO
use QLBH_Deploy99
GO

-- Tạo Bảng tài khoản
create table TaiKhoan
(
	Id int NOT NULL IDENTITY(1,1),
	UserName varchar(50) NOT NULL,
	Passwd varchar(16) NOT NULL,
	MaNV varchar(10) not null,
	RoleID int NOT NULL,
	ConQuanLy bit,
	Descripttion nvarchar(50),
	Primary key(Id)
)
go

create table NhatKyHeThong
(
	Id int NOT NULL IDENTITY(1,1),
	MaND varchar(10) not null,
	TenMT nvarchar(100),
	ThoiGian datetime,
	ChucNang nvarchar(300),
	HanhDong nvarchar(100),
	DoiTuong nvarchar(100),
	primary key(MaND)
)

-- Tạo bảng nhân viên
create table NhanVien
(
	Id int NOT NULL IDENTITY(1,1),
	MaNV varchar(10) not null,
	TenNV nvarchar(50) not null,
	GioiTinh nchar(3),
	DiaChi nvarchar(100),
	DienThoai varchar(15),
	DiDong varchar(15),
	Email nvarchar(50),
	QuanLy varchar(10),
	BoPhan varchar(10),
	ConQuanLy bit not null
	primary key(MaNV)
)
create table BoPhan
(
	Id int NOT NULL IDENTITY(1,1),
	MaBP varchar(10),
	TenBP nvarchar(100),
	GhiChu nvarchar(100),
	ConQuanLy bit
	primary key(MaBP)
)
-- Tạo bảng RoleUser
create table RoleUser
(
	Id int not null identity(1, 1),
	MaVT varchar(10) not null,
	RoleName nvarchar(50) not null,
	DescriptionName nvarchar(100), 
	KichHoat bit,
	primary key(Id)
)
go

-- Tạo bảng Form 
create table Form
(
	Id int not null identity(1, 1),
	FormName nvarchar(100) not null,
	Descripttion nvarchar(100) not null
	primary key(Id)
)
go
-- Tạo bảng RoleForm
CREATE TABLE RoleForm(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[FormId] [int] NOT NULL,
	[TruyCap] [bit] NOT NULL,
	[Them] [bit] NOT NULL,
	[Sua] [bit] NOT NULL,
	[Xoa] [bit] NOT NULL,
	[In_DL] [bit] NOT NULL,
	[Nhap] [bit] NOT NULL,
	[Xuat] [bit] NOT NULL,
	primary key(Id)
)
-- Tạo bảng Menu
create table MeNuBar
(
	Id int not null identity(1, 1),
	NameMenuBar nvarchar(100),
	Descripttion nvarchar(100)
	primary key(Id)
)
go
-- Tạo Bảng KhuVuc
create table KhuVuc
(
	Id int not null identity(1, 1),
	MaKV varchar(10) not null,
	TenKV nvarchar(30) not null,
	GhiChu nvarchar(200),
	ConQuanLy bit
	primary key(MaKV)
)
-- Tạo bảng loại khách hàng
create table LoaiKhachHang
(
	Id int not null identity(1, 1),
	MaLKH varchar(10) not null,
	TenLKH nvarchar(50) not null,
	Descripttion nvarchar(100),
	ConQuanLy bit,
	primary key(MaLKH)
)
-- Tạo bảng Khách Hàng
create table KhachHang
(
	Id int not null identity(1, 1),
	MaKH varchar(10) not null,
	TenKH nvarchar(150) not null,
	MaKV varchar(10) not null,
	LoaiKH varchar(10) not null,
	NguoiLienHe nvarchar(50),
	DiaChi nvarchar(150),
	MaSoThue varchar(10),
	DienThoai varchar(12),
	DiDong varchar(12),
	Fax char(10),
	Email varchar(50),
	Website varchar(100),
	SoTaiKhoan varchar(25),
	TenNganHang nvarchar(100),
	GioiHanNo float,
	NoHienTai float,
	ChietKhau varchar(3),
	NickYahoo nvarchar(100),
	NickSkype nvarchar(100),
	ConQuanLy bit
	primary key(MaKH)
)
-- Tạo bảng nhà cung cấp
create table NhaCungCap
(
	Id int not null identity(1, 1),
	MaNCC varchar(10) not null,
	TenNCC nvarchar(350) not null,
	MaKV varchar(10) not null,
	NguoiLienHe nvarchar(50),
	DiaChi nvarchar(150),
	MaSoThue varchar(10),
	DienThoai varchar(12),
	DiDong varchar(12),
	Fax char(110),
	Email varchar(150),
	Website varchar(100),
	SoTaiKhoan varchar(25),
	TenNganHang nvarchar(100),
	GioiHanNo float,
	NoHienTai float,
	ChietKhau varchar(3),
	ChucVu nvarchar(100),
	ConQuanLy bit
	primary key(MaNCC)
)
-- Tạo bảng RoleMenubar
create table RoleMenubar
(
	Id int not null identity(1, 1),
	RoleUserId int not null,
	MeNuBarId int not null,
	TrangThai bit
	primary key(Id)
)
go

-- tạo dữ liệu cho bảng user
insert into TaiKhoan(UserName, Passwd, MaNV, RoleID, ConQuanLy) 
values ('Hadestran', '', 'NV000001', 1, 1),
	   ('ThongNguyen', '', 'NV000005', 2, 1),
	   ('HaiCao', '', 'NV000006', 3, 1)
go

-- Tạo bảng khi hàng
create table KhoHang
(
	Id int not null identity(1, 1),
	MaKH varchar(10) not null,
	TenKH nvarchar(100) not null,
	NguoiQuanLy varchar(10),
	KyHieu varchar(20),
	NguoiLienHe nvarchar(50),
	DiaChi nvarchar(200),
	DienThoai varchar(12),
	Fax varchar(12),
	Email varchar(50),
	DienGiai nvarchar(100),
	ConQuanLy bit
	primary key (MaKH)
)
-- Tạo bảng DonViTinh
create table DonViTinh
(
	Id int not null identity(1, 1),
	MaDVT varchar(10) not null,
	TenDVT nvarchar(30) not null,
	GhiChu nvarchar(100),
	ConQuanLy bit
	primary key(MaDVT)
)
-- Tạo bảng Nhóm hàng
create table NhomHang
(
	Id int not null identity(1, 1),
	Ma_NH varchar(10) not null,
	Ten_NH nvarchar(30) not null,
	GhiChu nvarchar(100),
	ConQuanLy bit
	primary key(Ma_NH)
)

-- Tạo bảng Giá Bán
create table GiaBan
(
	Id int not null identity(1, 1),
	Ten nvarchar(50) not null
	primary key (Id)
)
-- Tạo bảng loại hàng hóa
create table LoaiHangHoa
(
	Id int not null identity(1, 1),
	MaLHH varchar(10) not null,
	TenLHH nvarchar(100) not null,
	primary key(MaLHH)
)

-- tao bảng Phiếu nhập hàng
create table PhieuNhapHang
(
	Id int not null identity(1, 1),
	MaPNH varchar(30) not null,
	MaNV varchar(10) not null,
	MaNCC varchar(10) not null,
	DiaChi nvarchar(255),
	GhiChu nvarchar(255),
	MaKho varchar(10) not null,
	SoVAT varchar(10),
	SoPhieuVT varchar(10),
	DK_ThanhToan varchar(10) not null,
	HT_ThanhToan varchar(10) not null,
	HanThanhToan date,
	NgayLap date not null,
	VAT varchar(10),
	CK varchar(10),
	TongThanhTien int,
	IsDaThanhToan bit,
	primary key(MaPNH)
)
-- tạo bảng chi tiết phiếu nhập hàng
create table CT_PhieuNhapHang
(
	Id int not null identity(1, 1),
	MaPhieuNhapHang varchar(30) not null,
	MaSanPham varchar(10) not null,
	TenSanPham nvarchar(255) not null,
	SoLuong int not null,
	DonVi nvarchar(30),
	DonGia float,
	ThanhTien float,
	GhiChu nvarchar(100),
	primary key(Id, MaPhieuNhapHang)
)
-- tạo bảng danh sách phiếu chi
create table DanhSachPhieuChi
(
	Id int not null identity(1, 1),
	MaPC varchar(30) not null,
	MaPNH varchar(30) not null,
	NgayLap date,
	MaNCC varchar(10),
	TenNCC nvarchar(300),
	TongTien float,
	GhiChu nvarchar(300)
	primary key(MaPC)
)

-- tạo bảng Điều Khoản Thanh toán
create table DK_ThanhToan
(
	Id int not null identity(1, 1),
	MaDKTT varchar(10) not null,
	TenDKTT nvarchar(100) not null
	primary key (MaDKTT)
)
-- tạo bảng Hình Thức Thanh toán
create table HT_ThanhToan
(
	Id int not null identity(1, 1),
	MaHHTT varchar(10) not null,
	TenHHTT nvarchar(100) not null
	primary key (MaHHTT)
)

-- tạo dữ liệu cho bảng RoleUser
insert into RoleUser(MaVT, RoleName, DescriptionName, KichHoat) 
values 
('Admin', 'Admin', 'Admin', 1),
('VT00001', N'Quản lý Nhân viên', N'Nhân viên quản lý', 1),
('VT00002', N'Nhân viên', N'Nhân viên công ty', 1)
-- Tạo bảng hàng hóa
create table HangHoa
(
	Id int not null identity(1, 1),
	MaHH varchar(10) not null,
	TenHH nvarchar(100) not null,
	MaDV varchar(10) not null,
	MaNH varchar(10) not null,
	MaLHH varchar(10) not null,
	MaKho varchar(10) not null,
	MaVachNSX varchar(20),
	XuatXu nvarchar(30),
	TonKhoToiThieu int,
	TonKhoHienTai int,
	Anh nvarchar(255),
	MaNCC varchar(10),
	GiaMua float,
	GiaBanLe float,
	GiaBanSi float,
	IsDelete bit not null,
	ConQuanLy bit,
	primary key (MaHH, MaKho)
)
-- tạo bảng chuyển kho
create table ChuyenKho
(
	Id int not null identity(1, 1),
	MaCK varchar(50) not null,
	MaPVT varchar(10),
	KhoXuatHang varchar(10),
	KhoNhanHang varchar(10),
	NguoiChuyen varchar(10),
	NguoiNhan varchar(10),
	GhiChu nvarchar(300),
	NgayChuyen date,
	SL_HangChuyen int,
	TongTien int,
	primary key(MaCK)
)
-- Tạo bảng Chi Tiết Chuyển Kho
create table CT_ChuyenKho
(
	Id int not null identity(1, 1),
	MaPhieuChuyenKho varchar(50),
	MaSanPham varchar(10),
	TenSanPham nvarchar(500),
	DonVi nvarchar(100),
	SoLuong int,
	DonGia float,
	ThanhTien float,
	primary key(Id, MaPhieuChuyenKho)

)
create table CT_ChuyenKho_Ao
(
	MaHang varchar(10),
	TenHang nvarchar(500),
	DonVi nvarchar(100),
	SoLuong int,
	DonGia float,
	ThanhTien float,
)

-- Tạo bảng tỷ giá
create table TyGia
(
	Id int not null identity(1, 1),
	MaTG varchar(10) not null,
	TenTG nvarchar(50) not null,
	TyGiaQD float not null,
	ConQuanLy bit
	primary key (Id, MaTG)
)
-- tạo dữ liệu bảng Menu bar
insert into MeNuBar(NameMenuBar, Descripttion) values
(N'Hệ thống', N'Nhóm menu hệ thống.'),
(N'Danh mục', N'Nhóm menu danh mục.'),
(N'Chức năng', N'Nhóm menu chức năng.'),
(N'Trợ giúp', N'Nhóm menu trợ giúp.')
go
-- Tạo bảng ảo
create table ChiTietHoaDonAo_MH
(
	[Mã Hàng] varchar(10),
	[Tên Hàng] nvarchar(100),
	[Đơn Vị] nvarchar(100),
	[Số Lượng] int,
	[Đơn Giá] float,
	[Thành Tiền] float,
	[Ghi Chú] nvarchar(300)
)

-- Tạo bảng Phiếu bán Hàng
create table PhieuBanHang
(
	Id int not null identity(1, 1),
	MaPBH varchar(30) not null,
	MaNV varchar(10) not null,
	MaKH varchar(10) not null,
	DiaChi nvarchar(355),
	GhiChu nvarchar(355),
	MaKho varchar(10) not null,
	SoVAT nvarchar(10),
	SoPhieuVT nvarchar(10),
	DK_ThanhToan varchar(10),
	HT_ThanhToan varchar(10),
	HanThanhToan date,
	NgayGiao date,
	NgayLap date,
	VAT nvarchar(10),
	CK nvarchar(10),
	TongThanhTien int,
	IsDaThuTien bit
	primary key(MaPBH)
)
-- Tạo bảng CT_Phiếu_Mua_Hàng
create table CT_Phieu_Ban_Hang
(
	Id int not null identity(1, 1),
	ViTri int,
	MaPhieuBanHang varchar(30) not null,
	MaSanPham varchar(10) not null,
	TenSanPham nvarchar(255) not null,
	LoaiGia int,
	DonVi nvarchar(30),
	SoLuong int not null,
	DonGia float,
	ThanhTien float,
	CK float,
	ChietKhau  float,
	ThanhToan float,
	primary key(Id, MaPhieuBanHang)
)
-- taobj bảng phiếu thu
create table DanhSachPhieuThu
(
	Id int not null identity(1, 1),
	MaPT varchar(30) not null,
	MaPBH varchar(30) not null,
	NgayLap date,
	MaKH varchar(10),
	TenKH nvarchar(300),
	TongTien float,
	GhiChu nvarchar(300)
	primary key(MaPT)
)
create table CT_PhieuBanHang_AO
(
	[Mã Hàng] varchar(10),
	[Tên Hàng] nvarchar(300),
	[Đơn Vị] nvarchar(40),
	[Loại Giá] int,
	[Số Lượng] int,
	[Đơn Giá] float,
	[Thành Tiền] float,
	CK float,
	[Chiết Khấu] float,
	[Thanh Toán] float,
)

-- Tạo dữ liệu bảng RoleMenuBar
insert into RoleMenubar (RoleUserId, MeNuBarId, TrangThai) values
(1, 1, 1),
(1, 2, 1),
(1, 3, 1),
(1, 4, 1),
(2, 1, 1),
(2, 2, 1),
(2, 3, 1),
(2, 4, 1),
(3, 1, 1),
(3, 2, 1),
(3, 3, 1),
(3, 4, 1)
go
-- Tạo dữ liệu cho bảng form
--SET IDENTITY_INSERT [dbo].[Form] ON 
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (1, N'ThongTin', N'Form thông tin phần mềm.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (2, N'Phan Quyen', N'Form để admin phân quyền.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (3, N'DoiMauKhau', N'Form đổi mật khẩu.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (4, N'NhatKyHeThong', N'Form ghi lại nhật ký hệ thống.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (5, N'SaoLuu', N'Form sao lưu.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (6, N'PhucHoi', N'Form phục hồi.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (7, N'SuaChua', N'Form sửa chữa.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (8, N'KetChuyen', N'Form kết chuyển.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (9, N'NhapTuExcel', N'Form danh mục từ file excel.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (10, N'KhuVuc', N'Form thông tin khu vực.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (11, N'KhachHang', N'Form thông tin khách hàng.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (12, N'NhaCungCap', N'Form nhà cung cấp.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (13, N'KhoHang', N'Form kho hàng.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (14, N'DonViTinh', N'Form đơn vị tính.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (15, N'NhomHang', N'Form Nhóm hàng.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (16, N'HangHoa', N'Form hàng hóa.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (17, N'InMaVach', N'Form in mã vạch.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (18, N'TyGia', N'Form tý giá.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (19, N'BoPhan', N'Form bộ phận.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (20, N'NhanVien', N'Form nhân viên.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (21, N'MuaHang', N'Form mua hàng.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (22, N'BanHang', N'Form bán hàng.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (23, N'TonKho', N'Form tồn kho')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (24, N'ChuyenKho', N'Form chuyển kho.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (25, N'NhapSoDuDauKy', N'Form nhập số dư đầu kỳ.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (26, N'ThuTien', N'Form thu tiền.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (27, N'TraTien', N'Form trả tiền.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (28, N'BaoCaoKhachHang', N'Form báo cáo khách hàng.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (29, N'BaoCaoKhoHang', N'Form báo cáo kho hàng.')
--INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (30, N'ChungTu', N'Form chứng từ.')

SET IDENTITY_INSERT [dbo].[Form] ON 
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (1, N'Thông Tin', N'Form thông tin phần mềm.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (2, N'Phân Quyền', N'Form để admin phân quyền.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (3, N'Đổi Mật Khẩu', N'Form đổi mật khẩu.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (4, N'Nhật Ký Hệ Thống', N'Form ghi lại nhật ký hệ thống.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (5, N'Sao Lưu', N'Form sao lưu.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (6, N'Phục Hồi', N'Form phục hồi.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (7, N'Sửa Chữa', N'Form sửa chữa.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (8, N'Kết Chuyển', N'Form kết chuyển.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (9, N'Nhập từ Excel', N'Form danh mục từ file excel.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (10, N'Khu Vực', N'Form thông tin khu vực.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (11, N'Khách Hàng', N'Form thông tin khách hàng.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (12, N'Nhà Cung Cấp', N'Form nhà cung cấp.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (13, N'Kho Hàng', N'Form kho hàng.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (14, N'Đơn Vị Tính', N'Form đơn vị tính.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (15, N'Nhóm Hàng', N'Form Nhóm hàng.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (16, N'Hàng Hóa', N'Form hàng hóa.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (17, N'In Mã Vạch', N'Form in mã vạch.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (18, N'Tỷ Giá', N'Form tý giá.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (19, N'Bộ Phận', N'Form bộ phận.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (20, N'Nhân Viên', N'Form nhân viên.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (21, N'Mua Hàng', N'Form mua hàng.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (22, N'Bán Hàng', N'Form bán hàng.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (23, N'Tồn Kho', N'Form tồn kho')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (24, N'Chuyển Kho', N'Form chuyển kho.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (25, N'Nhập Số Dư Đầu Kỳ', N'Form nhập số dư đầu kỳ.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (26, N'Thu Tiền', N'Form thu tiền.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (27, N'Trả Tiền', N'Form trả tiền.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (28, N'Báo Cáo Khách Hàng', N'Form báo cáo khách hàng.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (29, N'Báo Cáo Kho Hàng', N'Form báo cáo kho hàng.')
INSERT [dbo].[Form] ([Id], [FormName], [Descripttion]) VALUES (30, N'Chứng Từ', N'Form chứng từ.')

-- tao dữ liệu cho bảng roleform
SET IDENTITY_INSERT [dbo].[Form] OFF
SET IDENTITY_INSERT [dbo].[RoleForm] ON 
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (2, 1, 2, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (3, 1, 3, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (4, 1, 4, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (5, 1, 5, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (6, 1, 6, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (7, 1, 7, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (8, 1, 8, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (9, 1, 9, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (10, 1, 10, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (11, 1, 11, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (12, 1, 12, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (13, 1, 13, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (14, 1, 14, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (15, 1, 15, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (16, 1, 16, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (17, 1, 17, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (18, 1, 18, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (19, 1, 19, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (20, 1, 20, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (21, 1, 21, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (22, 1, 22, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (23, 1, 23, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (24, 1, 24, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (25, 1, 25, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (26, 1, 26, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (27, 1, 27, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (28, 1, 28, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (29, 1, 29, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (30, 1, 30, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (31, 2, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (32, 2, 2, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (33, 2, 3, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (34, 2, 4, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (35, 2, 5, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (36, 2, 6, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (37, 2, 7, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (38, 2, 8, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (39, 2, 9, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (40, 2, 10, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (41, 2, 11, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (42, 2, 12, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (43, 2, 13, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (44, 2, 14, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (45, 2, 15, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (46, 2, 16, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (47, 2, 17, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (48, 2, 18, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (49, 2, 19, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (50, 2, 20, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (51, 2, 21, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (52, 2, 22, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (53, 2, 23, 1, 0, 0, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (54, 2, 24, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (55, 2, 25, 1, 0, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (56, 2, 26, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (57, 2, 27, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (58, 2, 28, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (59, 2, 29, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (60, 2, 30, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (61, 3, 1, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (62, 3, 2, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (63, 3, 3, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (64, 3, 4, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (65, 3, 5, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (66, 3, 6, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (67, 3, 7, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (68, 3, 8, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (69, 3, 9, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (70, 3, 10, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (71, 3, 11, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (72, 3, 12, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (73, 3, 13, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (74, 3, 14, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (75, 3, 15, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (76, 3, 16, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (77, 3, 17, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (78, 3, 18, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (79, 3, 19, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (80, 3, 20, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (81, 3, 21, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (82, 3, 22, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (83, 3, 23, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (84, 3, 24, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (85, 3, 25, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (86, 3, 26, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (87, 3, 27, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (88, 3, 28, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (89, 3, 29, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleForm] ([Id], [RoleId], [FormId], [TruyCap], [Them], [Sua], [Xoa], [In_DL], [Nhap], [Xuat]) VALUES (90, 3, 30, 0, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[RoleForm] OFF 
 --tạo dữ liêu cho bảng nhân viên
insert into NhanVien (MaNV, TenNV, GioiTinh, DienThoai, DiDong, Email, BoPhan, ConQuanLy)
values
('NV000001', N'Nguyễn Thị Minh  Huệ', N'Nam', '0946 980 408', '0946 980 408', 'huenguyen@hptvn.com', 'GD', 1),
('NV000002', N'Phan Quang Thông', N'Nam', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', 'KD', 1),
('NV000003', N'Nguyễn Hoàng Dũng', N'Nam', '0946 980 407', '0946 980 407', 'hoangdung@hptvn.com	', 'KTH', 1),
('NV000004', N'Vũ Anh Tuấn', N'Nam', '0909 668 443', '0909 668 443', 'director@hptvn.com', 'KT', 1),
('NV000005', N'Huỳnh Thị Ngọc Lãnh', N'Nam', '0914 181 101', '0914 181 101', 'ketoan@hptvn.com', 'KD', 1),
('NV000006', N'Phạm Bảo Trung', N'Nam', '01207 512 093', '01207 512 093', '', 'KD', 1),
('NV000007', N'Phạm Thành Sơn', N'Nam', '0908 270 382', '0908 270 382', '', 'KD', 1),
('NV000008', N'Huỳnh Ngọc Trung', N'Nam', '01689 977 218', '01689 977 218', '', 'KD', 1),
('NV000009', N'Đoàn Thị Thu Thảo', N'Nam', '01668 777 006', '01668 777 006', 'thaodoan@hptvn.com', 'KD', 1)
-- tạo dữ liệu cho bảng bộ phân
insert into BoPhan(MaBP, TenBP, ConQuanLy)
values
('GD', N'Giám đốc', 1),
('KD', 'Phòng Kinh Doanh', 1),
('KT', N'Phòng Kế Toán', 1),
('KTH', N'Phòng kỹ thuật', 1)
-- tao dữ liệu bảng khu vực
insert into KhuVuc (MaKV, TenKV, ConQuanLy) 
values
('KV000001', N'Miền Bắc', 1),
('KV000002', N'Miền Trung', 1),
('KV000003', N'Miền Nam', 1)

-- Tạo dữ liệu bảng LoaiKhachHang
insert into LoaiKhachHang(MaLKH, TenLKH, ConQuanLy)
values
('DL', N'Đại lý', 1),
('KL', N'Khách lẻ', 1)
-- Tạo dữ liệu cho bảng khách hàng
insert into KhachHang(MaKH, TenKH, MaKV, LoaiKH)
values
('KH000001', N'Công ty Quang Phúc', 'KV000001', 'DL'),
('KH000002', N'Công ty trần hoàng duy', 'KV000001', 'DL'),
('KH000003', N'Chị Liễu Bình Dương', 'KV000001', 'DL'),
('KH000004', N'Công  ty Đăng Quang', 'KV000001', 'DL'),
('KH000005', N'CTY Trương Sỏi', 'KV000001', 'DL'),
('KH000006', N'CTY Khuôn Máy Việt', 'KV000002', 'DL'),
('KH000007', N'CTY Tin Học Trung Trực', 'KV000002', 'DL'),
('KH000008', N'CO.OP MART Rạch Miễu', 'KV000002', 'DL'),
('KH000009', N'Công ty Nam Phương', 'KV000002', 'DL'),
('KH000010', N'Công ty Thu Thanh -Q12', 'KV000002', 'DL'),
('KH000011', N'Dũng_ Tý', 'KV000003', 'KL'),
('KH000012', N'Tuấn_BIDV', 'KV000003', 'KL'),
('KH000013', N'Tuấn_Ngọc Phát', 'KV000003', 'KL'),
('KH000014', N'A Trang Hitech', 'KV000003', 'KL'),
('KH000015', N'Huệ_GPS Thủ Đức', 'KV000003', 'KL'),
('KH000016', N'Thông_ anh An 451 Hai Bà Trưng', 'KV000003', 'KL'),
('KH000017', N'Anh Lực đại lý', 'KV000003', 'KL'),
('KH000018', N'Anh Nguyễn Ngân', 'KV000003', 'KL'),
('KH000019', N'Anh Phú', 'KV000003', 'KL'),
('KH000020', N'Anh Chính D2 Bình Thạnh', 'KV000003', 'KL')

update KhachHang set DiaChi = N'Trại giam chí hòa 123', DienThoai = '0999888999', ChietKhau = '1 %'

-- Thêm nhà cung cấp
insert into NhaCungCap(MaNCC, TenNCC, MaKV, ConQuanLy)
values
('NCC000001', N'Công ty CP Minh An', 'KV000001', 1),
('NCC000002', N'Công ty TNHH TMDV Sao Việt', 'KV000001', 1),
('NCC000003', N'Công ty TNHH MTV Thiên An Phát', 'KV000001', 1),
('NCC000004', N'Công ty Cổ Phần Biển Bạc', 'KV000001', 1),
('NCC000005', N'Công ty TNHH TMDV Công Nghệ Chí Cường', 'KV000001', 1),
('NCC000006', N'Công ty CP SX TM & DV tin học xây dựng NaNo', 'KV000002', 1),
('NCC000007', N'Công ty TNHH MTV Quản trị mạng Quang Phát', 'KV000002', 1),
('NCC000008', N'Công ty TNHH Công nghệ Tân Quân', 'KV000002', 1),
('NCC000009', N'Nhập khẩu', 'KV000002', 1),
('NPP0001', N'Cty Kim Đạt', 'KV000002', 1),
('NPP0002', N'Công ty CP Thế Giới Di Động', 'KV000002', 1),
('NPP0003', N'Công ty TNHH TM TC Samsung', 'KV000003', 1),
('NPP0004', N'Công ty CP Quốc tế Viễn Tín', 'KV000003', 1),
('NPP0005', N'Công ty CP TM Công Nghệ Điện Tử Viễn Thông TES', 'KV000003', 1),
('NPP0006', N'Công ty CP Quốc tế Việt Khang', 'KV000003', 1),
('NPP0007', N'CN Công ty TNHH Vĩnh Tín', 'KV000003', 1),
('NPP0008', N'Công ty TNHH TM Phát triển Kỹ Thuật', 'KV000003', 1),
('NPP0009', N'Công ty Huyền Vũ', 'KV000003', 1),
('NPP0010', N'Công ty MINH NGỌC', 'KV000003', 1)

update NhaCungCap set DiaChi = N'Hades tran bóng mà nhà trắng', ChietKhau = '1 %', DienThoai = '113-114-115'

-- tạo dữ liệu bảng kho hàng
insert into KhoHang (MaKH, TenKH, ConQuanLy)
values
('CT1', N'Kho công ty', 1),
('CT2', N'Kho hà nội', 1),
('CT3', N'Kho phạm Văn Hai', 1),
('K000001', N'Kho 6 HCM', 1)

-- tạo dữu liệu cho bảng dơn vị tính
insert into DonViTinh (MaDVT, TenDVT, ConQuanLy)
values
('DV01', N'bình', 1),
('DV02', N'bộ', 1),
('DV03', N'cái', 1),
('DV04', N'cặp', 1),
('DV05', N'con', 1),
('DV06', N'cục', 1),
('DV07', N'chai', 1),
('DV08', N'dây', 1),
('DV09', N'gói', 1),
('DV10', N'kg', 1),
('DV11', N'lon', 1),
('DV12', N'hộp', 1),
('DV13', N'khúc', 1),
('DV14', N'lít', 1),
('DV15', N'm2', 1),
('DV16', N'mét', 1),
('DV17', N'ống', 1),
('DV18', N'que', 1),
('DV19', N'sợi', 1),
('DV20', N'tờ', 1),
('DV21', N'thùng', 1)

-- tao dư liệu bảng nhóm hàng
insert into NhomHang(Ma_NH, Ten_NH, ConQuanLy)
values
('ANS', N'An ninh siêu thị', 1),
('BAT', N'Báo trộm, báo cháy', 1),
('CAM', N'Camera quan sát', 1),
('CARCAM', N'Camera ghi hình', 1),
('CHA', N'Máy chấm công', 1),
('CHM', N'Chương cửa màn hình', 1),
('DAC', N'Dây cáp', 1),
('DAG', N'Đầu ghi', 1),
('NH000001', N'Hàng cũ', 1),
('NH000002', N'Secure Display', 1),
('OCU', N'Ổ cúng', 1),
('TBK', N'Thiết bị Khác', 1),
('TBV', N'Thiết vị định vị', 1),
('TDKL', N'Tay dò kim loại', 1)

-- tạo du lieu bang loại hang hoa
insert into LoaiHangHoa (MaLHH, TenLHH)
values
('HH', N'Hàng Hóa'),
('DV', N'Dịch Vụ')

-- tạo dữ liệu cho bảng hàng hóa
insert into HangHoa(MaHH, TenHH, MaDV, GiaMua, GiaBanSi, GiaBanLe, TonKhoToiThieu, MaLHH, MaKho, MaNH, TonKhoHienTai, IsDelete, ConQuanLy)
values
('TBK0001', N'USB DVR', 'DV03',2000, 5000, 4000, 0, 'HH', 'CT1', 'TBK', 10, 0, 1),
('TBK0002', N'Swicht TP link 8 port', 'DV03', 2500, 2000, 4000, 0, 'HH', 'CT1', 'TBK', 10, 0,  1),
('TBK0003', N'Swicht TP link 5 port', 'DV03', 200, 13000, 500, 0, 'HH', 'CT1', 'TBK', 10, 0,  1),
('TBK0004', N'Tay dò kim loại MD-3003B1', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT1', 'TBK', 10, 0,  1),
('TBK0005', N'Tay dò kim loại Mỹ', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT1', 'TBK', 10, 0,  1),
('TBK0006', N'Bộ chuyển đổi 258', 'DV03',  2000, 3000, 5000, 0, 'HH', 'CT1', 'TBK', 10, 0,  1),
('TBK0007', N'Chân đế nhôm tròn nhỏ QTA J303', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT1', 'TBK', 10, 0, 1),
('TBK0008', N'Chân đế LiLin PIH 5004', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT1', 'TBK', 10, 0, 1),
('TBK0009', N'Chân đế inox loại trung QTA J201T', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT2', 'TBK', 10, 0, 1),
('TBK0010', N'Chân đế cố định J205', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT2', 'TBK', 10, 0,  1),
('TBK0011', N'Jack AV', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT2', 'TBK', 10, 0,  1),
('TBK0012', N'Đầu JACK BNC', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT2', 'TBK', 10, 0,  1),
('TBK0013', N'Jack F5', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT2', 'TBK', 10, 0,  1),
('TBK0014', N'POE LAN BEP-101', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT2', 'TBK', 10, 0,  1),
('TBK0015', N'Balun', 'DV03', 2000, 3000, 5000, 0, 'HH', 'CT2', 'TBK', 10, 0,  1)

-- tao dữ liệu bảng tỷ giá
insert into TyGia (MaTG, TenTG, TyGiaQD, ConQuanLy)
values
('VND', N'Việt năm đồng', 1, 1),
('USD', N'Dola My', 23.250, 1),
('GBP', N'Bang Anh', 30.452, 1),
('EUR', N'Euro', 26.560, 1)

-- tao dữ liệu cho bảng diều kiên thanh toán
insert into DK_ThanhToan (MaDKTT, TenDKTT)
values
('DKTT01', N'Công nợ'),
('DKTT02', N'Thanh toán ngay')
--tạo dữ lệu bảng Hình thức thanh toán
insert into HT_ThanhToan(MaHHTT, TenHHTT)
values
('HTTT01', N'Tiền mặt'),
('HTTT02', N'Chuyển khoản')

-- Tạo dữ liệu Bảng giá bán
insert into GiaBan(Ten)
values
(N'Giá Mua'),
(N'Giá bán Sỉ'),
(N'Giá Bán Lẻ'),
(N'Giá Khác')

go
-- Nối Khóa Ngoại
-- Tạo Khóa Ngoại Bảng Tài Khoản
ALTER TABLE TaiKhoan

ADD
	CONSTRAINT TK_RoleUser
	FOREIGN KEY(RoleID)
	REFERENCES RoleUser
GO
ALTER TABLE TaiKhoan

ADD
	CONSTRAINT TK_NV
	FOREIGN KEY(MaNV)
	REFERENCES NhanVien
GO

-- Tạo Khóa Ngoại Bảng RoleForm
ALTER TABLE RoleForm

ADD
	CONSTRAINT RF_RS
	FOREIGN KEY(RoleId)
	REFERENCES RoleUser
GO
ALTER TABLE RoleForm

ADD
	CONSTRAINT RF_FRM
	FOREIGN KEY(FormId)
	REFERENCES Form(Id)
GO
-- Tạo khóa ngoại cho bảng RoleMenubar
ALTER TABLE RoleMenubar
ADD
	CONSTRAINT RMNB_RUS
	FOREIGN KEY(RoleUserId)
	REFERENCES RoleUser(Id)
GO
ALTER TABLE RoleMenubar

ADD
	CONSTRAINT RMNB_MNB
	FOREIGN KEY(MeNuBarId)
	REFERENCES MeNuBar(Id)
GO
-- Tạo khóa ngoại cho bảng Hàng Hóa
ALTER TABLE HangHoa
ADD
	CONSTRAINT HH_DV
	FOREIGN KEY(MaDV)
	REFERENCES DonViTinh(MaDVT)
GO

ALTER TABLE HangHoa
ADD
	CONSTRAINT HH_NhomHang
	FOREIGN KEY(MaNH)
	REFERENCES NhomHang(Ma_NH)
GO

ALTER TABLE HangHoa
ADD
	CONSTRAINT HH_LHH
	FOREIGN KEY(MaLHH)
	REFERENCES LoaiHangHoa(MaLHH)
GO

ALTER TABLE HangHoa
ADD
	CONSTRAINT HH_KhoHang
	FOREIGN KEY(MaKho)
	REFERENCES KhoHang(MaKH)
GO

ALTER TABLE HangHoa
ADD
	CONSTRAINT HH_NCC
	FOREIGN KEY(MaNCC)
	REFERENCES NhaCungCap(MaNCC)
GO
-- Tạo khóa ngoại cho bảng KhachHang
ALTER TABLE KhachHang
ADD
	CONSTRAINT KH_KhuVuc
	FOREIGN KEY(MaKV)
	REFERENCES KhuVuc(MaKV)
GO

ALTER TABLE KhachHang
ADD
	CONSTRAINT KH_LKH
	FOREIGN KEY(LoaiKH)
	REFERENCES LoaiKhachHang(MaLKH)
GO
-- Tạo khóa ngoại cho bảng Nhân Viên
ALTER TABLE NhanVien
ADD
	CONSTRAINT NV_BP
	FOREIGN KEY(BoPhan)
	REFERENCES BoPhan(MaBP)
GO

-- Tạo khóa ngoại cho bảng PhieuNhapHang
ALTER TABLE PhieuNhapHang
ADD
	CONSTRAINT PNH_NV
	FOREIGN KEY(MaNV)
	REFERENCES NhanVien(MaNV)
GO

ALTER TABLE PhieuNhapHang
ADD
	CONSTRAINT PNH_NCC
	FOREIGN KEY(MaNCC)
	REFERENCES NhaCungCap(MaNCC)
GO

ALTER TABLE PhieuNhapHang
ADD
	CONSTRAINT PNH_KhoHang
	FOREIGN KEY(MaKho)
	REFERENCES KhoHang(MaKH)
GO

ALTER TABLE PhieuNhapHang
ADD
	CONSTRAINT PNH_DKTT
	FOREIGN KEY(DK_ThanhToan)
	REFERENCES DK_ThanhToan(MaDKTT)
GO

ALTER TABLE PhieuNhapHang
ADD
	CONSTRAINT PNH_HTTT
	FOREIGN KEY(HT_ThanhToan)
	REFERENCES HT_ThanhToan(MaHHTT)
GO

-- Tạo khóa ngoại cho bảng CT_PhieuNhapHang
ALTER TABLE CT_PhieuNhapHang
ADD
	CONSTRAINT CT_PNH_PNHang
	FOREIGN KEY(MaPhieuNhapHang)
	REFERENCES PhieuNhapHang(MaPNH)
GO

--ALTER TABLE CT_PhieuNhapHang
--ADD
--	CONSTRAINT CT_PNH_HH
--	FOREIGN KEY(id, MaSanPham)
--	REFERENCES HangHoa(id, MaHH)
--GO
-- Tạo khóa ngoại cho bảng DanhSachPhieuChi
ALTER TABLE DanhSachPhieuChi
ADD
	CONSTRAINT DSPC_PNH
	FOREIGN KEY(MaPNH)
	REFERENCES PhieuNhapHang(MaPNH)
GO

ALTER TABLE DanhSachPhieuChi
ADD
	CONSTRAINT DSPC_NCC
	FOREIGN KEY(MaNCC)
	REFERENCES NhaCungCap(MaNCC)
GO

-- tạo khóa ngoại bảng phiếu bán hàng
ALTER TABLE PhieuBanHang
ADD
	CONSTRAINT PBH_NV
	FOREIGN KEY(MaNV)
	REFERENCES NhanVien(MaNV)
GO

ALTER TABLE PhieuBanHang
ADD
	CONSTRAINT PBH_KH
	FOREIGN KEY(MaKH)
	REFERENCES KhachHang(MaKH)
GO

ALTER TABLE PhieuBanHang
ADD
	CONSTRAINT PBH_KhoHang
	FOREIGN KEY(MaKho)
	REFERENCES KhoHang(MaKH)
GO

ALTER TABLE PhieuBanHang
ADD
	CONSTRAINT PBH_DKTT
	FOREIGN KEY(DK_ThanhToan)
	REFERENCES DK_ThanhToan(MaDKTT)
GO

ALTER TABLE PhieuBanHang
ADD
	CONSTRAINT PBH_HTTT
	FOREIGN KEY(HT_ThanhToan)
	REFERENCES HT_ThanhToan(MaHHTT)
GO

-- tạo khóa ngoại bảng CT_phiếu bán hàng
ALTER TABLE CT_Phieu_Ban_Hang
ADD
	CONSTRAINT CTPBH_PBH
	FOREIGN KEY(MaPhieuBanHang)
	REFERENCES PhieuBanHang(MaPBH)
GO

--ALTER TABLE CT_Phieu_Ban_Hang
--ADD
--	CONSTRAINT CTPBH_HH
--	FOREIGN KEY(id, MaSanPham)
--	REFERENCES HangHoa
--GO

-- tạo khóa ngoại bảng DanhSachPhieuThu
ALTER TABLE DanhSachPhieuThu
ADD
	CONSTRAINT DSPT_PBH
	FOREIGN KEY(MaPBH)
	REFERENCES PhieuBanHang(MaPBH)
GO


ALTER TABLE DanhSachPhieuThu
ADD
	CONSTRAINT DSPT_KH
	FOREIGN KEY(MaKH)
	REFERENCES KhachHang(MaKH)
GO

select * from ChuyenKho
select * from CT_ChuyenKho where MaPhieuChuyenKho like '{0}'
select * from CT_ChuyenKho_Ao
delete CT_ChuyenKho_Ao




