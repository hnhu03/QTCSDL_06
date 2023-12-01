create database QuanLiBanHang
use QuanLiBanHang
--Tao bang tai khoan
create table TaiKhoan(
	TaiKhoan varchar(100),
	MatKhau varchar(100)
	)
	insert into TaiKhoan values ('nhu','12345')
--Tạo bảng Nhân Viên

create table NhanVien
(	MaNhanVien nvarchar(20) primary key not null,
	TenChiNhanh	nvarchar(30),
	HanhDong bit,
)
--Tạo bảng Món
create table Mon
(	MaMon nvarchar(20) primary key not null,
	TenMon nvarchar(30),
	DonGiaBan float,
)
--Tạo bảng Hàng Nhập Vào

create table HangNhapVao
(	MaHangNhap nvarchar(20) primary key not null,
	TenHangNhap	nvarchar(30),
	DonGiaNhap float,
	
)
go
select*from HangNhapVao
--Tạo bảng Khách hàng
create table KhachHang
(
	MaKhachHang nvarchar(20) primary key not null,
	TenKhachHang nvarchar(30),
	DiaChiKhachHang nvarchar(30),
	SdtKhachHang nvarchar(10),
)

--Tạo bảng Nhập

create table Nhap
(
	MaNhapHang nvarchar(20) primary key not null,
	MaNhanVien nvarchar(20),
	Ngay date,
	TongTien float,
	foreign key (MaNhanVien) references NhanVien(MaNhanVien),
)
--Tạo bảng Nhập chi tiết

create table Nhapchitiet
(
	MaNhapHang nvarchar(20)  not null,
	MaHangNhap nvarchar(20)  not null ,
	TenHangNhap nvarchar(30),
	SoLuong float,
	DonGiaNhap float,
	CongNoCu nvarchar(20),
	ThanhTien float,	
	foreign key (MaHangNhap) references HangNhapVao (MaHangNhap),
)
--Tạo bảng Bán 
create table Ban
(
	MaHoaDon nvarchar(20) primary key not null,
	MaKhachHang nvarchar(20),
	NgayBan date,
	TongTienHang float,
	VAT float,
	TongCong float,
	foreign key (MaKhachHang) references KhachHang(MaKhachHang),
)
--Tạo bảng Bán chi tiết
create table BanChiTiet
(
	MaHoaDon nvarchar(20)  not null,
	MaMon nvarchar(20) ,
	TenMon nvarchar(30),
	MaNhanVien nvarchar(20),
	DonGiaBan float,
	SoLuong float,
	ThanhTien float,
	foreign key (MaMon) references Mon(MaMon),
	foreign key (MaNhanVien) references NhanVien(MaNhanVien)
)
insert into HangNhapVao values('HNV1','Jimbean','230000')
insert into HangNhapVao values('HNV2','Chicken Breast','90000')
insert into HangNhapVao values('HNV3','Burger Buns','6000')
insert into HangNhapVao values('HNV4','Wagyu Rump','200000')
insert into HangNhapVao values('HNV5','Coca Cola','8000')
insert into HangNhapVao values('HNV6','Panini','14000')
insert into HangNhapVao values('HNV7','Fish Basa','55000')
insert into HangNhapVao values('HNV8','Chicken Wings','90000')
insert into HangNhapVao values('HNV9','Huda Sliver','270000')
insert into HangNhapVao values('HNV10','Huda Gold','380000')
insert into HangNhapVao values('HNV11','Huda Ice','330000')
insert into HangNhapVao values('HNV12','Tuborg','335000')
insert into HangNhapVao values('HNV13','Carlsberg','415000')
insert into HangNhapVao values('HNV14','Hot Dogs','5000')
insert into HangNhapVao values('HNV15',N'Rượu Vang Đỏ Dalat','185000')
insert into HangNhapVao values('HNV16','Eggs','25000')
insert into HangNhapVao values('HNV17',N'Thịt bò mông Úc','300000')
insert into HangNhapVao values('HNV18',N'Đùi gà góc tư','44000')
insert into HangNhapVao values('HNV19','Captain Morgan','340000')
insert into HangNhapVao values('HNV20','Tuborg','335000')
insert into HangNhapVao values('HNV21','Orange','35000')
insert into HangNhapVao values('HNV22','Potato','15000')
insert into HangNhapVao values('HNV23','Salad','25000')
select*from HangNhapVao
---
insert into NhanVien values ('NV01','CN01',1)
insert into NhanVien values ('NV02','CN01',1)
insert into NhanVien values ('NV03','CN01',0)
insert into NhanVien values ('NV04','CN01',0)
insert into NhanVien values ('NV05','CN01',0)
go

