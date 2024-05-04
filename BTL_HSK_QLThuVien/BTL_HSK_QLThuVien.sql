

CREATE DATABASE BTL_HSK_QLThuVien
GO
USE BTL_HSK_QLThuVien
GO

GO 
--2
CREATE TABLE tblTheLoai
(
	iMaLoai int NOT NULL PRIMARY KEY,
	sTheLoai NVARCHAR(50) NOT NULL
)

GO

--4
CREATE TABLE tblNhaXuatBan
(
	iMaNXB int NOT NULL PRIMARY KEY,
	sTenNXB NVARCHAR(50) NOT NULL,
	sDiaChi NVARCHAR(100) NOT NULL,
	sSDT VARCHAR(10) NOT NULL
)

GO
CREATE TABLE tblSach
(
	iMaSach int NOT NULL PRIMARY KEY,
	sTenSach NVARCHAR(100) NOT NULL,
	iMaLoai int NOT NULL,
	sTacGia NVARCHAR(20) NOT NULL,
	FOREIGN KEY (iMaLoai) REFERENCES dbo.tblTheLoai(iMaLoai),
	iMaNXB int NOT NULL,
	FOREIGN KEY (iMaNXB) REFERENCES dbo.tblNhaXuatBan(iMaNXB),
	iSoLuong INT null,
	fGiaSach float null,
	fGiaMuon float null
)
GO
--3
CREATE TABLE tblNhanVien
(
	iMaNV int NOT NULL PRIMARY KEY,
	sTenNV NVARCHAR(50) NOT NULL,
	sGioiTinh NVARCHAR(3) null,
	sDiaChi NVARCHAR(100) NULL,
	dNgaySinh DATE NULL,
	dNgayVaoLam DATE NOT NULL,
	sSDT VARCHAR(10) NOT NULL,
	sTenDangNhap varchar(50) null,
	sMatKhau varchar(50) null
)

GO
--5
CREATE TABLE tblSinhVien
(
	iMaSV int NOT NULL PRIMARY KEY,
	sTenSV NVARCHAR(50),
	dNgaySinh DATE,
	sSDT VARCHAR(10),
	sCCCD VARCHAR(15),
)

GO 
--6

--7
CREATE TABLE tblMuonSach
(
	iMaMuon int NOT NULL PRIMARY KEY,
	iMaNV int NOT NULL,
	FOREIGN KEY (iMaNV) REFERENCES dbo.tblNhanVien(iMaNV),
	iMaSV int NOT NULL,
	FOREIGN KEY (iMaSV) REFERENCES dbo.tblSinhVien(iMaSV),
	dNgayMuon DATE null,
	sTrangThai VARCHAR(20)
)
alter table tblMuonSach add fTongTienMuon float

CREATE TABLE tblChiTietMuonSach
(
	iMaMuon int NOT NULL ,
	iMaSach int NOT NULL,
	fSoLuongMuon FLOAT NOT NULL,
		dNgayTra DATE null,
		sTrangThai VARCHAR(20)
	FOREIGN KEY (iMaMuon) REFERENCES dbo.tblMuonSach(iMaMuon),
	FOREIGN KEY (iMaSach) REFERENCES dbo.tblSach(iMaSach),
	PRIMARY KEY(iMaMuon, iMaSach)
)

alter table tblChiTietMuonSach add fGiaMuon float

GO

CREATE TABLE tblTraSach 
(
    iMaTra int NOT NULL PRIMARY KEY ,
    iMaMuon int NOT NULL,
	FOREIGN KEY (iMaMuon) REFERENCES dbo.tblMuonSach(iMaMuon),
	iMaNV int NOT NULL,
	FOREIGN KEY (iMaNV) REFERENCES dbo.tblNhanVien(iMaNV),
	iMaSV int NOT NULL,
	FOREIGN KEY (iMaSV) REFERENCES dbo.tblSinhVien(iMaSV),
	dNgayTra DATE null,
	fTongTienPhat float
)
CREATE TABLE tblChiTietTraSach
(
    iMaTra int NOT NULL,
    iMaSach int NOT NULL,
	fSoLuongTra FLOAT NOT NULL,
	sTrangThaiSach VARCHAR(20),
	fGiaPhat float,
	 FOREIGN KEY (iMaTra) REFERENCES dbo.tblTraSach(iMaTra),
	 FOREIGN KEY (iMaSach) REFERENCES dbo.tblSach(iMaSach),
	 PRIMARY KEY(iMaTra, iMaSach)

)
DROP TABLE tblChiTietTraSach
-- trang thai mat hay rach, nguyen ven

insert into tblTheLoai(iMaLoai,sTheLoai)
values('101',N'Kinh Tế'),
	('102',N'Xã Hội'),
	('103',N'DuLich'),
	('104',N'Chuyên Ngành');

