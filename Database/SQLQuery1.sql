create database QuanLyQuanCafe
go
use QuanLyQuanCafe


CREATE TABLE NhanVien
(
    ID int IDENTITY(1,1) NOT NULL,
    MaNV AS ('NV' + CAST(ID AS VARCHAR)) PERSISTED PRIMARY KEY,
    Email varchar(50) NOT NULL UNIQUE,
    TenNV nvarchar(100) NOT NULL,
    VaiTro tinyint ,
    GioiTinh nvarchar(5) ,
	Luong float not null , 
    SoDT varchar(13),
    DiaChi nvarchar(100),
    MatKhau varchar(300) NOT NULL, 
);


-- Chèn dữ liệu ví dụ
INSERT INTO NhanVien (Email, TenNV, VaiTro, GioiTinh, SoDT, DiaChi, MatKhau)
VALUES ('example@example.com', 'Nguyen Van A', 1, 'Nam', '0123456789', '123 Street', 'hashed_password');