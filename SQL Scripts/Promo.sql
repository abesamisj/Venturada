USE [venturada_uat]
GO
/****** Object:  Table [dbo].[Promo]    Script Date: 1/11/2015 2:41:20 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Promo](
	[PromoId] [int] IDENTITY(1,1) NOT NULL,
	[PromoTitle] [varchar](50) NULL,
	[PromoDescription] [varchar](max) NULL,
	[ImageString] [varchar](max) NULL,
 CONSTRAINT [PK_Promo] PRIMARY KEY CLUSTERED 
(
	[PromoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
) TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Promo] ON 

GO
INSERT [dbo].[Promo] ([PromoId], [PromoTitle], [PromoDescription], [ImageString]) VALUES (1, N'Want Savings?', N'<p style="text-align: justify;">At Paragraph we realized that a good proportion of the printing work we do for our customers are also part of a promotional campaign or to support specific activities and events. To simplify our customers sourcing needs we created our Para Promo service that provides you with the largest possible selection of quality promotional items that are custom tailored to your needs and company image. From cups and pens to golf shirts, caps and executive gifts Para Promo can help you make all your promotional initiatives a success</p>', N'Contents\Images\Services\4b25c0b3-e98e-479d-a11d-9e6c9d0f3cb1_promo.jpg')
GO
SET IDENTITY_INSERT [dbo].[Promo] OFF
GO
