create database QL_BANHANG
go 
use  QL_BANHANG
go
------
create table KHACHHANG
(
MAKH int identity(1,1) PRIMARY KEY ,
TENDN varchar(30) unique ,
MATKHAU varchar(20),
TENKH nvarchar(30),
DIACHI nvarchar(60),
SDT char(10)unique,
EMAIL char(30) unique,
NGAYSINH DATE,
)
create table NHACUNGCAP
(
MANCC int identity(3000,1) primary key,
TENNCC nvarchar(40),
DIACHI nvarchar(60),
SDT char(10),
)
create table LOAISP
(
MALOAI char(10) primary key,
TENLOAI nvarchar(30)
)
create table SANPHAM
(
MASP int identity(2000,1) primary key,
MALOAI char(10),
MANCC int,
TENSP nvarchar(50),
ANH varchar(50),
SL int,
DONGIA float,
MOTA nvarchar(200),
NGAYCAPNHAT DATE,
constraint pf_ncc foreign key (MANCC) references NHACUNGCAP(MANCC),
constraint pf_loaisp foreign key (MALOAI) references LOAISP(MALOAI),
)
create table DONDATHANG
(
SODH int identity(100,1),
MAKH int,
DATHANHTOAN nvarchar(30) ,
TINHTRANG nvarchar(20),
NGAYDH DATE,
NGAYGIAO DATE,
constraint PK_DH primary key (SODH),
constraint pf_dh_kh foreign key (MAKH) references KHACHHANG(MAKH)
)
create table CTDONHANG
(
SODH int,
MASP int,
SOLUONG int,
DONGIA MONEY,
constraint Pk_CTDH primary key(SODH,MASP),
CONSTRAINT pf_CT_DH foreign key(SODH) references DONDATHANG(SODH),
CONSTRAINT pf_CT_sp foreign key(MASP) references SANPHAM(MASP),
)
CREATE TABLE ADMIN(
TENDN char(30),
MATKHAU char(20)
)
Insert into ADMIN VALUES('thao','123')
Insert into NHACUNGCAP values('Louis Vuitton',' Pháp','0398745215'),
('Hermes','USA','0395214521'),('Prada','Ý','0789412587'),
('Chanel','Pháp','0987452158')
insert into LOAISP values('L01',N'Áo'),('L02',N'Quần'),('L03',N'Giầy'),
('L04',N'Túi xách'),('L05',N'Ví')
set dateformat DMY

insert into SANPHAM values('L01',3000,N'Áo thun CN001','CN001.png',50,1000000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','12-12-2022'),
('L01',3000,N'Áo thun CN002','CN002.png',20,1500000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','12-12-2022'),
('L01',3000,N'Áo thun CN003','CN003.png',10,1000000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','12-12-2022')
set dateformat DMY
INSERT INTO KHACHHANG VALUES('Sanh','123',N'Nguyễn Xuân Sanh',N'Bình Định','0935841245','Sanhnguyen@gmail.com','10-03-2002')
insert into SANPHAM values('L01',3000,N'Áo Thun Cổ Trụ Đơn Giản ','anh04.png',50,1000000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3001,N'Áo Thun Cổ Trụ Đơn Giản ','anh05.png',20,1500000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3001,N'Áo Thun Cổ Trụ Đơn Giản ','anh06.png',10,300000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3001,N'Áo Thun Cổ Trụ Đơn Giản ','anh07.png',50,700000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3002,N'Áo Thun Cổ Trụ Đơn Giản ','anh08.png',20,230000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3002,N'Áo Thun Cổ Trụ Đơn Giản ','anh09.png',10,1500000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3002,N'Áo Khoác Cardigan Đơn Giản','anh10.png',50,140000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3002,N'Áo Thun Cổ Trụ Đơn Giản','anh11.png',20,1500000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3003,N'Áo Thun Cổ Trụ Đơn Giản','anh12.png',10,1000000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3003,N'Áo Thun Cổ Trụ Đơn Giản','anh13.png',50,1000000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3002,N'Áo Thun Cổ Trụ Đơn Giản','anh14.png',20,1500000,N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt','10-10-2022'),
('L01',3003,N'Quần Jean Slimfit ','anh15.png',10,1000000,N'Chất liệu: Jean Cotton Thành phần: 100% Cotton','12-12-2022'),
('L01',3000,N'Quần Jean Slimfit ','anh16.png',50,1000000,N'Chất liệu: Jean Cotton Thành phần: 100% Cotton','12-12-2022'),
('L01',3001,N'Quần Jean Slimfit ','anh17.png',20,1500000,N'Chất liệu: Jean Cotton Thành phần: 100% Cotton','12-12-2022'),
('L01',3003,N'Quần Jean Slimfit ','anh18.png',10,1000000,N'Chất liệu: Jean Cotton Thành phần: 100% Cotton','12-12-2022'),
('L01',3002,N'Quần Jean Slimfit ','anh19.png',50,1000000,N'Chất liệu: Jean Cotton Thành phần: 100% Cotton','12-12-2022'),
('L01',3002,N'Quần Jean Slimfit ','anh20.png',10,1000000,N'Chất liệu: Jean Cotton Thành phần: 100% Cotton','12-12-2022')

----Trigger
create trigger Them ON CTDONHANG FOR INSERT
as
update SANPHAM
set SL=SL-(select SOLUONG from inserted where MASP=SANPHAM.MASP)
where MASP=(select MASP from INSERTED)

select * from CTDONHANG
select * from DONDATHANG
select *from KHACHHANG
select * from SANPHAM
