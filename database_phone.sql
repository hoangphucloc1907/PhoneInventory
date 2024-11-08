CREATE DATABASE [PHONE]
GO
USE [PHONE]
GO
/****** Object:  Table [dbo].[ExportDetail]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExportDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExportId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportDetail]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImportId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[StandardCost] [decimal](10, 2) NULL,
	[ListPrice] [decimal](10, 2) NULL,
	[Description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[CurrentStock]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CurrentStock] AS
SELECT 
    p.Id AS ProductId,
    p.ProductCode,
    p.ProductName,
    COALESCE(SUM(id.Quantity), 0) AS TotalImported,
    COALESCE(SUM(ed.Quantity), 0) AS TotalExported,
    COALESCE(SUM(id.Quantity), 0) - COALESCE(SUM(ed.Quantity), 0) AS StockBalance
FROM 
    Product p
LEFT JOIN 
    ImportDetail id ON p.Id = id.ProductId
LEFT JOIN 
    ExportDetail ed ON p.Id = ed.ProductId
GROUP BY 
    p.Id, p.ProductCode, p.ProductName;
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryCode] [nvarchar](50) NULL,
	[CategoryName] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[Gender] [nvarchar](10) NULL,
	[Address] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Export]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Export](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[EmployeeId] [int] NULL,
	[ExportDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Import]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SupplierId] [int] NULL,
	[EmployeeId] [int] NULL,
	[ImportDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SupplierCode] [nvarchar](50) NULL,
	[SupplierName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/6/2024 5:39:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](200) NULL,
	[Password] [nvarchar](max) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[Gender] [nvarchar](10) NULL,
	[Address] [nvarchar](500) NULL,
	[Role] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CategoryCode], [CategoryName]) VALUES (2, N'SS', N'Samsung')
INSERT [dbo].[Category] ([Id], [CategoryCode], [CategoryName]) VALUES (3, N'IP', N'Iphone')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [LastName], [FirstName], [PhoneNumber], [Gender], [Address]) VALUES (1, N'Phúc Lộc', N'Hoàng', N'09090909', N'Nam', N'12 Quang Trung')
INSERT [dbo].[Customer] ([Id], [LastName], [FirstName], [PhoneNumber], [Gender], [Address]) VALUES (2, N'Hoàng', N'Phúc Lộc', N'08080808', N'Nam', N'20 Quang Trung')
INSERT [dbo].[Customer] ([Id], [LastName], [FirstName], [PhoneNumber], [Gender], [Address]) VALUES (3, N'Nguyễn', N'Thanh Hà', N'07070707', N'Nữ', N'50 Lê Văn Sỹ')
INSERT [dbo].[Customer] ([Id], [LastName], [FirstName], [PhoneNumber], [Gender], [Address]) VALUES (4, N'Lý', N'Gia Hưng', N'06060606', N'Nam', N'32 Nguyễn Thượng Hiền')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Export] ON 

INSERT [dbo].[Export] ([Id], [CustomerId], [EmployeeId], [ExportDate]) VALUES (1, 2, 1, CAST(N'2024-11-06T02:31:47.823' AS DateTime))
INSERT [dbo].[Export] ([Id], [CustomerId], [EmployeeId], [ExportDate]) VALUES (2, 3, 1, CAST(N'2024-11-06T02:32:34.493' AS DateTime))
INSERT [dbo].[Export] ([Id], [CustomerId], [EmployeeId], [ExportDate]) VALUES (3, 2, 1, CAST(N'2024-11-06T03:23:45.927' AS DateTime))
INSERT [dbo].[Export] ([Id], [CustomerId], [EmployeeId], [ExportDate]) VALUES (4, 2, 1, CAST(N'2024-11-06T03:23:54.380' AS DateTime))
SET IDENTITY_INSERT [dbo].[Export] OFF
GO
SET IDENTITY_INSERT [dbo].[ExportDetail] ON 

INSERT [dbo].[ExportDetail] ([Id], [ExportId], [ProductId], [Quantity], [UnitPrice]) VALUES (1, 2, 4, 2, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[ExportDetail] ([Id], [ExportId], [ProductId], [Quantity], [UnitPrice]) VALUES (2, 4, 7, 3, CAST(100.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[ExportDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Import] ON 

INSERT [dbo].[Import] ([Id], [SupplierId], [EmployeeId], [ImportDate]) VALUES (1, 2, 2, CAST(N'2024-11-05T23:30:07.750' AS DateTime))
INSERT [dbo].[Import] ([Id], [SupplierId], [EmployeeId], [ImportDate]) VALUES (2, 2, 2, CAST(N'2024-11-05T23:33:16.307' AS DateTime))
INSERT [dbo].[Import] ([Id], [SupplierId], [EmployeeId], [ImportDate]) VALUES (3, 2, 1, CAST(N'2024-11-06T00:31:52.760' AS DateTime))
INSERT [dbo].[Import] ([Id], [SupplierId], [EmployeeId], [ImportDate]) VALUES (4, 2, 1, CAST(N'2024-11-06T00:34:20.680' AS DateTime))
INSERT [dbo].[Import] ([Id], [SupplierId], [EmployeeId], [ImportDate]) VALUES (5, 2, 1, CAST(N'2024-11-06T04:15:51.080' AS DateTime))
INSERT [dbo].[Import] ([Id], [SupplierId], [EmployeeId], [ImportDate]) VALUES (6, 2, 1, CAST(N'2024-11-06T04:20:21.043' AS DateTime))
INSERT [dbo].[Import] ([Id], [SupplierId], [EmployeeId], [ImportDate]) VALUES (7, 2, 1, CAST(N'2024-11-06T04:21:48.827' AS DateTime))
SET IDENTITY_INSERT [dbo].[Import] OFF
GO
SET IDENTITY_INSERT [dbo].[ImportDetail] ON 

INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (1, 2, 7, 4, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (2, 2, 5, 10, CAST(800.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (3, 2, 6, 5, CAST(600.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (4, 3, 3, 7, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (5, 4, 4, 6, CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (6, 4, 3, 6, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (7, 5, 4, 11, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (8, 5, 7, 5, CAST(1200.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (9, 6, 3, 2, CAST(150.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (10, 6, 5, 3, CAST(900.00 AS Decimal(10, 2)))
INSERT [dbo].[ImportDetail] ([Id], [ImportId], [ProductId], [Quantity], [UnitPrice]) VALUES (11, 7, 4, 2, CAST(400.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[ImportDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [CategoryId], [ProductCode], [ProductName], [StandardCost], [ListPrice], [Description]) VALUES (3, 3, N'IpX', N'IphoneX', CAST(150.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'aaa')
INSERT [dbo].[Product] ([Id], [CategoryId], [ProductCode], [ProductName], [StandardCost], [ListPrice], [Description]) VALUES (4, 2, N'Ip11', N'Iphone 11', CAST(400.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), N'aaa')
INSERT [dbo].[Product] ([Id], [CategoryId], [ProductCode], [ProductName], [StandardCost], [ListPrice], [Description]) VALUES (5, 3, N'Ip12', N'Iphone 12', CAST(900.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'aaa')
INSERT [dbo].[Product] ([Id], [CategoryId], [ProductCode], [ProductName], [StandardCost], [ListPrice], [Description]) VALUES (6, 3, N'Ip12p', N'Iphone 12 Pro', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'aaa')
INSERT [dbo].[Product] ([Id], [CategoryId], [ProductCode], [ProductName], [StandardCost], [ListPrice], [Description]) VALUES (7, 3, N'Ip12prm', N'Iphone 12 Pro Max', CAST(1200.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'aaa')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [SupplierCode], [SupplierName], [Address], [PhoneNumber]) VALUES (1, N'Samsung', N'Samsung Việt Nam', N'Hồ Chí Minh', N'11111111')
INSERT [dbo].[Supplier] ([Id], [SupplierCode], [SupplierName], [Address], [PhoneNumber]) VALUES (2, N'Apple', N'Apple Việt Nam', N'Hồ Chí Minh', N'22222222')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [UserName], [Password], [LastName], [FirstName], [PhoneNumber], [Gender], [Address], [Role]) VALUES (1, N'admin', N'ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413', N'admin', N'admin', N'00000', N'Nam', N'00000', N'Admin')
INSERT [dbo].[User] ([Id], [UserName], [Password], [LastName], [FirstName], [PhoneNumber], [Gender], [Address], [Role]) VALUES (2, N'hoangloc', N'ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413', N'Hoàng', N'Phúc Lộc', N'098098098', N'Nam', N'12 Quang Trung', N'Employee')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Export]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Export]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[ExportDetail]  WITH CHECK ADD FOREIGN KEY([ExportId])
REFERENCES [dbo].[Export] ([Id])
GO
ALTER TABLE [dbo].[ExportDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([Id])
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD FOREIGN KEY([ImportId])
REFERENCES [dbo].[Import] ([Id])
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
