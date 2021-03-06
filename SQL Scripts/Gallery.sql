USE [venturada_uat]
GO
/****** Object:  Table [dbo].[Gallery]    Script Date: 2/11/2015 1:41:05 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gallery](
	[GalleryId] [int] IDENTITY(1,1) NOT NULL,
	[GalleryTitle] [varchar](50) NULL,
	[GalleryDescription] [varchar](200) NULL,
	[Row] [int] NOT NULL,
	[ImageString] [varchar](max) NULL,
 CONSTRAINT [PK_Gallery] PRIMARY KEY CLUSTERED 
(
	[GalleryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
) TEXTIMAGE_ON [PRIMARY]

--GO
--SET ANSI_PADDING OFF
--GO
--SET IDENTITY_INSERT [dbo].[Gallery] ON 

--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (4, N'sdfasdfsdfa sdfasdf asdf a', N'sfasdfa sd fasdf sdf ', 2, N'Contents\Images\Gallery\0ca43b26-86aa-444b-b1b5-d022e8460fd5_aboutus.jpg')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (5, N'asdfsdf sdf asdfas', N'dfasdfa sdf s', 2, N'Contents\Images\Gallery\8a8ec9eb-41c0-4ba0-9ad2-3634b7f6cd4b_delivery.jpg')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (6, N'tests asdd', N'ssdfsdfsdfsdfsdfsdfsdfsdf sdsd fsd f', 2, N'Contents\Images\Gallery\5e0190fb-24b7-4aae-8b14-764dec824652_ourproducts.jpg')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (7, N'gsgs', N'sddfgdf', 3, N'Contents\Images\Gallery\edaf38ee-39b8-4088-b9f3-b555d171e498_orderform.jpg')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (8, N'000', N't000000', 3, N'Contents\Images\Gallery\bada3165-45bd-483b-a61e-d3bf038bf1aa_farmmeatbrochure3.png')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (9, N'y', N'y', 3, N'Contents\Images\Gallery\ff3edf84-4929-4593-8acf-23283f0da2d6_iloveporkOriginal.png')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (11, N'y', N'y', 1, N'Contents\Images\Gallery\90ff3ed6-c2dd-4408-a924-77ef9d0478d0_products.jpg')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (12, N'656565 '' ', N'56565 56 5 ''', 4, N'Contents\Images\Gallery\e62d81a3-8ac0-464f-b6ac-6d360fdfd4ab_farmmeat.png')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (14, N'34343', N'34343434', 1, N'Contents\Images\Gallery\90ff3ed6-c2dd-4408-a924-77ef9d0478d0_products.jpg')
--GO
--INSERT [dbo].[Gallery] ([GalleryId], [GalleryTitle], [GalleryDescription], [Row], [ImageString]) VALUES (15, N'44444', N'444444444', 4, N'Contents\Images\Gallery\bada3165-45bd-483b-a61e-d3bf038bf1aa_farmmeatbrochure3.png')
--GO
--SET IDENTITY_INSERT [dbo].[Gallery] OFF
--GO