insert into Mon values ('M01','Huda','35000')
insert into Mon values ('M02','Blance 1664','50000')
insert into Mon values ('M03','Caesar Salad','75000')
insert into Mon values ('M04','Greek Salad','75000')
insert into Mon values ('M05','Potato Salad','60000')
insert into Mon values ('M06','Smash Burger & Chip','100000')
insert into Mon values ('M07','Beef Burger & Chip','145000')
insert into Mon values ('M08','Cheese Burger & Chip','150000')
insert into Mon values ('M09','Cheddar Melt Burger & Chip','150000')
insert into Mon values ('M10','Chicken Mayo Panini','125000')
insert into Mon values ('M11','Korean Chicken Burger & Chip','150000')
insert into Mon values ('M12','250 Wagyu Rump','480000')
insert into Mon values ('M13','Steak Special','180000')
insert into Mon values ('M14','Mixed Grill','1200000')
insert into Mon values ('M15','Rack with Chips and Onion Ring','287000')
insert into Mon values ('M16','Rack Smoked Ham Rib with Chips','287000')
insert into Mon values ('M17','Peri Peri Chiken Leg','160000')
insert into Mon values ('M18','Slow Cooked Chicken with Rice','145000')
insert into Mon values ('M19','Chicken Tender','80000')
insert into Mon values ('M20','Boerewons and Chips','125000')
insert into Mon values ('M21','Beef Samosa','120000')
insert into Mon values ('M22','BBQ Chicken Wings','180000')
insert into Mon values ('M23','Mac and Cheese','150000')
insert into Mon values ('M24','Coke','35000')
insert into Mon values ('M25','Juice','35000')
insert into Mon values ('M26','Mix Juice','45000')
insert into Mon values ('M27','Braai Brootjie','45000')
insert into Mon values ('M28','Chicken Teriyaki Skewer','100000')
insert into Mon values ('M29','Fish Finger with Crispy Fries','100000')
insert into Mon values ('M30','Pork Skewer 2pcs','100000')
insert into Mon values ('M31','Grill Chicken Caesar Salad','125000')
insert into Mon values ('M32','Chip Regular or Slap Chip','45000')
insert into Mon values ('M33','Sweet Carrot','65000')
insert into Mon values ('M34','Butter Nut','65000')
insert into Mon values ('M35','Mashed Green Beans','65000')
insert into Mon values ('M36','Broccoli and Potato','65000')
insert into Mon values ('M37','Foot Long Cheese Griller ','90000')
insert into Mon values ('M38','Teriyaki Chicken Panini','135000')
insert into Mon values ('M39','Stir-fry Pork with Rice','130000')
insert into Mon values ('M40','Stir-fry Chicken with Rice','130000')
insert into Mon values ('M41','Stir-fry Veggies with Rice','85000')
insert into Mon values ('M42','Stir-fry Pepper Beef','150000')
insert into Mon values ('M43','Crispy Fried Basa,Chips','145000')
insert into Mon values ('M44','Crispy Basa, Calamari Chips','185000')
insert into Mon values ('M45','Calamari Traditional 250g','180000')
insert into Mon values ('M46','Tiger Prawn Saganaki','160000')
insert into Mon values ('M47','Pork Schnitzel with Mash','145000')
insert into Mon values ('M48','Pork Chop with Mash and Salad','180000')
insert into Mon values ('M49','Boerewons with Mash','180000')
insert into Mon values ('M50','Black Pepper Sauces','55000')
insert into Mon values ('M51','Creamy Peri Peri Sauces','55000')
insert into Mon values ('M52','Garlic Butter Sauces','55000')
insert into Mon values ('M53','Blue Cheese Ranch Sauces','55000')
insert into Mon values ('M54','Huda draft','45000')
insert into Mon values ('M55','Beer Shandy 500ml','35000')
insert into Mon values ('M56','Huda Gold','40000')
insert into Mon values ('M57','Huda Ice','35000')
insert into Mon values ('M58','Tuborg','45000')
insert into Mon values ('M59','Carlsberg','50000')
insert into Mon values ('M60','Somerby Apple','50000')
insert into Mon values ('M61','Somerby Blackberry','50000')
insert into Mon values ('M62','House Red glass','75000')
insert into Mon values ('M63','House White glass','75000')
insert into Mon values ('M64','Pinot Grigio Rose glass','75000')
insert into Mon values ('M65','Leonard RD Shiraz','420000')
insert into Mon values ('M66','Leonard RD Shemillon','420000')
insert into Mon values ('M67','Mojito','95000')
insert into Mon values ('M68','Black White Russian','95000')
insert into Mon values ('M69','Blood Mary','95000')
insert into Mon values ('M70','Blue Lagoon','95000')
insert into Mon values ('M71','Daiquiri','95000')
insert into Mon values ('M72','Long Island Ice Tea','95000')
insert into Mon values ('M73','Martini Classic','95000')
insert into Mon values ('M74','Old Fashion','120000')
insert into Mon values ('M75','Tequila Sunrise','95000')
insert into Mon values ('M76','Whiskey Sour','95000')
insert into Mon values ('M77','Blue Hawaiian','95000')
insert into Mon values ('M78','Sex On The Beach','95000')
insert into Mon values ('M79','Fruit Tigle','95000')
insert into Mon values ('M80','Pain Killer','95000')
insert into Mon values ('M81','Iron Man','95000')
insert into Mon values ('M82','Maitai','95000')
insert into Mon values ('M83','Rasberry Mojito','95000')
go

