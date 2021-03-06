USE [master]
GO
/****** Object:  Database [BD_adopt]    Script Date: 26/11/2016 0:09:43 ******/
CREATE DATABASE [BD_adopt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_adopt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BD_adopt.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_adopt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BD_adopt_log.ldf' , SIZE = 7616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BD_adopt] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_adopt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_adopt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_adopt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_adopt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_adopt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_adopt] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_adopt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_adopt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_adopt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_adopt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_adopt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_adopt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_adopt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_adopt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_adopt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_adopt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_adopt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_adopt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_adopt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_adopt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_adopt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_adopt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_adopt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_adopt] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_adopt] SET  MULTI_USER 
GO
ALTER DATABASE [BD_adopt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_adopt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_adopt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_adopt] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BD_adopt] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BD_adopt]
GO
/****** Object:  User [usuario]    Script Date: 26/11/2016 0:09:43 ******/
CREATE USER [usuario] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[animales]    Script Date: 26/11/2016 0:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[animales](
	[id_animales] [int] IDENTITY(1,1) NOT NULL,
	[raza] [varchar](10) NULL,
	[edad] [int] NULL,
	[informacion] [varchar](max) NULL,
	[estado] [int] NULL,
	[id_cliente] [int] NULL,
	[nombre] [varchar](50) NULL,
	[ubicacion] [varchar](50) NULL,
	[tipo] [int] NULL,
	[img] [varchar](max) NULL,
 CONSTRAINT [PK_animales] PRIMARY KEY CLUSTERED 
(
	[id_animales] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[donacion]    Script Date: 26/11/2016 0:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[donacion](
	[id_donacion] [int] IDENTITY(1,1) NOT NULL,
	[donante] [varchar](20) NULL,
	[donacion] [varchar](50) NULL,
 CONSTRAINT [PK_donacion] PRIMARY KEY CLUSTERED 
(
	[id_donacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estaditica]    Script Date: 26/11/2016 0:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estaditica](
	[id_estaditica] [int] IDENTITY(1,1) NOT NULL,
	[id_animales] [int] NULL,
	[id_publicaciones] [int] NULL,
	[id_donacion] [int] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_estaditica] PRIMARY KEY CLUSTERED 
(
	[id_estaditica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[login]    Script Date: 26/11/2016 0:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[genero] [varchar](50) NULL,
	[fecha] [varchar](100) NULL,
	[img] [varchar](max) NULL,
	[tipo] [int] NULL CONSTRAINT [DF_login_tipo]  DEFAULT ((0)),
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[animales]  WITH CHECK ADD  CONSTRAINT [FK_animales_login] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[login] ([id_usuario])
GO
ALTER TABLE [dbo].[animales] CHECK CONSTRAINT [FK_animales_login]
GO
ALTER TABLE [dbo].[estaditica]  WITH CHECK ADD  CONSTRAINT [FK_estaditica_animales] FOREIGN KEY([id_animales])
REFERENCES [dbo].[animales] ([id_animales])
GO
ALTER TABLE [dbo].[estaditica] CHECK CONSTRAINT [FK_estaditica_animales]
GO
ALTER TABLE [dbo].[estaditica]  WITH CHECK ADD  CONSTRAINT [FK_estaditica_donacion] FOREIGN KEY([id_donacion])
REFERENCES [dbo].[donacion] ([id_donacion])
GO
ALTER TABLE [dbo].[estaditica] CHECK CONSTRAINT [FK_estaditica_donacion]
GO
USE [master]
GO
ALTER DATABASE [BD_adopt] SET  READ_WRITE 
GO