insert into tblNhaXuatBan(iMaNXB,sTenNXB,sDiaChi,sSDT)
values('11',N'Bộ GD&ĐT Hà Nội',N'Hà Nội','0344447777'),
	('12',N'Kim Đồng',N'Hà Nội','0355578888'),
	('13',N'Thanh Niên',N'Hà Nội','0355578888');

insert into tblNhanVien(iMaNV,sTenNV, sGioiTinh, sDiaChi,dNgaySinh,dNgayVaoLam,sSDT)
values('100',N'Nguyễn Tuấn Anh','Nam',N'Hà Nội', '10/10/2000','01/01/2022','0987656789'),
		('200',N'Nguyễn Tất Nam', 'Nam',N'Hà Nội','05/05/1997','01/05/2022','0987656797');

insert into tblSinhVien(iMaSV,sTenSV,dNgaySinh,sSDT,sCCCD)
values('1111',N'Phạm Hải Nam','08/08/2002','0966778886','0245420320034'),
	('2222',N'Phạm Hải Hoàng','11/18/2001','0963777888','0245420329967'),
	('3333',N'Nguyễn Quang Anh','02/28/2000','0962388986','024542035673'),
	('4444',N'Ngô Thị Lan','01/01/2000','0966734876','0245420327834');

insert into tblSach(iMaSach,sTenSach,iMaLoai,sTacGia,iMaNXB,iSoLuong, fGiaSach, fGiaMuon)
values ('501',N'Nước Mỹ nhìn từ bên trong','101',N'Donald Trump','11',20, 150000, 10000),
		('502',N'Quốc gia khởi nghiệp','101',N'Thành Lương','12',15, 100000, 10000),
		('503',N'Kinh tế học lãng mạn','101',N'Tuấn Anh','11',20, 120000, 120000),
		('504',N'Triết lý cuộc đời','101',N'Jim Rohn','13',15, 120000, 11000);

insert into tblMuonSach(iMaMuon,iMaSV,iMaNV,dNgayMuon,sTrangThai)
values(01,'1111','100','10/10/2022',N'Đã Mượn'),
		(02,'3333','100','12/10/2022',N'Đã Mượn'),
		(03,'4444','200','01/10/2023',N'Đã Mượn'),
		(04,'2222','200','04/05/2023',N'Đã Mượn'),
		(05,'1111','200','10/19/2022',N'Đã Mượn');

insert into tblChiTietMuonSach(iMaMuon,iMaSach,fSoLuongMuon,dNgayTra,sTrangThai, fGiaMuon)
values (01,'501',5,'05/10/2023',N'Đã Trả', 10000),
		(01,'503',5,'05/10/2023',N'Đã Trả', 10000),
		(04,'501',5,'05/08/2023',N'Đã Trả', 11000),
		(02,'503',5,'05/28/2023',N'Đã Trả', 10000),
		(03,'502',5,'05/11/2023',N'Chưa Trả', 12000),
		(01,'504',5,'05/10/2023',N'Chưa Trả', 10000);

insert into tblTraSach(iMaTra, iMaMuon,iMaNV,iMaSV, dNgayTra)
values  (2885,01,'100','1111','05/10/2023'),
		(2965,02,'100','3333','05/10/2023'),
		(2789,03,'100','4444','05/10/2023'),
		(2856,04,'100','2222','05/10/2023');

insert into tblChiTietTraSach(iMaTra,iMaSach,fSoLuongTra,sTrangThaiSach,fGiaPhat)
values(2885,'501',5,N'Nguyên Vẹn',0),
		(2885,'503',5,N'Nguyên Vẹn',0),
		(2789,'502',2,N'Nguyên Vẹn',0),
		(2885,'504',5,N'Nguyên Vẹn',0),
		(2965,'503',5,N'Nguyên Vẹn',0);

--QUẢN LÝ ĐĂNG NHẬP 
create table tblDangNhap
( sTenDangNhap nvarchar(50) primary key,
  sMatKhau nvarchar(50),
  iMaNV int,
  FOREIGN KEY (iMaNV) REFERENCES dbo.tblNhanVien(iMaNV),
  )
drop table tblDangNhap
-- Tạo tài khoản đăng nhập 
create proc pr_DangKy(@tendangnhap nvarchar(50), @matkhau nvarchar(50), @manv int)
as
begin
   insert into tblDangNhap (sTenDangNhap , sMatKhau, iMaNV)
   values (@tendangnhap, @matkhau, @manv)
end 

create proc pr_UpdatePass (@tendangnhap nvarchar(50), @matkhau nvarchar(50))
as
begin
update tblDangNhap
set sMatKhau = @matkhau
where sTenDangNhap = @tendangnhap
end

drop proc pr_UpdateLogin

create proc pr_DangNhap( @tendangnhap nvarchar(50), @matkhau nvarchar(50)) 
as
begin
	select * from tblDangNhap
	where sTenDangNhap = @tendangnhap and sMatKhau = @matkhau