insert into KhachHang values ('MKH01','Mike','London','0914162689')
insert into KhachHang values ('MKH02',N'Diễm Quỳnh','Quảng Nam','0978178764')
insert into KhachHang values ('MKH03',N'Sam','Thailand','0979809204')
insert into KhachHang values ('MKH04',N'Diễm',N'Bình Định','0972209204')
insert into KhachHang values ('MKH05',N'Hoàng Như',N'Quảng Nam','0905682529')
insert into KhachHang values ('MKH06',N'Gino',N'Nam Phi','0905684387')
insert into KhachHang values ('MKH07',N'Tuyết Nhung',N'Đà Nẵng','0982725726')
insert into KhachHang values ('MKH08',N'Ngọc Huy',N'Đà Nẵng','0982722326')
insert into KhachHang values ('MKH09',N'Alex',N'Anh','0937303282')
insert into KhachHang values ('MKH11',N'Funky',N'Pháp','0937456282')
insert into KhachHang values ('MKH10',N'Yolande',N'Nam Phi','0974131489')
insert into KhachHang values ('MKH12',N'Jacques',N'Nam Phi','0974122489')
insert into KhachHang values ('MKH13',N'Tường Vân',N'Tiền Giang','0122803933')
insert into KhachHang values ('MKH14',N'Đào Xuân Đinh',N'Đà Nẵng','0122842833')
insert into KhachHang values ('MKH15',N'Ngọc Dung',N'Hà Nội','0977433157')
insert into KhachHang values ('MKH16',N'Xuân Việt',N'Đà Nẵng','0922433157')
insert into KhachHang values ('MKH17',N'Barex',N'Anh','0977583157')
insert into KhachHang values ('MKH18',N'James',N'Singapore','0906248184')
insert into KhachHang values ('MKH19',N'Salim',N'Đà Nẵng','0906693784')
insert into KhachHang values ('MKH20',N'Tiến Hưng',N'Hà Nội','0906249264')


go
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH02','NV01','09-11-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH03','NV03','10-20-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH04','NV01','1-10-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH05','NV02','02-11-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH06','NV02','10-16-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH07','NV03','09-10-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH08','NV01','10-17-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH09','NV04','11-04-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH10','NV01','11-04-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH11','NV04','11-04-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH12','NV04','08-04-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH13','NV01','08-26-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH14','NV04','10-07-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH15','NV05','11-28-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH16','NV01','10-20-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH17','NV02','10-22-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH18','NV03','11-23-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH19','NV03','11-19-2023')
insert into Nhap(MaNhapHang,MaNhanVien,Ngay) values('MNH20','NV05','11-05-2023')
select*from Nhap

