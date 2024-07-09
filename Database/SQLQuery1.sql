create database QuanLyQuanCafe
go
use QuanLyQuanCafe


CREATE TABLE NhanVien
(
    ID int IDENTITY(1,1) NOT NULL,
    MaNV AS ('NV' + CAST(ID AS VARCHAR)) PERSISTED PRIMARY KEY,
    Email varchar(50) NOT NULL UNIQUE,
    TenNV nvarchar(100) NOT NULL,
    VaiTro tinyint DEFAULT 0,
    GioiTinh nvarchar(5) ,
    SoDT varchar(13),
    DiaChi nvarchar(100),
    MatKhau varchar(300) NOT NULL
);



-- Chèn dữ liệu ví dụ
INSERT INTO NhanVien (Email, TenNV, VaiTro, GioiTinh, SoDT, DiaChi, MatKhau)
VALUES ('example@example.com', 'Nguyen Van A', 1, 'Nam', '0123456789', '123 Street', 'hashed_password');

go
create proc DangNhap
@email varchar(50) , @MatKhau varchar(50) 
as 
begin 
declare @check int
	if exists (select * from NhanVien where email = @email and MatKhau = @MatKhau)
		set @check = 1
	else
		set @check = 0
	select @check
end
go
--Kiểm tra email có tồn tại không 
create proc checkEmail
@email varchar(50) 
as begin
	declare @check int 
	if exists (select MaNV from NhanVien where email =@email ) 
		set @check = 1 
	 else 
		set @check =0 
 select @check 
end

-- Đổi mật khẩu
create proc DoiMatKhau 
	@email varchar(50),
	@MatKhauCu varchar(50) ,
	@MatKhauMoi varchar(50) 
as 
begin 
	declare @matKhau  varchar(50) 
	select @matKhau = MatKhau from NhanVien where email = @email
	if ( @matKhau = @MatKhauCu ) 
		begin 
			update NhanVien set MatKhau = @MatKhauMoi where email = @email
			return 1
		end
	else 
		return 0 
end


go
create proc DanhSachNV
as
begin
select MANV,TenNV,Email,VaiTro,DiaChi,MatKhau from NhanVien
end
go
