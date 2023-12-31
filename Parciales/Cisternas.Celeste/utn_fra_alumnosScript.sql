USE [master]
GO
/****** Object:  Database [utn_fra_alumnos]    Script Date: 1/12/2021 11:08:28 ******/
CREATE DATABASE [utn_fra_alumnos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'utn_fra_alumnos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\utn_fra_alumnos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'utn_fra_alumnos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\utn_fra_alumnos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [utn_fra_alumnos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [utn_fra_alumnos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ARITHABORT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [utn_fra_alumnos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [utn_fra_alumnos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [utn_fra_alumnos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [utn_fra_alumnos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET RECOVERY FULL 
GO
ALTER DATABASE [utn_fra_alumnos] SET  MULTI_USER 
GO
ALTER DATABASE [utn_fra_alumnos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [utn_fra_alumnos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [utn_fra_alumnos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [utn_fra_alumnos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [utn_fra_alumnos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [utn_fra_alumnos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'utn_fra_alumnos', N'ON'
GO
ALTER DATABASE [utn_fra_alumnos] SET QUERY_STORE = OFF
GO
USE [utn_fra_alumnos]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 1/12/2021 11:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[dni] [int] NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[nota] [float] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (123, N'test', N'a', 3)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (2, N'cisternas', N'celeste', 2)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (111, N'aaa', N'aaa', 10)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (1212, N'don', N'corleone', 6)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (12345, N'pepito', N'peposo', 4)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (1010, N'hoho', N'hoho', 5)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (1111, N'aloha', N'aaaa', 1)
INSERT [dbo].[alumnos] ([dni], [apellido], [nombre], [nota]) VALUES (13, N'utn', N'utn', 10)
GO
USE [master]
GO
ALTER DATABASE [utn_fra_alumnos] SET  READ_WRITE 
GO
