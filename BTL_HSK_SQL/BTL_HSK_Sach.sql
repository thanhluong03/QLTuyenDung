CREATE DATABASE BTL_HSK_QLSach
GO
USE BTL_HSK_QLSach
GO
CREATE TABLE tblUser 
(
	sTenDangNhap varchar(50) not null,
	sMatKhau varchar(50) not null
)

GO 
--2
CREATE TABLE tblTheLoai
(
	sMaLoai VARCHAR(10) NOT NULL PRIMARY KEY,
	sTheLoai NVARCHAR(50) NOT NULL
)

GO

--4
CREATE TABLE tblNhaXuatBan
(
	sMaNXB VARCHAR(20) NOT NULL PRIMARY KEY,
	sTenNXB NVARCHAR(50) NOT NULL,
	sDiaChi NVARCHAR(100) NOT NULL,
	sSDT VARCHAR(10) NOT NULL
)

GO
CREATE TABLE tblSach
(
	sMaSach VARCHAR(10) NOT NULL PRIMARY KEY,
	sTenSach NVARCHAR(100) NOT NULL,
	sMaLoai VARCHAR(10) NOT NULL,
	sTacGia NVARCHAR(20) NOT NULL,
	fDonGia FLOAT NULL,
	FOREIGN KEY (sMaLoai) REFERENCES dbo.tblTheLoai(sMaLoai),
	sMaNXB VARCHAR(20) NOT NULL,
	FOREIGN KEY (sMaNXB) REFERENCES dbo.tblNhaXuatBan(sMaNXB),
	iSoLuong INT null 
)
GO
--3
CREATE TABLE tblNhanVien
(
	sMaNV VARCHAR(20) NOT NULL PRIMARY KEY,
	sTenNV NVARCHAR(50) NOT NULL,
	sDiaChi NVARCHAR(100) NULL,
	dNgaySinh DATE NULL,
	dNgayVaoLam DATE NOT NULL,
	sSDT VARCHAR(10) NOT NULL,
)

GO
--5
CREATE TABLE tblKhachHang
(
	sMaKH VARCHAR(20) NOT NULL PRIMARY KEY,
	sTenKH NVARCHAR(50),
	sDiaChi NVARCHAR(100),
	dNgaySinh DATE,
	sSDT VARCHAR(10),
)

GO 
--6

--7
CREATE TABLE tblHoaDon 
(
	iSoHD int NOT NULL PRIMARY KEY,
	sMaNV VARCHAR(20) NOT NULL,
	FOREIGN KEY (sMaNV) REFERENCES dbo.tblNhanVien(sMaNV),
	sMaKH VARCHAR(20) NOT NULL,
	FOREIGN KEY (sMaKH) REFERENCES dbo.tblKhachHang(sMaKH),
	dNgayLap DATE null
)
alter table tblHoaDon
add fTongTien float
CREATE TABLE tblChiTietHD
(
	iSoHD int NOT NULL ,
	sMaSach VARCHAR(10) NOT NULL,
	fSoLuongMua FLOAT NOT NULL,
	fDonGia FLOAT NOT NULL,

	FOREIGN KEY (iSoHD) REFERENCES dbo.tblHoaDon(iSoHD),
	FOREIGN KEY (sMaSach) REFERENCES dbo.tblSach(sMaSach),
	PRIMARY KEY(iSoHD, sMaSach)
)
GO
--8
CREATE TABLE tblDonNhap
(
	iSoDN int NOT NULL PRIMARY KEY,
	dNgayNhap date null, 
	sMaNV VARCHAR(20) NOT NULL,
	FOREIGN KEY (sMaNV) REFERENCES dbo.tblNhanVien(sMaNV),
	sMaNXB VARCHAR(20) NOT NULL,
	FOREIGN KEY (sMaNXB) REFERENCES dbo.tblNhaXuatBan(sMaNXB),
)

GO
--9


GO
--10
CREATE TABLE tblChiTiet_HD_NhapSach
(
	iSoDN int NOT NULL,
	sMaSach VARCHAR(10) NOT NULL,
	fSoLuongNhap FLOAT NOT NULL,
	fGiaNhap float null,
	FOREIGN KEY (iSoDN) REFERENCES dbo.tblDonNhap(iSoDN),
	FOREIGN KEY (sMaSach) REFERENCES dbo.tblSach(sMaSach),
	PRIMARY KEY (iSoDN, sMaSach)
)
/*NHẬP DỮ LIỆU CHO TẤT CẢ CÁC BẢNG*/

insert into tblTheLoai(sMaLoai, sTheLoai)
values ( 'ML1', N'Sách Văn Học'), 
       ( 'ML2', N'Tiểu Thuyết'),
	   ( 'ML3', N'Truyện Cười');

insert into tblNhaXuatBan(sMaNXB, sTenNXB, sDiaChi, sSDT)
values ( 'MNXB1', N'Nhà xuất bản Văn Học', N'Hà Nội','0987634233'), 
       ( 'MNXB2', N'Nhà xuất bản Dân Trí', N'Hà Nội','0989006754'),
	   ( 'MNXB3', N'Nhà xuất bản Trẻ', N'Hà Nội','0945123998');

insert into tblSach(sMaSach, sTenSach, sMaLoai, sTacGia, fDonGia, sMaNXB, iSoLuong)
values ( 'MS1', N'Truyện Trạng Cười Việt Nam','ML3', 'Đức Anh', 50000, 'MNXB2', 50 ), 
       ( 'MS2', N'101 Truyện Cười Đặc Sắc','ML3', 'Đức Anh', 35000, 'MNXB2', 60 ), 
	   ( 'MS3', N'Mắt Biếc','ML2', 'Nguyễn Nhật Ánh', 55000, 'MNXB3', 50 ), 
	   ( 'MS4', N'Kẻ Trộm Mộ','ML2', 'Nguyễn Đức Vịnh', 120000, 'MNXB1', 10 ), 
	   ( 'MS5', N'Tuổi Thơ Dữ Dội','ML1', 'Phùng Quán', 40000, 'MNXB1', 100 ), 
	   ( 'MS6', N'Tắt Đèn','ML1', 'Ngô Tất Tố', 30000, 'MNXB1', 90 );

