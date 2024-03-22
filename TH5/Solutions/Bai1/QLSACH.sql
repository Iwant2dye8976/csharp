CREATE DATABASE QLSACH

CREATE TABLE LOAISACH
(
	MaLoai char(10) not null primary key,
	TenLoai nvarchar(50)
)

CREATE TABLE NXB(
	MaNXB char(10) not null primary key,
	TenNXB Nvarchar(50)
)

CREATE TABLE Tacgia(MaTG char(10) not null primary key, TenTG Nvarchar(50))

CREATE TABLE HD(MaHD char(10) not null primary key, TenKhach Nvarchar(50), SDT
char(10), Tongtien int)


CREATE TABLE SACH
(
	MaSach char(10) not null primary key, 
	MaLoai char(10), 
	MaTG char(10), 
	MaNXB char(10), 
	TenSach Nvarchar(100), 
	Dongia int, 
	Soluong int

	foreign key (MaLoai) references LOAISACH(MaLoai),
	foreign key (MaNXB) references NXB(MaNXB),
	foreign key (MaTG) references Tacgia(MaTG)
)

CREATE TABLE ChitietHD(
	MaHD char(10) not null primary key,
	MaSach char(10),
	Soluong int,
	Giaban int,

	foreign key (MaSach) references SACH(MaSach)
)

ALTER TABLE ChitietHD ADD FOREIGN KEY(MaHD) REFERENCES HD(MaHD)
select SUM