end
drop proc pr_DangNhap

-- Quản lý nhà xuất bản 
-- Hiện danh sách nhà xuất bản
create view V_HienNXB 
as
select iMaNXB[Mã Nhà Xuất Bản], sTenNXB[Tên Nhà Xuất Bản], sDiaChi[Địa Chỉ], sSDT[Số Điện Thoại]
from tblNhaXuatBan
group by iMaNXB, sTenNXB, sDiaChi, sSDT

select * from V_HienNXB
-- Thêm nhà xuất bản 
create proc pr_ThemNXB ( @manxb int, @tennxb nvarchar(50), @diachi nvarchar(100), @sodt varchar(10))
as 
begin
insert into tblNhaXuatBan(iMaNXB, sTenNXB, sDiaChi, sSDT)
values ( @manxb, @tennxb, @diachi, @sodt)
end 

-- Sửa nhà xuất bản 
create proc pr_UpdateNXB (@manxb int, @tennxb nvarchar(50), @diachi nvarchar(100), @sodt varchar(10))
as
begin
update tblNhaXuatBan
set sTenNXB = @tennxb, sDiaChi = @diachi, sSDT = @sodt
where iMaNXB = @manxb
end

-- Xóa nhà xuất bản
create proc pr_DeleteNXB (@manxb int)
as
begin
delete from tblNhaXuatBan
where tblNhaXuatBan.iMaNXB = @manxb 
end
drop proc pr_DeleteNXB
exec pr_DeleteNXB @manxb = 13
-- Tìm kiếm nhà xuất bản 
--Tìm theo mã nhà xuất bản
create proc pr_TimKiemMaNXB (@manxb int)
as
begin
select iMaNXB[Mã Nhà Xuất Bản], sTenNXB[Tên Nhà Xuất Bản], sDiaChi[Địa Chỉ], sSDT[Số Điện Thoại]
from tblNhaXuatBan
where @manxb = iMaNXB
end

exec pr_TimKiemMaNXB @manxb = 11

-- Tìm theo tên nhà xuất bản
create proc pr_TimKiemTenNXB (@tennxb nvarchar(50) )
as
begin
select iMaNXB[Mã Nhà Xuất Bản], sTenNXB[Tên Nhà Xuất Bản], sDiaChi[Địa Chỉ], sSDT[Số Điện Thoại]
from tblNhaXuatBan
where sTenNXB like '%'+@tennxb+'%'
end

-- Tìm theo địa chỉ 
create proc pr_TimKiemDiaChiNXB (@diachi nvarchar(100))
as
begin
select iMaNXB[Mã Nhà Xuất Bản], sTenNXB[Tên Nhà Xuất Bản], sDiaChi[Địa Chỉ], sSDT[Số Điện Thoại]
from tblNhaXuatBan
where sDiaChi like '%'+@diachi+'%'
end

-- Tìm theo số điện thoại 
create proc pr_TimKiemSDTNXB (@sodt nvarchar(10))
as
begin
select iMaNXB[Mã Nhà Xuất Bản], sTenNXB[Tên Nhà Xuất Bản], sDiaChi[Địa Chỉ], sSDT[Số Điện Thoại]
from tblNhaXuatBan
where sSDT like '%'+@sodt+'%'
end

-- QUẢN LÝ THỂ LOẠI
-- Hiện danh sách thể loại 
create view V_HienTL 
as
select iMaLoai[Mã Loại], sTheLoai[Thể Loại]
from tblTheLoai
group by iMaLoai, sTheLoai

select * from V_HienTL
-- Thêm thể loại 
create proc pr_ThemTL ( @maloai int, @theloai nvarchar(50))
as 
begin
insert into tblTheLoai(iMaLoai, sTheLoai)
values ( @maloai, @theloai)
end 

-- Sửa thể loại  
create proc pr_UpdateTL (@maloai int, @theloai nvarchar(50))
as
begin
update tblTheLoai
set sTheLoai= @theloai
where iMaLoai = @maloai
end

-- Xóa thể loại 
create proc pr_DeleteTL (@maloai int)
as
begin
delete from tblTheLoai
where tblTheLoai.iMaLoai = @maloai
end
drop proc pr_DeleteTL

-- Tìm kiếm thể loại 
--Tìm theo mã thể loại 
create proc pr_TimKiemMaTL (@maloai int)
as
begin
select iMaLoai[Mã Loại], sTheLoai[Thể Loại]
from tblTheLoai
where @maloai = iMaLoai
end