insert into tblKhachHang(sMaKH, sTenKH, sDiaChi, dNgaySinh,sSDT)
values ( 'MKH1', N'Nguyễn Thúy Lan','Hà Nội', '2003/03/02', '0987623456'),
       ( 'MKH2', N'Ngô Văn Nam','Hải Dương', '2007/12/23', '0990784536'), 
	   ( 'MKH3', N'Trần Duy Hùng','Hải Phòng', '1999/05/15', '0912356778'), 
	   ( 'MKH4', N'Nguyễn Nhật Minh','Hà Nội', '2001/03/25', '0998673452'), 
	   ( 'MKH5', N'Đỗ Thị Lan Anh','Lào Cai', '1997/08/12', '0923009785');

insert into tblNhanVien(sMaNV, sTenNV, sDiaChi, dNgaySinh, dNgayVaoLam, sSDT)
values ( 'MNV1', N'Nguyễn Mai Linh','Hà Nội', '1998/07/02', '2020/12/02', '0945677899'),
       ( 'MNV2', N'Trần Duy Mạnh','Hà Nội', '2000/03/24', '2021/05/08', '0912567456'),
	   ( 'MNV3', N'Nguyễn Thảo Linh','Hà Nội', '1999/03/20', '2021/10/23', '0900896764');

insert into tblHoaDon(iSoHD, sMaNV, sMaKH, dNgayLap, fTongTien)
values ( 1, 'MNV1','MKH1', '2022/03/02', 100000),
       ( 2, 'MNV2','MKH5', '2022/10/12', 55000),
	   ( 3, 'MNV3','MKH3', '2022/06/26', 120000),
	   ( 4, 'MNV2','MKH4', '2022/11/02', 120000),
	   ( 5, 'MNV3','MKH2', '2022/02/18', 30000);
insert into tblChiTietHD(iSoHD, sMaSach, fSoLuongMua, fDonGia)
values ( 1, 'MS1', 2, 50000),
       ( 2, 'MS3', 1, 55000),
	   ( 3, 'MS4', 1, 120000),
	   ( 4, 'MS5', 3, 40000),
	   ( 5, 'MS6', 1, 30000);

	   
insert into tblDonNhap(iSoDN, dNgayNhap, sMaNV, sMaNXB)
values ( 10, '2021/02/08', 'MNV1', 'MNXB2'),
       ( 11, '2021/12/22', 'MNV2', 'MNXB1'),
	   ( 12, '2021/09/25', 'MNV3', 'MNXB3');

insert into tblChiTiet_HD_NhapSach(iSoDN, sMaSach, fSoLuongNhap, fGiaNhap)
values ( 10, 'MS1',100, 40000),
       ( 11, 'MS4',50, 90000),
	   ( 12, 'MS6',120, 20000);

-- thi
alter table tblHoaDon
add mota nvarchar(255)
-- các chức năng trong quản lý hóa đon và chi tiết hóa đơn
-- chuc nang them hoa don
create proc pr_themhd(
@sohd int,
@manv varchar(20),
@makh varchar(20),
@ngaylap date)
as 
insert into tblHoaDon(iSoHD, sMaNV, sMaKH, dNgayLap)
values (@sohd, @manv, @makh, @ngaylap)
create proc pr_themhd (@sohd int, @tennv nvarchar(50), @tenkh nvarchar(50), @ngaylap date)
as
begin
declare @manv varchar(20), @makh varchar(20)
select @manv=sMaNV from tblNhanVien where sTenNV like @tennv 
select @makh=sMaKH from tblKhachHang where sTenKH like @tenkh
	insert into tblHoaDon(iSoHD, sMaNV,sMaKH, dNgayLap)
	values (@sohd, @manv, @makh, @ngaylap)
end
drop proc pr_themhd
-- chuc nang sua
create proc pr_suahd(
@sohd int,
@manv varchar(20),
@makh varchar(20),
@ngaylap date)
as
begin
update tblHoaDon
set sMaNV = @manv, sMaKH = @makh, dNgayLap = @ngaylap
where iSoHD = @sohd
end
alter proc pr_suahd (@sohd int, @tennv nvarchar(50), @tenkh nvarchar(50), @ngaylap date)
as
begin
declare @manv varchar(20), @makh varchar(20)
select @manv=sMaNV from tblNhanVien where sTenNV like @tennv 
select @makh=sMaKH from tblKhachHang where sTenKH like @tenkh
update tblHoaDon
set sMaNV = @manv, sMaKH = @makh, dNgayLap = @ngaylap
where iSoHD = @sohd
end
select * from tblChiTietHD
select * from tblHoaDon
drop proc pr_suahd
-- chuc nang xoa hoa don se xoa chi tiet truoc va xoa hoa don sau
create proc pr_Xoahd (@sohd int)
as
begin
delete from tblChiTietHD
where tblChiTietHD.iSoHD = @sohd
delete from tblHoaDon
where tblHoaDon.iSoHD = @sohd
end
drop proc pr_Xoahd

-- chuc nang them chi tiet hoa don
create proc pr_themchitiethd(
@sohd int,
@masach varchar(10),
@soluong float,
@dongia float)
as 
insert into tblChiTietHD(iSoHD, sMaSach, fSoLuongMua, fDonGia)
values (@sohd, @masach, @soluong, @dongia)
alter proc pr_themchitiethd (@sohd int , @tensach NVARCHAR(100), @soluong float, @dongia float)
as 
begin
declare @masach varchar(10)
select @masach = sMaSach from tblSach where sTenSach like @tensach
insert into tblChiTietHD(iSoHD, sMaSach, fSoLuongMua, fDonGia)
values (@sohd, @masach, @soluong, @dongia)
end

