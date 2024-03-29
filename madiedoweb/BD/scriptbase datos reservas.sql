USE [Reservas]
GO
/****** Object:  Table [dbo].[Table_hotel]    Script Date: 26/11/2021 20:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_hotel](
	[id_hotel] [int] IDENTITY(1,1) NOT NULL,
	[nombre_hotel] [varchar](50) NULL,
	[id_sede] [int] NULL,
	[direccion_hotel] [varchar](70) NULL,
	[habitaciones] [int] NULL,
	[tipo] [varchar](50) NULL,
	[cupo] [int] NULL,
 CONSTRAINT [PK_Table_hotel] PRIMARY KEY CLUSTERED 
(
	[id_hotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_Sede]    Script Date: 26/11/2021 20:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_Sede](
	[id_sede] [int] IDENTITY(1,1) NOT NULL,
	[nombre_sede] [varchar](50) NULL,
	[ubicacion] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Sede] PRIMARY KEY CLUSTERED 
(
	[id_sede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Table_hotel] ON 

INSERT [dbo].[Table_hotel] ([id_hotel], [nombre_hotel], [id_sede], [direccion_hotel], [habitaciones], [tipo], [cupo]) VALUES (1, N'marina    ', 1, N'direccion1', 30, N'standar', 4)
INSERT [dbo].[Table_hotel] ([id_hotel], [nombre_hotel], [id_sede], [direccion_hotel], [habitaciones], [tipo], [cupo]) VALUES (2, N'lucas     cali', 2, N'direccion1-2', 20, N'premium', 6)
INSERT [dbo].[Table_hotel] ([id_hotel], [nombre_hotel], [id_sede], [direccion_hotel], [habitaciones], [tipo], [cupo]) VALUES (3, N'Cartagena', 3, N'direccion31', 10, N'standar', 8)
INSERT [dbo].[Table_hotel] ([id_hotel], [nombre_hotel], [id_sede], [direccion_hotel], [habitaciones], [tipo], [cupo]) VALUES (4, N'bogot plaza', 4, N'direccion4-1', 20, N'premium', 6)
INSERT [dbo].[Table_hotel] ([id_hotel], [nombre_hotel], [id_sede], [direccion_hotel], [habitaciones], [tipo], [cupo]) VALUES (5, N'cartagena resorlt', 3, N'direccion3-2', 10, N'premium', 6)
INSERT [dbo].[Table_hotel] ([id_hotel], [nombre_hotel], [id_sede], [direccion_hotel], [habitaciones], [tipo], [cupo]) VALUES (7, N'barranquilla resorlt', 1, N'direccion1-3', 30, N'3', 4)
SET IDENTITY_INSERT [dbo].[Table_hotel] OFF
SET IDENTITY_INSERT [dbo].[Table_Sede] ON 

INSERT [dbo].[Table_Sede] ([id_sede], [nombre_sede], [ubicacion]) VALUES (1, N'Barranquilla,', N'Barranquilla,')
INSERT [dbo].[Table_Sede] ([id_sede], [nombre_sede], [ubicacion]) VALUES (2, N'Cali', N'Cali')
INSERT [dbo].[Table_Sede] ([id_sede], [nombre_sede], [ubicacion]) VALUES (3, N'Cartagena', N'Cartagena')
INSERT [dbo].[Table_Sede] ([id_sede], [nombre_sede], [ubicacion]) VALUES (4, N'Bogotá', N'Bogotá')
SET IDENTITY_INSERT [dbo].[Table_Sede] OFF
