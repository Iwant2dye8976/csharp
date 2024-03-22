CREATE DATABASE SINHVIEN
CREATE TABLE SinhVien
(
	MaSV char(10) NOT NULL PRIMARY KEY,
	HoTen nchar(50),
	NgaySinh date,
	Gioitinh nchar(10),
	Quequan nchar(50)
)