create proc pr_suachitiethd(
@sohd int,
@masach varchar(10),
@soluong float,
@dongia float)
as
begin
update tblChiTietHD
set  fSoLuongMua = @soluong, fDonGia =@dongia
where iSoHD = @sohd and sMaSach = @masach
end
alter proc pr_suachitiethd (@sohd int , @tensach NVARCHAR(100), @soluong float, @dongia float)
as 
begin
declare @masach varchar(10)
select @masach = sMaSach from tblSach where sTenSach like @tensach
update tblChiTietHD
set  fSoLuongMua = @soluong, fDonGia =@dongia
where iSoHD = @sohd and sMaSach = @masach
end

create proc pr_Xoachitiethd (@sohd int, @masach varchar(10))
as
begin
delete from tblChiTietHD
where @sohd = iSoHD and @masach = sMaSach
end
alter proc pr_Xoachitiethd (@sohd int,@tensach NVARCHAR(100))
as
begin
declare @masach varchar(10)
select @masach = sMaSach from tblSach where sTenSach like @tensach
delete from tblChiTietHD
where @sohd = iSoHD and @masach = sMaSach
end
drop proc pr_Xoachitiethd



create view V_laydulieu
as
select iSoHD[Số Hóa Đơn] , tblNhanVien.sTenNV[Tên Nhân Viên],tblKhachHang.sTenKH[Tên Khách Hàng], dNgayLap[Ngày Lập], fTongTien [Tổng Tiền]
from (tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV) 
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH
where tblKhachHang.sMaKH = tblHoaDon.sMaKH and tblHoaDon.sMaNV = tblNhanVien.sMaNV
group by iSoHD, tblKhachHang.sTenKH, tblNhanVien.sTenNV, dNgayLap, fTongTien
drop view V_laydulieu


create view V_laychitiethd
as
select iSoHD[Số Hóa Đơn], tblSach.sTenSach[Tên Sách], fSoLuongMua[Số Lượng], tblSach.fDonGia[Đơn Giá]
from tblSach, tblChiTietHD
where tblSach.sMaSach = tblChiTietHD.sMaSach 
group by iSoHD, tblSach.sTenSach, fSoLuongMua, tblSach.fDonGia
select * from V_laychitiethd



create view tongtien(SoHD,Tongtien)
as
select tblHoaDon.iSoHD, sum(fSoLuongMua *fDonGia) 
from tblChiTietHD inner join tblHoaDon on tblChiTietHD.iSoHD =tblHoaDon.iSoHD
group by tblHoaDon.iSoHD
-- chuc nang tu dong tang tong tien
CREATE TRIGGER TG_updatetongtien 
ON tblHoaDon
FOR INSERT
AS
BEGIN
        DECLARE @sohd int
		select @sohd = iSoHD
		FROM inserted
				IF EXISTS (SELECT iSoHD
					FROM tblHoaDon
					WHERE @sohd = iSoHD)
					BEGIN
						UPDATE tblHoaDon
						SET fTongTien = 0
						where iSoHD = @sohd
					END	
		ELSE
		BEGIN
		ROLLBACK TRANSACTION
		END
END


drop trigger TG_updatetongtien 


CREATE TRIGGER TG_Tangtongtien
ON tblChiTietHD
FOR INSERT,update
AS
BEGIN
		DECLARE @sohd int
		DECLARE @soluongmua float
		SELECT @sohd = iSoHD
		FROM inserted
		IF EXISTS (SELECT iSoHD
					FROM tblChiTietHD
					WHERE @sohd = iSoHD)
					BEGIN
						UPDATE tblHoaDon
						SET fTongTien = (SELECT Tongtien
						                 FROM tongtien
					                     WHERE iSoHD=tongtien.SoHD)
					END	
		ELSE
		BEGIN
		ROLLBACK TRANSACTION
		END
END
drop trigger TG_Tangtongtien
select * from tblHoaDon
select * from tblChiTietHD
delete from tblHoaDon


CREATE TRIGGER TG_Giamtongtien
ON tblChiTietHD
FOR delete,update
AS
BEGIN
		DECLARE @sohd int
		DECLARE @soluongmua float
		SELECT @sohd = iSoHD
		FROM deleted
		IF EXISTS (SELECT iSoHD
					FROM tblChiTietHD
					WHERE @sohd = iSoHD)
					BEGIN
						UPDATE tblHoaDon
						SET fTongTien = (SELECT Tongtien
						                 FROM tongtien
					                     WHERE iSoHD=tongtien.SoHD)
										 where iSoHD = @sohd
					END	
		ELSE
		BEGIN
		(SELECT iSoHD
					FROM tblChiTietHD
					WHERE @sohd = iSoHD)
					BEGIN
						UPDATE tblHoaDon
						SET fTongTien = 0
										 where iSoHD = @sohd
										 END
		END
END
drop trigger TG_Giamtongtien 

--CÁC CHỨC NĂNG TÌM KIẾM 

-- chuc nang tim kiem hoa don
create proc pr_timkiemnv( @manv varchar(20))
as
begin
select iSoHD[Số Hóa Đơn] , tblNhanVien.sTenNV[Tên Nhân Viên],tblKhachHang.sTenKH[Tên Khách Hàng], dNgayLap[Ngày Lập], fTongTien [Tổng Tiền]
	from (tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV) 
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH
where @manv = tblHoaDon.sMaNV 
end
create proc pr_timkiemnv ( @tennv nvarchar(50))
as
begin
declare @manv varchar(20)
select @manv=sMaNV from tblNhanVien where sTenNV like @tennv
	select iSoHD[Số Hóa Đơn] , tblNhanVien.sTenNV[Tên Nhân Viên],tblKhachHang.sTenKH[Tên Khách Hàng], dNgayLap[Ngày Lập], fTongTien [Tổng Tiền]
	from (tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV) 
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH
where @manv = tblHoaDon.sMaNV 
end