-- Tìm theo tên thể loại 
create proc pr_TimKiemTheLoai (@theloai nvarchar(50) )
as
begin
select iMaLoai[Mã Loại], sTheLoai[Thể Loại]
from tblTheLoai
where sTheLoai like '%'+@theloai+'%'
end
drop proc pr_TimKiemTheLoai
exec pr_TimKiemTheLoai @theloai = N'Du Lịch'
-- QUẢN LÝ SÁCH 
-- Hiện danh sách sách
create view V_HienSach 
as
select iMaSach[Mã Sách], sTenSach[Tên Sách], sTheLoai[Thể Loại], sTacGia[Tác Giả], sTenNXB[Tên Nhà Xuất Bản], iSoLuong [Số Lượng], fGiaSach[Giá Sách], fGiaMuon[Giá Mượn]
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
group by iMaSach, sTenSach, sTheLoai, sTacGia, sTenNXB, iSoLuong, fGiaSach, fGiaMuon

select * from V_HienSach
-- Thêm Sách  
create proc pr_ThemSach ( @masach int, @tensach nvarchar(100), @theloai nvarchar(50), @tacgia nvarchar(20), @tennxb nvarchar(50), @soluong int, @giasach float, @giamuon float)
as 
begin
declare @maloai varchar(20), @manxb varchar(20)
select @maloai= iMaLoai from tblTheLoai where sTheLoai like @theloai
select @manxb= iMaNXB from tblNhaXuatBan where sTenNXB like @tennxb
     insert into tblSach(iMaSach, sTenSach, iMaLoai, sTacGia, iMaNXB, iSoLuong, fGiaSach, fGiaMuon) 
     values ( @masach, @tensach, @maloai, @tacgia, @manxb, @soluong, @giasach, @giamuon)
end 
drop proc pr_ThemSach

-- Sửa Sách  
create proc pr_UpdateSach ( @masach int, @tensach nvarchar(100), @theloai nvarchar(50), @tacgia nvarchar(20), @tennxb nvarchar(50), @soluong int, @giasach float, @giamuon float)
as
begin
declare @maloai varchar(20), @manxb varchar(20)
select @maloai= iMaLoai from tblTheLoai where sTheLoai like @theloai
select @manxb= iMaNXB from tblNhaXuatBan where sTenNXB like @tennxb
    update tblSach
    set iMaSach = @masach, sTenSach = @tensach, iMaLoai = @maloai, sTacGia = @tacgia, iMaNXB = @manxb, iSoLuong = @soluong, fGiaSach = @giasach, fGiaMuon = @giamuon
where iMaSach = @masach
end

-- Xóa Sách 
create proc pr_DeleteSach (@masach int)
as 
begin
delete from tblSach
where tblSach.iMaSach = @masach
end
drop proc pr_DeleteSach

-- Tìm kiếm Sách 
-- Tìm theo tên sách 
create proc pr_TimKiemTenSach (@tensach nvarchar(100))
as
begin
select iMaSach[Mã Sách], sTenSach[Tên Sách], sTheLoai[Thể Loại], sTacGia[Tác Giả], sTenNXB[Tên Nhà Xuất Bản], iSoLuong [Số Lượng], fGiaSach[Giá Sách], fGiaMuon[Giá Mượn]
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
	  where sTenSach like '%'+@tensach+'%'
end
exec pr_TimKiemTenSach @tensach = N'Giải thuật'
-- Tìm theo tác giả 
create proc pr_TimKiemTacGia (@tacgia nvarchar(20))
as
begin
select iMaSach[Mã Sách], sTenSach[Tên Sách], sTheLoai[Thể Loại], sTacGia[Tác Giả], sTenNXB[Tên Nhà Xuất Bản], iSoLuong [Số Lượng], fGiaSach[Giá Sách], fGiaMuon[Giá Mượn]
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
	  where sTacGia like '%'+@tacgia+'%'
end
drop proc pr_TimKiemTacGia
-- Tìm theo nhà xuất bản
create proc pr_TimKiemNhaXuatBan (@nxb nvarchar(50))
as
begin
declare @manxb int 
select @manxb= iMaNXB from tblNhaXuatBan where sTenNXB like @nxb
	select iMaSach[Mã Sách], sTenSach[Tên Sách], sTheLoai[Thể Loại], sTacGia[Tác Giả], sTenNXB[Tên Nhà Xuất Bản], iSoLuong [Số Lượng], fGiaSach[Giá Sách], fGiaMuon[Giá Mượn]
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
where @manxb = tblSach.iMaNXB
end
drop proc pr_TimKiemNhaXuatBan
-- Tìm theo thể loại 
create proc pr_TimKiemTenTheLoai (@theloai nvarchar(50))
as
begin
declare @matl int 
select @matl= iMaLoai from tblTheLoai where sTheLoai like @theloai
	select iMaSach[Mã Sách], sTenSach[Tên Sách], sTheLoai[Thể Loại], sTacGia[Tác Giả], sTenNXB[Tên Nhà Xuất Bản], iSoLuong [Số Lượng], fGiaSach[Giá Sách], fGiaMuon[Giá Mượn]
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
where @matl = tblSach.iMaLoai
end
drop proc pr_TimKiemTenTheLoai
--CRYSTAL REPORT  SÁCH 
-- Hiển thị danh sách sách 
create proc pr_BaoCaoSach
as 
begin
select iMaSach, sTenSach, sTheLoai, sTacGia, sTenNXB, iSoLuong, fGiaSach, fGiaMuon
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
end 

