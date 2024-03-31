create database QLDIEM
create table DIEM
(
	MaSV char(5) not null primary key,
	HoTen nchar(30),
	MonHoc nchar(30),
	Diem float
)