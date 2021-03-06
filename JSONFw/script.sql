USE [jinsasan2]
GO
/****** Object:  StoredProcedure [dbo].[SearchTemple]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SearchTemple](
	@IdolId int = -1,
    @CityId int= -1,
    @TrustId int= -1,
    @HasDshala bit= 0,
    @HasBshala bit= 0
) as
select 
tt.Id, 
tt.Title,
cm.City,
im.Title as Moolnayak ,
(select COUNT(Id) from Bhojanshala) as HasBhojanshala,
(select COUNT(Id) from Dharmshala) as HasDharmshala
--                    BhojanshalaCount 
--                    DharmshalaCount 
 from TempleTable tt
 left join TempleIdolMapping ti on tt.Id = ti.TempleId
 left join IdolMaster im on ti.IdolId = im.Id
 left join vwCities cm on tt.CityId = cm.Id
 where 
	(IdolId = @IdolId or @IdolId = -1) and
	(CityId = @CityId or @CityId = -1) and
	(TrustId = @TrustId or @TrustId = -1) and
	((select COUNT(Id) from Bhojanshala) > 0 or @HasDshala = 0) and
	((select COUNT(Id) from Dharmshala) > 0 or @HasBshala = 0)
GO
/****** Object:  Table [dbo].[Apasara]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apasara](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
	[ContactNumbers] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[TrustId] [int] NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_Apasara] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bhojanshala]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bhojanshala](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
	[ContactNumbers] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[TrustId] [int] NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_Bhojanshala] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CityMaster]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Latitude] [nvarchar](20) NULL,
	[Longitude] [nvarchar](20) NULL,
	[StateId] [int] NULL,
 CONSTRAINT [PK_CityMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CountryMaster]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_CountryMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Descriptions]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DescriptionContent] [nvarchar](max) NULL,
	[UserDisplayName] [nvarchar](50) NULL,
	[SubmittedOn] [datetime] NULL,
	[TempleId] [int] NULL,
 CONSTRAINT [PK_Descriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dharmshala]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dharmshala](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
	[ContactNumbers] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[TrustId] [int] NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_Dharmshala] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EntryRequests]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntryRequests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestTime] [datetime] NULL,
	[RequestBy] [nvarchar](255) NULL,
	[RequestType] [nvarchar](50) NULL,
	[Text1] [nvarchar](max) NULL,
	[Text2] [nvarchar](max) NULL,
	[Text3] [nvarchar](max) NULL,
	[Text4] [nvarchar](max) NULL,
	[Text5] [nvarchar](max) NULL,
	[Status] [nvarchar](10) NULL,
	[Key1] [nvarchar](50) NULL,
	[Key2] [nvarchar](50) NULL,
 CONSTRAINT [PK_EntryRequests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IdolMaster]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdolMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[IdolTypeId] [int] NULL,
 CONSTRAINT [PK_IdolMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IdolType]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdolType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](10) NULL,
 CONSTRAINT [PK_IdolType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Images]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageType] [int] NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Tag] [nvarchar](50) NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StateMaster]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[CountryId] [int] NULL,
 CONSTRAINT [PK_StateMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TempleIdolMapping]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleIdolMapping](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TempleId] [int] NULL,
	[IdolId] [int] NULL,
 CONSTRAINT [PK_TempleIdolMapping] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TempleTable]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[ContactNumber] [nchar](10) NULL,
	[ContactDetails] [nchar](10) NULL,
	[TrustId] [int] NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_TempleTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrustMaster]    Script Date: 12-07-2021 01:16:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrustMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrustMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Apasara]  WITH CHECK ADD  CONSTRAINT [FK_Apasara_CityMaster] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityMaster] ([Id])
GO
ALTER TABLE [dbo].[Apasara] CHECK CONSTRAINT [FK_Apasara_CityMaster]
GO
ALTER TABLE [dbo].[Bhojanshala]  WITH CHECK ADD  CONSTRAINT [FK_Bhojanshala_CityMaster] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityMaster] ([Id])
GO
ALTER TABLE [dbo].[Bhojanshala] CHECK CONSTRAINT [FK_Bhojanshala_CityMaster]
GO
ALTER TABLE [dbo].[CityMaster]  WITH CHECK ADD  CONSTRAINT [FK_CityMaster_StateMaster] FOREIGN KEY([StateId])
REFERENCES [dbo].[StateMaster] ([Id])
GO
ALTER TABLE [dbo].[CityMaster] CHECK CONSTRAINT [FK_CityMaster_StateMaster]
GO
ALTER TABLE [dbo].[Descriptions]  WITH CHECK ADD  CONSTRAINT [FK_Descriptions_TempleTable] FOREIGN KEY([TempleId])
REFERENCES [dbo].[TempleTable] ([Id])
GO
ALTER TABLE [dbo].[Descriptions] CHECK CONSTRAINT [FK_Descriptions_TempleTable]
GO
ALTER TABLE [dbo].[Dharmshala]  WITH CHECK ADD  CONSTRAINT [FK_Dharmshala_CityMaster] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityMaster] ([Id])
GO
ALTER TABLE [dbo].[Dharmshala] CHECK CONSTRAINT [FK_Dharmshala_CityMaster]
GO
ALTER TABLE [dbo].[IdolMaster]  WITH CHECK ADD  CONSTRAINT [FK_IdolMaster_IdolType] FOREIGN KEY([IdolTypeId])
REFERENCES [dbo].[IdolType] ([Id])
GO
ALTER TABLE [dbo].[IdolMaster] CHECK CONSTRAINT [FK_IdolMaster_IdolType]
GO
ALTER TABLE [dbo].[StateMaster]  WITH CHECK ADD  CONSTRAINT [FK_StateMaster_CountryMaster] FOREIGN KEY([CountryId])
REFERENCES [dbo].[CountryMaster] ([Id])
GO
ALTER TABLE [dbo].[StateMaster] CHECK CONSTRAINT [FK_StateMaster_CountryMaster]
GO
ALTER TABLE [dbo].[TempleIdolMapping]  WITH CHECK ADD  CONSTRAINT [FK_TempleIdolMapping_IdolMaster] FOREIGN KEY([IdolId])
REFERENCES [dbo].[IdolMaster] ([Id])
GO
ALTER TABLE [dbo].[TempleIdolMapping] CHECK CONSTRAINT [FK_TempleIdolMapping_IdolMaster]
GO
ALTER TABLE [dbo].[TempleIdolMapping]  WITH CHECK ADD  CONSTRAINT [FK_TempleIdolMapping_TempleTable] FOREIGN KEY([TempleId])
REFERENCES [dbo].[TempleTable] ([Id])
GO
ALTER TABLE [dbo].[TempleIdolMapping] CHECK CONSTRAINT [FK_TempleIdolMapping_TempleTable]
GO
ALTER TABLE [dbo].[TempleTable]  WITH CHECK ADD  CONSTRAINT [FK_TempleTable_CityMaster] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityMaster] ([Id])
GO
ALTER TABLE [dbo].[TempleTable] CHECK CONSTRAINT [FK_TempleTable_CityMaster]
GO
ALTER TABLE [dbo].[TempleTable]  WITH CHECK ADD  CONSTRAINT [FK_TempleTable_TrustMaster] FOREIGN KEY([TrustId])
REFERENCES [dbo].[TrustMaster] ([Id])
GO
ALTER TABLE [dbo].[TempleTable] CHECK CONSTRAINT [FK_TempleTable_TrustMaster]
GO