exec pr_BaoCaoSach

--Hiển thị danh sách sách có giá mượn trong khoảng
create proc pr_BaoCaoGiaMuonTrongKhoang ( @giatridau float, @giatricuoi float)
as
begin
select iMaSach, sTenSach, sTheLoai, sTacGia, sTenNXB, iSoLuong, fGiaSach, fGiaMuon
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
	  where @giatridau <= fGiaMuon and @giatricuoi >= fGiaMuon
end 

exec pr_BaoCaoGiaMuonTrongKhoang @giatridau = 10000, @giatricuoi = 12000
--Hiển thị danh sách theo thể loại 
create proc pr_BaoCaoTheoTheLoai (@theloai nvarchar(50))
as
begin
select iMaSach, sTenSach, sTheLoai, sTacGia, sTenNXB, iSoLuong, fGiaSach, fGiaMuon
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
	  where @theloai = sTheLoai
end

exec pr_BaoCaoTheoTheLoai @theloai = N'Kinh Tế'


--- Quản lý sinh viên
--hiện danh sách sinh viên
create view V_HienSV
as
select iMaSV[Mã sinh viên ],sTenSV[Tên sinh viên ],dNgaySinh[Ngày sinh ],sSDT[số điện thoại],sCCCD[cccd]
from tblSinhVien
group by iMaSV,sTenSV,dNgaySinh,sSDT,sCCCD
select *from V_HienSV
--thêm sinh viên
create proc pr_ThemSV ( @MaSV int,@TenSV nvarchar(50),@ngaysinh date, @sodt varchar(10),@cccd varchar(15))
as 
begin
insert into tblSinhVien(iMaSV,sTenSV,dNgaySinh,sSDT,sCCCD)
values (@MaSV,@TenSV,@ngaysinh,@sodt,@cccd)
end 
--sua sinh vien
create proc pr_SuaSV (@MaSV int,@TenSV nvarchar(50),@ngaysinh date, @sodt varchar(10),@cccd varchar(15))
as
begin
update tblSinhVien
set sTenSV = @TenSV,dNgaySinh= @ngaysinh,sSDT=@sodt,sCCCD=@cccd
where iMaSV=@MaSV
end
---xoa sinh vien
create proc pr_DeleteSV (@maSV int)
as
begin 
delete from tblSinhVien
where tblSinhVien.iMaSV = @maSV
end

drop proc pr_DeleteSV
exec pr_DeleteSV @maSV = 1110
select *from tblSinhVien
select *from tblMuonSach
--Tìm theo mã Sinh viên
create proc pr_TimKiemMaSV (@ma int)
as
begin
select *from tblSinhVien
where @ma = iMaSV
end
exec pr_TimKiemMaSV @ma=1111
select *from tblSinhVien
--tìm kiếm theo tên
create proc pr_TimKiemTenSV(@ten NVARCHAR(50))
as
begin
select *from tblSinhVien
where @ten = sTenSV
end
--tìm kiếm theo sdt
create proc pr_TimKiemSVTheoSDT(@SDT VARCHAR(10))
as
begin
select *from tblSinhVien
where @SDT = sSDT
end
--tìm kiếm theo cccd
create proc pr_TimKiemSVTheoCCCD(@CCCD VARCHAR(15))
as
begin
select *from tblSinhVien
where @CCCD = sCCCD 
end
----báo cáo sinh viên
create proc pr_BaoCaoSinhVien
as 
begin
select iMaSV,sTenSV,dNgaySinh,sSDT,sCCCD
from tblSinhVien
end 
---- báo cáo sinh viên có mượn sách
create proc pr_BaoCaoSinhVientuoilonhon(@tuoi int)
as 
begin
select iMaSV,sTenSV,dNgaySinh,sSDT,sCCCD
from tblSinhVien 
where (year(getdate())-year(dngaysinh))>=@tuoi
end 


---báo cáo sinh viên mượn sách trong khoảng thời gian
create proc pr_BaoCaoSinhVienTrongKhoang ( @NgayDau date, @NgayCuoi date)
as
begin
select iMaSV,sTenSV,dNgaySinh,sSDT,sCCCD
from  tblSinhVien 
where  @NgayDau <= dNgaySinh and dNgaySinh >= @NgayCuoi
end 


