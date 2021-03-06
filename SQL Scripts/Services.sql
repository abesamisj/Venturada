USE [venturada]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 1/11/2015 12:45:22 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Services](
	[ServicesId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [varchar](100) NULL,
	[ServiceSubTitle] [varchar](100) NULL,
	[ServiceDescription] [varchar](max) NULL,
	[ImageString] [varchar](max) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServicesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
) TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

GO
INSERT [dbo].[Services] ([ServicesId], [ServiceName], [ServiceSubTitle], [ServiceDescription], [ImageString]) VALUES (1, N'Cutting Requirements', N'Name your cut and will do it for you', N'<p><span style="font-family: Muli, sans-serif; font-size: 16px; line-height: 22.8571px;">Whatever kind of cuts you need, our specialy craft butchers will do the job for you.</span></p>', N'Contents\Images\Services\6133d29f-5a3e-4141-ab4f-5ebb5ed12728_cutting.jpg')
GO
INSERT [dbo].[Services] ([ServicesId], [ServiceName], [ServiceSubTitle], [ServiceDescription], [ImageString]) VALUES (2, N'Processing ', N'Process your meat', N'<p><span style="font-family: Muli, sans-serif; font-size: 16px; line-height: 22.8571px;">Precooked-cooked meat products contain mixes of lower-grade muscle trimmings, fatty tissues, head meat, animal feet, animal skin, blood, liver and other edible slaughter by-products.</span></p>', N'Contents\Images\Services\6498127a-8717-48ca-a3c8-d507f4ffffa4_processing.jpg')
GO
INSERT [dbo].[Services] ([ServicesId], [ServiceName], [ServiceSubTitle], [ServiceDescription], [ImageString]) VALUES (3, N'Delivery', N'Meat delivered at your door steps.', N'<p><span style="font-family: Muli, sans-serif; font-size: 16px; line-height: 22.8571px;">Don''t have time? Or you cannot go out? Venturadahogs got you covered. All your ordered meat will be delivered right at your door step</span></p>', N'Contents\Images\Services\8a369c94-1467-4cec-8906-05c830724b09_delivery.jpg')
GO
INSERT [dbo].[Services] ([ServicesId], [ServiceName], [ServiceSubTitle], [ServiceDescription], [ImageString]) VALUES (4, N'Price List', N'Guaranteed lowest prices', N'<p><span style="font-family: Muli, sans-serif; font-size: 16px; line-height: 22.8571px;">Come and see our stock for value and savings.</span></p>', N'Contents\Images\Services\e39746eb-b56c-442f-96d9-cb48d7038c6d_pricelist.jpg')
GO
INSERT [dbo].[Services] ([ServicesId], [ServiceName], [ServiceSubTitle], [ServiceDescription], [ImageString]) VALUES (5, N'Order Form', N'Order from us', N'<p><span style="font-family: Muli, sans-serif; font-size: 16px; line-height: 22.8571px;">You can place your order by submitting the order form.</span></p>', N'Contents\Images\Services\3dace413-7ccd-48fa-b7af-ef9d53388002_orderform.jpg')
GO
INSERT [dbo].[Services] ([ServicesId], [ServiceName], [ServiceSubTitle], [ServiceDescription], [ImageString]) VALUES (6, N'Wholesale ', N'Wholesale and bulk orders.', N'<p><span style="font-family: Muli, sans-serif; font-size: 16px; line-height: 22.8571px;">We have wholesale and bulk orders options 2. Come and talk to us.</span></p>', N'Contents\Images\Services\9c6ea347-2a71-4f7d-8635-663d091af8f5_wholesale.jpg')
GO
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
