USE [master]
GO
/****** Object:  Database [TMSystem]    Script Date: 28/05/2020 3:12:16 am ******/
CREATE DATABASE [TMSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TMSystem', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMSystem.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TMSystem_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMSystem_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TMSystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TMSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TMSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TMSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TMSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TMSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TMSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [TMSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TMSystem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TMSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TMSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TMSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TMSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TMSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TMSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TMSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TMSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TMSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TMSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TMSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TMSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TMSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TMSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TMSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TMSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TMSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TMSystem] SET  MULTI_USER 
GO
ALTER DATABASE [TMSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TMSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TMSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TMSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TMSystem]
GO
/****** Object:  StoredProcedure [dbo].[BookingAdd]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BookingAdd]

@C_id int,
@Date Date,
@Due_Date Date,
@trail_Date Date,
@Advance decimal(10, 2),
@Balance decimal(10, 2),
@Total decimal(10, 2)

AS


BEGIN
	INSERT INTO [dbo].[Booking]
           ([C_id]
           ,[Date]
           ,[Due_Date]
           ,[Trail_Date]
           ,[Advance]
           ,[Balance]
           ,[Total])
     VALUES
           (
@C_id,
@Date ,
@Due_Date ,
@trail_Date ,
@Advance ,
@Balance ,
@Total )


select IDENT_CURRENT('Booking') 
END


GO
/****** Object:  StoredProcedure [dbo].[CustomerAdd]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CustomerAdd]
@C_no int ,
@C_Name nvarchar(50),
@ContactNo nvarchar(50),
@Address nvarchar(50)

AS
BEGIN

INSERT INTO [dbo].[Customer]
           ([C_no]
           ,[C_Name]
           ,[ContactNo]
           ,[Address])
     VALUES
           (@C_no 
           ,@C_Name
           ,@ContactNo 
           ,@Address)


END


GO
/****** Object:  StoredProcedure [dbo].[CustomerDelete]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[CustomerDelete]
	@C_ID int 

AS
BEGIN
DELETE FROM [dbo].[Customer]
      WHERE C_id = @C_ID
END

GO
/****** Object:  StoredProcedure [dbo].[CustomerLOV]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CustomerLOV]

AS
BEGIN
Select C_id,C_Name from Customer
END


GO
/****** Object:  StoredProcedure [dbo].[CustomerShowAll]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerShowAll]
@C_no int 
AS
BEGIN
SELECT [C_id]
      ,[C_no]
      ,[C_Name]
      ,[ContactNo]
      ,[Address]
  FROM [dbo].[Customer]
END


GO
/****** Object:  StoredProcedure [dbo].[CustomerUpdate]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerUpdate]
@C_ID int,
@C_Name nvarchar(50),
@ContactNo nvarchar(50),
@address nvarchar(50)
AS
BEGIN
UPDATE [dbo].[Customer]
   SET [C_Name] = @C_Name
      ,[ContactNo] = @ContactNo
	  ,[Address] = @Address
 WHERE C_ID=@C_ID
END

GO
/****** Object:  StoredProcedure [dbo].[Get_Customer_NO]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Customer_NO]

AS
BEGIN
select ISNULL(MAx(C_NO)+1,1) from Customer

END


GO
/****** Object:  StoredProcedure [dbo].[LowerAdd]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LowerAdd]

@Waist int,
@Hip nvarchar(50),
@Length nvarchar(50),
@Bottom nvarchar(50),
@knee nvarchar(50),
@Thai nvarchar(50),
@FullFly nvarchar(50),

@B_id int,
@Particular nvarchar(50),
@Material nvarchar(50),
@isLace bit,
@isPiping bit,
@PicPath nvarchar(50),
@Comments nvarchar(max)
AS
BEGIN


declare @L_id int
INSERT INTO [dbo].[Lower]
           ([Waist]
           ,[Hip]
           ,[Length]
           ,[Bottom]
           ,[Knee]
           ,[Thai]
           ,[FullFly])
     VALUES
           (@Waist
           ,@Hip 
           ,@Length 
           ,@Bottom 
           ,@knee 
           ,@Thai
           ,@FullFly)

select @L_id=IDENT_CURRENT('Lower') 

INSERT INTO [dbo].[Stitching]
           ([B_id]
           ,[U_id]
           ,[L_id]
           ,[Particular]
           ,[Material]
           ,[isLace]
           ,[isPiping]
           ,[PicPath]
           ,[Comments])
     VALUES
           (@B_id
           ,0
           ,@L_id
           ,@Particular
           ,@Material
           ,@isLace
           ,@isPiping
           ,@PicPath
           ,@Comments)
END


GO
/****** Object:  StoredProcedure [dbo].[StitchingAdd]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[StitchingAdd]
@B_id int,
@U_id int,
@L_id int,
@Particular nvarchar(50),
@Material nvarchar(50),
@isLace bit,
@isPiping bit,
@PicPath nvarchar(50),
@Comments nvarchar(max)
AS
BEGIN
INSERT INTO [dbo].[Stitching]
           ([B_id]
           ,[U_id]
           ,[L_id]
           ,[Particular]
           ,[Material]
           ,[isLace]
           ,[isPiping]
           ,[PicPath]
           ,[Comments])
     VALUES
           (@B_id
           ,@L_id
           ,@L_id
           ,@Particular
           ,@Material
           ,@isLace
           ,@isPiping
           ,@PicPath
           ,@Comments)
END


GO
/****** Object:  StoredProcedure [dbo].[UpperAdd]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpperAdd]
	
	@Length nvarchar(50),
	@Shoulder nvarchar(50),
	@Sleeve nvarchar(50),
	@Chest nvarchar(50),
	@Waist nvarchar(50),
	@Hip nvarchar(50),
	@Collor nvarchar(50),


	
@B_id int,
@Particular nvarchar(50),
@Material nvarchar(50),
@isLace bit,
@isPiping bit,
@PicPath nvarchar(50),
@Comments nvarchar(max)

AS
    
BEGIN

declare @U_id int
INSERT INTO [dbo].[Upper]
           ([Length]
           ,[Shoulder]
           ,[Sleeve]
           ,[Chest]
           ,[Waist]
           ,[Hip]
           ,[Collar])
     VALUES
           (@Length,
		   @Shoulder,
		   @Sleeve,
		   @Chest,
		   @Waist,
		   @Hip,
		   @COllor)

select @U_id =IDENT_CURRENT('Upper') 

INSERT INTO [dbo].[Stitching]
           ([B_id]
           ,[U_id]
           ,[L_id]
           ,[Particular]
           ,[Material]
           ,[isLace]
           ,[isPiping]
           ,[PicPath]
           ,[Comments])
     VALUES
           (@B_id
           ,@U_id
           ,0
           ,@Particular
           ,@Material
           ,@isLace
           ,@isPiping
           ,@PicPath
           ,@Comments)
END


GO
/****** Object:  Table [dbo].[Admin]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[UserName] [nvarchar](50) NULL,
	[Password] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Booking]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[B_id] [int] IDENTITY(1,1) NOT NULL,
	[C_id] [int] NOT NULL,
	[Date] [date] NULL,
	[Due_Date] [date] NULL,
	[Trail_Date] [date] NULL,
	[Advance] [decimal](10, 2) NULL,
	[Balance] [decimal](10, 2) NULL,
	[Total] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[B_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[C_id] [int] IDENTITY(1,1) NOT NULL,
	[C_no] [int] NULL,
	[C_Name] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[C_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lower]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lower](
	[L_id] [int] IDENTITY(1,1) NOT NULL,
	[Waist] [nvarchar](50) NULL,
	[Hip] [nvarchar](50) NULL,
	[Length] [nvarchar](50) NULL,
	[Bottom] [nvarchar](50) NULL,
	[Knee] [nvarchar](50) NULL,
	[Thai] [nvarchar](50) NULL,
	[FullFly] [nvarchar](50) NULL,
 CONSTRAINT [PK_Upper] PRIMARY KEY CLUSTERED 
(
	[L_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stitching]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stitching](
	[S_id] [int] IDENTITY(1,1) NOT NULL,
	[B_id] [int] NOT NULL,
	[U_id] [int] NULL,
	[L_id] [int] NULL,
	[Particular] [nvarchar](50) NULL,
	[Material] [nvarchar](50) NULL,
	[isLace] [bit] NULL,
	[isPiping] [bit] NULL,
	[PicPath] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_Stitching] PRIMARY KEY CLUSTERED 
(
	[S_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Upper]    Script Date: 28/05/2020 3:12:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Upper](
	[U_id] [int] IDENTITY(1,1) NOT NULL,
	[Length] [nvarchar](50) NULL,
	[Shoulder] [nvarchar](50) NULL,
	[Sleeve] [nvarchar](50) NULL,
	[Chest] [nvarchar](50) NULL,
	[Waist] [nvarchar](50) NULL,
	[Hip] [nvarchar](50) NULL,
	[Collar] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lower] PRIMARY KEY CLUSTERED 
(
	[U_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Customer] FOREIGN KEY([C_id])
REFERENCES [dbo].[Customer] ([C_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Customer]
GO
ALTER TABLE [dbo].[Stitching]  WITH CHECK ADD  CONSTRAINT [FK_Stitching_Booking] FOREIGN KEY([B_id])
REFERENCES [dbo].[Booking] ([B_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Stitching] CHECK CONSTRAINT [FK_Stitching_Booking]
GO
USE [master]
GO
ALTER DATABASE [TMSystem] SET  READ_WRITE 
GO