---	Quản Lý Nhân Viên
create view V_HienNV
as
select iMaNV[Mã Nhân viên ],sTenNV[Tên Nhân Viên ],sGioiTinh[Giới tính ],sDiaChi[Địa Chỉ ],dNgaySinh[Ngày sinh ],dNgayVaoLam[Ngày Vào Làm],sSDT[SDT]
from tblNhanVien
group by iMaNV,sTenNV,sGioiTinh,sDiaChi,dNgaySinh,dNgayVaoLam,sSDT

select* from V_HienNV
---thêm Nhân Viên
create proc pr_ThemNV ( @maNV int, @tenNV nvarchar(50), @gioitinh nvarchar(100),@diachi nvarchar(30),@ngaysinh date,@ngayvaolam date, @sodt varchar(10))
as 
begin
insert into tblNhanVien(iMaNV,sTenNV,sGioiTinh,sDiaChi,dNgaySinh,dNgayVaoLam,sSDT)
values ( @maNV,@tenNV,@gioitinh,@diachi,@ngaysinh,@ngayvaolam,@sodt)
end 
----Sửa Nhân viên
create proc pr_SuaNV ( @maNV int, @tenNV nvarchar(50), @gioitinh nvarchar(100),@diachi nvarchar(30),@ngaysinh date,@ngayvaolam date, @sodt varchar(10))
as 
begin
update tblNhanVien
set sTenNV = @tenNV, sDiaChi = @diachi, sSDT = @sodt
where iMaNV=@maNV
end
--xoa Nhân Viên
 create proc pr_DeleteNV (@maNV int)
as
begin 
delete from tblNhanVien
where tblNhanVien.iMaNV= @maNV
end

select *from tblNhanVien
select *from tblMuonSach
exec pr_DeleteNV @maNV = 101
drop pr_DeleteNV
--Tìm theo mã Sinh viên
create proc pr_TimKiemMaNV (@ma int)
as
begin
select iMaNV[Mã Nhân viên ],sTenNV[Tên Nhân Viên ],sGioiTinh[Giới tính ],sDiaChi[Địa Chỉ ],dNgaySinh[Ngày sinh ],dNgayVaoLam[Ngày Vào Làm],sSDT[SDT]
from tblNhanVien
where @ma = iMaNV
end
drop proc pr_TimKiemMaNV
--tìm kiếm theo tên
create proc pr_TimKiemTenNV(@ten NVARCHAR(50))
as
begin
select iMaNV[Mã Nhân viên ],sTenNV[Tên Nhân Viên ],sGioiTinh[Giới tính ],sDiaChi[Địa Chỉ ],dNgaySinh[Ngày sinh ],dNgayVaoLam[Ngày Vào Làm],sSDT[SDT]
from tblNhanVien
where @ten = sTenNV
end
drop proc pr_TimKiemTenNV
--tìm kiếm theo sdt
create proc pr_TimKiemNVTheoSDT(@SDT VARCHAR(10))
as
begin
select *from tblNhanVien
where @SDT = sSDT
end
--tìm kiếm theo địa chỉ
create proc pr_TimKiemNVTheoDiaChi(@DiaChi NVARCHAR(100))
as
begin
select *from tblNhanVien
where @DiaChi = sDiaChi
end

select *from tblNhanVien
--bao cao nhan vien
create proc pr_BaoCaoNhanVien
as 
begin
select *from tblNhanVien
end 
--bao cao nhan vien co tren x nam lam viec
create proc pr_BaoCaoNhanViencotrenXnamlamvc(@nam int)
as 
begin
select *from tblNhanVien
where (YEAR(getdate())-YEAR(dNgayVaoLam))>=@nam
end 
---bao cao nhan vien theo gioi tính
create proc pr_BaoCaoNhanVientheoGT (@gioitinh nvarchar(3) )
as 
begin
select *from tblNhanVien
where sGioiTinh=@gioitinh
end 