drop proc pr_timkiemnv
exec pr_timkiemnv @tennv = N'Nguyễn Mai Linh'
drop proc pr_timkiemnv
-- tim kiem theo so hoa don
create proc pr_timkiemsohd( @sohd int)
as
begin
select iSoHD[Số Hóa Đơn] , tblNhanVien.sTenNV[Tên Nhân Viên],tblKhachHang.sTenKH[Tên Khách Hàng], dNgayLap[Ngày Lập], fTongTien [Tổng Tiền]
	from (tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV) 
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH
where @sohd = tblHoaDon.iSoHD
end

--tim kiem theo ten khach hang
create proc pr_timkiemkh ( @tenkh nvarchar(50))
as
begin
declare @makh varchar(20)
select @makh=sMaKH from tblKhachHang where sTenKH like @tenkh
	select iSoHD[Số Hóa Đơn] , tblNhanVien.sTenNV[Tên Nhân Viên],tblKhachHang.sTenKH[Tên Khách Hàng], dNgayLap[Ngày Lập], fTongTien [Tổng Tiền], sMota[Mô tả]
	from (tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV) 
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH
where @makh = tblHoaDon.sMaKH
end
drop proc pr_timkiemkh
 exec pr_timkiemkh @tenkh = 'Trần Duy Hùng'
-- tim theo ngay lap
create proc pr_timkiemngaylap( @ngaylap date)
as
begin
select iSoHD[Số Hóa Đơn] , tblNhanVien.sTenNV[Tên Nhân Viên],tblKhachHang.sTenKH[Tên Khách Hàng], dNgayLap[Ngày Lập], fTongTien [Tổng Tiền]
	from (tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV) 
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH
where @ngaylap = tblHoaDon.dNgayLap
end


-- chuc nang tim kiem chi tiet hoa don
create proc pr_timkiemsocthd( @sohd int)
as
begin
select iSoHD[Số Hóa Đơn], tblSach.sTenSach[Tên Sách], fSoLuongMua[Số Lượng], tblSach.fDonGia[Đơn Giá]
from tblSach inner join tblChiTietHD on tblSach.sMaSach = tblChiTietHD.sMaSach
where @sohd = tblChiTietHD.iSoHD
end

-- tim ten sach trong chi tiet hoa don
create proc pr_timkiemtensach( @tensach nvarchar(100), @sohd int)
as
begin
declare @masach varchar(10)
select @masach = sMaSach from tblSach where sTenSach like @tensach
select iSoHD[Số Hóa Đơn], tblSach.sTenSach[Tên Sách], fSoLuongMua[Số Lượng], tblSach.fDonGia[Đơn Giá]
from tblSach inner join tblChiTietHD on tblSach.sMaSach = tblChiTietHD.sMaSach
where @masach = tblChiTietHD.sMaSach and @sohd = tblChiTietHD.iSoHD
end
drop proc pr_timkiemtensach
exec pr_timkiemtensach @tensach = N'Mắt Biếc', @sohd = 3
-- tim sach so luong mua nhieu nhat trong chi tiet hoa don




create proc pr_timkiemhdkh ( @tenkh nvarchar(50))
as
begin
	select tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblKhachHang.sTenKH, tblHoaDon.dNgayLap, tblSach.sTenSach, fSoLuongMua, tblChiTietHD.fDonGia, sMota
	from ((((tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV))
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH)
	inner join tblChiTietHD on tblHoaDon.iSoHD = tblChiTietHD.iSoHD) inner join tblSach on tblChiTietHD.sMaSach = tblSach.sMaSach
where sTenKH like '%'+@tenkh+'%'
end

drop proc pr_timkiemhdkh
 exec pr_timkiemhdkh @tenkh = N'Lan'

create proc pr_timdongiatrongkhoang ( @giabatdau float, @giaketthuc float)
as
begin
	select tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblKhachHang.sTenKH, tblHoaDon.dNgayLap, tblSach.sTenSach, fSoLuongMua, tblChiTietHD.fDonGia
	from ((((tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV))
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH)
	inner join tblChiTietHD on tblHoaDon.iSoHD = tblChiTietHD.iSoHD) inner join tblSach on tblChiTietHD.sMaSach = tblSach.sMaSach
where @giabatdau <= tblChiTietHD.fDonGia and tblChiTietHD.fDonGia <= @giaketthuc
end 
drop proc pr_timdongiatrongkhoang 
select *from tblChiTietHD
exec pr_timdongiatrongkhoang @giabatdau = 50000 , @giaketthuc = 60000

create proc pr_thangnam( @ngay date)
as
begin
select tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblKhachHang.sTenKH, tblHoaDon.dNgayLap, tblSach.sTenSach, fSoLuongMua, tblChiTietHD.fDonGia
	from ((((tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV))
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH)
	inner join tblChiTietHD on tblHoaDon.iSoHD = tblChiTietHD.iSoHD) inner join tblSach on tblChiTietHD.sMaSach = tblSach.sMaSach
where MONTH(tblHoaDon.dNgayLap) = month(@ngay) and year(tblHoaDon.dNgayLap) = year(@ngay)
end

drop proc pr_thangnam 

exec pr_thangnam @ngay = '2023-04-11'


create proc pr_baocaohd
as
begin
select tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblKhachHang.sTenKH, tblHoaDon.dNgayLap, tblSach.sTenSach, fSoLuongMua, tblChiTietHD.fDonGia
	from ((((tblNhanVien inner join tblHoaDon on tblNhanVien.sMaNV = tblHoaDon.sMaNV))
	inner join tblKhachHang on tblKhachHang.sMaKH = tblHoaDon.sMaKH)
	inner join tblChiTietHD on tblHoaDon.iSoHD = tblChiTietHD.iSoHD) inner join tblSach on tblChiTietHD.sMaSach = tblSach.sMaSach