go
create trigger tgNhapchitiet
on Nhapchitiet
for insert, update, delete 
as
begin
	update Nhapchitiet
	set TenHangNhap = (select TenHangNhap from HangNhapVao where  MaHangNhap = (select MaHangNhap from inserted))
	where MaHangNhap = (select MaHangNhap from inserted)
	update Nhapchitiet 
	set DonGiaNhap = (select DonGiaNhap from HangNhapVao where MaHangNhap = (select MaHangNhap from inserted))
	where MaHangNhap = (select MaHangNhap from inserted)
	update Nhapchitiet
	set ThanhTien =  DonGiaNhap * SoLuong + ( select CongNoCu from Nhapchitiet where (MaHangNhap = (select MaHangNhap from inserted)) and MaNhapHang= (select MaNhapHang from inserted))
	where  (MaHangNhap = (select MaHangNhap from inserted) and MaNhapHang = (select MaNhapHang from inserted))
	update Nhap
	set TongTien = ( select sum(ThanhTien) from Nhapchitiet where MaNhapHang = (select MaNhapHang from inserted))
	where MaNhapHang = (select MaNhapHang from inserted)
	--xoa
	update  Nhap
	set TongTien = ( select sum(ThanhTien) from Nhapchitiet where MaNhapHang = (select MaNhapHang from deleted))
	where MaNhapHang = (select MaNhapHang from deleted)

end
go
--
go
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH01','HNV6','2','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH02','HNV3','5','150000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH03','HNV8','36','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH04','HNV2','9','1100000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH05','HNV4','2','120000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH06','HNV5','12','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH07','HNV6','10','60000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH08','HNV7','5','125000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH09','HNV23','2','20000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH10','HNV11','1','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH11','HNV10','2','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH12','HNV23','2','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH13','HNV23','2','185000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH14','HNV23','2','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH15','HNV23','2','150000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH16','HNV23','2','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH17','HNV23','2','176000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH19','HNV23','2','50000')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH19','HNV23','2','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH20','HNV23','2','0')
insert into Nhapchitiet(MaNhapHang,MaHangNhap,SoLuong,CongNoCu) values ('MNH21','HNV21','2','0')
Select*from Nhapchitiet

select * from Nhapchitiet
select * from Nhap
--Nhap Ban chỉ được nhập (MaHoaDon,MaKhachHang,NgayBan)  
insert into Ban(MaHoaDon,MaKhachHang,NgayBan) values('HD01','MKH20','09-11-2023')
insert into Ban(MaHoaDon,MaKhachHang,NgayBan) values('HD02','MKH20','09-11-2023')
,('HD03','MKH19','10-11-2023')
,('HD04','MKH01','10-29-2023')
,('HD05','MKH20','11-11-2023')
,('HD06','MKH20','11-11-2023')
,('HD07','MKH20','11-11-2023')
,('HD08','MKH02','11-03-2023')
,('HD09','MKH07','11-22-2023')
,('HD10','MKH04','11-09-2023')
,('HD11','MKH11','09-30-2023')
,('HD12','MKH15','09-05-2023')
,('HD13','MKH08','09-03-2023')
,('HD14','MKH08','09-03-2023')
,('HD15','MKH09','09-27-2023')
,('HD16','MKH01','09-04-2023')
,('HD17','MKH09','10-06-2023')
,('HD18','MKH04','10-06-2023')
,('HD19','MKH19','10-21-2023')
,('HD20','MKH03','10-15-2023')
,('HD21','MKH03','10-15-2023')
,('HD22','MKH06','10-30-2023')
,('HD23','MKH04','10-25-2023')
,('HD24','MKH07','10-28-2023')
,('HD25','MKH07','10-28-2023')
,('HD26','MKH17','11-01-2023')
,('HD27','MKH13','11-14-2023')
,('HD28','MKH18','11-17-2023')
,('HD29','MKH19','11-18-2023')
,('HD30','MKH19','11-18-2023')


