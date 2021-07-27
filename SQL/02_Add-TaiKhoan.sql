create table TaiKhoan
(
	MaNhanVien varchar(10),
	foreign key (MaNhanVien) references NhanVien(MaNhanVien),
	TenDangNhap varchar(20),
	MatKhau varchar(20),
	TrangThai bit
)
go

insert into dbo.TaiKhoan values ('NV001', 'thaingocquang', '12345', 'true')