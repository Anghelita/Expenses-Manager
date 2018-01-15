USE [master]
GO
/****** Object:  Database [Hramul]    Script Date: 1/15/2018 1:40:08 AM ******/
CREATE DATABASE [Hramul]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hramul', FILENAME = N'/var/opt/mssql/data/Hramul.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hramul_log', FILENAME = N'/var/opt/mssql/data/Hramul_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hramul] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hramul].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hramul] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hramul] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hramul] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hramul] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hramul] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hramul] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hramul] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hramul] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hramul] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hramul] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hramul] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hramul] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hramul] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hramul] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hramul] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hramul] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hramul] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hramul] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hramul] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hramul] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hramul] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hramul] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hramul] SET RECOVERY FULL 
GO
ALTER DATABASE [Hramul] SET  MULTI_USER 
GO
ALTER DATABASE [Hramul] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hramul] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hramul] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hramul] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hramul] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hramul', N'ON'
GO
ALTER DATABASE [Hramul] SET QUERY_STORE = OFF
GO
USE [Hramul]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Hramul]
GO
USE [Hramul]
GO
/****** Object:  Sequence [dbo].[ContorFacturi]    Script Date: 1/15/2018 1:40:09 AM ******/
CREATE SEQUENCE [dbo].[ContorFacturi] 
 AS [int]
 START WITH 1000
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
/****** Object:  Table [dbo].[State de plata]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State de plata](
	[ID_PLATA] [int] IDENTITY(1000,1) NOT NULL,
	[ID_ANGAJAT] [int] NULL,
	[Suma] [money] NULL,
	[Data] [datetime] NULL,
	[TIP_PLATA] [nchar](30) NULL,
 CONSTRAINT [PK__Plati an__2A08766F5FD46EEF] PRIMARY KEY CLUSTERED 
(
	[ID_PLATA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Achizitii]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Achizitii](
	[ID_ACHIZITIE] [int] IDENTITY(1,1) NOT NULL,
	[ID_PRODUS] [int] NULL,
	[Numar de bucati] [int] NULL,
	[ID_FACTURA] [int] NULL,
	[Pret Unitar] [money] NULL,
	[ID_DEPOZIT] [int] NULL,
	[ID_FURNIZOR] [int] NULL,
 CONSTRAINT [PK__Achiziti__8DE4529050158264] PRIMARY KEY CLUSTERED 
(
	[ID_ACHIZITIE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Cheltuieli]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Cheltuieli] AS
SELECT SUM([Numar de bucati]*[Pret Unitar]) AS Bani, 'Achizitii' AS Tip
FROM Achizitii
UNION
SELECT SUM(Suma) AS Bani, 'Salariati' AS Tip
FROM [State de plata]
GO
/****** Object:  Table [dbo].[Comanda Detalii]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comanda Detalii](
	[ID_COMANDA_DETALII] [int] IDENTITY(1,1) NOT NULL,
	[ID_COMANDA] [int] NULL,
	[ID_PRODUS] [int] NULL,
	[Suma] [money] NULL,
	[Cantitate] [int] NULL,
 CONSTRAINT [PK_Comanda Detalii] PRIMARY KEY CLUSTERED 
(
	[ID_COMANDA_DETALII] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comenzi]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comenzi](
	[ID_COMANDA] [int] IDENTITY(1,1) NOT NULL,
	[Data initiere] [datetime] NULL,
	[ID_FACTURA] [int] NULL,
	[ID_ANGAJAT] [int] NULL,
	[Data estimata livrare] [datetime] NULL,
	[Status] [nchar](20) NULL,
	[ID_CLIENT] [int] NULL,
 CONSTRAINT [PK__Vanzari__4D26C9AF471A4570] PRIMARY KEY CLUSTERED 
(
	[ID_COMANDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Castiguri]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Castiguri]
AS
SELECT        SUM(dbo.[Comanda Detalii].Suma) AS Bani
FROM            dbo.[Comanda Detalii] INNER JOIN
                         dbo.Comenzi ON dbo.[Comanda Detalii].ID_COMANDA = dbo.Comenzi.ID_COMANDA
WHERE        (dbo.Comenzi.Status = 'Livrata')
GO
/****** Object:  Table [dbo].[Facturi]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturi](
	[ID_FACTURA] [int] IDENTITY(200,1) NOT NULL,
	[Data] [datetime] NULL,
	[Nr] [int] NOT NULL,
	[Tip] [nchar](10) NULL,
	[Observatii] [nvarchar](150) NULL,
 CONSTRAINT [PK__Factura__4A921BED91CC4726] PRIMARY KEY CLUSTERED 
(
	[ID_FACTURA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[CheltuieliLunare]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CheltuieliLunare] AS
SELECT SUM([Numar de bucati]*[Pret Unitar]) AS Bani, 'Achizitii' AS Tip
FROM Achizitii inner join Facturi on Facturi.ID_FACTURA=Achizitii.ID_FACTURA
WHERE DATEPART(mm, Facturi.[Data]) = DATEPART(mm, GETDATE())
UNION
SELECT SUM(Suma) AS Bani, 'Salariati' AS Tip
FROM [State de plata]
GO
/****** Object:  View [dbo].[FacturiEmise]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FacturiEmise]
AS
SELECT Nr, SUM(Suma) AS Bani, Observatii, Data
FROM Facturi 
INNER JOIN Comenzi on Comenzi.ID_FACTURA = Facturi.ID_FACTURA
INNER JOIN [Comanda Detalii] on Comenzi.ID_COMANDA = [Comanda Detalii].ID_COMANDA
WHERE Facturi.Tip= 'IBU'
GROUP BY Nr, Comenzi.ID_COMANDA, Observatii, Data
GO
/****** Object:  View [dbo].[FacturiPrimite]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FacturiPrimite]
AS
SELECT Nr, Data, SUM([Pret Unitar]*[Numar de bucati]) AS Bani, Observatii
FROM Facturi 
INNER JOIN Achizitii on Achizitii.ID_FACTURA=Facturi.ID_FACTURA
WHERE Facturi.Tip= 'ITU'
GROUP BY Nr, Observatii, Data
GO
/****** Object:  Table [dbo].[Angajati]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Angajati](
	[ID_ANGAJAT] [int] IDENTITY(1,1) NOT NULL,
	[Nume] [nvarchar](50) NULL,
	[Prenume] [nvarchar](50) NULL,
	[Adresa] [nvarchar](150) NULL,
	[Rating] [float] NULL,
	[Functie] [nvarchar](30) NULL,
	[Activ] [bit] NULL,
	[ID_DEPARTAMENT] [int] NULL,
 CONSTRAINT [PK__Angajati__B9912020C666F867] PRIMARY KEY CLUSTERED 
(
	[ID_ANGAJAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Salarii]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Salarii]
AS
SELECT        dbo.Angajati.ID_ANGAJAT, dbo.Angajati.Nume, dbo.Angajati.Prenume, dbo.Angajati.Functie, dbo.Angajati.Rating, SUM(dbo.[State de plata].Suma) AS Salariu, dbo.[State de plata].Data
FROM            dbo.Angajati INNER JOIN
                         dbo.[State de plata] ON dbo.[State de plata].ID_ANGAJAT = dbo.Angajati.ID_ANGAJAT
GROUP BY dbo.Angajati.ID_ANGAJAT, dbo.Angajati.Nume, dbo.Angajati.Prenume, dbo.Angajati.Functie, dbo.Angajati.Rating, dbo.[State de plata].Data
GO
/****** Object:  View [dbo].[Balanta]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Balanta]
AS
SELECT        SUM(dbo.Cheltuieli.Bani) AS Cheltuieli, MAX(dbo.Castiguri.Bani) AS Castiguri, MAX(dbo.Castiguri.Bani) - SUM(dbo.Cheltuieli.Bani) AS Profit
FROM            dbo.Cheltuieli CROSS JOIN
                         dbo.Castiguri
GO
/****** Object:  View [dbo].[SalariiCurente]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SalariiCurente] AS

SELECT ID_ANGAJAT, Nume, Prenume, Functie, Rating, Salariu FROM Salarii
WHERE DATEPART(YYYY, GETDATE())=DATEPART(YYYY, [Data]) AND DATEPART(MM, GETDATE())=DATEPART(MM, [Data])
GO
/****** Object:  Table [dbo].[Depozite]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Depozite](
	[ID_DEPOZIT] [int] IDENTITY(30,1) NOT NULL,
	[Adresa] [nvarchar](150) NULL,
	[Telefon] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_DEPOZIT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furnizori]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furnizori](
	[ID_FURNIZOR] [int] IDENTITY(80,1) NOT NULL,
	[Nume] [nvarchar](50) NULL,
	[Adresa] [nvarchar](150) NULL,
	[CUI] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_FURNIZOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produse]    Script Date: 1/15/2018 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produse](
	[ID_PRODUS] [int] IDENTITY(100,1) NOT NULL,
	[Denumire] [nvarchar](50) NULL,
	[Stoc] [int] NULL,
	[Pret Unitar] [money] NULL,
 CONSTRAINT [PK__Produse__8EDD02FFC25421DB] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AchizitiiExtended]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AchizitiiExtended]
AS
SELECT ID_ACHIZITIE, Produse.Denumire AS [Nume Produs], [Numar de bucati], Achizitii.[Pret Unitar], Furnizori.Nume, Depozite.Adresa AS [Adresa Depozit], Facturi.Nr AS [Numar Factura]
FROM Achizitii
INNER JOIN Facturi ON Facturi.ID_FACTURA = Achizitii.ID_FACTURA
INNER JOIN Depozite ON Depozite.ID_DEPOZIT = Achizitii.ID_DEPOZIT
INNER JOIN Produse ON Produse.ID_PRODUS = Achizitii.ID_PRODUS
INNER JOIN Furnizori ON Furnizori.ID_FURNIZOR = Achizitii.ID_FURNIZOR
GO
/****** Object:  Table [dbo].[Clienti]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clienti](
	[ID_CLIENT] [int] IDENTITY(100,1) NOT NULL,
	[Nume] [nvarchar](50) NULL,
	[Adresa] [nvarchar](150) NULL,
	[Telefon] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CLIENT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ComenziEnhanced]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ComenziEnhanced]
AS
select ID_COMANDA, CAST([Data initiere] AS date) AS [Data plasare comanda], CAST([Data estimata livrare] AS date) AS [Data estimata livrare], Nr AS [Numar Factura], CONCAT(Angajati.Nume,' ', Angajati.Prenume) AS Angajat, Clienti.Nume AS Destinatar
from Comenzi
inner join Angajati on Angajati.ID_ANGAJAT = Comenzi.ID_ANGAJAT
inner join Facturi on Facturi.ID_FACTURA = Comenzi.ID_FACTURA
inner join Clienti on Clienti.ID_CLIENT = Comenzi.ID_CLIENT
GO
/****** Object:  View [dbo].[ComenziExtended]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ComenziExtended]
AS
SELECT        dbo.Comenzi.ID_COMANDA, CAST(dbo.Comenzi.[Data initiere] AS date) AS [Data plasare comanda], CAST(dbo.Comenzi.[Data estimata livrare] AS date) AS [Data estimata livrare], dbo.Facturi.Nr AS [Numar Factura], 
                         CONCAT(dbo.Angajati.Nume, ' ', dbo.Angajati.Prenume) AS Angajat, dbo.Clienti.Nume AS Destinatar, dbo.Comenzi.Status, CASE WHEN SUM(dbo.[Comanda Detalii].Suma) != 0 THEN SUM(dbo.[Comanda Detalii].Suma) 
                         ELSE 0 END AS Total
FROM            dbo.Comenzi INNER JOIN
                         dbo.Angajati ON dbo.Angajati.ID_ANGAJAT = dbo.Comenzi.ID_ANGAJAT INNER JOIN
                         dbo.Facturi ON dbo.Facturi.ID_FACTURA = dbo.Comenzi.ID_FACTURA INNER JOIN
                         dbo.Clienti ON dbo.Clienti.ID_CLIENT = dbo.Comenzi.ID_CLIENT LEFT OUTER JOIN
                         dbo.[Comanda Detalii] ON dbo.[Comanda Detalii].ID_COMANDA = dbo.Comenzi.ID_COMANDA
GROUP BY dbo.Comenzi.ID_COMANDA, dbo.Comenzi.[Data initiere], dbo.Comenzi.[Data estimata livrare], dbo.Facturi.Nr, dbo.Angajati.Nume, dbo.Angajati.Prenume, dbo.Clienti.Nume, Status
GO
/****** Object:  View [dbo].[OrderDetailsExtended]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OrderDetailsExtended]
AS
SELECT        dbo.[Comanda Detalii].ID_COMANDA_DETALII, dbo.[Comanda Detalii].ID_COMANDA, dbo.Produse.Denumire, dbo.[Comanda Detalii].Cantitate, dbo.[Comanda Detalii].Suma AS Subtotal
FROM            dbo.[Comanda Detalii] INNER JOIN
                         dbo.Produse ON dbo.Produse.ID_PRODUS = dbo.[Comanda Detalii].ID_PRODUS
GO
/****** Object:  Table [dbo].[Departamente]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamente](
	[ID_DEPARTAMENT] [int] IDENTITY(1,1) NOT NULL,
	[Denumire] [nvarchar](50) NULL,
 CONSTRAINT [PK_Departamente] PRIMARY KEY CLUSTERED 
(
	[ID_DEPARTAMENT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID_USER] [int] IDENTITY(1,1) NOT NULL,
	[ID_ANGAJAT] [int] NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [binary](150) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID_USER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Achizitii] ON 

INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (12, 103, 40, 1015, 0.1000, 30, 81)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (13, 101, 20, 1016, 100.0000, 31, 82)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1022, 101, 12, 2033, 12.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1023, 101, 12, 2034, 12.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1024, 103, 12, 2035, 15.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1025, 103, 12, 2036, 12.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1026, 103, 1212, 2037, 44.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1027, 101, 1212, 2037, 44.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1028, 103, 1212, 2037, 44.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1029, 101, 1212, 2037, 44.0000, 31, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1030, 103, 12, 2041, 5432.0000, 30, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1031, 101, 12, 2041, 5432.0000, 30, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1032, 101, 12, 2041, 5432.0000, 30, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1033, 103, 43, 2042, 432.0000, 30, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1034, 101, 43, 2042, 432.0000, 30, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1035, 103, 43, 2042, 432.0000, 30, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1036, 101, 43, 2042, 432.0000, 30, 1085)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1037, 103, 123, 2043, 32.0000, 32, 81)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1038, 101, 12, 2040, NULL, 32, 81)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1039, 101, 12, 2045, 2252.0000, 32, 81)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1040, 101, 100, 2047, 25.0000, 30, 1083)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1041, 1149, 21, 2056, 21.0000, 31, 1086)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1042, 1165, 21, 2045, 3232.0000, 30, 81)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1043, 100, 20, 2071, 12.0000, 31, 1084)
INSERT [dbo].[Achizitii] ([ID_ACHIZITIE], [ID_PRODUS], [Numar de bucati], [ID_FACTURA], [Pret Unitar], [ID_DEPOZIT], [ID_FURNIZOR]) VALUES (1044, 1162, 12, 2076, 34.0000, 30, 80)
SET IDENTITY_INSERT [dbo].[Achizitii] OFF
SET IDENTITY_INSERT [dbo].[Angajati] ON 

INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (1, N'Anghelita', N'Traian', N'Centura', 5, N'Baiatu cu Interfata', 1, 1)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (2, N'Avram', N'Andrei', N'Palat', 4.7, N'Baiatu din spate', 1, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (3, N'Cizman', N'Alexandru', N'Bulgaria', 3, N'Baiatu', 1, 3)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (4, N'Mihailescu', N'Dan', N'11, Strada 1918, Razboieni', 5, N'Serif-Sef', 0, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (5, N'Cazacu', N'Alex', N'Bloc 1A, Rahova, Bucuresti', 5, N'Comediant', 0, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (6, N'Tamaurgul', N'Nectarie', N'11, BOR, Bucuresti', 1, N'Baiatul cu lumanarile', 1, 4)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (7, N'Nazareanu', N'Cristi', N'17A, Gradina Ghetismani, Bucuresti', 5, N'ScapeGoat', 0, 1)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (9, N'Avram', N'Avram', N'213123', 6, N'Avram', 0, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (10, N'Mihailescu', N'Daniel', N'Bl.R2', 6, N'Human Strategies', 0, 1)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (11, N'Gicu', N'Ion', N'Nr.32', 3, N'Lautar', 1, 3)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (12, N'Ionel', N'Ion', N'3123', 9, N'General', 1, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (13, N'Radu', N'Andrei', N'Nr.22', 6, N'Sef', 0, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (14, N'Ciobanu', N'Daniel', N'Nr.1', 7, N'Barosan', 1, 4)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (15, N'Ciobanu', N'Daniela', N'Nr.9', 7, N'Barosan', 1, 1)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (16, N'Adad', N'Addd', N'3123', 5, N'Dad', 0, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (17, N'Ciripel', N'Ionut', N'Nr.2', 4, N'Manager', 1, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (18, N'Gagu', N'Daniel', N'3213', 2, N'Manager', 1, 2)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (19, N'Ana', N'Maria', N'Nr.2', 7, N'Programator', 1, 1)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (20, N'Geanta', N'Miruna', N'Nr.8', 8, N'Programator', 1, 1)
INSERT [dbo].[Angajati] ([ID_ANGAJAT], [Nume], [Prenume], [Adresa], [Rating], [Functie], [Activ], [ID_DEPARTAMENT]) VALUES (21, N'Adam', N'Aaa', N'23123', 2, N'Manager', 1, 1)
SET IDENTITY_INSERT [dbo].[Angajati] OFF
SET IDENTITY_INSERT [dbo].[Clienti] ON 

INSERT [dbo].[Clienti] ([ID_CLIENT], [Nume], [Adresa], [Telefon]) VALUES (100, N'Scuipa-n balta', N'01, Strada Dambovitei, Dambovita', N'07noidoi')
INSERT [dbo].[Clienti] ([ID_CLIENT], [Nume], [Adresa], [Telefon]) VALUES (101, N'Rebu', N'14, Strada Curateniei, Sectorul 6, Bucuresti', N'0712345678')
INSERT [dbo].[Clienti] ([ID_CLIENT], [Nume], [Adresa], [Telefon]) VALUES (102, N'Polaris', N'11, Strada Cuza Voda, Constanta', N'0762927300')
INSERT [dbo].[Clienti] ([ID_CLIENT], [Nume], [Adresa], [Telefon]) VALUES (103, N'Nicki Minaj SRL', N'21, Bulevardul Haliud, Comuna Fierbinti', N'0764254000')
INSERT [dbo].[Clienti] ([ID_CLIENT], [Nume], [Adresa], [Telefon]) VALUES (104, N'RO Army Caterinc', N'5d, Bulevardul Timisoara', N'0213185000')
SET IDENTITY_INSERT [dbo].[Clienti] OFF
SET IDENTITY_INSERT [dbo].[Comanda Detalii] ON 

INSERT [dbo].[Comanda Detalii] ([ID_COMANDA_DETALII], [ID_COMANDA], [ID_PRODUS], [Suma], [Cantitate]) VALUES (19, 17, 103, 0.5000, 5)
INSERT [dbo].[Comanda Detalii] ([ID_COMANDA_DETALII], [ID_COMANDA], [ID_PRODUS], [Suma], [Cantitate]) VALUES (1023, 19, 101, 150.0000, 1)
INSERT [dbo].[Comanda Detalii] ([ID_COMANDA_DETALII], [ID_COMANDA], [ID_PRODUS], [Suma], [Cantitate]) VALUES (1024, 19, 1165, 96960.0000, 30)
INSERT [dbo].[Comanda Detalii] ([ID_COMANDA_DETALII], [ID_COMANDA], [ID_PRODUS], [Suma], [Cantitate]) VALUES (1025, 19, 1165, 32320.0000, 10)
INSERT [dbo].[Comanda Detalii] ([ID_COMANDA_DETALII], [ID_COMANDA], [ID_PRODUS], [Suma], [Cantitate]) VALUES (1026, 20, 100, 40.0000, 1)
INSERT [dbo].[Comanda Detalii] ([ID_COMANDA_DETALII], [ID_COMANDA], [ID_PRODUS], [Suma], [Cantitate]) VALUES (1027, 17, 100, 80.0000, 2)
SET IDENTITY_INSERT [dbo].[Comanda Detalii] OFF
SET IDENTITY_INSERT [dbo].[Comenzi] ON 

INSERT [dbo].[Comenzi] ([ID_COMANDA], [Data initiere], [ID_FACTURA], [ID_ANGAJAT], [Data estimata livrare], [Status], [ID_CLIENT]) VALUES (17, CAST(N'2018-01-13T00:00:00.000' AS DateTime), 1017, 1, CAST(N'2018-01-20T00:00:00.000' AS DateTime), N'Livrata             ', 103)
INSERT [dbo].[Comenzi] ([ID_COMANDA], [Data initiere], [ID_FACTURA], [ID_ANGAJAT], [Data estimata livrare], [Status], [ID_CLIENT]) VALUES (18, CAST(N'2018-01-13T00:00:00.000' AS DateTime), 1018, 2, CAST(N'2018-01-21T00:00:00.000' AS DateTime), N'In Asteptare        ', 104)
INSERT [dbo].[Comenzi] ([ID_COMANDA], [Data initiere], [ID_FACTURA], [ID_ANGAJAT], [Data estimata livrare], [Status], [ID_CLIENT]) VALUES (19, CAST(N'2018-01-14T21:47:00.230' AS DateTime), 2073, 1, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'In Asteptare        ', 102)
INSERT [dbo].[Comenzi] ([ID_COMANDA], [Data initiere], [ID_FACTURA], [ID_ANGAJAT], [Data estimata livrare], [Status], [ID_CLIENT]) VALUES (20, CAST(N'2018-01-14T22:47:54.083' AS DateTime), 2074, 1, CAST(N'2018-01-09T00:00:00.000' AS DateTime), N'In Asteptare        ', 101)
SET IDENTITY_INSERT [dbo].[Comenzi] OFF
SET IDENTITY_INSERT [dbo].[Departamente] ON 

INSERT [dbo].[Departamente] ([ID_DEPARTAMENT], [Denumire]) VALUES (1, N'Maintenance')
INSERT [dbo].[Departamente] ([ID_DEPARTAMENT], [Denumire]) VALUES (2, N'Human Resources')
INSERT [dbo].[Departamente] ([ID_DEPARTAMENT], [Denumire]) VALUES (3, N'Sales')
INSERT [dbo].[Departamente] ([ID_DEPARTAMENT], [Denumire]) VALUES (4, N'Management')
SET IDENTITY_INSERT [dbo].[Departamente] OFF
SET IDENTITY_INSERT [dbo].[Depozite] ON 

INSERT [dbo].[Depozite] ([ID_DEPOZIT], [Adresa], [Telefon]) VALUES (30, N'1, Strada Saraciei, Craiova', N'0762683533')
INSERT [dbo].[Depozite] ([ID_DEPOZIT], [Adresa], [Telefon]) VALUES (31, N'1, Ultimu Drum, Ferentari', N'0726387280')
INSERT [dbo].[Depozite] ([ID_DEPOZIT], [Adresa], [Telefon]) VALUES (32, N'31, Strada Metalului, Pitesti', N'0769890900')
INSERT [dbo].[Depozite] ([ID_DEPOZIT], [Adresa], [Telefon]) VALUES (1034, N'55, Trafic Greu, Bucuresti', N'1447854642')
SET IDENTITY_INSERT [dbo].[Depozite] OFF
SET IDENTITY_INSERT [dbo].[Facturi] ON 

INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (1015, CAST(N'2018-01-03T00:00:00.000' AS DateTime), 1234, N'ITU       ', NULL)
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (1016, CAST(N'2018-01-12T00:00:00.000' AS DateTime), 3465, N'ITU       ', NULL)
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (1017, CAST(N'2018-01-13T21:34:33.770' AS DateTime), 1007, N'IBU       ', NULL)
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (1018, CAST(N'2018-01-13T21:34:33.770' AS DateTime), 1008, N'IBU       ', NULL)
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2023, CAST(N'2017-12-01T00:00:00.000' AS DateTime), 1154, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2024, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 21212, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2025, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 3232, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2027, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 321321, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2028, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 212121, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2029, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 23232, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2030, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 43434, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2031, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 431123432, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2032, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 312312312, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2033, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 4321, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2034, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 42432, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2035, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 45554543, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2036, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 111233, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2037, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 21111, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2038, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 54432, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2039, CAST(N'2018-04-14T00:00:00.000' AS DateTime), 312312, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2040, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 1213, N'          ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2041, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 432432, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2042, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 1112, N'IBU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2043, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 543, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2044, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 1213, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2045, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 32323, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2047, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 1222213, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2048, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 1112131, N'ITU       ', N'Rudarie mare')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2049, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 4244224, N'ITU       ', N'aa')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2050, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 321312, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2051, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 21212, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2053, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 423432, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2054, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 321312, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2055, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 32131, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2056, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 3131, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2057, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 313131321, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2058, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 112121, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2059, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 12121233, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2060, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 2121, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2061, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 3232, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2062, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 3232, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2063, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 211121, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2064, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 333434, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2065, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 4433, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2066, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 321321, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2067, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 111221, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2068, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 112332, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2069, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 3343232, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2070, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 32323, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2071, CAST(N'2018-01-14T00:00:00.000' AS DateTime), 11234, N'ITU       ', N'')
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2073, CAST(N'2018-01-14T21:47:00.227' AS DateTime), 1009, N'IBU       ', NULL)
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2074, CAST(N'2018-01-14T22:47:54.080' AS DateTime), 1010, N'IBU       ', NULL)
INSERT [dbo].[Facturi] ([ID_FACTURA], [Data], [Nr], [Tip], [Observatii]) VALUES (2076, CAST(N'2018-01-15T00:00:00.000' AS DateTime), 23, N'ITU       ', N'Au fost Stricati')
SET IDENTITY_INSERT [dbo].[Facturi] OFF
SET IDENTITY_INSERT [dbo].[Furnizori] ON 

INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (80, N'Comunitatea Minoritara din Craiova', N'Strada Bogatiei, Craiova', N'1243')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (81, N'Asociatia Romilor din Romania', N'Cortul 1, Ferentari', N'1234')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (82, N'Asociatia Rudari fara Frontiere', N'12, Buchenstrasse, Zurich', N'8001')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (86, N'SA Paien SRL', N'Splaiul Unirii', N'2444')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (1083, N'Manastire Putna', N'Strada Manastirii', N'122254')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (1084, N'Euro Gsm SA', N'Strada nuieleor', N'11441')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (1085, N'Nucul cel batran STL', N'Aleea Nucilor', N'1124')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (1086, N'Aerul INC', N'Aleea cerbului 14', N'1123211')
INSERT [dbo].[Furnizori] ([ID_FURNIZOR], [Nume], [Adresa], [CUI]) VALUES (1087, N'ApaNova', N'12, Baicului, Ferentexas', N'114155')
SET IDENTITY_INSERT [dbo].[Furnizori] OFF
SET IDENTITY_INSERT [dbo].[Produse] ON 

INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (100, N'Cartie', 25837, 40.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (101, N'Xanax', 2722, 150.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (102, N'Grasime', 390, 5.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (103, N'Rosii putrezite', 2684, 0.1000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (1149, N'Aer', 636, 1.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (1150, N'Margarina', 66, 100.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (1162, N'Carnati', 34, 50.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (1164, N'Cartoafa', 100, 10.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (1165, N'Creveti', 2, 3232.0000)
INSERT [dbo].[Produse] ([ID_PRODUS], [Denumire], [Stoc], [Pret Unitar]) VALUES (1167, N'Salam', 0, 100.0000)
SET IDENTITY_INSERT [dbo].[Produse] OFF
SET IDENTITY_INSERT [dbo].[State de plata] ON 

INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1032, 9, 5000.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1033, 9, 36936.9000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA RATING                  ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1034, 10, 233.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1035, 10, 69.9000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA RATING                  ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1036, 11, 100.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1037, 12, 5000.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1038, 13, 5000.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1039, 13, 450.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA RATING                  ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1040, 14, 5000.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1041, 14, 15.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA RATING                  ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1042, 15, 500.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1043, 16, 333.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1044, 17, 2000.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1045, 9, 300.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1046, 9, 300.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1047, 9, 300.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1048, 11, 500.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1049, 15, 300.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1050, 15, 50.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1051, 18, 200.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1052, 19, 3000.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1053, 19, 900.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA RATING                  ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1054, 20, 4500.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1055, 20, 1350.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA RATING                  ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1056, 20, 30.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1057, 19, 50.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1058, 16, 50.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1059, 21, 3333.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'SALARIU                       ')
INSERT [dbo].[State de plata] ([ID_PLATA], [ID_ANGAJAT], [Suma], [Data], [TIP_PLATA]) VALUES (1060, 17, 300.0000, CAST(N'2018-01-14T00:00:00.000' AS DateTime), N'PRIMA                         ')
SET IDENTITY_INSERT [dbo].[State de plata] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (1, 1, N'atraian69', 0x390039003000310038003900650032003600310064003600350035003700300061006200650030003700610034003900310066006100630037006400370038000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (3, 3, N'c1baN', 0x660031006300610061003800660066003500660031003800610032006400310039006500330064006600390039006300340036006100660031003400310037000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (4, 2, N'avram666', 0x310033003900350035003200390039003700650063006500300061003700640030003400300034003500640035003900300037003900330062006400360036000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (5, 6, N'preafericitu', 0x620063003200650038006200320061006300390033006200300032003400330032006400310038003100360066003800300065003200360065003700650038000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (6, NULL, N'avramus', 0xE10ADC3949BA59ABBE56E057F20F883E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (7, NULL, N'Gagu', 0xE10ADC3949BA59ABBE56E057F20F883E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (8, 17, N'Cip', 0x81DC9BDB52D04DC20036DBD8313ED0550000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (9, 13, N'Radu', 0x202CB962AC59075B964B07152D234B700000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
INSERT [dbo].[Users] ([ID_USER], [ID_ANGAJAT], [Username], [Password]) VALUES (10, 21, N'adam', 0x81DC9BDB52D04DC20036DBD8313ED0550000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Facturi] ADD  CONSTRAINT [DF_FctCtr]  DEFAULT (NEXT VALUE FOR [ContorFacturi]) FOR [Nr]
GO
ALTER TABLE [dbo].[Achizitii]  WITH CHECK ADD  CONSTRAINT [FK__Achizitii__ID_DE__5535A963] FOREIGN KEY([ID_DEPOZIT])
REFERENCES [dbo].[Depozite] ([ID_DEPOZIT])
GO
ALTER TABLE [dbo].[Achizitii] CHECK CONSTRAINT [FK__Achizitii__ID_DE__5535A963]
GO
ALTER TABLE [dbo].[Achizitii]  WITH CHECK ADD  CONSTRAINT [FK__Achizitii__ID_FU__534D60F1] FOREIGN KEY([ID_FURNIZOR])
REFERENCES [dbo].[Furnizori] ([ID_FURNIZOR])
GO
ALTER TABLE [dbo].[Achizitii] CHECK CONSTRAINT [FK__Achizitii__ID_FU__534D60F1]
GO
ALTER TABLE [dbo].[Achizitii]  WITH CHECK ADD  CONSTRAINT [FK__Cumparari__ID_FA__412EB0B6] FOREIGN KEY([ID_FACTURA])
REFERENCES [dbo].[Facturi] ([ID_FACTURA])
GO
ALTER TABLE [dbo].[Achizitii] CHECK CONSTRAINT [FK__Cumparari__ID_FA__412EB0B6]
GO
ALTER TABLE [dbo].[Achizitii]  WITH CHECK ADD  CONSTRAINT [FK__Cumparari__ID_PR__403A8C7D] FOREIGN KEY([ID_PRODUS])
REFERENCES [dbo].[Produse] ([ID_PRODUS])
GO
ALTER TABLE [dbo].[Achizitii] CHECK CONSTRAINT [FK__Cumparari__ID_PR__403A8C7D]
GO
ALTER TABLE [dbo].[Angajati]  WITH CHECK ADD  CONSTRAINT [FK_Angajati_Departamente] FOREIGN KEY([ID_DEPARTAMENT])
REFERENCES [dbo].[Departamente] ([ID_DEPARTAMENT])
GO
ALTER TABLE [dbo].[Angajati] CHECK CONSTRAINT [FK_Angajati_Departamente]
GO
ALTER TABLE [dbo].[Comanda Detalii]  WITH CHECK ADD  CONSTRAINT [FK_Comanda Detalii_Comenzi] FOREIGN KEY([ID_COMANDA])
REFERENCES [dbo].[Comenzi] ([ID_COMANDA])
GO
ALTER TABLE [dbo].[Comanda Detalii] CHECK CONSTRAINT [FK_Comanda Detalii_Comenzi]
GO
ALTER TABLE [dbo].[Comanda Detalii]  WITH CHECK ADD  CONSTRAINT [FK_Comanda Detalii_Produse] FOREIGN KEY([ID_PRODUS])
REFERENCES [dbo].[Produse] ([ID_PRODUS])
GO
ALTER TABLE [dbo].[Comanda Detalii] CHECK CONSTRAINT [FK_Comanda Detalii_Produse]
GO
ALTER TABLE [dbo].[Comenzi]  WITH CHECK ADD  CONSTRAINT [FK__Vanzari__ID_CLIE__3D5E1FD2] FOREIGN KEY([ID_CLIENT])
REFERENCES [dbo].[Clienti] ([ID_CLIENT])
GO
ALTER TABLE [dbo].[Comenzi] CHECK CONSTRAINT [FK__Vanzari__ID_CLIE__3D5E1FD2]
GO
ALTER TABLE [dbo].[Comenzi]  WITH CHECK ADD  CONSTRAINT [FK_Comenzi_Angajati] FOREIGN KEY([ID_ANGAJAT])
REFERENCES [dbo].[Angajati] ([ID_ANGAJAT])
GO
ALTER TABLE [dbo].[Comenzi] CHECK CONSTRAINT [FK_Comenzi_Angajati]
GO
ALTER TABLE [dbo].[Comenzi]  WITH CHECK ADD  CONSTRAINT [FK_Comenzi_Facturi] FOREIGN KEY([ID_FACTURA])
REFERENCES [dbo].[Facturi] ([ID_FACTURA])
GO
ALTER TABLE [dbo].[Comenzi] CHECK CONSTRAINT [FK_Comenzi_Facturi]
GO
ALTER TABLE [dbo].[State de plata]  WITH CHECK ADD  CONSTRAINT [FK__Plati ang__ID_AN__45F365D3] FOREIGN KEY([ID_ANGAJAT])
REFERENCES [dbo].[Angajati] ([ID_ANGAJAT])
GO
ALTER TABLE [dbo].[State de plata] CHECK CONSTRAINT [FK__Plati ang__ID_AN__45F365D3]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Angajati] FOREIGN KEY([ID_ANGAJAT])
REFERENCES [dbo].[Angajati] ([ID_ANGAJAT])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Angajati]
GO
/****** Object:  StoredProcedure [dbo].[AddOrderPart]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[AddOrderPart]
@Order_Id int,
@Product_Id int,
@Quantity int
AS
BEGIN
DECLARE @Stock int
DECLARE @UnitPrice money

--Get the stock
SELECT @Stock=Stoc
FROM Produse WHERE ID_PRODUS=@Product_Id
--Evaluate the stock
IF @Stock <@Quantity
--Not enough products in stock
BEGIN
	PRINT  N'Stoc Insuficient'
END;
ELSE
--Update the stock and add order part
BEGIN
	--Update the stock
	UPDATE Produse
	SET Stoc=Stoc-@Quantity, @UnitPrice=Produse.[Pret Unitar]
	WHERE Produse.ID_PRODUS=@Product_Id
	--Add order part
	INSERT INTO [Comanda Detalii] (ID_COMANDA, ID_PRODUS, Suma, Cantitate)
	VALUES (@Order_Id, @Product_Id, @UnitPrice*@Stock, @Quantity)
END;


END;
GO
/****** Object:  StoredProcedure [dbo].[BuyItem]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[BuyItem]

@Product_Name nvarchar(50),
@Count int,
@Invoice_Number int,
@Unit_Price money,
@Warehouse_Id int,
@Supplier_Id int

AS
BEGIN
DECLARE @Current_Stock int
DECLARE @Product_Id int
DECLARE @Invoice_Id int
DECLARE @Product_aux TABLE(ID int)

--The invoice first
INSERT INTO Facturi([Data], Nr, Tip)
VALUES (GETDATE(), @Invoice_Number, 'ITU')
SET @Invoice_Id = SCOPE_IDENTITY()
PRINT N'Factura cu nr ' + CAST(@Invoice_Id AS nvarchar(30)) + ' a fost adaugata'

--I try to Update the stock
UPDATE Produse
SET Stoc = Stoc + @Count
OUTPUT inserted.ID_PRODUS INTO @Product_aux
WHERE Denumire LIKE @Product_Name
select @Product_Id=ID from @Product_aux

--Did that fail?
IF (@Product_Id IS NULL)
--Add the product
BEGIN
	INSERT INTO Produse(Denumire, Stoc, [Pret Unitar])
	VALUES (@Product_Name, @Count, @Unit_Price*1.5)
	SET @Product_Id = SCOPE_IDENTITY()
	PRINT N'Produsul ' + @Product_Name + ' a fost adaugat'
END;
ELSE
--Stock updated
BEGIN
	PRINT N'Stocul a fost modificat'
END;

INSERT INTO Achizitii(ID_PRODUS, [Numar de bucati], ID_FACTURA, [Pret Unitar], ID_DEPOZIT, ID_FURNIZOR)
	VALUES (@Product_Id, @Count, @Invoice_Id, @Unit_Price, @Warehouse_Id, @Supplier_Id)
END;
GO
/****** Object:  StoredProcedure [dbo].[CalculateExpenses]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[CalculateExpenses]

AS
BEGIN
SELECT SUM(Bani)
FROM Cheltuieli
END;
GO
/****** Object:  StoredProcedure [dbo].[CalculateProfit]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[CalculateProfit]
@Cheltuieli money OUT,
@Castiguri money OUT
AS
BEGIN
SELECT @Cheltuieli = SUM(Bani) FROM Cheltuieli
SELECT @Castiguri = SUM([Suma]) FROM [Comanda Detalii] inner join Comenzi on [Comanda Detalii].ID_COMANDA= Comenzi.ID_COMANDA
--SELECT @Castiguri-@Cheltuieli AS 'Profit', @Castiguri AS 'Castiguri', @Cheltuieli AS 'Cheltuieli'
END;
GO
/****** Object:  StoredProcedure [dbo].[CalculateProfitOriginal]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[CalculateProfitOriginal]
AS
BEGIN
DECLARE @Cheltuieli money
DECLARE @Castiguri money
SELECT @Cheltuieli = SUM(Bani) FROM Cheltuieli
SELECT @Castiguri = SUM([Suma]) FROM [Comanda Detalii] inner join Comenzi on [Comanda Detalii].ID_COMANDA= Comenzi.ID_COMANDA
SELECT @Castiguri-@Cheltuieli AS 'Profit', @Castiguri AS 'Castiguri', @Cheltuieli AS 'Cheltuieli'
END;
GO
/****** Object:  StoredProcedure [dbo].[IssueInvoice]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[IssueInvoice]
@Invoice_Id int OUT
AS
INSERT INTO Facturi(Data,Observatii, Tip)
VALUES(GETDATE(), 'Automat', 'IBU')
SET @Invoice_Id=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[MakeOrder]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[MakeOrder]
@Employee_Id int,
@Estimated_Date datetime,
@Client_Id int,
@Order_Id int OUT
AS
BEGIN
DECLARE @Invoice_Id int
--The invoice first
INSERT INTO Facturi([Data], Tip)
VALUES (GETDATE(), 'IBU')
SET @Invoice_Id = SCOPE_IDENTITY()
INSERT INTO Comenzi([Data initiere], ID_ANGAJAT, [Data estimata livrare], [Status], ID_CLIENT, ID_FACTURA)
VALUES(GETDATE(), @Employee_Id, @Estimated_Date, 'In Asteptare', @Client_Id, @Invoice_Id)
SET @Order_Id = SCOPE_IDENTITY()
END;
GO
/****** Object:  Trigger [dbo].[AchizitiiFixStock]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[AchizitiiFixStock]
ON [dbo].[Achizitii]
AFTER INSERT 

AS
BEGIN
	UPDATE Produse
	SET Stoc = Stoc + [Numar de bucati]
	FROM inserted
	INNER JOIN Produse ON Produse.ID_PRODUS = inserted.ID_PRODUS
END;
GO
ALTER TABLE [dbo].[Achizitii] ENABLE TRIGGER [AchizitiiFixStock]
GO
/****** Object:  Trigger [dbo].[AchizitiiFixStockUpdate]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[AchizitiiFixStockUpdate]
ON [dbo].[Achizitii]
AFTER UPDATE 

AS
BEGIN
	UPDATE Produse
	SET Stoc = Stoc - deleted.[Numar de bucati]
	FROM deleted
	INNER JOIN Produse ON Produse.ID_PRODUS = deleted.ID_PRODUS
	UPDATE Produse
	SET Stoc = Stoc + inserted.[Numar de bucati]
	FROM inserted
	INNER JOIN Produse ON Produse.ID_PRODUS = inserted.ID_PRODUS
END;
GO
ALTER TABLE [dbo].[Achizitii] ENABLE TRIGGER [AchizitiiFixStockUpdate]
GO
/****** Object:  Trigger [dbo].[AngajatiOnFire]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[AngajatiOnFire]
ON [dbo].[Angajati]
AFTER UPDATE

AS 

BEGIN

	IF UPDATE(Activ)
	BEGIN
		delete from Users
		WHERE ID_USER in (
			SELECT ID_USER
			FROM Users 
			inner join inserted on inserted.ID_ANGAJAT = Users.ID_ANGAJAT
			inner join deleted on deleted.ID_ANGAJAT = Users.ID_ANGAJAT
			WHERE deleted.Activ=1 AND inserted.Activ=0
		)
	END;
END;
GO
ALTER TABLE [dbo].[Angajati] ENABLE TRIGGER [AngajatiOnFire]
GO
/****** Object:  Trigger [dbo].[OrderDetailInsert]    Script Date: 1/15/2018 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[OrderDetailInsert]
ON [dbo].[Comanda Detalii]
INSTEAD OF INSERT
AS

BEGIN
SET NOCOUNT ON
	PRINT N'Enough?'
	DECLARE @Status TABLE
	(
	PID int,
	Enough int,
	Substract int
	)
	DECLARE @Inserted TABLE
	(
	ID_COMANDA int,
	ID_PRODUS int,
	Suma money,
	Cantitate int
	)
	DECLARE @AllGood int
	--Copy Inserted
	INSERT INTO @Inserted(ID_COMANDA, ID_PRODUS, Suma, Cantitate)
	SELECT ID_COMANDA, ID_PRODUS, Suma, Cantitate FROM inserted
	--Calculate Requirements
	INSERT INTO @Status(PID, Enough, Substract)
		SELECT inserted.ID_PRODUS, case when  SUM([inserted].Cantitate)<=Produse.Stoc then 1 else 0 end AS Enough, SUM([inserted].Cantitate)
		FROM inserted
		INNER JOIN Produse ON Produse.ID_PRODUS = inserted.ID_PRODUS
		GROUP BY inserted.ID_PRODUS, Produse.Stoc
	--Determine If there is enough
	SELECT @AllGood = MIN(Enough)
	FROM @Status

	--Not enough products?
	IF(@AllGood = 0)
	--Abort
	BEGIN
		PRINT N'Stoc insuficient'
	END;
	ELSE
	--Commit
	BEGIN
		--Perform the Insert
		INSERT INTO [Comanda Detalii](ID_COMANDA, ID_PRODUS, Suma, Cantitate)
		SELECT ID_COMANDA, Produse.ID_PRODUS, Cantitate* [Pret Unitar],Cantitate
		FROM @Inserted AS Inserate INNER JOIN Produse ON Produse.ID_PRODUS=Inserate.ID_PRODUS
		PRINT N'Order Accepted'
		--Update Stocks
		UPDATE Produse
		SET Stoc=Stoc - STAT.Substract
		FROM Produse
		INNER JOIN @Status AS STAT  ON STAT.PID=Produse.ID_PRODUS
	END;

END;
GO
ALTER TABLE [dbo].[Comanda Detalii] DISABLE TRIGGER [OrderDetailInsert]
GO
/****** Object:  Trigger [dbo].[OrderDetailUpsert]    Script Date: 1/15/2018 1:40:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[OrderDetailUpsert]
ON [dbo].[Comanda Detalii]
INSTEAD OF UPDATE
AS

BEGIN
	PRINT N'Updating Stocks'
	DECLARE @Status TABLE
	(
	PID int,
	Enough int,
	Substract int
	)
	DECLARE @InitialStatus TABLE
	(
	PID int,
	CurrentAmount int
	)
	DECLARE @Inserted TABLE
	(
	ID int,
	ID_COMANDA int,
	ID_PRODUS int,
	Suma money,
	Cantitate int
	)
	DECLARE @Deleted TABLE
	(
	ID int,
	ID_COMANDA int,
	ID_PRODUS int,
	Suma money,
	Cantitate int
	)
	DECLARE @AllGood int
	--Copy Inserted
	INSERT INTO @Inserted(ID, ID_COMANDA, ID_PRODUS, Suma, Cantitate)
	SELECT ID_COMANDA_DETALII, ID_COMANDA, ID_PRODUS, Suma, Cantitate FROM inserted
	--Copy Deleted
	INSERT INTO @Deleted(ID, ID_COMANDA, ID_PRODUS, Suma, Cantitate)
	SELECT ID_COMANDA_DETALII, ID_COMANDA, ID_PRODUS, Suma, Cantitate FROM deleted
	--Calculate Requirements
	INSERT INTO @Status(PID, Enough, Substract)
		SELECT inserted.ID_PRODUS, case when  SUM([inserted].Cantitate)<=Produse.Stoc then 1 else 0 end AS Enough, SUM([inserted].Cantitate)
		FROM inserted
		INNER JOIN Produse ON Produse.ID_PRODUS = inserted.ID_PRODUS
		GROUP BY inserted.ID_PRODUS, Produse.Stoc
	--Calculate Initial
	INSERT INTO @InitialStatus(PID, CurrentAmount)
	SELECT deleted.ID_PRODUS, SUM([deleted].Cantitate)
		FROM deleted
		INNER JOIN Produse ON Produse.ID_PRODUS = deleted.ID_PRODUS
		GROUP BY deleted.ID_PRODUS, Produse.Stoc
	--Determine If there is enough
	SELECT @AllGood = MIN(Enough)
	FROM @Status

	--Not enough products?
	IF(@AllGood = 0)
	--Abort
	BEGIN
		PRINT N'Stoc insuficient'
	END;
	ELSE
	--Commit
	BEGIN
		--Perform the Update
		UPDATE [Comanda Detalii]
		SET Cantitate=Inserate.Cantitate, Suma = Inserate.Cantitate*[Pret Unitar], ID_PRODUS = Inserate.ID_PRODUS
		FROM [Comanda Detalii]
		INNER JOIN @Deleted AS Inserate on Inserate.ID=[Comanda Detalii].ID_COMANDA_DETALII
		INNER JOIN Produse on Inserate.ID_PRODUS = Produse.ID_PRODUS

		UPDATE [Comanda Detalii]
		SET Cantitate=Inserate.Cantitate, Suma = Inserate.Cantitate*[Pret Unitar], ID_PRODUS = Inserate.ID_PRODUS
		FROM [Comanda Detalii]
		INNER JOIN @Inserted AS Inserate on Inserate.ID=[Comanda Detalii].ID_COMANDA_DETALII
		INNER JOIN Produse on Inserate.ID_PRODUS = Produse.ID_PRODUS
		PRINT N'Order Updated'
		--Update Stocks
		UPDATE Produse
		SET Stoc=Stoc - STAT.Substract
		FROM Produse
		INNER JOIN @Status AS STAT  ON STAT.PID=Produse.ID_PRODUS
		UPDATE Produse
		SET Stoc=Stoc + STATINIT.CurrentAmount
		FROM Produse
		INNER JOIN @InitialStatus AS STATINIT ON STATINIT.PID = Produse.ID_PRODUS
	END;

END;
GO
ALTER TABLE [dbo].[Comanda Detalii] ENABLE TRIGGER [OrderDetailUpsert]
GO
/****** Object:  Trigger [dbo].[RefreshStock]    Script Date: 1/15/2018 1:40:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TRIGGER on update Comenzi:
--on status = Livrat,
--Stoc-=quantity


CREATE   TRIGGER [dbo].[RefreshStock]
ON [dbo].[Comenzi]
AFTER UPDATE
AS

BEGIN
IF UPDATE(Status)
BEGIN
PRINT(N'Garit')
UPDATE Produse
SET Produse.Stoc=Produse.Stoc-[Comanda Detalii].Cantitate
FROM Produse INNER JOIN [Comanda Detalii] 
on Produse.ID_PRODUS = [Comanda Detalii].ID_PRODUS
INNER JOIN Comenzi on [Comanda Detalii].ID_COMANDA=Comenzi.ID_COMANDA
WHERE Comenzi.ID_COMANDA in (SELECT inserted.ID_COMANDA FROM inserted INNER JOIN deleted on inserted.ID_COMANDA=deleted.ID_COMANDA WHERE inserted.Status='Livrata' AND deleted.Status='In Asteptare')
END;
PRINT(N'Delivery Trigger Fired')
END;
GO
ALTER TABLE [dbo].[Comenzi] DISABLE TRIGGER [RefreshStock]
GO
/****** Object:  Trigger [dbo].[RefreshStockAbort]    Script Date: 1/15/2018 1:40:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TRIGGER on update Comenzi:
--on status = Livrat,
--Stoc-=quantity


CREATE   TRIGGER [dbo].[RefreshStockAbort]
ON [dbo].[Comenzi]
AFTER UPDATE
AS

BEGIN
IF UPDATE(Status)
BEGIN
UPDATE Produse
SET Produse.Stoc=Produse.Stoc+[Comanda Detalii].Cantitate
FROM Produse INNER JOIN [Comanda Detalii] 
on Produse.ID_PRODUS = [Comanda Detalii].ID_PRODUS
INNER JOIN Comenzi on [Comanda Detalii].ID_COMANDA=Comenzi.ID_COMANDA
WHERE Comenzi.ID_COMANDA in (SELECT inserted.ID_COMANDA FROM inserted INNER JOIN deleted on inserted.ID_COMANDA=deleted.ID_COMANDA WHERE inserted.Status='Anulata' AND deleted.Status='In Asteptare')
END;
PRINT(N'Delivery Trigger Fired')
END;
GO
ALTER TABLE [dbo].[Comenzi] ENABLE TRIGGER [RefreshStockAbort]
GO
/****** Object:  Trigger [dbo].[RefreshStockRetur]    Script Date: 1/15/2018 1:40:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TRIGGER on update Comenzi:
--on status = Livrat,
--Stoc-=quantity


CREATE   TRIGGER [dbo].[RefreshStockRetur]
ON [dbo].[Comenzi]
AFTER UPDATE
AS

BEGIN
IF UPDATE(Status)
BEGIN
UPDATE Produse
SET Produse.Stoc=Produse.Stoc + [Comanda Detalii].Cantitate
FROM Produse INNER JOIN [Comanda Detalii] 
on Produse.ID_PRODUS = [Comanda Detalii].ID_PRODUS
INNER JOIN Comenzi on [Comanda Detalii].ID_COMANDA=Comenzi.ID_COMANDA
WHERE Comenzi.ID_COMANDA in (SELECT inserted.ID_COMANDA FROM inserted INNER JOIN deleted on inserted.ID_COMANDA=deleted.ID_COMANDA WHERE inserted.Status='Retur' AND deleted.Status='Livrata')
END;
PRINT(N'Retur Trigger Fired')
END;
GO
ALTER TABLE [dbo].[Comenzi] ENABLE TRIGGER [RefreshStockRetur]
GO
/****** Object:  Trigger [dbo].[ProduseNoDup]    Script Date: 1/15/2018 1:40:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[ProduseNoDup]
ON [dbo].[Produse]
INSTEAD OF INSERT
AS
BEGIN

DECLARE @UpdateStoc TABLE
(
Denumire nvarchar(50),
Cantitate int
)

DECLARE @InsertStoc TABLE
(
Denumire nvarchar(50),
Cantitate int
)

DECLARE @InsertBackup TABLE
(
Denumire nvarchar(50),
Cantitate int,
Pret money
)

Insert into @InsertBackup(Denumire, Cantitate, Pret)
SELECT Denumire, inserted.Stoc, inserted.[Pret Unitar] from inserted

Insert into @UpdateStoc(Denumire, Cantitate)
SELECT Denumire, SUM(Cantitate)
FROM @InsertBackup AS inser
WHERE Denumire IN (SELECT Denumire FROM Produse)
GROUP BY Denumire

Insert into @InsertStoc(Denumire, Cantitate)
SELECT Denumire, SUM(Cantitate)
FROM @InsertBackup AS inser
WHERE Denumire NOT IN (SELECT Denumire FROM Produse)
GROUP BY Denumire

UPDATE Produse
SET Stoc = Stoc + Cantitate
FROM Produse INNER JOIN @UpdateStoc as UPSTC on UPSTC.Denumire=Produse.Denumire

INSERT INTO Produse([Pret Unitar], Stoc, Denumire)
SELECT MAX(ib.Pret), SUM(ib.Cantitate), ib.Denumire
FROM @InsertBackup as ib
INNER JOIN @InsertStoc as iss on iss.Denumire = ib.Denumire
GROUP BY ib.Denumire

END;
GO
ALTER TABLE [dbo].[Produse] DISABLE TRIGGER [ProduseNoDup]
GO
/****** Object:  Trigger [dbo].[AutoReward]    Script Date: 1/15/2018 1:40:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[AutoReward]
ON [dbo].[State de plata]
AFTER INSERT
AS

BEGIN
	INSERT INTO [State de plata](ID_ANGAJAT, Suma, Data, TIP_PLATA)
	SELECT inserted.ID_ANGAJAT, Suma*0.3,Data, 'PRIMA RATING'
	FROM inserted
	INNER JOIN Angajati ON Angajati.ID_ANGAJAT = inserted.ID_ANGAJAT
	WHERE Rating>4.5 AND TIP_PLATA='SALARIU'
END;
GO
ALTER TABLE [dbo].[State de plata] ENABLE TRIGGER [AutoReward]
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
         Begin Table = "Cheltuieli"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Castiguri"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 85
               Right = 448
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
      Begin ColumnWidths = 12
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Balanta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Balanta'
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
         Begin Table = "Comanda Detalii"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 266
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Comenzi"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 250
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
      Begin ColumnWidths = 12
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Castiguri'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Castiguri'
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
         Begin Table = "Comanda Detalii"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Produse"
            Begin Extent = 
               Top = 6
               Left = 288
               Bottom = 136
               Right = 458
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
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OrderDetailsExtended'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OrderDetailsExtended'
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
         Begin Table = "Angajati"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "State de plata"
            Begin Extent = 
               Top = 6
               Left = 281
               Bottom = 136
               Right = 467
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
      Begin ColumnWidths = 12
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Salarii'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Salarii'
GO
USE [master]
GO
ALTER DATABASE [Hramul] SET  READ_WRITE 
GO
