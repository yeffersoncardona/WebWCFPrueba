USE [master]
GO
/****** Object:  Database [PruebaWCFDB]    Script Date: 29/09/2023 10:41:09 ******/
CREATE DATABASE [PruebaWCFDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PruebaWCFDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PruebaWCFDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PruebaWCFDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PruebaWCFDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PruebaWCFDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PruebaWCFDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PruebaWCFDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PruebaWCFDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PruebaWCFDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PruebaWCFDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PruebaWCFDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET RECOVERY FULL 
GO
ALTER DATABASE [PruebaWCFDB] SET  MULTI_USER 
GO
ALTER DATABASE [PruebaWCFDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PruebaWCFDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PruebaWCFDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PruebaWCFDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PruebaWCFDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PruebaWCFDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PruebaWCFDB', N'ON'
GO
ALTER DATABASE [PruebaWCFDB] SET QUERY_STORE = OFF
GO
USE [PruebaWCFDB]
GO
/****** Object:  Table [dbo].[TblUsuarios]    Script Date: 29/09/2023 10:41:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUsuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[fechaNacimiento] [date] NULL,
	[Sexo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblUsuarios] ON 

INSERT [dbo].[TblUsuarios] ([id], [Nombre], [fechaNacimiento], [Sexo]) VALUES (1, N'yeffer', CAST(N'2023-09-28' AS Date), N'M')
SET IDENTITY_INSERT [dbo].[TblUsuarios] OFF
GO
/****** Object:  StoredProcedure [dbo].[spDeleteUsuario]    Script Date: 29/09/2023 10:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeleteUsuario]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[TblUsuarios]
      WHERE id = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertUsuario]    Script Date: 29/09/2023 10:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertUsuario] 
	-- Add the parameters for the stored procedure here
	@Nombre varchar(100),
	@FechaNacimiento date,
	@Sexo char
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[TblUsuarios]
           ([Nombre]
           ,[fechaNacimiento]
           ,[Sexo])
     VALUES
           (@Nombre
           ,@FechaNacimiento
           ,@Sexo)
END
GO
/****** Object:  StoredProcedure [dbo].[spSelectListadoUsuarios]    Script Date: 29/09/2023 10:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSelectListadoUsuarios] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  [id]
      ,[Nombre]
      ,[fechaNacimiento]
      ,[Sexo]
  FROM [PruebaWCFDB].[dbo].[TblUsuarios]
END
GO
/****** Object:  StoredProcedure [dbo].[spSelectUsuario]    Script Date: 29/09/2023 10:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSelectUsuario]

@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  [id]
      ,[Nombre]
      ,[fechaNacimiento]
      ,[Sexo]
  FROM [PruebaWCFDB].[dbo].[TblUsuarios]
  WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUsuario]    Script Date: 29/09/2023 10:41:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateUsuario]
	-- Add the parameters for the stored procedure here
	@ID INT,
	@Nombre varchar(100),
	@FechaNacimiento date,
	@Sexo char
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE U SET u.fechaNacimiento=@FechaNacimiento,u.Sexo=@Sexo, u.Nombre=@Nombre
	FROM TblUsuarios U WHERE U.id=@ID
END
GO
USE [master]
GO
ALTER DATABASE [PruebaWCFDB] SET  READ_WRITE 
GO
