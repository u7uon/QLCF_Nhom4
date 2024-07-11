create database QuanLyQuanCafe
go
use QuanLyQuanCafe


create TABLE NhanVien
(
    ID int IDENTITY(1,1) NOT NULL,
    MaNV AS ('NV' + CAST(ID AS VARCHAR)) PERSISTED PRIMARY KEY,
    Email varchar(50) NOT NULL UNIQUE,
    TenNV nvarchar(100) NOT NULL,
    VaiTro tinyint DEFAULT 0,
    GioiTinh nvarchar(5) ,
    SoDT varchar(13),
    DiaChi nvarchar(100),
	 CCCD varchar(50) not null
);

alter table NhanVien add NgaySinh Date 
create table TaiKhoan 
(
	Email varchar(50) primary key  foreign key references NhanVien(Email) , 
	HashedPassword varchar(400) NOT NULL,
    Salt varchar(100) NOT NULL,
	MatKhau varchar(400) ,
)


	

alter table NhanVien drop column Luong

-- Chèn dữ liệu ví dụ
INSERT INTO NhanVien (Email, TenNV, VaiTro, GioiTinh, SoDT, DiaChi, MatKhau)
VALUES ('duonng1203@gmail.com', 'Nguyen Van A', 1, 'Nam', '0123456789', '123 Street', '123');

go



alter proc DangNhap
@email varchar(50) , @MatKhau varchar(50) 
as 
begin 
declare @check int
	if exists (select * from TaiKhoan where email = @email and HashedPassword = @MatKhau)
		set @check = 1
	else
		set @check = 0
	select @check
end


create proc getSalt
@Email varchar(50) 
as
begin
	select Salt from TaiKhoan where Email = @Email
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
alter proc DoiMatKhau 
	@email varchar(50),
	@MatKhauCu varchar(400) ,
	@MatKhauMoi varchar(400) ,
	@Salt varchar(100)
as 
begin 
	declare @matKhau  varchar(50) 
	declare @status int 
	select @matKhau = HashedPassword from TaiKhoan where email = @email
	if ( @matKhau = @MatKhauCu ) 
		begin 
			update TaiKhoan set HashedPassword = @MatKhauMoi , Salt = @Salt where email = @email
			set @status = 1
		end
	else 
		set @status = 0 
	select @status
end




go
alter proc DanhSachNV
as
begin
select Email , TenNV ,  VaiTro , GioiTinh ,SoDT ,DiaChi ,CCCD ,NgaySinh  from NhanVien
end
go
select * from NhanVien
alter proc LayVaiTro 
	@Email varchar(50) 
as
begin
	Select Vaitro from NhanVien where email = @Email
end



alter proc setNewPass 
@email varchar(50) ,  @pass varchar(400) , @salt varchar(100)  
as 
begin 
	Update TaiKhoan set HashedPassword = @pass , Salt =@salt    where Email = @email
end


--Thêm nhân viên
create proc  insert_NhanVien 
@Email varchar(50) ,
@TenNV varchar(100) , 
@SoDienThoai varchar(15), 
@DiaChi nvarchar(100) , 
@GioiTinh nvarchar(5) , 
@CCCD varchar(30) ,
@NgaySinh Date ,
@VaiTro tinyint 
as
begin
	insert into NhanVien values ( @Email ,@TenNV , @VaiTro , @GioiTinh ,@SoDienThoai, @DiaChi ,@CCCD ,@NgaySinh    )  
end


create proc inset_TK 
@Email  varchar(50) , 
@HashedPass varchar(400) ,
@Salt varchar(100) 
as
begin
	insert into TaiKhoan values ( @Email , @HashedPass , @Salt ) 
end