end
drop proc pr_baocaohd
exec pr_baocaohd

--- in bao cao hoa don
create proc pr_baocaohdtheonam (@nam int)
as
begin
	select tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblHoaDon.dNgayLap,sum(tblHoaDon.fTongTien) as 'fTongTien'
	from tblHoaDon inner join tblNhanVien on tblHoaDon.sMaNV = tblNhanVien.sMaNV
where YEAR(tblHoaDon.dNgayLap) = @nam
group by tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblHoaDon.dNgayLap
end

exec pr_baocaohdtheonam @nam = 2023

create proc pr_baocaothunhap
as 
begin
select tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblHoaDon.dNgayLap,sum(tblHoaDon.fTongTien) as 'fTongTien'
	from tblHoaDon inner join tblNhanVien on tblHoaDon.sMaNV = tblNhanVien.sMaNV
	group by tblHoaDon.iSoHD, tblNhanVien.sTenNV,tblHoaDon.dNgayLap
end

drop proc pr_baocaothunhap
 exec pr_baocaothunhap 

 -- các chức năng quản lý sách và thể loại
 /* proc tìm kiếm sách theo tên */
 create proc HienThiSach
 as
 begin
 select sMaSach[Mã sách],sTenNXB[Nhà xuất bản],sTheLoai[Thể loại],sTenSach[Tên sách],sTacGia[Tác giả],fDonGia[Đơn giá],iSoLuong[Số lượng]
 from (tblTheLoai inner join tblSach on tblTheLoai.sMaLoai = tblSach.sMaLoai)
 inner join tblNhaXuatBan on tblSach.sMaNXB = tblNhaXuatBan.sMaNXB
 end
 exec HienThiSach
 drop proc HienThiSach
create proc TimKiemTheoTen
@TenSach nvarchar(100)
as
begin
 select sMaSach[Mã sách],sTenNXB[Nhà xuất bản],sTheLoai[Thể loại],sTenSach[Tên sách],sTacGia[Tác giả],fDonGia[Đơn giá],iSoLuong[Số lượng]
 from tblSach, tblTheLoai, tblNhaXuatBan
 where tblNhaXuatBan.sMaNXB=tblSach.sMaNXB and tblSach.sMaLoai=tblTheLoai.sMaLoai and sTenSach like @TenSach
end

exec TimKiemTheoTen N'Mắt Biếc'

go
/* proc chọn khoảng giá */
create proc HienThiDuLieuSach
@Min int,@Max int
as
begin
select sMaSach[Mã sách],sTenNXB[Nhà xuất bản],sTheLoai[Thể loại],sTenSach[Tên sách],sTacGia[Tác giả],fDonGia[Đơn giá],iSoLuong[Số lượng]
 from (tblTheLoai inner join tblSach on tblTheLoai.sMaLoai = tblSach.sMaLoai)
 inner join tblNhaXuatBan on tblSach.sMaNXB = tblNhaXuatBan.sMaNXB
 where tblSach.sMaLoai=tblTheLoai.sMaLoai and tblNhaXuatBan.sMaNXB=tblSach.sMaNXB and tblSach.fDonGia >@Min and tblSach.fDonGia <@Max
end
 drop proc HienThiDuLieuSach
exec HienThiDuLieuSach @Min=10000,@Max=40000

go 
/* proc thêm sách */
create proc Them_Du_Lieu_Sach
@MaSach nvarchar(10),@TenSach nvarchar(100),@MaLoai nvarchar(10),@TacGia nvarchar(20),@DonGia float,@MaNXB nvarchar(20),@SoLuong int
as
begin
 insert into tblSach values(@MaSach,@TenSach,@MaLoai,@TacGia,@DonGia,@MaNXB,@SoLuong)
end

go
/* proc sửa sách */
create proc Sua_Du_Lieu_Sach
@MaSach nvarchar(10),@TenSach nvarchar(100),@MaLoai nvarchar(10),@TacGia nvarchar(20),@DonGia float,@MaNXB nvarchar(20),@SoLuong int
as
begin
 update tblSach
 set sTenSach=@TenSach,sMaLoai=@MaLoai,sTacGia=@TacGia,fDonGia=@DonGia,sMaNXB=@MaNXB,iSoLuong=@SoLuong
 where sMaSach=@MaSach
end

go
/* proc xoá sách */
create proc Xoa_Du_Lieu_Sach
@MaSach nvarchar(10)
as
begin
 delete from tblSach where sMaSach=@MaSach
end

go
/* proc thêm thể loại */
create proc Them_Du_Lieu_The_Loai
@MaLoai nvarchar(10),@TheLoai nvarchar(50)
as
begin
 insert into tblTheLoai values(@MaLoai,@TheLoai)
end

go
/* proc sửa thể loại */
create proc Sua_Du_Lieu_The_Loai
@MaLoai nvarchar(10),@TheLoai nvarchar(50)
as
begin
 update tblTheLoai
 set sTheLoai=@TheLoai
 where sMaLoai=@MaLoai
end

go
/* proc xoá thể loại */
create proc Xoa_Du_Lieu_The_Loai
@MaLoai nvarchar(10)
as
begin
 delete from tblTheLoai where sMaLoai=@MaLoai
end


-- CÁC CHỨC NĂNG QUẢN LÝ ĐƠN NHẬP VÀ CHI TIẾT ĐƠN NHẬP
create view V_DonNhap
as
select iSoDN[Số đơn nhập], dNgayNhap[Ngày nhập], sTenNV[Tên người lập], sTenNXB[Nhà xuất bản]
from tblDonNhap A, tblNhanVien B, tblNhaXuatBan C
where B.sMaNV=A.sMaNV and C.sMaNXB=A.sMaNXB

