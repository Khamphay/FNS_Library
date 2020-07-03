USE [master]
GO
/****** Object:  Database [db_Libary]    Script Date: 03-07-2020 10:02:39 PM ******/
CREATE DATABASE [db_Libary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_Libary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_Libary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_Libary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_Libary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_Libary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_Libary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_Libary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_Libary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_Libary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_Libary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_Libary] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_Libary] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [db_Libary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_Libary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_Libary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_Libary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_Libary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_Libary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_Libary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_Libary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_Libary] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_Libary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_Libary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_Libary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_Libary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_Libary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_Libary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_Libary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_Libary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_Libary] SET  MULTI_USER 
GO
ALTER DATABASE [db_Libary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_Libary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_Libary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_Libary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_Libary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_Libary] SET QUERY_STORE = OFF
GO
USE [db_Libary]
GO
/****** Object:  Table [dbo].[tbBooks]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBooks](
	[barcode] [varchar](12) NOT NULL,
	[bid] [varchar](10) NULL,
	[status] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbBooks] PRIMARY KEY CLUSTERED 
(
	[barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbBooks_Detail]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBooks_Detail](
	[bid] [varchar](10) NOT NULL,
	[bname] [nvarchar](100) NOT NULL,
	[page] [int] NOT NULL,
	[ISBN] [varchar](20) NULL,
	[Qty] [int] NOT NULL,
	[rentQty] [int] NULL,
	[reserQty] [int] NULL,
	[catgid] [varchar](10) NOT NULL,
	[typeid] [varchar](10) NOT NULL,
	[tbdid] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tbBooks_1] PRIMARY KEY CLUSTERED 
(
	[bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCategory]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCategory](
	[catgid] [varchar](10) NOT NULL,
	[name] [nvarchar](60) NULL,
 CONSTRAINT [PK_tbCategory] PRIMARY KEY CLUSTERED 
(
	[catgid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbMember]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMember](
	[mid] [varchar](12) NOT NULL,
	[fname] [nvarchar](60) NOT NULL,
	[lname] [nvarchar](60) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
	[tel] [varchar](12) NULL,
	[village] [nvarchar](60) NULL,
	[district] [nvarchar](60) NULL,
	[province] [nvarchar](60) NULL,
	[birdate] [date] NULL,
	[detpname] [nvarchar](100) NULL,
	[dateRgt] [date] NOT NULL,
	[dateREd] [date] NOT NULL,
 CONSTRAINT [PK_tbMember] PRIMARY KEY CLUSTERED 
(
	[mid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbType]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbType](
	[typeid] [varchar](10) NOT NULL,
	[typename] [nvarchar](60) NULL,
 CONSTRAINT [PK_tbType] PRIMARY KEY CLUSTERED 
(
	[typeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRent_Book]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRent_Book](
	[rentid] [varchar](12) NOT NULL,
	[barcode] [varchar](12) NOT NULL,
	[qty] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbRent_Book] PRIMARY KEY CLUSTERED 
(
	[rentid] ASC,
	[barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRent_Detail]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRent_Detail](
	[rentid] [varchar](12) NOT NULL,
	[mbid] [varchar](12) NULL,
	[qty] [int] NULL,
	[datest] [date] NULL,
	[dateed] [date] NULL,
 CONSTRAINT [PK_tbRent_Detail] PRIMARY KEY CLUSTERED 
(
	[rentid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_ShowLostBooks]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ShowLostBooks]
AS
SELECT dbo.tbBooks.barcode, dbo.tbBooks_Detail.bname, dbo.tbBooks_Detail.page, dbo.tbCategory.name, dbo.tbType.typename, dbo.tbRent_Book.qty, dbo.tbBooks_Detail.tbdid, dbo.tbRent_Book.status, dbo.tbRent_Detail.datest, dbo.tbRent_Detail.dateed, dbo.tbRent_Detail.mbid, 
             dbo.tbMember.fname, dbo.tbMember.lname, dbo.tbMember.tel, dbo.tbRent_Detail.rentid
FROM   dbo.tbBooks INNER JOIN
             dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN
             dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN
             dbo.tbRent_Book ON dbo.tbBooks.barcode = dbo.tbRent_Book.barcode INNER JOIN
             dbo.tbRent_Detail ON dbo.tbRent_Book.rentid = dbo.tbRent_Detail.rentid INNER JOIN
             dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid INNER JOIN
             dbo.tbMember ON dbo.tbRent_Detail.mbid = dbo.tbMember.mid
GO
/****** Object:  Table [dbo].[tbBook_Lost]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBook_Lost](
	[losid] [int] IDENTITY(1,1) NOT NULL,
	[barcode] [varchar](12) NOT NULL,
	[qty] [int] NOT NULL,
	[cost] [decimal](18, 2) NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_tbBook_Lost_1] PRIMARY KEY CLUSTERED 
(
	[losid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_BookLost]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_BookLost]
AS
SELECT dbo.tbBook_Lost.barcode, dbo.tbBooks_Detail.bname, dbo.tbBooks_Detail.page, dbo.tbBook_Lost.qty, dbo.tbBook_Lost.cost, dbo.tbCategory.name AS catgname, dbo.tbType.typename, dbo.tbBooks_Detail.tbdid, dbo.tbBook_Lost.date
FROM   dbo.tbBook_Lost INNER JOIN
             dbo.tbBooks ON dbo.tbBook_Lost.barcode = dbo.tbBooks.barcode INNER JOIN
             dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN
             dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN
             dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid
GO
/****** Object:  View [dbo].[vw_Book]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vw_Book]
AS
SELECT dbo.tbBooks.barcode, dbo.tbBooks_Detail.bname, dbo.tbBooks_Detail.page, dbo.tbBooks_Detail.ISBN, dbo.tbCategory.name, dbo.tbType.typename, dbo.tbBooks_Detail.tbdid, dbo.tbBooks.status
FROM   dbo.tbBooks INNER JOIN
             dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN
             dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN
             dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid

GO
/****** Object:  Table [dbo].[tbTable]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTable](
	[tbid] [varchar](10) NOT NULL,
	[tbdid] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tbTable_1] PRIMARY KEY CLUSTERED 
(
	[tbdid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Return]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Return]
AS
SELECT dbo.tbRent_Detail.rentid, dbo.tbBooks_Detail.bid, dbo.tbRent_Book.barcode, dbo.tbBooks_Detail.bname, dbo.tbBooks_Detail.page, dbo.tbCategory.name, dbo.tbType.typename,dbo.tbRent_Detail.qty as [qty_total],  dbo.tbRent_Book.qty, dbo.tbBooks_Detail.tbdid, dbo.tbRent_Detail.datest, dbo.tbRent_Detail.dateed, 
             dbo.tbRent_Detail.mbid, dbo.tbMember.fname, dbo.tbMember.lname
FROM   dbo.tbBooks INNER JOIN
             dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN
             dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN
             dbo.tbRent_Book ON dbo.tbBooks.barcode = dbo.tbRent_Book.barcode INNER JOIN
             dbo.tbRent_Detail ON dbo.tbRent_Book.rentid = dbo.tbRent_Detail.rentid INNER JOIN
             dbo.tbTable ON dbo.tbBooks_Detail.tbdid = dbo.tbTable.tbdid INNER JOIN
             dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid INNER JOIN
             dbo.tbMember ON dbo.tbRent_Detail.mbid = dbo.tbMember.mid
GO
/****** Object:  View [dbo].[vw_ReturnBooks]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ReturnBooks]
AS
SELECT dbo.tbRent_Detail.rentid, dbo.tbBooks_Detail.bid, dbo.tbRent_Book.barcode, dbo.tbBooks_Detail.bname, dbo.tbBooks_Detail.page, dbo.tbCategory.name, dbo.tbType.typename, dbo.tbRent_Book.qty, dbo.tbBooks_Detail.tbdid, dbo.tbRent_Detail.datest, dbo.tbRent_Detail.dateed, 
             dbo.tbRent_Detail.mbid
FROM   dbo.tbBooks INNER JOIN
             dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN
             dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN
             dbo.tbRent_Book ON dbo.tbBooks.barcode = dbo.tbRent_Book.barcode INNER JOIN
             dbo.tbRent_Detail ON dbo.tbRent_Book.rentid = dbo.tbRent_Detail.rentid INNER JOIN
             dbo.tbTable ON dbo.tbBooks_Detail.tbdid = dbo.tbTable.tbdid INNER JOIN
             dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid

GO
/****** Object:  Table [dbo].[tbStaff]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStaff](
	[empid] [varchar](12) NOT NULL,
	[fname] [nvarchar](60) NULL,
	[lname] [nvarchar](60) NULL,
	[gender] [nvarchar](10) NULL,
	[tel] [varchar](12) NULL,
 CONSTRAINT [PK_tbStaff] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUser]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUser](
	[empid] [varchar](12) NOT NULL,
	[user_name] [nvarchar](50) NULL,
	[password] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_User]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_User]
AS
SELECT dbo.tbStaff.empid, dbo.tbStaff.fname, dbo.tbStaff.lname, dbo.tbStaff.tel, dbo.tbUser.user_name, dbo.tbUser.password
FROM   dbo.tbStaff INNER JOIN
             dbo.tbUser ON dbo.tbStaff.empid = dbo.tbUser.empid

GO
/****** Object:  Table [dbo].[tbReserve]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbReserve](
	[rsid] [varchar](12) NOT NULL,
	[barcode] [varchar](12) NOT NULL,
	[qty] [int] NULL,
 CONSTRAINT [PK_tbReserve] PRIMARY KEY CLUSTERED 
(
	[rsid] ASC,
	[barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbReserve_Detail]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbReserve_Detail](
	[rsid] [varchar](12) NOT NULL,
	[mid] [varchar](12) NOT NULL,
	[dateSt] [date] NULL,
	[dateEd] [date] NULL,
 CONSTRAINT [PK_tbReserve_Detail] PRIMARY KEY CLUSTERED 
(
	[rsid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Reserves_Books]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_Reserves_Books]
AS
SELECT dbo.tbReserve_Detail.rsid, dbo.tbReserve.barcode, dbo.tbBooks_Detail.bname, tbBooks_Detail.page, dbo.tbCategory.name, dbo.tbType.typename, dbo.tbTable.tbdid, dbo.tbReserve_Detail.dateSt, dbo.tbReserve_Detail.dateEd, dbo.tbReserve_Detail.mid, dbo.tbMember.fname, dbo.tbMember.lname, 
             dbo.tbMember.tel, dbo.tbBooks_Detail.bid
FROM   dbo.tbBooks INNER JOIN
             dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN
             dbo.tbReserve ON dbo.tbBooks.barcode = dbo.tbReserve.barcode INNER JOIN
             dbo.tbReserve_Detail ON dbo.tbReserve.rsid = dbo.tbReserve_Detail.rsid INNER JOIN
             dbo.tbMember ON dbo.tbReserve_Detail.mid = dbo.tbMember.mid INNER JOIN
             dbo.tbTable ON dbo.tbBooks_Detail.tbdid = dbo.tbTable.tbdid INNER JOIN
             dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid INNER JOIN
             dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid
GO
/****** Object:  Table [dbo].[tbAthor]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAthor](
	[athid] [varchar](10) NOT NULL,
	[fname] [nvarchar](100) NOT NULL,
	[lname] [nvarchar](100) NULL,
	[tel] [varchar](12) NULL,
 CONSTRAINT [PK_tbAthor] PRIMARY KEY CLUSTERED 
(
	[athid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDepart]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDepart](
	[depid] [varchar](10) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[depid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbFine]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbFine](
	[fid] [int] IDENTITY(1,1) NOT NULL,
	[price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tbFine] PRIMARY KEY CLUSTERED 
(
	[fid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRegister_cost]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRegister_cost](
	[rgid] [int] IDENTITY(1,1) NOT NULL,
	[cost] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tbRegister_cost] PRIMARY KEY CLUSTERED 
(
	[rgid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTableDetail]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTableDetail](
	[tbid] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tbTableDetail] PRIMARY KEY CLUSTERED 
(
	[tbid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbWrite]    Script Date: 03-07-2020 10:02:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbWrite](
	[bid] [varchar](10) NOT NULL,
	[athid] [varchar](10) NOT NULL,
	[Year] [varchar](10) NULL,
 CONSTRAINT [PK_tbBooks_Detail] PRIMARY KEY CLUSTERED 
(
	[bid] ASC,
	[athid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbBooks_Detail] ADD  CONSTRAINT [DF_tbBooks_Detail_rentQty]  DEFAULT ((0)) FOR [rentQty]
GO
ALTER TABLE [dbo].[tbBooks_Detail] ADD  CONSTRAINT [DF_tbBooks_Detail_reserQty]  DEFAULT ((0)) FOR [reserQty]
GO
ALTER TABLE [dbo].[tbBook_Lost]  WITH CHECK ADD  CONSTRAINT [FK_tbBook_Lost_tbBooks] FOREIGN KEY([barcode])
REFERENCES [dbo].[tbBooks] ([barcode])
GO
ALTER TABLE [dbo].[tbBook_Lost] CHECK CONSTRAINT [FK_tbBook_Lost_tbBooks]
GO
ALTER TABLE [dbo].[tbBooks]  WITH CHECK ADD  CONSTRAINT [FK_tbBooks_Detail_tbBooks] FOREIGN KEY([bid])
REFERENCES [dbo].[tbBooks_Detail] ([bid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbBooks] CHECK CONSTRAINT [FK_tbBooks_Detail_tbBooks]
GO
ALTER TABLE [dbo].[tbBooks_Detail]  WITH CHECK ADD  CONSTRAINT [FK_tbBooks_Detail_tbCategory] FOREIGN KEY([catgid])
REFERENCES [dbo].[tbCategory] ([catgid])
GO
ALTER TABLE [dbo].[tbBooks_Detail] CHECK CONSTRAINT [FK_tbBooks_Detail_tbCategory]
GO
ALTER TABLE [dbo].[tbBooks_Detail]  WITH CHECK ADD  CONSTRAINT [FK_tbBooks_Detail_tbTable] FOREIGN KEY([tbdid])
REFERENCES [dbo].[tbTable] ([tbdid])
GO
ALTER TABLE [dbo].[tbBooks_Detail] CHECK CONSTRAINT [FK_tbBooks_Detail_tbTable]
GO
ALTER TABLE [dbo].[tbBooks_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Type] FOREIGN KEY([typeid])
REFERENCES [dbo].[tbType] ([typeid])
GO
ALTER TABLE [dbo].[tbBooks_Detail] CHECK CONSTRAINT [FK_Type]
GO
ALTER TABLE [dbo].[tbRent_Book]  WITH CHECK ADD  CONSTRAINT [FK_tbRent_Book_tbBooks] FOREIGN KEY([barcode])
REFERENCES [dbo].[tbBooks] ([barcode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbRent_Book] CHECK CONSTRAINT [FK_tbRent_Book_tbBooks]
GO
ALTER TABLE [dbo].[tbRent_Book]  WITH CHECK ADD  CONSTRAINT [FK_tbRent_Book_tbRent_Detail] FOREIGN KEY([rentid])
REFERENCES [dbo].[tbRent_Detail] ([rentid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbRent_Book] CHECK CONSTRAINT [FK_tbRent_Book_tbRent_Detail]
GO
ALTER TABLE [dbo].[tbRent_Detail]  WITH CHECK ADD  CONSTRAINT [FK_tbRent_Detail_tbMember] FOREIGN KEY([mbid])
REFERENCES [dbo].[tbMember] ([mid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbRent_Detail] CHECK CONSTRAINT [FK_tbRent_Detail_tbMember]
GO
ALTER TABLE [dbo].[tbReserve]  WITH CHECK ADD  CONSTRAINT [FK_tbReserve_tbBooks] FOREIGN KEY([barcode])
REFERENCES [dbo].[tbBooks] ([barcode])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbReserve] CHECK CONSTRAINT [FK_tbReserve_tbBooks]
GO
ALTER TABLE [dbo].[tbReserve]  WITH CHECK ADD  CONSTRAINT [FK_tbReserve_tbReserve_Detail] FOREIGN KEY([rsid])
REFERENCES [dbo].[tbReserve_Detail] ([rsid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbReserve] CHECK CONSTRAINT [FK_tbReserve_tbReserve_Detail]
GO
ALTER TABLE [dbo].[tbReserve_Detail]  WITH CHECK ADD  CONSTRAINT [FK_tbReserve_Detail_tbMember] FOREIGN KEY([mid])
REFERENCES [dbo].[tbMember] ([mid])
GO
ALTER TABLE [dbo].[tbReserve_Detail] CHECK CONSTRAINT [FK_tbReserve_Detail_tbMember]
GO
ALTER TABLE [dbo].[tbTable]  WITH CHECK ADD  CONSTRAINT [FK_tbTable_tbTableDetail] FOREIGN KEY([tbid])
REFERENCES [dbo].[tbTableDetail] ([tbid])
GO
ALTER TABLE [dbo].[tbTable] CHECK CONSTRAINT [FK_tbTable_tbTableDetail]
GO
ALTER TABLE [dbo].[tbUser]  WITH CHECK ADD  CONSTRAINT [FK_tbUser_tbStaff] FOREIGN KEY([empid])
REFERENCES [dbo].[tbStaff] ([empid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbUser] CHECK CONSTRAINT [FK_tbUser_tbStaff]
GO
ALTER TABLE [dbo].[tbWrite]  WITH CHECK ADD  CONSTRAINT [FK_tbBooks_Detail_tbAthor] FOREIGN KEY([athid])
REFERENCES [dbo].[tbAthor] ([athid])
GO
ALTER TABLE [dbo].[tbWrite] CHECK CONSTRAINT [FK_tbBooks_Detail_tbAthor]
GO
ALTER TABLE [dbo].[tbWrite]  WITH CHECK ADD  CONSTRAINT [FK_tbWrite_tbBooks_Detail] FOREIGN KEY([bid])
REFERENCES [dbo].[tbBooks_Detail] ([bid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbWrite] CHECK CONSTRAINT [FK_tbWrite_tbBooks_Detail]
GO
ALTER TABLE [dbo].[tbFine]  WITH CHECK ADD  CONSTRAINT [CK_tbFine] CHECK  (([price]>=(0)))
GO
ALTER TABLE [dbo].[tbFine] CHECK CONSTRAINT [CK_tbFine]
GO
ALTER TABLE [dbo].[tbRegister_cost]  WITH CHECK ADD  CONSTRAINT [CK_tbRegister_cost] CHECK  (([cost]>=(0)))
GO
ALTER TABLE [dbo].[tbRegister_cost] CHECK CONSTRAINT [CK_tbRegister_cost]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneCONigurations = 
      Begin PaneCONiguration = 0
         NumPanes = 4
         CONiguration = "(H (1[55] 4[7] 2[11] 3) )"
      End
      Begin PaneCONiguration = 1
         NumPanes = 3
         CONiguration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneCONiguration = 2
         NumPanes = 3
         CONiguration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneCONiguration = 3
         NumPanes = 3
         CONiguration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneCONiguration = 4
         NumPanes = 2
         CONiguration = "(H (1 [56] 3))"
      End
      Begin PaneCONiguration = 5
         NumPanes = 2
         CONiguration = "(H (2 [66] 3))"
      End
      Begin PaneCONiguration = 6
         NumPanes = 2
         CONiguration = "(H (4 [50] 3))"
      End
      Begin PaneCONiguration = 7
         NumPanes = 1
         CONiguration = "(V (3))"
      End
      Begin PaneCONiguration = 8
         NumPanes = 3
         CONiguration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneCONiguration = 9
         NumPanes = 2
         CONiguration = "(H (1 [75] 4))"
      End
      Begin PaneCONiguration = 10
         NumPanes = 2
         CONiguration = "(H (1[66] 2) )"
      End
      Begin PaneCONiguration = 11
         NumPanes = 2
         CONiguration = "(H (4 [60] 2))"
      End
      Begin PaneCONiguration = 12
         NumPanes = 1
         CONiguration = "(H (1) )"
      End
      Begin PaneCONiguration = 13
         NumPanes = 1
         CONiguration = "(V (4))"
      End
      Begin PaneCONiguration = 14
         NumPanes = 1
         CONiguration = "(V (2))"
      End
      ActivePaneCONig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbBooks"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 176
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbBooks_Detail"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 381
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbCategory"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbType"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 102
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      En' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Book'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'd
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Book'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Book'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[34] 2[6] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbBook_Lost"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbBooks"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbBooks_Detail"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 206
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbCategory"
            Begin Extent = 
               Top = 9
               Left = 894
               Bottom = 152
               Right = 1116
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbType"
            Begin Extent = 
               Top = 153
               Left = 894
               Bottom = 296
               Right = 1116
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
      ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_BookLost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'   Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_BookLost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_BookLost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneCONigurations = 
      Begin PaneCONiguration = 0
         NumPanes = 4
         CONiguration = "(H (1[62] 4[2] 2[3] 3) )"
      End
      Begin PaneCONiguration = 1
         NumPanes = 3
         CONiguration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneCONiguration = 2
         NumPanes = 3
         CONiguration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneCONiguration = 3
         NumPanes = 3
         CONiguration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneCONiguration = 4
         NumPanes = 2
         CONiguration = "(H (1 [56] 3))"
      End
      Begin PaneCONiguration = 5
         NumPanes = 2
         CONiguration = "(H (2 [66] 3))"
      End
      Begin PaneCONiguration = 6
         NumPanes = 2
         CONiguration = "(H (4 [50] 3))"
      End
      Begin PaneCONiguration = 7
         NumPanes = 1
         CONiguration = "(V (3))"
      End
      Begin PaneCONiguration = 8
         NumPanes = 3
         CONiguration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneCONiguration = 9
         NumPanes = 2
         CONiguration = "(H (1 [75] 4))"
      End
      Begin PaneCONiguration = 10
         NumPanes = 2
         CONiguration = "(H (1[66] 2) )"
      End
      Begin PaneCONiguration = 11
         NumPanes = 2
         CONiguration = "(H (4 [60] 2))"
      End
      Begin PaneCONiguration = 12
         NumPanes = 1
         CONiguration = "(H (1) )"
      End
      Begin PaneCONiguration = 13
         NumPanes = 1
         CONiguration = "(V (4))"
      End
      Begin PaneCONiguration = 14
         NumPanes = 1
         CONiguration = "(V (2))"
      End
      ActivePaneCONig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbBooks"
            Begin Extent = 
               Top = 16
               Left = 694
               Bottom = 186
               Right = 916
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbBooks_Detail"
            Begin Extent = 
               Top = 0
               Left = 365
               Bottom = 383
               Right = 587
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbCategory"
            Begin Extent = 
               Top = 222
               Left = 753
               Bottom = 397
               Right = 975
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbRent_Book"
            Begin Extent = 
               Top = 27
               Left = 1014
               Bottom = 230
               Right = 1236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbRent_Detail"
            Begin Extent = 
               Top = 24
               Left = 1300
               Bottom = 253
               Right = 1522
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbTable"
            Begin Extent = 
               Top = 165
               Left = 5
               Bottom = 342
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbType"
            Begin Extent = 
               Top = 3
               Left = 10
               Bottom = 146
               Right = 232
            End
            D' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Return'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'isplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbMember"
            Begin Extent = 
               Top = 234
               Left = 1032
               Bottom = 431
               Right = 1254
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Return'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_Return'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneCONigurations = 
      Begin PaneCONiguration = 0
         NumPanes = 4
         CONiguration = "(H (1[62] 4[2] 2[3] 3) )"
      End
      Begin PaneCONiguration = 1
         NumPanes = 3
         CONiguration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneCONiguration = 2
         NumPanes = 3
         CONiguration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneCONiguration = 3
         NumPanes = 3
         CONiguration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneCONiguration = 4
         NumPanes = 2
         CONiguration = "(H (1 [56] 3))"
      End
      Begin PaneCONiguration = 5
         NumPanes = 2
         CONiguration = "(H (2 [66] 3))"
      End
      Begin PaneCONiguration = 6
         NumPanes = 2
         CONiguration = "(H (4 [50] 3))"
      End
      Begin PaneCONiguration = 7
         NumPanes = 1
         CONiguration = "(V (3))"
      End
      Begin PaneCONiguration = 8
         NumPanes = 3
         CONiguration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneCONiguration = 9
         NumPanes = 2
         CONiguration = "(H (1 [75] 4))"
      End
      Begin PaneCONiguration = 10
         NumPanes = 2
         CONiguration = "(H (1[66] 2) )"
      End
      Begin PaneCONiguration = 11
         NumPanes = 2
         CONiguration = "(H (4 [60] 2))"
      End
      Begin PaneCONiguration = 12
         NumPanes = 1
         CONiguration = "(H (1) )"
      End
      Begin PaneCONiguration = 13
         NumPanes = 1
         CONiguration = "(V (4))"
      End
      Begin PaneCONiguration = 14
         NumPanes = 1
         CONiguration = "(V (2))"
      End
      ActivePaneCONig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbBooks"
            Begin Extent = 
               Top = 16
               Left = 694
               Bottom = 186
               Right = 916
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbBooks_Detail"
            Begin Extent = 
               Top = 0
               Left = 365
               Bottom = 383
               Right = 587
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbCategory"
            Begin Extent = 
               Top = 222
               Left = 753
               Bottom = 397
               Right = 975
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbRent_Book"
            Begin Extent = 
               Top = 27
               Left = 1014
               Bottom = 230
               Right = 1236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbRent_Detail"
            Begin Extent = 
               Top = 24
               Left = 1300
               Bottom = 253
               Right = 1522
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbTable"
            Begin Extent = 
               Top = 165
               Left = 5
               Bottom = 342
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbType"
            Begin Extent = 
               Top = 3
               Left = 10
               Bottom = 146
               Right = 232
            End
            D' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ReturnBooks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'isplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ReturnBooks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ReturnBooks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[3] 2[4] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -71
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbBooks"
            Begin Extent = 
               Top = 304
               Left = 385
               Bottom = 474
               Right = 607
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbBooks_Detail"
            Begin Extent = 
               Top = 34
               Left = 729
               Bottom = 410
               Right = 951
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbCategory"
            Begin Extent = 
               Top = 52
               Left = 1010
               Bottom = 195
               Right = 1232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbRent_Book"
            Begin Extent = 
               Top = 136
               Left = 27
               Bottom = 349
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbRent_Detail"
            Begin Extent = 
               Top = 72
               Left = 379
               Bottom = 317
               Right = 601
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbType"
            Begin Extent = 
               Top = 251
               Left = 1022
               Bottom = 394
               Right = 1244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbMember"
            Begin Extent = 
               Top = 350
               Left = 57
               Bottom = 547
               Right = 279
            End
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ShowLostBooks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2060
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ShowLostBooks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ShowLostBooks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbStaff"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 264
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbUser"
            Begin Extent = 
               Top = 64
               Left = 642
               Bottom = 234
               Right = 864
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_User'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_User'
GO
USE [master]
GO
ALTER DATABASE [db_Libary] SET  READ_WRITE 
GO
