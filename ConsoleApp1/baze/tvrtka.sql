USE [tvrtka]
GO
/****** Object:  Table [dbo].[odjeli]    Script Date: 20.3.2019. 0:03:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odjeli](
	[id] [int] NOT NULL,
	[odjel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_odjeli] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proizvodi]    Script Date: 20.3.2019. 0:03:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proizvodi](
	[id] [int] NOT NULL,
	[naziv] [varchar](50) NULL,
	[mjesto_skladista] [int] NULL,
 CONSTRAINT [PK_proizvodi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[radnici]    Script Date: 20.3.2019. 0:03:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[radnici](
	[id] [int] NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[voditelj] [bit] NULL,
	[odjel] [int] NULL,
	[mjesto_skladista] [int] NOT NULL,
 CONSTRAINT [PK_radnici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[skladiste]    Script Date: 20.3.2019. 0:03:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[skladiste](
	[id] [int] NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_skladiste] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[proizvodi]  WITH CHECK ADD  CONSTRAINT [FK_proizvodi_skladiste1] FOREIGN KEY([mjesto_skladista])
REFERENCES [dbo].[skladiste] ([id])
GO
ALTER TABLE [dbo].[proizvodi] CHECK CONSTRAINT [FK_proizvodi_skladiste1]
GO
ALTER TABLE [dbo].[radnici]  WITH CHECK ADD  CONSTRAINT [FK_radnici_odjeli] FOREIGN KEY([odjel])
REFERENCES [dbo].[odjeli] ([id])
GO
ALTER TABLE [dbo].[radnici] CHECK CONSTRAINT [FK_radnici_odjeli]
GO
ALTER TABLE [dbo].[radnici]  WITH CHECK ADD  CONSTRAINT [FK_radnici_skladiste1] FOREIGN KEY([mjesto_skladista])
REFERENCES [dbo].[skladiste] ([id])
GO
ALTER TABLE [dbo].[radnici] CHECK CONSTRAINT [FK_radnici_skladiste1]
GO