select * from tblDonNhap
select * from tblNhanVien
select * from tblNhaXuatBan
Select * from V_DonNhap

create proc sp_ThemDonNhap (@iSoDN int, @dNgayNhap date, @sTenNV nvarchar(50), @sTenNXB nvarchar(50))
as
begin
declare @sMaNV varchar(20), @sMaNXB varchar(20)
select @sMaNV=sMaNV from tblNhanVien where sTenNV like @sTenNV
select @sMaNXB=sMaNXB from tblNhaXuatBan where sTenNXB like @sTenNXB
	insert into tblDonNhap(iSoDN, dNgayNhap, sMaNV, sMaNXB)
	values (@iSoDN, @dNgayNhap, @sMaNV, @sMaNXB)
end
select * from tblDonNhap
select * from tblNhaXuatBan
exec sp_ThemDonNhap 13, '2023/01/12', N'Nguyễn Mai Linh', N'Nhà xuất bản Dân Trí';
delete from tblDonNhap where iSoDN=14
create proc sp_DNCT (@MaDN int)
as
select sTenSach, fSoLuongNhap, fGiaNhap
from tblChiTiet_HD_NhapSach, tblSach
where tblChiTiet_HD_NhapSach.sMaSach=tblSach.sMaSach and iSoDN=@MaDN

create view V_DNCT 
as
select iSoDN[Số đơn nhập], sTenSach[Tên sách], fSoLuongNhap[Số lượng], fGiaNhap[Giá nhập]
from tblChiTiet_HD_NhapSach, tblSach
where tblChiTiet_HD_NhapSach.sMaSach=tblSach.sMaSach

select * from V_DNCT
where [Số đơn nhập]=10

select sMaSach[Mã sách],sTenNXB[Nhà xuất bản],sTheLoai[Thể loại],sTenSach[Tên sách],sTacGia[Tác giả],fDonGia[Đơn giá],iSoLuong[Số lượng]
from tblSach, tblTheLoai, tblNhaXuatBan
where tblNhaXuatBan.sMaNXB=tblSach.sMaNXB and tblSach.sMaLoai=tblTheLoai.sMaLoai and sTenSach=N'Truyện Trạng Cười Việt Nam'

select * from tblChiTiet_HD_NhapSach

create proc sp_ThemDonNhapCT (@iSoDN int, @sTenSach nvarchar(50), @fSoLuongNhap float, @fGiaNhap float)
as
begin
declare @sMaSach varchar(10)
select sMaSach=@sMaSach from tblSach where sTenSach like @sTenSach
	insert into tblChiTiet_HD_NhapSach 
	values (@iSoDN, @sMaSach, @fSoLuongNhap, @fGiaNhap)
end

exec sp_ThemDonNhapCT 10, N'Tắt đèn', 10, 23000;
select * from tblChiTiet_HD_NhapSach

create proc insert_nv (@maNV nvarchar(20), @tenNV nvarchar(50), @diaChi nvarchar(100),@ngaySinh date, @sdt varchar(10), @ngayVao date)
as 
begin 
	insert into tblNhanVien 
	values(@maNV,@tenNV,@diaChi,@ngaySinh,@ngayVao,@sdt)
end
exec insert_nv 'NV11',        -- sMaNV - varchar(20)
    N'Trần Quốc Hieu',       -- sTenNV - nvarchar(50)
    N' Hà Nội',       -- sDiaChi - nvarchar(100)
    '20030120', -- dNgaySinh - date
    '0654879645',        -- sSDT - varchar(10)
    '20211218' -- dNgayVaoLam - date
	select * from tblNhanVien

create proc sp_DSDonNhapTheoNXB
@NXB nvarchar(50)
as
select * from V_DonNhap
where [Nhà xuất bản] like '%'+@NXB+'%';



exec sp_DSDonNhapTheoNXB N'Dân Trí'

select * from V_DonNhap
where [Nhà xuất bản] like N'%Dân Trí%';


--danh sách các sách mà nhân viên này đã nhập
Create proc sp_DSDNtheoNhanVien
@NhanVien nvarchar(50)
as
select sTenNV[Nhân Viên], tblDonNhap.iSoDN[Số đơn nhập], dNgayNhap[Ngày nhập], sTenNV[Nhân Viên]
from tblChiTiet_HD_NhapSach, tblNhanVien, tblDonNhap

create proc sp_SuaDonNhap (@iSoDN int, @dNgayNhap date, @sTenNV nvarchar(50), @sTenNXB nvarchar(50))
as
begin
declare @sMaNV varchar(20), @sMaNXB varchar(20)
select @sMaNV=sMaNV from tblNhanVien where sTenNV like @sTenNV
select @sMaNXB=sMaNXB from tblNhaXuatBan where sTenNXB like @sTenNXB
if(datediff(day, (select dNgayNhap from tblDonNhap where iSoDN=@iSoDN), getdate())<=3)
	begin
	update tblDonNhap set 
	sMaNV= @sMaNV,sMaNXB= @sMaNXB, dNgayNhap=@dNgayNhap
	where iSoDN=@iSoDN
	end
end

select * from tblDonNhap
select * from V_DonNhap
select * from tblChiTiet_HD_NhapSach
insert into tblDonNhap(iSoDN, dNgayNhap, sMaNV, sMaNXB)
	values (15,'2023/4/8', 'MNV2', 'MNXB3')
exec sp_SuaDonNhap 15, '2023/4/7', N'Nguyễn Thảo Linh', N'Nhà xuất bản Văn Học'
delete from tblDonNhap where iSoDN=14
  