--- QUẢN LÝ MƯỢN SÁCH 
USE [BTL_HSK_QLThuVien]
GO
/****** Object:  StoredProcedure [dbo].[Select_tblMuonsach]    Script Date: 7/2/2023 7:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC Select_tblMuonsach
AS
	SELECT iMaMuon, tblNhanVien.sTenNV, tblSinhVien.sTenSV, dNgayMuon, sTrangThai, fTongTienMuon 
	FROM tblMuonSach 
	INNER JOIN tblNhanVien ON tblMuonSach.iMaNV = tblNhanVien.iMaNV
	INNER JOIN tblSinhVien ON tblMuonSach.iMaSV = tblSinhVien.iMaSV
GO


exec Select_tblMuonsach

CREATE PROC Insert_MuonSach
@iMaMuon int,
@iMaNV varchar(20),
@iMaSV varchar(20),
@dNgayMuon date,
@sTrangThai varchar(20),
@fTongTienMuon float
AS
	INSERT INTO tblMuonSach (iMaMuon, iMaNV, iMaSV, dNgayMuon, sTrangThai, fTongTienMuon)
	VALUES (@iMaMuon, @iMaNV, @iMaSV, @dNgayMuon, @sTrangThai, @fTongTienMuon)
GO

CREATE PROC Delete_MuonSach
@iMaMuon int
AS
	DELETE FROM tblMuonSach WHERE iMaMuon = @iMaMuon
GO

CREATE PROC Update_MuonSach
@iMaMuon int,
@iMaNV varchar(20),
@iMaSV varchar(20),
@dNgayMuon date,
@sTrangThai varchar(20),
@fTongTienMuon float
AS
	UPDATE tblMuonSach 
		SET
		iMaMuon = @iMaMuon,
		iMaNV = @iMaNV,
		iMaSV = @iMaSV,
		dNgayMuon = @dNgayMuon,
		sTrangThai = @sTrangThai,
		fTongTienMuon= @fTongTienMuon
	Where iMaMuon = @iMaMuon
GO

CREATE PROC Select_MaMuon
@iMaMuon int
AS
SELECT iMaMuon FROM tblMuonSach WHERE @iMaMuon = iMaMuon
GO

CREATE PROC Select_ChiTietMuonSach 
AS
	SELECT iMaMuon, sTenSach, fSoLuongMuon, dNgayTra, sTrangThai, tblChiTietMuonSach.fGiaMuon 
	FROM tblChiTietMuonSach
	INNER JOIN tblSach ON tblChiTietMuonSach.iMaSach = tblSach.iMaSach
GO

drop proc Select_ChiTietMuonSach

CREATE PROC Insert_ChiTietMuonSach
@iMaMuon int,
@iMaSach varchar(20),
@fSoLuongMuon float,
@dNgayTra date,
@sTrangThai varchar(20),
@fGiaMuon float
AS
	INSERT INTO tblChiTietMuonSach (iMaMuon, iMaSach, fSoLuongMuon, dNgayTra, sTrangThai, fGiaMuon)
	VALUES (@iMaMuon, @iMaSach, @fSoLuongMuon, @dNgayTra, @sTrangThai, @fGiaMuon)
GO

CREATE PROC Delete_ChiTietMuonSach
@iMaMuon int
AS
	DELETE FROM tblChiTietMuonSach WHERE iMaMuon = @iMaMuon
GO

CREATE PROC Update_ChiTietMuonSach
@iMaMuon int,
@iMaSach varchar(20),
@fSoLuongMuon float,
@dNgayTra date,
@sTrangThai varchar(20),
@fGiaMuon float
AS
	UPDATE tblChiTietMuonSach
		SET
		iMaMuon = @iMaMuon,
		iMaSach = @iMaSach,
		fSoLuongMuon = @fSoLuongMuon,
		dNgayTra = @dNgayTra,
		sTrangThai = @sTrangThai, 
		fGiaMuon = fGiaMuon
	WHERE iMaMuon = @iMaMuon
GO

Create VIEW Select_MuonSach AS
SELECT ms.iMaMuon, ms.iMaNV, ms.iMaSV, ms.dNgayMuon, ms.sTrangThai, ms.fTongTienMuon, sv.sTenSV, sv.sSDT, s.iMaSach, s.sTenSach, ctms.fSoLuongMuon, ctms.fGiaMuon, nv.sTenNV
FROM tblMuonSach ms 
INNER JOIN tblChiTietMuonSach ctms ON ms.iMaMuon = ctms.iMaMuon
INNER JOIN tblSach s ON s.iMaSach = ctms.iMaSach
INNER JOIN tblNhanVien nv ON nv.iMaNV = ms.iMaNV
INNER JOIN tblSinhVien sv ON sv.iMaSV = ms.iMaSV;
GO

Create PROCEDURE Select_BaoCaoMuonSach
    @iMaMuon INT = NULL
AS
BEGIN
    IF @iMaMuon IS NULL
    BEGIN
        SELECT *
        FROM Select_MuonSach;
    END
    ELSE
    BEGIN
        SELECT *
        FROM Select_MuonSach
        WHERE iMaMuon = @iMaMuon;
    END
END;

create proc Select_BaoCaoChiTietMuonSach
as 
begin
select ctms.iMaMuon, ctms.fSoLuongMuon, ctms.fGiaMuon, ms.dNgayMuon, sv.iMaSV, sv.sTenSV, sv.sSDT, nv.iMaNV, nv.sTenNV, s.iMaSach, nxb.sTenNXB, s.sTacGia, s.sTenSach, s.iSoLuong
from tblChiTietMuonSach ctms 
	  inner join tblMuonSach ms on ms.iMaMuon = ctms.iMaMuon
	  inner join tblSinhVien sv on sv.iMaSV = ms.iMaSV
	  inner join tblNhanVien nv on nv.iMaNV = ms.iMaNV
      inner join tblSach s on s.iMaSach = ctms.iMaSach
	  inner join tblNhaXuatBan nxb on nxb.iMaNXB = s.iMaNXB
end

EXEC Select_BaoCaoChiTietMuonSach
Select * from tblSach


--- QUẢN LÝ trả SÁCH 
use BTL_HSK_QLThuVien



CREATE view  Select_tblTraSach
AS
	SELECT iMaTra,iMaMuon, tblNhanVien.sTenNV, tblSinhVien.sTenSV, dNgayTra, fTongTienPhat
	FROM tblTraSach 
	INNER JOIN tblNhanVien ON tblTraSach.iMaNV = tblNhanVien.iMaNV
	INNER JOIN tblSinhVien ON tblTraSach.iMaSV = tblSinhVien.iMaSV
GO

CREATE PROC Insert_TraSach
@iMaTra int,
@iMaMuon int,
@iMaNV varchar(20),
@iMaSV varchar(20),
@dNgayTra date,
@fTongTienPhat float
AS
	INSERT INTO tblTraSach(iMaTra,iMaMuon, iMaNV, iMaSV, dNgayTra, fTongTienPhat)
	VALUES (@iMaTra,@iMaMuon, @iMaNV, @iMaSV, @dNgayTra, @fTongTienPhat)
GO

CREATE PROC Delete_TraSach
@iMaTra int
AS
	DELETE FROM tblTraSach WHERE iMaTra = @iMaTra
GO

CREATE PROC Update_TraSach
@iMaTra int,
@iMaMuon int,
@iMaNV varchar(20),
@iMaSV varchar(20),
@dNgayTra date,
@fTongTienPhat float
AS
	UPDATE tblTraSach 
		SET
		iMaTra = @iMaTra,
		iMaMuon = @iMaMuon,
		iMaNV = @iMaNV,
		iMaSV = @iMaSV,
		dNgayTra = @dNgayTra,
		fTongTienPhat= @fTongTienPhat
	Where iMaTra=@iMaTra 
GO

CREATE view Select_ChiTietTraSach 
AS
	SELECT iMaTra, sTenSach, fSoLuongTra,  sTrangThaiSach,fGiaPhat 
	FROM tblChiTietTraSach
	INNER JOIN tblSach ON tblChiTietTraSach.iMaSach = tblSach.iMaSach
GO
select*from tblChiTietMuonSach
select*from tblChiTietTraSach



CREATE PROC Insert_ChiTietTraSach
@iMaTra int,
@iMaSach varchar(20),
@fSoLuongTra float,
@sTrangThaiSach varchar(20),
@fGiaPhat float
AS
	INSERT INTO tblChiTietTraSach (iMaTra, iMaSach, fSoLuongTra,sTrangThaiSach, fGiaPhat)
	VALUES (@iMaTra, @iMaSach, @fSoLuongTra, @sTrangThaiSach, @fGiaPhat)
GO

CREATE PROC Delete_ChiTietTraSach
@iMaTra int
AS
	DELETE FROM tblChiTietTraSach WHERE iMaTra = @iMaTra
GO
CREATE PROC Update_ChiTietTraSach
@iMaTra int,
@iMaSach varchar(20),
@fSoLuongTra float,
@sTrangThaiSach varchar(20),
@fGiaPhat float
AS
	UPDATE tblChiTietTraSach
		SET
		iMaTra =@iMaTra,
		iMaSach =@iMaSach,
		fSoLuongTra=@fSoLuongTra,
		sTrangThaiSach=@sTrangThaiSach,
		fGiaPhat=@fGiaPhat
	WHERE iMaTra = @iMaTra
GO


-- thi
create proc pr_TimKiemGiaSachTrongKhoang ( @giatridau float, @giatricuoi float)
as
begin
select iMaSach, sTenSach, sTheLoai, sTacGia, sTenNXB, iSoLuong, fGiaSach, fGiaMuon
from (tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai
	  where @giatridau <= fGiaSach and @giatricuoi >= fGiaSach
end 


create proc pr_BaoCaoSach2
as 
begin
select tblSach.iMaSach, sTenSach, sTheLoai, sTacGia, sTenNXB, iSoLuong, fGiaSach, tblSach.fGiaMuon, COUNT(fSoLuongMuon) as N'Slmuon'
from ((tblNhaXuatBan inner join tblSach on tblNhaXuatBan.iMaNXB = tblSach.iMaNXB) 
      inner join tblTheLoai on tblSach.iMaLoai = tblTheLoai.iMaLoai) 
	  inner join tblChiTietMuonSach on tblSach.iMaSach = tblChiTietMuonSach.iMaSach
	  group by tblSach.iMaSach, sTenSach, sTheLoai, sTacGia, sTenNXB, iSoLuong, fGiaSach, tblSach.fGiaMuon
end 
drop proc pr_BaoCaoSach2
exec pr_BaoCaoSach2