USE [CuidarMais]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01/05/2023 11:22:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuidadores]    Script Date: 01/05/2023 11:22:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuidadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Cpf] [nvarchar](max) NOT NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[Telefone] [nvarchar](max) NULL,
	[Cep] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NULL,
	[Cidade] [nvarchar](max) NULL,
	[AreaAtuacao] [nvarchar](max) NOT NULL,
	[ValorHora] [float] NOT NULL,
	[NumeroProfissional] [nvarchar](max) NOT NULL,
	[Senha] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Cuidadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioLogins]    Script Date: 01/05/2023 11:22:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioLogins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Senha] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_UsuarioLogins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230426202710_InitialCreate', N'7.0.5')
GO
SET IDENTITY_INSERT [dbo].[Cuidadores] ON 

INSERT [dbo].[Cuidadores] ([Id], [Nome], [Email], [Cpf], [DataNascimento], [Telefone], [Cep], [Estado], [Cidade], [AreaAtuacao], [ValorHora], [NumeroProfissional], [Senha]) VALUES (1, N'Roberto Macedo', N'robertomacedo320@gmail.com', N'12345678911', CAST(N'2023-04-26T20:29:45.5130000' AS DateTime2), N'957876737', N'04673180', N'São Paulo', N'São Paulo', N'Enfermeiro', 200, N'1234', N'12345678')
INSERT [dbo].[Cuidadores] ([Id], [Nome], [Email], [Cpf], [DataNascimento], [Telefone], [Cep], [Estado], [Cidade], [AreaAtuacao], [ValorHora], [NumeroProfissional], [Senha]) VALUES (2, N'Vitória Mendes', N'vitoria@gmail.com', N'12345678911', CAST(N'2023-04-27T14:40:57.4770000' AS DateTime2), N'123', N'04564848', N'São Paulo', N'São Paulo', N'Enfermeira', 2000, N'123456', N'123456789')
INSERT [dbo].[Cuidadores] ([Id], [Nome], [Email], [Cpf], [DataNascimento], [Telefone], [Cep], [Estado], [Cidade], [AreaAtuacao], [ValorHora], [NumeroProfissional], [Senha]) VALUES (3, N'Anderson Lopes', N'Anderson@gmail.com', N'12345678933', CAST(N'2020-05-10T00:00:00.0000000' AS DateTime2), N'12345678911', N'04678950', N'Minas Gerais', N'Uberlândia', N'Cuidador', 300, N'123456789', N'Cuidador1234')
INSERT [dbo].[Cuidadores] ([Id], [Nome], [Email], [Cpf], [DataNascimento], [Telefone], [Cep], [Estado], [Cidade], [AreaAtuacao], [ValorHora], [NumeroProfissional], [Senha]) VALUES (4, N'string', N'string', N'stringstrin', CAST(N'2023-04-29T00:00:00.0000000' AS DateTime2), N'string', N'stringst', N'string', N'string', N'string', 0, N'string', N'$2a$11$iTFoK4sNEgkPfO3pJdUeZulzDDO4a9D8VyQJmUFS5h1akzU6X5CNG')
SET IDENTITY_INSERT [dbo].[Cuidadores] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuarioLogins] ON 

INSERT [dbo].[UsuarioLogins] ([Id], [Email], [Senha]) VALUES (1, N'robertomacedo320@gmail.com', N'12345678')
INSERT [dbo].[UsuarioLogins] ([Id], [Email], [Senha]) VALUES (2, N'vitoria@gmail.com', N'123456789')
INSERT [dbo].[UsuarioLogins] ([Id], [Email], [Senha]) VALUES (3, N'Anderson@gmail.com', N'Cuidador1234')
INSERT [dbo].[UsuarioLogins] ([Id], [Email], [Senha]) VALUES (4, N'string', N'$2a$11$iTFoK4sNEgkPfO3pJdUeZulzDDO4a9D8VyQJmUFS5h1akzU6X5CNG')
SET IDENTITY_INSERT [dbo].[UsuarioLogins] OFF
GO
