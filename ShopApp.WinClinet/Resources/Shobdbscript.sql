SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[Corporations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Address] [nvarchar](1000) NULL,
	[Telephone] [nvarchar](21) NULL,
	[Fax] [nvarchar](21) NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[FinancialYears]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[FinancialYears](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CorporationsId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[StartDate] [datetime] NOT NULL,
	[FinishDate] [datetime] NOT NULL,
	[IsClosed] [bit] NOT NULL,
	[CloseDate] [datetime] NULL,
	[ClosedByUserId] [bigint] NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[Inventories]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[Inventories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CorporationsId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[InventoryInsDetails]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[InventoryInsDetails](
	[InventoryInsHeaderId] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InventoryInsHeaderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[InventoryInsHeaders]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[InventoryInsHeaders](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[InventoryId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Accepted] [bit] NOT NULL,
	[AcceptedDate] [datetime] NULL,
	[AcceptedByUserId] [bigint] NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[InventoryInsTypes]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[InventoryInsTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[InventoryOutsDetails]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[InventoryOutsDetails](
	[InventoryOutsHeaderId] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InventoryOutsHeaderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[InventoryOutsHeaders]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[InventoryOutsHeaders](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[InventoryId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Accepted] [bit] NOT NULL,
	[AcceptedDate] [datetime] NULL,
	[AcceptedByUserId] [bigint] NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[InventoryOutsTypes]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[InventoryOutsTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[ProductCategories]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[ProductCategories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InventoryId] [int] NOT NULL,
	[ParentCategoryId] [int] NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[ProductParameters]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[ProductParameters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryId] [int] NOT NULL,
	[Key] [nvarchar](100) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Data] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[ProductParametersValues]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[ProductParametersValues](
	[ProductId] [int] NOT NULL,
	[ProductParameterId] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[ProductParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[ProductPrices]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[ProductPrices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[Products]    Script Date: 7/25/2023 9:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryId] [int] NOT NULL,
	[ProductUnitId] [int] NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[ProductUnits]    Script Date: 7/25/2023 9:55:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[ProductUnits](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ShopDb].[dbo].[Users]    Script Date: 7/25/2023 9:55:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ShopDb].[dbo].[Users](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](200) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeletedByUserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [ShopDb].[dbo].[ProductPrices] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [ShopDb].[dbo].[Corporations]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[FinancialYears]  WITH CHECK ADD FOREIGN KEY([ClosedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[FinancialYears]  WITH CHECK ADD FOREIGN KEY([CorporationsId])
REFERENCES [ShopDb].[dbo].[Corporations] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[FinancialYears]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[Inventories]  WITH CHECK ADD FOREIGN KEY([CorporationsId])
REFERENCES [ShopDb].[dbo].[Corporations] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[Inventories]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryInsDetails]  WITH CHECK ADD FOREIGN KEY([InventoryInsHeaderId])
REFERENCES [ShopDb].[dbo].[InventoryInsHeaders] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryInsDetails]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo].[Products] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([AcceptedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([InventoryId])
REFERENCES [ShopDb].[dbo].[Inventories] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [ShopDb].[dbo].[InventoryInsTypes] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryInsTypes]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryOutsDetails]  WITH CHECK ADD FOREIGN KEY([InventoryOutsHeaderId])
REFERENCES [ShopDb].[dbo].[InventoryOutsHeaders] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryOutsDetails]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo].[Products] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([AcceptedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([InventoryId])
REFERENCES [ShopDb].[dbo].[Inventories] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [ShopDb].[dbo].[InventoryOutsTypes] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[InventoryOutsTypes]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductCategories]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductCategories]  WITH CHECK ADD FOREIGN KEY([InventoryId])
REFERENCES [ShopDb].[dbo].[Inventories] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductCategories]  WITH CHECK ADD FOREIGN KEY([ParentCategoryId])
REFERENCES [ShopDb].[dbo].[ProductCategories] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductParameters]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductParameters]  WITH CHECK ADD FOREIGN KEY([ProductCategoryId])
REFERENCES [ShopDb].[dbo].[ProductCategories] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductParametersValues]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo].[Products] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductParametersValues]  WITH CHECK ADD FOREIGN KEY([ProductParameterId])
REFERENCES [ShopDb].[dbo].[ProductParameters] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductPrices]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo].[Products] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[Products]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[Products]  WITH CHECK ADD FOREIGN KEY([ProductCategoryId])
REFERENCES [ShopDb].[dbo].[ProductCategories] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[Products]  WITH CHECK ADD FOREIGN KEY([ProductUnitId])
REFERENCES [ShopDb].[dbo].[ProductUnits] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[ProductUnits]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
ALTER TABLE [ShopDb].[dbo].[Users]  WITH CHECK ADD FOREIGN KEY([DeletedByUserId])
REFERENCES [ShopDb].[dbo].[Users] ([ID])
GO
