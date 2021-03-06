USE [DB_A3B5B5_sici]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 20/06/2018 11:02:46 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 20/06/2018 11:02:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 20/06/2018 11:02:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 20/06/2018 11:02:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 20/06/2018 11:02:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 20/06/2018 11:02:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Anuncios]    Script Date: 20/06/2018 11:02:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Anuncios](
	[IdAnuncio] [int] IDENTITY(1,1) NOT NULL,
	[AutorAnuncio] [varchar](50) NULL,
	[TituloAnuncio] [varchar](100) NULL,
	[DescripcionAnuncio] [varchar](200) NULL,
	[FechaCreacionAnuncio] [datetime] NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_Tbl_Anuncios] PRIMARY KEY CLUSTERED 
(
	[IdAnuncio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_AsistenciaTransferencias]    Script Date: 20/06/2018 11:02:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_AsistenciaTransferencias](
	[IdAsistenciaTransferencia] [int] IDENTITY(1,1) NOT NULL,
	[IdTransferencia] [int] NOT NULL,
	[Cedula] [numeric](18, 0) NULL,
	[IdSede] [int] NULL,
	[FechaRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_ASISTENCIATRANSFERENCIAS] PRIMARY KEY CLUSTERED 
(
	[IdAsistenciaTransferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Calificaciones]    Script Date: 20/06/2018 11:02:50 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Calificaciones](
	[IdCalificacion] [int] IDENTITY(1,1) NOT NULL,
	[IdTransferencia] [int] NULL,
	[Cedula] [numeric](18, 0) NULL,
	[Calificacion] [numeric](18, 0) NULL,
 CONSTRAINT [PK_CALIFICACIONES] PRIMARY KEY CLUSTERED 
(
	[IdCalificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Discapacidades]    Script Date: 20/06/2018 11:02:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Discapacidades](
	[IdDiscapacidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_DISCAPACIDADES] PRIMARY KEY CLUSTERED 
(
	[IdDiscapacidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Especializacion]    Script Date: 20/06/2018 11:02:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Especializacion](
	[IdEspecializacion] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionEspecializacion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Tbl_Especializacion] PRIMARY KEY CLUSTERED 
(
	[IdEspecializacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_EspecializacionesUsuario]    Script Date: 20/06/2018 11:02:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_EspecializacionesUsuario](
	[Cedula] [numeric](18, 0) NOT NULL,
	[IdEspecializacion] [int] NOT NULL,
	[nidreg] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Tbl_EspecializacionesUsuario] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC,
	[IdEspecializacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Estados]    Script Date: 20/06/2018 11:02:52 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Estados](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_ESTADOS] PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_HistoricoNotificaciones]    Script Date: 20/06/2018 11:02:52 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_HistoricoNotificaciones](
	[IdTransferencia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTransferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_InformacionBasicaUsuario]    Script Date: 20/06/2018 11:02:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_InformacionBasicaUsuario](
	[Cedula] [numeric](18, 0) NOT NULL,
	[NombreCompleto] [varchar](200) NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](25) NULL,
	[Discapacidad] [int] NULL,
	[IdEstado] [int] NULL,
	[Id] [nvarchar](128) NULL,
	[IdPerfil] [int] NULL,
 CONSTRAINT [PK_INFOBASICAUSUARIO] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Inscripciones]    Script Date: 20/06/2018 11:02:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Inscripciones](
	[IdInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [numeric](18, 0) NULL,
	[IdTransferencia] [int] NULL,
 CONSTRAINT [PK_Tbl_Inscripciones] PRIMARY KEY CLUSTERED 
(
	[IdInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Perfiles]    Script Date: 20/06/2018 11:02:53 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Perfiles](
	[IdPerfil] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Perfiles] PRIMARY KEY CLUSTERED 
(
	[IdPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sedes]    Script Date: 20/06/2018 11:02:54 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sedes](
	[IdSede] [int] IDENTITY(1,1) NOT NULL,
	[NombreSede] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
 CONSTRAINT [PK_SEDES] PRIMARY KEY CLUSTERED 
(
	[IdSede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Transferencias]    Script Date: 20/06/2018 11:02:54 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Transferencias](
	[NombreTransferencia] [varchar](50) NULL,
	[IdTransferencia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CuposIniciales] [numeric](18, 0) NULL,
	[CuposActuales] [numeric](18, 0) NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[FechaCreacion] [datetime] NULL,
	[EstadoTransferencia] [int] NOT NULL,
	[IdEspecializacion] [int] NOT NULL,
	[IdSede] [int] NOT NULL,
 CONSTRAINT [PK_TRANSFERENCIAS] PRIMARY KEY CLUSTERED 
(
	[IdTransferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias] ADD  CONSTRAINT [DF_Tbl_AsistenciaTransferencias_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_AsistenciaTransferencias_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Cedula])
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias] CHECK CONSTRAINT [FK_Tbl_AsistenciaTransferencias_Tbl_InformacionBasicaUsuario]
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_AsistenciaTransferencias_Tbl_Sedes] FOREIGN KEY([IdSede])
REFERENCES [dbo].[Tbl_Sedes] ([IdSede])
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias] CHECK CONSTRAINT [FK_Tbl_AsistenciaTransferencias_Tbl_Sedes]
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_AsistenciaTransferencias_Tbl_Transferencias] FOREIGN KEY([IdTransferencia])
REFERENCES [dbo].[Tbl_Transferencias] ([IdTransferencia])
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias] CHECK CONSTRAINT [FK_Tbl_AsistenciaTransferencias_Tbl_Transferencias]
GO
ALTER TABLE [dbo].[Tbl_Calificaciones]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Calificaciones_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Cedula])
GO
ALTER TABLE [dbo].[Tbl_Calificaciones] CHECK CONSTRAINT [FK_Tbl_Calificaciones_Tbl_InformacionBasicaUsuario]
GO
ALTER TABLE [dbo].[Tbl_Calificaciones]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Calificaciones_Tbl_Transferencias1] FOREIGN KEY([IdTransferencia])
REFERENCES [dbo].[Tbl_Transferencias] ([IdTransferencia])
GO
ALTER TABLE [dbo].[Tbl_Calificaciones] CHECK CONSTRAINT [FK_Tbl_Calificaciones_Tbl_Transferencias1]
GO
ALTER TABLE [dbo].[Tbl_EspecializacionesUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_EspecializacionesUsuario_Tbl_Especializacion] FOREIGN KEY([IdEspecializacion])
REFERENCES [dbo].[Tbl_Especializacion] ([IdEspecializacion])
GO
ALTER TABLE [dbo].[Tbl_EspecializacionesUsuario] CHECK CONSTRAINT [FK_Tbl_EspecializacionesUsuario_Tbl_Especializacion]
GO
ALTER TABLE [dbo].[Tbl_EspecializacionesUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_EspecializacionesUsuario_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Cedula])
GO
ALTER TABLE [dbo].[Tbl_EspecializacionesUsuario] CHECK CONSTRAINT [FK_Tbl_EspecializacionesUsuario_Tbl_InformacionBasicaUsuario]
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_INFOBASICAUSUARIO_DISCAPACIDADES] FOREIGN KEY([Discapacidad])
REFERENCES [dbo].[Tbl_Discapacidades] ([IdDiscapacidad])
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario] CHECK CONSTRAINT [FK_INFOBASICAUSUARIO_DISCAPACIDADES]
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_AspNetUsers] FOREIGN KEY([Id])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario] CHECK CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_AspNetUsers]
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_Tbl_Estados] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Tbl_Estados] ([IdEstado])
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario] CHECK CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_Tbl_Estados]
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_Tbl_Perfiles] FOREIGN KEY([IdPerfil])
REFERENCES [dbo].[Tbl_Perfiles] ([IdPerfil])
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario] CHECK CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_Tbl_Perfiles]
GO
ALTER TABLE [dbo].[Tbl_Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Inscripciones_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Cedula])
GO
ALTER TABLE [dbo].[Tbl_Inscripciones] CHECK CONSTRAINT [FK_Tbl_Inscripciones_Tbl_InformacionBasicaUsuario]
GO
ALTER TABLE [dbo].[Tbl_Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Inscripciones_Tbl_Transferencias1] FOREIGN KEY([IdTransferencia])
REFERENCES [dbo].[Tbl_Transferencias] ([IdTransferencia])
GO
ALTER TABLE [dbo].[Tbl_Inscripciones] CHECK CONSTRAINT [FK_Tbl_Inscripciones_Tbl_Transferencias1]
GO
ALTER TABLE [dbo].[Tbl_Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Transferencias_Tbl_Especializacion] FOREIGN KEY([IdEspecializacion])
REFERENCES [dbo].[Tbl_Especializacion] ([IdEspecializacion])
GO
ALTER TABLE [dbo].[Tbl_Transferencias] CHECK CONSTRAINT [FK_Tbl_Transferencias_Tbl_Especializacion]
GO
ALTER TABLE [dbo].[Tbl_Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Transferencias_Tbl_Estados] FOREIGN KEY([EstadoTransferencia])
REFERENCES [dbo].[Tbl_Estados] ([IdEstado])
GO
ALTER TABLE [dbo].[Tbl_Transferencias] CHECK CONSTRAINT [FK_Tbl_Transferencias_Tbl_Estados]
GO
ALTER TABLE [dbo].[Tbl_Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Transferencias_Tbl_Sedes] FOREIGN KEY([IdSede])
REFERENCES [dbo].[Tbl_Sedes] ([IdSede])
GO
ALTER TABLE [dbo].[Tbl_Transferencias] CHECK CONSTRAINT [FK_Tbl_Transferencias_Tbl_Sedes]
GO
