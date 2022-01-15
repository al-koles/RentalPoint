--drop database [RentalPoint];
--USE [master]
----GO
/****** Object:  Database [RentalPoint]    Script Date: 1/26/2021 10:53:14 PM ******/
--CREATE DATABASE [RentalPoint]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'RentalPoint', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentalPoint.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'RentalPoint_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentalPoint_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT
--GO
--ALTER DATABASE [RentalPoint] SET COMPATIBILITY_LEVEL = 150
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [RentalPoint].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [RentalPoint] SET ANSI_NULL_DEFAULT OFF 
----GO
--ALTER DATABASE [RentalPoint] SET ANSI_NULLS OFF 
----GO
--ALTER DATABASE [RentalPoint] SET ANSI_PADDING OFF 
----GO
--ALTER DATABASE [RentalPoint] SET ANSI_WARNINGS OFF 
----GO
--ALTER DATABASE [RentalPoint] SET ARITHABORT OFF 
----GO
--ALTER DATABASE [RentalPoint] SET AUTO_CLOSE OFF 
----GO
--ALTER DATABASE [RentalPoint] SET AUTO_SHRINK OFF 
----GO
--ALTER DATABASE [RentalPoint] SET AUTO_UPDATE_STATISTICS ON 
----GO
--ALTER DATABASE [RentalPoint] SET CURSOR_CLOSE_ON_COMMIT OFF 
----GO
--ALTER DATABASE [RentalPoint] SET CURSOR_DEFAULT  GLOBAL 
----GO
--ALTER DATABASE [RentalPoint] SET CONCAT_NULL_YIELDS_NULL OFF 
----GO
--ALTER DATABASE [RentalPoint] SET NUMERIC_ROUNDABORT OFF 
----GO
--ALTER DATABASE [RentalPoint] SET QUOTED_IDENTIFIER OFF 
----GO
--ALTER DATABASE [RentalPoint] SET RECURSIVE_TRIGGERS OFF 
----GO
--ALTER DATABASE [RentalPoint] SET  DISABLE_BROKER 
----GO
--ALTER DATABASE [RentalPoint] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
----GO
--ALTER DATABASE [RentalPoint] SET DATE_CORRELATION_OPTIMIZATION OFF 
----GO
--ALTER DATABASE [RentalPoint] SET TRUSTWORTHY OFF 
----GO
--ALTER DATABASE [RentalPoint] SET ALLOW_SNAPSHOT_ISOLATION OFF 
----GO
--ALTER DATABASE [RentalPoint] SET PARAMETERIZATION SIMPLE 
----GO
--ALTER DATABASE [RentalPoint] SET READ_COMMITTED_SNAPSHOT OFF 
----GO
--ALTER DATABASE [RentalPoint] SET HONOR_BROKER_PRIORITY OFF 
----GO
--ALTER DATABASE [RentalPoint] SET RECOVERY FULL 
----GO
--ALTER DATABASE [RentalPoint] SET  MULTI_USER 
----GO
--ALTER DATABASE [RentalPoint] SET PAGE_VERIFY CHECKSUM  
----GO
--ALTER DATABASE [RentalPoint] SET DB_CHAINING OFF 
----GO
--ALTER DATABASE [RentalPoint] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
----GO
--ALTER DATABASE [RentalPoint] SET TARGET_RECOVERY_TIME = 60 SECONDS 
----GO
--ALTER DATABASE [RentalPoint] SET DELAYED_DURABILITY = DISABLED 
----GO
--EXEC sys.sp_db_vardecimal_storage_format N'RentalPoint', N'ON'
----GO
--ALTER DATABASE [RentalPoint] SET QUERY_STORE = OFF
----GO
USE [RentalPoint]
--GO
/****** Object:  Table [dbo].[Attachment]    Script Date: 1/26/2021 10:53:14 PM ******/
----SET ANSI_NULLS ON
--GO
----SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Attachment](
	[attachment_id] [int] NOT NULL,
	[rent_id] [int] NOT NULL,
	[set_id] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[TotalPrice(UAH)] [money] NULL,
	[ReturnAmount] [int] NULL,
	[ReturnPrice] [money] NULL,
 CONSTRAINT [PK_Attachment] PRIMARY KEY CLUSTERED 
(
	[attachment_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Brand]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Brand](
	[brand_id] [int] NOT NULL,
	[BrandName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[brand_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Client]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Client](
	[client_id] [int] NOT NULL,
	[Discount(%)] [int] NOT NULL,
	[discountType_id] [int] NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[SecondName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NULL,
	[Gender] [nvarchar](255) NOT NULL,
	[PhoneNumber] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NOT NULL,
	[PostCode] [int] NOT NULL,
	[RegistrationDate] [datetime] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] --TEXTIMAGE_ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Detail]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Detail](
	[detail_id] [int] NOT NULL,
	[model_id] [int] NOT NULL,
	[producer_id] [int] NOT NULL,
	[Price(UAH)] [money] NOT NULL,
	[Amount] [int] NOT NULL,
	[IsReturnable] [bit] NOT NULL,
 CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED 
(
	[detail_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[DiscountType]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[DiscountType](
	[discountType_id] [int] NOT NULL,
	[DiscountTypeName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_DiscountType] PRIMARY KEY CLUSTERED 
(
	[discountType_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Good]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Good](
	[good_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[Condition] [bit] NOT NULL,
	[ProductionDate] [date] NOT NULL,
	[UsingSince] [date] NOT NULL,
 CONSTRAINT [PK_Copy] PRIMARY KEY CLUSTERED 
(
	[good_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Model]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Model](
	[model_id] [int] NOT NULL,
	[brand_id] [int] NOT NULL,
	[modelType_id] [int] NOT NULL,
	[ModelName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[model_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[ModelType]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[ModelType](
	[modelType_id] [int] NOT NULL,
	[ModelTypeName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_ModelType] PRIMARY KEY CLUSTERED 
(
	[modelType_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Order]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Order](
	[order_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CancelDate] [datetime] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] --TEXTIMAGE_ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Producer]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Producer](
	[producer_id] [int] NOT NULL,
	[ProducerName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Producer] PRIMARY KEY CLUSTERED 
(
	[producer_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Product]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Product](
	[product_id] [int] NOT NULL,
	[model_id] [int] NOT NULL,
	[producer_id] [int] NOT NULL,
	[Price(UAH/day)] [money] NOT NULL,
	[Discount(%)] [int] NOT NULL,
	[Deposit(UAH)] [money] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] --TEXTIMAGE_ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Rent]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Rent](
	[rent_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[copy_id] [int] NOT NULL,
	[From(date)] [datetime] NOT NULL,
	[To(date)] [datetime] NOT NULL,
	[TotalPrice(UAH)] [money] NULL,
	[Deposit] [money] NULL,
	[ReturnDate] [date] NULL,
	[ReturnCondition] [bit] NOT NULL,
	[Penalty] [money] NULL,
 CONSTRAINT [PK_Rent] PRIMARY KEY CLUSTERED 
(
	[rent_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
/****** Object:  Table [dbo].[Set]    Script Date: 1/26/2021 10:53:14 PM ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE TABLE [dbo].[Set](
	[set_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[detail_id] [int] NOT NULL,
 CONSTRAINT [PK_Set] PRIMARY KEY CLUSTERED 
(
	[set_id] ASC
)--WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO
ALTER TABLE [dbo].[Rent] ADD  CONSTRAINT [df_Condition]  DEFAULT ((1)) FOR [ReturnCondition]
--GO
ALTER TABLE [dbo].[Attachment]  WITH CHECK ADD FOREIGN KEY([rent_id])
REFERENCES [dbo].[Rent] ([rent_id])
--GO
ALTER TABLE [dbo].[Attachment]  WITH CHECK ADD FOREIGN KEY([set_id])
REFERENCES [dbo].[Set] ([set_id])
--GO
ALTER TABLE [dbo].[Attachment]  WITH CHECK ADD  CONSTRAINT [fk_rent] FOREIGN KEY([rent_id])
REFERENCES [dbo].[Rent] ([rent_id])
ON DELETE CASCADE
--GO
ALTER TABLE [dbo].[Attachment] CHECK CONSTRAINT [fk_rent]
--GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD FOREIGN KEY([discountType_id])
REFERENCES [dbo].[DiscountType] ([discountType_id])
--GO
ALTER TABLE [dbo].[Detail]  WITH CHECK ADD FOREIGN KEY([model_id])
REFERENCES [dbo].[Model] ([model_id])
--GO
ALTER TABLE [dbo].[Detail]  WITH CHECK ADD FOREIGN KEY([producer_id])
REFERENCES [dbo].[Producer] ([producer_id])
--GO
ALTER TABLE [dbo].[Good]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([product_id])
--GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD FOREIGN KEY([brand_id])
REFERENCES [dbo].[Brand] ([brand_id])
--GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD FOREIGN KEY([modelType_id])
REFERENCES [dbo].[ModelType] ([modelType_id])
--GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[Client] ([client_id])
--GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([model_id])
REFERENCES [dbo].[Model] ([model_id])
--GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([producer_id])
REFERENCES [dbo].[Producer] ([producer_id])
--GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD FOREIGN KEY([copy_id])
REFERENCES [dbo].[Good] ([good_id])
--GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([order_id])
--GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [fk_order] FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([order_id])
ON DELETE CASCADE
--GO
ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [fk_order]
--GO
ALTER TABLE [dbo].[Set]  WITH CHECK ADD FOREIGN KEY([detail_id])
REFERENCES [dbo].[Detail] ([detail_id])
--GO
--USE [master]
--GO
--ALTER DATABASE [RentalPoint] SET  READ_WRITE 
--GO