Create proc sp_InDanhSachMatHang (@min int, @max int)
as
begin
	Select sMaSach[Mã sách], sTenSach[Tên sách], sTheLoai[Thể loại], sTacGia[Tác giả], 
			fDonGia[Đơn giá], sTenNXB[Nhà xuất bản], iSoLuong[Số lượng]
	from tblSach A, tblNhaXuatBan B, tblTheLoai C
	where  B.sMaNXB=A.sMaNXB and C.sMaLoai=A.sMaLoai and fDonGia>=@min and fDonGia<=@max
	end

select * from tblSach
exec sp_InDanhSachMatHang 50000, 100000


--Sửa sl giá nhập của bảng đơn nhập chi tiết khi tính từ hôm nhập đến hôm nay không quá 3 ngày truyền vào sDN, tên sách, sl, gn

drop proc sp_SuaDNCT
select * from tblChiTiet_HD_NhapSach
select * from V_DNCT
select * from tblDonNhap
insert into tblDonNhap values(14, '2023/04/14', 'MNV2', 'MNXB1')
insert into tblChiTiet_HD_NhapSach values(14, 'MS1', 20, 40000)

create proc sp_SuaDNCT (@iSoDN int, @sTenSach nvarchar(100), @fSoLuongNhap float, @fGiaNhap float)
as
begin
	Declare @sMaSach varchar (10)
	select @sMaSach=sMaSach from tblSach where sTenSach=@sTenSach
	Declare @soNgay int
	select @soNgay = datediff(day, dNgayNhap, getdate()) from tblDonNhap where iSoDN=@iSoDN 
	if(@soNgay<=3)
	begin
		update tblChiTiet_HD_NhapSach set fSoLuongNhap=@fSoLuongNhap, fGiaNhap=@fGiaNhap
		where iSoDN =@iSoDN and sMaSach=@sMaSach
	end
end

exec sp_SuaDNCT 14, N'Truyện Trạng Cười Việt Nam', 50, 35000

create proc sp_TimDN_So(@iSoDN int)
as
select *from V_DonNhap where [Số đơn nhập]=@iSoDN 

exec sp_TimDN_So 14

create proc sp_TimDN_Nguoi (@sTen nvarchar(50))
as
select * from V_DonNhap where [Tên người lập] like N'%'+@sTen+N'%'

exec sp_TimDN_Nguoi N'nguyễn'

create proc sp_TimDN_NXB (@sNXB nvarchar(50))
as
select * from V_DonNhap where [Nhà xuất bản] like N'%'+@sNXB+N'%'

exec sp_TimDN_NXB N'trẻ'

create proc sp_TimDN_NguoivaNXB (@sTen nvarchar(50), @sNXB nvarchar(50))
as
select * from V_DonNhap where [Nhà xuất bản] like N'%'+@sNXB+N'%' and [Tên người lập] like N'%'+@sTen+N'%'

exec sp_TimDN_NguoivaNXB N'Linh', N'Trẻ'


create proc sp_TimCT_Ten (@iSoDN int, @TenS nvarchar(50))
as 
select * from V_DNCT where [Tên sách]like N'%'+@TenS+N'%' and [Số đơn nhập]=@iSoDN

exec sp_TimCT_Ten 10, N'Truyện'

create proc sp_crp_ThongKeNhapHang(@thang int, @nam int)
as
begin 
	select A.iSoDN as [Số ĐN], dNgayNhap as [Ngày nhập], sTenNV as [Tên NV lập], sTenNXB as [Tên NXB], 
			sTenSach as [Tên sách], fSoLuongNhap as[Số lượng], fGiaNhap as [Giá nhập]
	from tblDonNhap A, tblChiTiet_HD_NhapSach B, tblSach C, tblNhaXuatBan D, tblNhanVien E
	where A.iSoDN=B.iSoDN and A.sMaNV=E.sMaNV and A.sMaNXB=D.sMaNXB and B.sMaSach=C.sMaSach
	and month(dNgayNhap)=@thang and year(dNgayNhap)=@nam
end
  exec sp_crp_ThongKeNhapHang @thang = 9, @nam = 2021
  drop proc sp_crp_ThongKeNhapHang

create proc thongkenhaphang
as 
begin
select A.iSoDN as [Số ĐN], dNgayNhap as [Ngày nhập], sTenNV as [Tên NV lập], sTenNXB as [Tên NXB], 
			sTenSach as [Tên sách], fSoLuongNhap as[Số lượng], fGiaNhap as [Giá nhập]
	from tblDonNhap A, tblChiTiet_HD_NhapSach B, tblSach C, tblNhaXuatBan D, tblNhanVien E
	where A.iSoDN=B.iSoDN and A.sMaNV=E.sMaNV and A.sMaNXB=D.sMaNXB and B.sMaSach=C.sMaSach
end

exec thongkenhaphang

-- QUẢN LÝ ĐĂNG NHẬP 
create table tblDangKi (
	sTenDangNhap nvarchar(50) primary key,
	sMatKhau nvarchar(50),
	sTenUser nvarchar(50),
		
)
select * from tblUser;
select * from tblDangKi;
go
create proc insert_newuser @tenDangNhap nvarchar(50),@MatKhau nvarchar(50),@TenUser nvarchar(50)
as
begin
	insert into tblDangKi 
	values(@tenDangNhap,@MatKhau,@TenUser)
end
go
create proc update_user @tenDangNhap nvarchar(50),@MatKhau nvarchar(50)
as
begin
	update tblUser
	set sMatKhau = @MatKhau
	where sTenDangNhap = @tenDangNhap
end
go
create trigger trg_DangKi
on tblDangKi
after insert
as
begin
	declare @tenDangNhap nvarchar(50)
	declare @matKhau nvarchar(50)
	select @tenDangNhap = inserted.sTenDangNhap, @matKhau = inserted.sMatKhau from inserted

	insert into tblUser(sTenDangNhap,sMatKhau)
	values (@tenDangNhap,@matKhau)
