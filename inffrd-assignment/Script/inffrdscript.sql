USE [Infrrd]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020-07-31 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 2020-07-31 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[Year] [datetime] NULL,
	[Amount] [numeric](18, 0) NULL,
	[IsDeleted] [bit] NULL,
	[IsValid] [bit] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name]) VALUES (1, N'Finance')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (2, N'Manufacturing')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (3, N'Transportation')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (4, N'HR')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (5, N'Other')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Expenses] ON 

INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (1, 1, CAST(N'2015-01-01T00:00:00.000' AS DateTime), CAST(500 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (2, 1, CAST(N'2015-01-01T00:00:00.000' AS DateTime), CAST(500 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (3, 1, CAST(N'2016-01-01T00:00:00.000' AS DateTime), CAST(500 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (4, 1, CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(1500 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (5, 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(1000 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (6, 1, CAST(N'2020-01-01T00:00:00.000' AS DateTime), CAST(1100 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (7, 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(1000 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (8, 3, CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(680 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (9, 2, CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(450 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (10, 4, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(300 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (11, 4, CAST(N'2015-01-01T00:00:00.000' AS DateTime), CAST(1500 AS Numeric(18, 0)), 0, 1)
INSERT [dbo].[Expenses] ([Id], [CategoryId], [Year], [Amount], [IsDeleted], [IsValid]) VALUES (12, 5, CAST(N'2020-01-01T00:00:00.000' AS DateTime), CAST(150 AS Numeric(18, 0)), 0, 1)
SET IDENTITY_INSERT [dbo].[Expenses] OFF
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expenses_Expenses] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expenses_Expenses]
GO
