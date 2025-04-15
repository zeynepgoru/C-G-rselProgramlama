USE [Kisiler]
GO

/****** Object:  Table [dbo].[Bilgi]    Script Date: 16.04.2025 00:09:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bilgi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[dogum_gun] [int] NULL,
	[dogum_ay] [int] NULL,
	[dogum_yil] [int] NULL,
	[kilo] [float] NULL,
	[boy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bilgi]  WITH CHECK ADD CHECK  (([boy]>=(0) AND [boy]<=(250)))
GO

ALTER TABLE [dbo].[Bilgi]  WITH CHECK ADD CHECK  (([dogum_ay]>=(1) AND [dogum_ay]<=(12)))
GO

ALTER TABLE [dbo].[Bilgi]  WITH CHECK ADD CHECK  (([dogum_gun]>=(1) AND [dogum_gun]<=(31)))
GO

ALTER TABLE [dbo].[Bilgi]  WITH CHECK ADD CHECK  (([dogum_yil]>=(1900) AND [dogum_yil]<=(2100)))
GO

