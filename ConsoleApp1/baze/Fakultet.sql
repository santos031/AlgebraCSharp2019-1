USE [master]
GO
/****** Object:  Database [Fakultet]    Script Date: 21.3.2019. 10:00:35 ******/
CREATE DATABASE [Fakultet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Fakultet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Fakultet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Fakultet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Fakultet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Fakultet] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Fakultet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Fakultet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Fakultet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Fakultet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Fakultet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Fakultet] SET ARITHABORT OFF 
GO
ALTER DATABASE [Fakultet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Fakultet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Fakultet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Fakultet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Fakultet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Fakultet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Fakultet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Fakultet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Fakultet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Fakultet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Fakultet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Fakultet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Fakultet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Fakultet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Fakultet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Fakultet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Fakultet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Fakultet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Fakultet] SET  MULTI_USER 
GO
ALTER DATABASE [Fakultet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Fakultet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Fakultet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Fakultet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Fakultet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Fakultet] SET QUERY_STORE = OFF
GO
USE [Fakultet]
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
USE [Fakultet]
GO
/****** Object:  Table [dbo].[dvorana]    Script Date: 21.3.2019. 10:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dvorana](
	[oznDvorana] [nvarchar](5) NOT NULL,
	[kapacitet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ispit]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ispit](
	[mbrStud] [int] NOT NULL,
	[sifPred] [int] NOT NULL,
	[sifNastavnik] [int] NOT NULL,
	[datIspit] [datetime] NOT NULL,
	[ocjena] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mjesto]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mjesto](
	[pbr] [int] NOT NULL,
	[nazMjesto] [nvarchar](40) NOT NULL,
	[sifZupanija] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nastavnik]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nastavnik](
	[sifNastavnik] [int] NOT NULL,
	[imeNastavnik] [nvarchar](25) NOT NULL,
	[prezNastavnik] [nvarchar](25) NOT NULL,
	[pbrStan] [int] NOT NULL,
	[sifOrgjed] [int] NOT NULL,
	[koef] [decimal](3, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orgjed]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orgjed](
	[sifOrgjed] [int] NOT NULL,
	[nazOrgjed] [nvarchar](60) NOT NULL,
	[sifNadorgjed] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pred]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pred](
	[sifPred] [int] NOT NULL,
	[kratPred] [nvarchar](8) NULL,
	[nazPred] [nvarchar](60) NOT NULL,
	[sifOrgjed] [int] NULL,
	[upisanoStud] [int] NULL,
	[brojSatiTjedno] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rezervacija]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rezervacija](
	[oznDvorana] [nvarchar](5) NOT NULL,
	[oznVrstaDan] [nvarchar](2) NOT NULL,
	[sat] [smallint] NOT NULL,
	[sifPred] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stud]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stud](
	[mbrStud] [int] NOT NULL,
	[imeStud] [nvarchar](25) NOT NULL,
	[prezStud] [nvarchar](25) NOT NULL,
	[pbrRod] [int] NULL,
	[pbrStan] [int] NOT NULL,
	[datRodStud] [datetime] NULL,
	[jmbgStud] [nvarchar](13) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zupanija]    Script Date: 21.3.2019. 10:00:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zupanija](
	[sifZupanija] [smallint] NOT NULL,
	[nazZupanija] [nvarchar](40) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Fakultet] SET  READ_WRITE 
GO
