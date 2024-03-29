USE [QL_BANHANG]
GO
/****** Object:  Table [dbo].[ADMIN]    Script Date: 2/2/2024 9:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADMIN](
	[TENDN] [char](30) NULL,
	[MATKHAU] [char](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTDONHANG]    Script Date: 2/2/2024 9:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDONHANG](
	[SODH] [int] NOT NULL,
	[MASP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [money] NULL,
 CONSTRAINT [Pk_CTDH] PRIMARY KEY CLUSTERED 
(
	[SODH] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONDATHANG]    Script Date: 2/2/2024 9:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONDATHANG](
	[SODH] [int] IDENTITY(100,1) NOT NULL,
	[MAKH] [int] NULL,
	[DATHANHTOAN] [nvarchar](30) NULL,
	[TINHTRANG] [nvarchar](20) NULL,
	[NGAYDH] [date] NULL,
	[NGAYGIAO] [date] NULL,
 CONSTRAINT [PK_DH] PRIMARY KEY CLUSTERED 
(
	[SODH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 2/2/2024 9:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[TENDN] [varchar](30) NULL,
	[MATKHAU] [varchar](20) NULL,
	[TENKH] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](60) NULL,
	[SDT] [char](10) NULL,
	[EMAIL] [char](30) NULL,
	[NGAYSINH] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAISP]    Script Date: 2/2/2024 9:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAISP](
	[MALOAI] [char](10) NOT NULL,
	[TENLOAI] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 2/2/2024 9:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [int] IDENTITY(3000,1) NOT NULL,
	[TENNCC] [nvarchar](40) NULL,
	[DIACHI] [nvarchar](60) NULL,
	[SDT] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 2/2/2024 9:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [int] IDENTITY(2000,1) NOT NULL,
	[MALOAI] [char](10) NULL,
	[MANCC] [int] NULL,
	[TENSP] [nvarchar](50) NULL,
	[ANH] [varchar](50) NULL,
	[SL] [int] NULL,
	[DONGIA] [float] NULL,
	[MOTA] [nvarchar](200) NULL,
	[NGAYCAPNHAT] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ADMIN] ([TENDN], [MATKHAU]) VALUES (N'admin                         ', N'123                 ')
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MAKH], [TENDN], [MATKHAU], [TENKH], [DIACHI], [SDT], [EMAIL], [NGAYSINH]) VALUES (1, N'Sanh', N'123', N'Nguyễn Xuân Sanh', N'Bình Định', N'0935841245', N'Sanhnguyen@gmail.com          ', CAST(N'2002-03-10' AS Date))
INSERT [dbo].[KHACHHANG] ([MAKH], [TENDN], [MATKHAU], [TENKH], [DIACHI], [SDT], [EMAIL], [NGAYSINH]) VALUES (2, N'sds', N'ds', N'dsd', N'dsds', N'dsd       ', N'sdsd                          ', CAST(N'2023-11-02' AS Date))
INSERT [dbo].[KHACHHANG] ([MAKH], [TENDN], [MATKHAU], [TENKH], [DIACHI], [SDT], [EMAIL], [NGAYSINH]) VALUES (3, N'dsdsd', N'd', N'd', N'd', N'd         ', N'                              ', CAST(N'2023-10-25' AS Date))
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'L01       ', N'Áo')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'L02       ', N'Quần')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'L03       ', N'Giầy')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'L04       ', N'Túi xách')
INSERT [dbo].[LOAISP] ([MALOAI], [TENLOAI]) VALUES (N'L05       ', N'Ví')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (3000, N'Louis Vuitton', N' Pháp', N'0398745215')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (3001, N'Hermes', N'USA', N'0395214521')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (3002, N'Prada', N'Y´', N'0789412587')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (3003, N'Chanel', N'Pha´p', N'0987452158')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2000, N'L01       ', 3000, N'Áo thun CN001', N'CN001.png', 50, 1000000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2001, N'L01       ', 3000, N'Áo thun CN002', N'CN002.png', 20, 1500000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2002, N'L01       ', 3000, N'Áo thun CN003', N'CN003.png', 10, 1000000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2003, N'L01       ', 3000, N'Áo Thun Cổ Trụ Đơn Giản ', N'anh04.png', 50, 1000000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2004, N'L01       ', 3001, N'Áo Thun Cổ Trụ Đơn Giản ', N'anh05.png', 20, 1500000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2005, N'L01       ', 3001, N'Áo Thun Cổ Trụ Đơn Giản ', N'anh06.png', 10, 300000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2006, N'L01       ', 3001, N'Áo Thun Cổ Trụ Đơn Giản ', N'anh07.png', 50, 700000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2007, N'L01       ', 3002, N'Áo Thun Cổ Trụ Đơn Giản ', N'anh08.png', 20, 230000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2008, N'L01       ', 3002, N'Áo Thun Cổ Trụ Đơn Giản ', N'anh09.png', 10, 1500000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2009, N'L01       ', 3002, N'Áo Khoác Cardigan Đơn Giản', N'anh10.png', 50, 140000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2010, N'L01       ', 3002, N'Áo Thun Cổ Trụ Đơn Giản', N'anh11.png', 20, 1500000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2011, N'L01       ', 3003, N'Áo Thun Cổ Trụ Đơn Giản', N'anh12.png', 10, 1000000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2012, N'L01       ', 3003, N'Áo Thun Cổ Trụ Đơn Giản', N'anh13.png', 50, 1000000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2013, N'L01       ', 3002, N'Áo Thun Cổ Trụ Đơn Giản', N'anh14.png', 20, 1500000, N'Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton:Thân thiện,Thấm hút thoát ẩm,Mềm mại,Kiểm soát mùi,Điều hòa nhiệt', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2014, N'L01       ', 3003, N'Quần Jean Slimfit ', N'anh15.png', 10, 1000000, N'Chất liệu: Jean Cotton Thành phần: 100% Cotton', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2015, N'L01       ', 3000, N'Quần Jean Slimfit ', N'anh16.png', 50, 1000000, N'Chất liệu: Jean Cotton Thành phần: 100% Cotton', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2016, N'L01       ', 3001, N'Quần Jean Slimfit ', N'anh17.png', 20, 1500000, N'Chất liệu: Jean Cotton Thành phần: 100% Cotton', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2017, N'L01       ', 3003, N'Quần Jean Slimfit ', N'anh18.png', 10, 1000000, N'Chất liệu: Jean Cotton Thành phần: 100% Cotton', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2018, N'L01       ', 3002, N'Quần Jean Slimfit ', N'anh19.png', 50, 1000000, N'Chất liệu: Jean Cotton Thành phần: 100% Cotton', CAST(N'2022-12-12' AS Date))
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MANCC], [TENSP], [ANH], [SL], [DONGIA], [MOTA], [NGAYCAPNHAT]) VALUES (2019, N'L01       ', 3002, N'Quần Jean Slimfit ', N'anh20.png', 10, 1000000, N'Chất liệu: Jean Cotton Thành phần: 100% Cotton', CAST(N'2022-12-12' AS Date))
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__KHACHHAN__161CF72432FB8DFD]    Script Date: 2/2/2024 9:01:53 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD UNIQUE NONCLUSTERED 
(
	[EMAIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__KHACHHAN__A58D7781F922ACDF]    Script Date: 2/2/2024 9:01:53 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD UNIQUE NONCLUSTERED 
(
	[TENDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__KHACHHAN__CA1930A516DBC967]    Script Date: 2/2/2024 9:01:53 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTDONHANG]  WITH CHECK ADD  CONSTRAINT [pf_CT_DH] FOREIGN KEY([SODH])
REFERENCES [dbo].[DONDATHANG] ([SODH])
GO
ALTER TABLE [dbo].[CTDONHANG] CHECK CONSTRAINT [pf_CT_DH]
GO
ALTER TABLE [dbo].[CTDONHANG]  WITH CHECK ADD  CONSTRAINT [pf_CT_sp] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CTDONHANG] CHECK CONSTRAINT [pf_CT_sp]
GO
ALTER TABLE [dbo].[DONDATHANG]  WITH CHECK ADD  CONSTRAINT [pf_dh_kh] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[DONDATHANG] CHECK CONSTRAINT [pf_dh_kh]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [pf_loaisp] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAISP] ([MALOAI])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [pf_loaisp]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [pf_ncc] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [pf_ncc]
GO
