alter table tblSinhVien
add constraint PK_iMasv primary key(iMasv);

create proc pr_themsv(
@masv int,
@tensv nvarchar(20),
@ngaysinh date,
@gt nvarchar(3),
@trangthai nvarchar(50))
as 
insert into tblSinhVien (iMasv, sTensv, dNgaysinh, bGioitinh, sTrangthai)
values (@masv, @tensv, @ngaysinh, @gt, @trangthai)

drop proc pr_themsv
exec pr_themsv @masv=809777,@tensv=N'Nguyễn Thành Lương',@ngaysinh='12/10/2000',@gt=N'nam', @trangthai = 'tot'

create login luong with password = '2003'


create proc pr_Xoasv (@masv int)
as
begin
delete from tblSinhVien
where iMasv = @masv
end
exec pr_Xoasv @masv = 1
drop proc  pr_Xoasv

create proc pr_Timkiemsv(@tensv nvarchar(20))
as
begin
select iMasv, sTensv, dNgaysinh, bGioitinh
from tblSinhVien
where sTensv like '%'+@tensv+'%'
end
exec pr_Timkiemsv @tensv = N'Tung'
drop proc pr_Timkiemsv

create proc pr_Timkiemthangsv(@thang int)
as
begin
select iMasv, sTensv, dNgaysinh, bGioitinh
from tblSinhVien
where @thang = MONTH(dNgaysinh)
end
exec pr_Timkiemthangsv @thang = 11
drop proc pr_Timkiemthangsv


create proc pr_Capnhatsv( @masv int, @tensv nvarchar(20), @ngaysinh date, @gioitinh nvarchar(3))
as
begin
update tblSinhVien
set sTensv = @tensv, dNgaysinh = @ngaysinh, bGioitinh = @gioitinh
where iMasv = @masv
end
 
create proc pr_ktramasv(@masv int)
as
begin
select tblSinhVien.iMasv
from tblSinhVien
where @masv = iMasv
end

exec pr_ktramasv @masv = 0

create view V_Hiennganh
as
select *from tblNganh ;

create view V_Hiensinhvien
as
select *from tblSinhVien ;

drop view V_Hiennganh

select *from V_Hiensinhvien


