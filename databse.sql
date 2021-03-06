USE [master]
GO
/****** Object:  Database [Proje]    Script Date: 6.06.2022 21:57:48 ******/
CREATE DATABASE [Proje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proje.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proje_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Proje] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proje] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proje] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Proje] SET  MULTI_USER 
GO
ALTER DATABASE [Proje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proje] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proje] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proje] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Proje] SET QUERY_STORE = OFF
GO
USE [Proje]
GO
/****** Object:  Table [dbo].[Hareket]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hareket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [int] NULL,
	[MusteriId] [int] NULL,
	[PersonelId] [int] NULL,
	[Fiyat] [int] NULL,
 CONSTRAINT [PK_Hareket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](max) NULL,
	[Soyad] [nvarchar](max) NULL,
	[Telefon] [nvarchar](max) NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](max) NULL,
	[Soyad] [nvarchar](max) NULL,
	[TC] [nvarchar](max) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](max) NULL,
	[Fiyat] [int] NULL,
	[Adet] [int] NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hareket] ON 

INSERT [dbo].[Hareket] ([Id], [UrunId], [MusteriId], [PersonelId], [Fiyat]) VALUES (2, 1, 2, 3, 740)
INSERT [dbo].[Hareket] ([Id], [UrunId], [MusteriId], [PersonelId], [Fiyat]) VALUES (5, 2, 4, 1, 750)
INSERT [dbo].[Hareket] ([Id], [UrunId], [MusteriId], [PersonelId], [Fiyat]) VALUES (6, 4, 4, 1, 30)
INSERT [dbo].[Hareket] ([Id], [UrunId], [MusteriId], [PersonelId], [Fiyat]) VALUES (7, 3, 3, 2, 750)
INSERT [dbo].[Hareket] ([Id], [UrunId], [MusteriId], [PersonelId], [Fiyat]) VALUES (8, 1, 1, 1, 23)
SET IDENTITY_INSERT [dbo].[Hareket] OFF
GO
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([Id], [Ad], [Soyad], [Telefon]) VALUES (1, N'Furkan', N'Adakbh', N'(   )    -')
INSERT [dbo].[Musteri] ([Id], [Ad], [Soyad], [Telefon]) VALUES (2, N'Nazmi', N'Korük', NULL)
INSERT [dbo].[Musteri] ([Id], [Ad], [Soyad], [Telefon]) VALUES (3, N'Can3', N'Dinç', N'(   )    -')
INSERT [dbo].[Musteri] ([Id], [Ad], [Soyad], [Telefon]) VALUES (4, N'Meltem', N'Yılmaz', NULL)
INSERT [dbo].[Musteri] ([Id], [Ad], [Soyad], [Telefon]) VALUES (5, N'Nazmi', N'2', N'(532) 682-1780')
INSERT [dbo].[Musteri] ([Id], [Ad], [Soyad], [Telefon]) VALUES (6, N'Furkan', N'Adak2', N'(   )    -')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC]) VALUES (1, N'Ahmet', N'Yıldırım', NULL)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC]) VALUES (2, N'Veysel', N'Kaya', NULL)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC]) VALUES (3, N'Ecem', N'Yılmaz', NULL)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [TC]) VALUES (4, N'Yebi', N'23211111111111', N'23232323232')
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([Id], [Ad], [Fiyat], [Adet]) VALUES (1, N'Çamaşır Makinesi', 750, 10)
INSERT [dbo].[Urunler] ([Id], [Ad], [Fiyat], [Adet]) VALUES (2, N'Buzdolabuu', 800, 5)
INSERT [dbo].[Urunler] ([Id], [Ad], [Fiyat], [Adet]) VALUES (3, N'LCD', 1250, 7)
INSERT [dbo].[Urunler] ([Id], [Ad], [Fiyat], [Adet]) VALUES (4, N'Su Isıtıcı', 35, 20)
INSERT [dbo].[Urunler] ([Id], [Ad], [Fiyat], [Adet]) VALUES (5, N'bilgisayar', 1700, 102)
INSERT [dbo].[Urunler] ([Id], [Ad], [Fiyat], [Adet]) VALUES (6, N'Yeni', 12322, 528)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
ALTER TABLE [dbo].[Hareket]  WITH CHECK ADD  CONSTRAINT [FK_Hareket_Musteri] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteri] ([Id])
GO
ALTER TABLE [dbo].[Hareket] CHECK CONSTRAINT [FK_Hareket_Musteri]
GO
ALTER TABLE [dbo].[Hareket]  WITH CHECK ADD  CONSTRAINT [FK_Hareket_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[Hareket] CHECK CONSTRAINT [FK_Hareket_Personel]
GO
ALTER TABLE [dbo].[Hareket]  WITH CHECK ADD  CONSTRAINT [FK_Hareket_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([Id])
GO
ALTER TABLE [dbo].[Hareket] CHECK CONSTRAINT [FK_Hareket_Urunler]
GO
/****** Object:  StoredProcedure [dbo].[Hareketler]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Hareketler]
as
select h.Id as 'Hareket Numarası',u.Ad,(m.Ad+' '+m.Soyad) as 'Müşteri',(p.Ad+' '+p.Soyad) as 'Personel',h.Fiyat from Hareket h
inner join Urunler u on h.UrunId=u.Id 
inner join Musteri m  on h.MusteriId=m.Id
inner join Personel p on h.PersonelId=p.Id
GO
/****** Object:  StoredProcedure [dbo].[ProMusteri]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProMusteri]
as
Select * from Musteri
GO
/****** Object:  StoredProcedure [dbo].[ProPersonel]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ProPersonel]
as
Select * from Personel
GO
/****** Object:  StoredProcedure [dbo].[ProUrun]    Script Date: 6.06.2022 21:57:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ProUrun]
as
Select Id,Ad,Adet,Fiyat from Urunler
GO
USE [master]
GO
ALTER DATABASE [Proje] SET  READ_WRITE 
GO