---------------------------------------------------------
--trigger
go
create trigger tgBanChiTiet
on BanChiTiet
for insert,update,delete
as
begin
	
	update BanChiTiet
	set DonGiaBan = (select DonGiaBan from Mon where MaMon = (select MaMon from inserted)) where MaMon= (select MaMon from inserted) 
	update BanChiTiet 
	set TenMon = (Select TenMon from Mon where MaMon= (select MaMon from inserted)) where MaMon= (select MaMon from inserted)
	update BanChiTiet
	set ThanhTien=DonGiaBan*SoLuong where (MaMon=(select MaMon from inserted)) and (MaHoaDon=(select MaHoaDon from inserted))
	update Ban
	set TongTienHang=(select sum(ThanhTien) from BanChiTiet where MaHoaDon = (select MaHoaDon from inserted)) 
					where MaHoaDon = (select MaHoaDon from inserted)
	update Ban
	set VAT = (select sum(ThanhTien) from BanChiTiet where MaHoaDon = (select MaHoaDon from inserted)) * 0.1
					where MaHoaDon = (select MaHoaDon from inserted) 
	update Ban
	set TongCong = TongTienHang + VAT
	where MaHoaDon = (select MaHoaDon from inserted)
	--xoa
	update Ban
	set TongTienHang=(select sum(ThanhTien) from BanChiTiet where MaHoaDon = (select MaHoaDon from deleted)) 
					where MaHoaDon = (select MaHoaDon from deleted)
	update Ban
	set VAT = (select sum(ThanhTien) from BanChiTiet where MaHoaDon = (select MaHoaDon from deleted)) * 0.1
					where MaHoaDon = (select MaHoaDon from deleted) 
	update Ban
	set TongCong = TongTienHang + VAT
	where MaHoaDon = (select MaHoaDon from deleted)
end

-- Nhap vào BánChiTiet chỉ được nhập (MaHoaDon,MaMon,MaNhanVien,SoLuong)
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD01','M23','NV01','2')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD02','M01','NV02','7')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD03','M06','NV02','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD04','M27','NV02','2')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD05','M01','NV01','7')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD06','M33','NV01','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD07','M26','NV02','3')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD08','M24','NV02','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD09','M09','NV01','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD10','M12','NV01','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD11','M13','NV02','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD12','M18','NV02','2')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD13','M17','NV02','3')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD14','M73','NV02','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD15','M83','NV01','3')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD16','M62','NV01','5')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD17','M01','NV02','8')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD18','M01','NV02','8')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD19','M31','NV02','3')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD20','M47','NV02','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD21','M54','NV01','6')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD22','M43','NV01','4')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD23','M49','NV01','4')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD24','M16','NV02','3')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD25','M58','NV02','5')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD26','M45','NV02','1')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD27','M19','NV01','2')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD28','M08','NV02','4')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD29','M22','NV02','4')
insert into BanChiTiet(MaHoaDon,MaMon,MaNhanVien,SoLuong) values ('HD30','M30','NV02','1')

--R4 
-- Tạo Index 
create nonclustered index idx_manhaphang on Nhapchitiet (MaNhapHang)
go
create nonclustered index idx_mahoadon on BanChiTiet (MaHoaDon)
go
--Kiểm tra tốc độ truy xuất dữ liệu của index
-- Chạy có index 
select*from BanChiTiet 
with(index(idx_mahoadon))
where MaHoaDon='HD06'
-- Chạy không có index 
select*from Nhapchitiet
with (index(0))
where MaNhapHang='MNH19'


------------------------------------------R5 
---Mã hoá dữ liệu
alter table KhachHang add 
[encrypted SdtKhachHang] varbinary (MAX)

alter table TaiKhoan add 
[encrypted Passwords] varbinary (MAX)

--Cập nhật dữ liệu đã được mã hoá vào hai cột vừa tạo
update KhachHang
set [encrypted SdtKhachHang] = encryptbypassphrase('SdtKhachHang',convert (varchar(100),SdtKhachHang))
go 


update TaiKhoan
set [encrypted Passwords] = encryptbypassphrase('MatKhau',convert (varchar(100),MatKhau))
go 
--Truy vấn sau khi mã hoá 
select*from KhachHang
go 
select *from TaiKhoan 
go
-- Xoá bỏ cột dữ liệu được mã hoá 

alter table KhachHang drop column SdtKhachHang
go 
alter table TaiKhoan drop column MatKhau
go 

--Truy vấn 
select*from KhachHang
go 
select *from TaiKhoan 
go
--Giải mã dữ liệu thông qua  decryptbypassphrase
	select MaKhachHang , TenKhachHang , DiaChiKhachHang,
	convert (varchar,convert(varchar(100), Decryptbypassphrase('SdtKhachHang',[encrypted SdtKhachHang])))
	as SdtKhachHang from KhachHang
go 

select TaiKhoan , 
(try_convert (varchar,convert(varchar(50), Decryptbypassphrase('MatKhau', [encrypted Passwords]))))
as Password from TaiKhoan
go 



