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
	CCCD varchar(50) not null,
	NgaySinh Date 
);


CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY identity(1,1),
    NgayLap DaTETIME NOT NULL,
    Email varchar(50)  NOT NULL,
    TongTien DECIMAL(10, 2) NOT NULL,
	TienNhan DECIMAL(10, 2) NOT NULL,
	TienTraLai DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (Email) REFERENCES NhanVien(Email),
);
CREATE TABLE SanPham (
	
    MaSanPham INT PRIMARY KEY IDENTITY(1,1), -- Mã sản phẩm, tự động tăng
    TenSanPham NVARCHAR(100) NOT NULL,       -- Tên sản phẩm
    Gia DECIMAL(18, 2) NOT NULL,             -- Giá của sản phẩm
    PhanLoai NVARCHAR(20),                   -- Phân loại
    HinhAnh NVARCHAR(200)                    -- Hình ảnh

);

CREATE TABLE ChiTietHoaDon (
    MaChiTiet INT PRIMARY KEY identity(1,1) ,
    MaHoaDon INT NOT NULL,
    MaSanPham INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(10, 2) NOT NULL,
    ThanhTien DECIMAL(10, 2) AS (SoLuong * DonGia) STORED,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

alter table NhanVien add NgaySinh Date 

create table TaiKhoan 
(
	Email varchar(50) primary key  foreign key references NhanVien(Email) , 
	HashedPassword varchar(400) NOT NULL,
    Salt varchar(100) NOT NULL,
	
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


create proc Load_SP 
as
 begin
	select * from SanPham
 end 
create proc Load_Food
 as
 begin 
	select * from SanPham where PhanLoai = 'Đồ ăn'
 end 


create proc Load_Drink 
 as
 begin
	select * from SanPham where TenSanPham = 'Cafe đen'
 end

 exec Load_SP

 INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm A', 100.00, 'Loại 1', '/images/sp1.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm B', 150.00, 'Loại 2', '/images/sp2.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm C', 120.50, 'Loại 1', '/images/sp3.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm D', 200.00, 'Loại 2', '/images/sp4.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm E', 80.00, 'Loại 1', '/images/sp5.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm F', 300.00, 'Loại 2', '/images/sp6.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm G', 250.00, 'Loại 1', '/images/sp7.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm H', 180.75, 'Loại 2', '/images/sp8.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm I', 90.25, 'Loại 1', '/images/sp9.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm J', 210.50, 'Loại 2', '/images/sp10.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm K', 95.00, 'Loại 1', '/images/sp11.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm L', 180.00, 'Loại 2', '/images/sp12.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm M', 150.00, 'Loại 1', '/images/sp13.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm N', 220.00, 'Loại 2', '/images/sp14.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm O', 120.50, 'Loại 1', '/images/sp15.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm P', 260.00, 'Loại 2', '/images/sp16.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm Q', 110.00, 'Loại 1', '/images/sp17.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm R', 180.00, 'Loại 2', '/images/sp18.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm S', 95.75, 'Loại 1', '/images/sp19.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm T', 200.50, 'Loại 2', '/images/sp20.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm U', 85.00, 'Loại 1', '/images/sp21.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm V', 175.00, 'Loại 2', '/images/sp22.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm W', 130.25, 'Loại 1', '/images/sp23.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm X', 240.00, 'Loại 2', '/images/sp24.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm Y', 100.00, 'Loại 1', '/images/sp25.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm Z', 300.00, 'Loại 2', '/images/sp26.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AA', 280.00, 'Loại 1', '/images/sp27.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AB', 95.50, 'Loại 2', '/images/sp28.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AC', 200.25, 'Loại 1', '/images/sp29.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AD', 150.00, 'Loại 2', '/images/sp30.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AE', 110.75, 'Loại 1', '/images/sp31.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AF', 190.50, 'Loại 2', '/images/sp32.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AG', 85.00, 'Loại 1', '/images/sp33.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AH', 220.00, 'Loại 2', '/images/sp34.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AI', 130.00, 'Loại 1', '/images/sp35.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AJ', 240.75, 'Loại 2', '/images/sp36.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AK', 175.00, 'Loại 1', '/images/sp37.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AL', 300.00, 'Loại 2', '/images/sp38.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AM', 95.25, 'Loại 1', '/images/sp39.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AN', 180.50, 'Loại 2', '/images/sp40.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AO', 210.00, 'Loại 1', '/images/sp41.jpg');
INSERT INTO SanPham (TenSanPham, Gia, PhanLoai, HinhAnh) VALUES ('Sản phẩm AP', 120.00, 'Loại 2', '/images/sp ');


delete from SanPham where MaSanPham != 1 