end
go
create trigger trg_update
on tblUser
after update
as
begin
	declare @tenDangNhap nvarchar(50)
	declare @matKhau nvarchar(50)
	select @tenDangNhap = inserted.sTenDangNhap, @matKhau = inserted.sMatKhau from inserted
	update tblDangKi
	set sMatKhau = @matKhau
	where sTenDangNhap = @tenDangNhap
end

go
create proc sp_login @tenDangNhap nvarchar(50), @matKhau nvarchar(50) 
as
begin
	select * from tblUser
	where sTenDangNhap = @tenDangNhap and sMatKhau = @matKhau
end
go
--QUẢN LÝ NHÂN VIÊN, KHÁCH HÀNG 
create view vDSNV 
as 
	select sMaNV as [Mã Nhân Viên] ,sTenNV as [Tên Nhân Viên],sDiaChi as [Địa Chỉ],dNgaySinh as [Ngày Sinh],sSDT as [SDT],dNgayVaoLam as [Ngày Vào] 
	from tblNhanVien
go
create view VDSND
as 
select * from tblUser
go
create view vDSKH
as
	select sMaKH as [Mã Khách Hàng],sTenKH as [Tên Khách Hàng],sDiaChi as [Địa Chỉ],dNgaySinh as [Ngày Sinh],sSDT as [SDT]
	from tblKhachHang
go
alter proc insert_nv 
@maNV nvarchar(20), @tenNV nvarchar(50), @diaChi nvarchar(100),@ngaySinh date, @ngayVao date, @sdt varchar(10)
as 
begin 
	insert into tblNhanVien values(@maNV,@tenNV,@diaChi,@ngaySinh,@ngayVao,@sdt)
end
go
create proc insert_kh 
@maKH nvarchar(20), @tenKH nvarchar(50), @diaChi nvarchar(100),@ngaySinh date,@sdt varchar(10)
as
begin
	insert into tblKhachHang
	values(@maKH,@tenKH,@diaChi,@ngaySinh,@sdt)
end
go
create proc delete_kh @maKH nvarchar(20)
as
begin
	delete from tblKhachHang
	where sMaKH = @maKH;
end
go
create proc update_kh @maKH nvarchar(20), @tenKH nvarchar(50), @diaChi nvarchar(100),@ngaySinh date,@sdt varchar(10)
as
begin
	update tblKhachHang
	set sTenKH =@tenKH,sDiaChi = @diaChi,dNgaySinh=@ngaySinh,sSDT=@sdt
	where sMaKH= @maKH
end

create proc prXoaKhachHang @maKH VARCHAR(20)
as
begin	

	declare @sohd int
	select @sohd = iSoHD from tblHoaDon where sMaKH = @maKH
	delete from tblChiTietHD 
	where iSoHD =@sohd
	delete from tblHoaDon
	where iSoHD = @sohd
	delete from tblKhachHang
	where sMaKH = @maKH
end

create proc delete_nv @maNV nvarchar(20)
as
begin 
	delete from tblNhanVien 
	where sMaNV = @maNV;
end
go
create proc update_nv @maNV nvarchar(20), @tenNV nvarchar(50), @diaChi nvarchar(100),@ngaySinh date, @ngayVao date, @sdt varchar(10)
as 
begin
	update tblNhanVien
	set sTenNV = @tenNV,sDiaChi=@diaChi,dNgaySinh=@ngaySinh,dNgayVaoLam=@ngayVao,sSDT=@sdt
	where sMaNV = @maNV
end
go

select * from tblDangKi
go
create proc sp_DSKHtheodiachi @diaChi nvarchar(100)
as
begin
	select * from tblKhachHang
	where sDiaChi like '%'+@diaChi+'%'
end
select * from tblKhachHang
select * from tblKhachHang
	where sDiaChi like '%cai%'
exec sp_DSKHtheodiachi 'cai'
go
create proc sp_DSNV
as
begin
	select * from tblNhanVien
end
go
create proc sp_DSNVtheothang @ngayVao date
as
begin
	select * from tblNhanVien
	where MONTH(dNgayVaoLam) = MONTH(@ngayVao) and year(dNgayVaoLam) = YEAR(@ngayVao)
end


--CÁC CHỨC NĂNG CỦA NHÀ XUẤT BẢN 


Create view V_Nhaxuatban
as 
	Select sMaNXB as [Mã nhà xuất bản], sTenNXB as [Tên nhà xuất bản], sDiaChi as [Địa chỉ], sSDT as [Điện thoại]
		From tblNhaXuatBan


go 
Create proc pr_ThemNXB
@manxb varchar(20),@tennxb nvarchar(50),@diachi nvarchar(100),@SDT varchar(10)
as
	Insert into tblNhaXuatBan values (@manxb, @tennxb, @diachi,@SDT)
exec pr_ThemNXB @manxb = 'MNXB4',@tennxb = N' Nhà xuất bản Kim Đồng',@diachi = N'Hà Nội',@SDT = '0389478337'
Go 

Create proc Pr_SuaNXB
@manxb varchar(20),@tennxb nvarchar(50), @diachi nvarchar(100),@sdt varchar(10)
as
	Update tblNhaXuatBan set sTenNXB = @tennxb ,sDiaChi = @diachi, sSDT = @sdt 
	Where sMaNXB = @manxb


go
Create proc Pr_TimNXBtheoma
@manxb varchar(20)
as
	Select * from V_Nhaxuatban
	Where [Mã nhà xuất bản] Like '%'+@manxb+'%'

go
Create proc Pr_TimNXBtheoten
@tennxb nvarchar(50)
as
	Select * from V_Nhaxuatban
	Where [Tên nhà xuất bản] like N'%'+@tennxb+'%'

go
Create proc Pr_TimNXBtheoDC
@diachi nvarchar(100)
as
	Select * from V_Nhaxuatban
	Where [Địa chỉ] like N'%'+@diachi+'%'





