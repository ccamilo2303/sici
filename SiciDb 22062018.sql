USE [DB_A3B5B5_sici]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 22/06/2018 12:17:52 a.m. ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 22/06/2018 12:17:54 a.m. ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 22/06/2018 12:17:54 a.m. ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 22/06/2018 12:17:55 a.m. ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 22/06/2018 12:17:55 a.m. ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 22/06/2018 12:17:55 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_Anuncios]    Script Date: 22/06/2018 12:17:56 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_ArchivosUsuario]    Script Date: 22/06/2018 12:17:56 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ArchivosUsuario](
	[Id] [nvarchar](128) NULL,
	[Name] [varchar](200) NULL,
	[ContentType] [nvarchar](200) NULL,
	[Data] [varbinary](max) NULL,
	[idRegistro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Tbl_ArchivosUsuario] PRIMARY KEY CLUSTERED 
(
	[idRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_AsistenciaTransferencias]    Script Date: 22/06/2018 12:17:57 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_AsistenciaTransferencias](
	[IdAsistenciaTransferencia] [int] IDENTITY(1,1) NOT NULL,
	[IdTransferencia] [int] NOT NULL,
	[Id] [nvarchar](128) NULL,
	[IdSede] [int] NULL,
	[FechaRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_ASISTENCIATRANSFERENCIAS] PRIMARY KEY CLUSTERED 
(
	[IdAsistenciaTransferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Calificaciones]    Script Date: 22/06/2018 12:17:57 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Calificaciones](
	[IdCalificacion] [int] IDENTITY(1,1) NOT NULL,
	[IdTransferencia] [int] NULL,
	[Id] [nvarchar](128) NULL,
	[Calificacion] [numeric](18, 0) NULL,
 CONSTRAINT [PK_CALIFICACIONES] PRIMARY KEY CLUSTERED 
(
	[IdCalificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Discapacidades]    Script Date: 22/06/2018 12:17:58 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_Especializacion]    Script Date: 22/06/2018 12:17:58 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_EspecializacionesUsuario]    Script Date: 22/06/2018 12:17:58 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_EspecializacionesUsuario](
	[Id] [nvarchar](128) NOT NULL,
	[IdEspecializacion] [int] NOT NULL,
	[nidreg] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Tbl_EspecializacionesUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[IdEspecializacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Estados]    Script Date: 22/06/2018 12:17:59 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_HistoricoNotificaciones]    Script Date: 22/06/2018 12:17:59 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_InformacionBasicaUsuario]    Script Date: 22/06/2018 12:18:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_InformacionBasicaUsuario](
	[Id] [nvarchar](128) NOT NULL,
	[Cedula] [varchar](50) NOT NULL,
	[NombreCompleto] [varchar](200) NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](25) NULL,
	[Discapacidad] [int] NULL,
	[IdEstado] [int] NULL,
	[IdPerfil] [int] NULL,
 CONSTRAINT [PK_Tbl_InformacionBasicaUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Inscripciones]    Script Date: 22/06/2018 12:18:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Inscripciones](
	[IdInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[Id] [nvarchar](128) NULL,
	[IdTransferencia] [int] NULL,
 CONSTRAINT [PK_Tbl_Inscripciones] PRIMARY KEY CLUSTERED 
(
	[IdInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Perfiles]    Script Date: 22/06/2018 12:18:01 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_Sedes]    Script Date: 22/06/2018 12:18:01 a.m. ******/
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
/****** Object:  Table [dbo].[Tbl_Transferencias]    Script Date: 22/06/2018 12:18:01 a.m. ******/
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
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201806162204170_InitialCreate', N'SICI.Models.ApplicationDbContext', 0x1F8B0800000000000400DD5CDB6EE336107D2FD07F10F4D416A9954B77B10DEC5DA44ED21ADD5CB0CE167D5BD012ED082B51AA44651314FDB23EF493FA0B1D4AD48D175D6CC5768A02C55A1C9E190E87E47074947FFFFE67FCEED1F78C071CC56E4026E6D1E8D03430B103C725AB8999D0E5F76FCC776FBFFE6A7CE1F88FC66FB9DC0993839E249E98F79486A79615DBF7D847F1C877ED288883251DD9816F2127B08E0F0F7FB48E8E2C0C10266019C6F84342A8EBE3F407FC9C06C4C6214D90771538D88BF9736899A7A8C635F2711C221B4FCCF96C3A1B6562A671E6B9084C98636F691A889080220A069E7E8CF19C460159CD437880BCBBA71083DC127931E6869F96E25DC77078CCC660951D73283B8969E0F7043C3AE14EB1C4EE6BB9D62C9C066EBB00F7D22736EAD4751373E6E0F4D187C00307880A4FA75EC48427E655A1E22C0EAF311DE51D4719E46504705F82E8F3A88A786074EE775004D1F1E890FD77604C138F26119E109CD0087907C66DB2F05CFB57FC74177CC6647272B4589EBC79F51A3927AF7FC027AFAA2385B1825CED013CBA8D821047601B5E16E3370DABDECF123B16DD2A7D32AF402CC17A308D2BF4F81E9315BD879572FCC6342EDD47ECE44F78707D242E2C1FE844A3047E5E279E87161E2EDAAD469DECFF0D5A8F5FBD1E44EB357A7057E9D40BFA61E144B0AE3E602F6D8DEFDD305B5EB5F9FEC4C52EA3C067BFEBF195B57E9A074964B3C1045A913B14AD30AD5B37B6CAE0ED14D20C6AF8B0CE51F73FB499A572782B45D980D65909B98A6DAF86DCDEE7D5DB39E2CEC210262F0D2DE691A680AB9C5223A1DB81C11ACB6039EA1A2C0406F17FDEFB2E7CE47A036C7E1DB440C2B174231F17A3FC29805043A4B7CDB7288E61ED3BBFA0F8BEC174F8E700A6CFB19D441092738AFCF0D9B5DDDE07045F27FE8245FAF6740D3635775F824B64D320BA20ACD7C678EF03FB7390D00BE29C238A3F523B07643FEF5CBF3BC020E69CD9368EE34B0866EC4C03C8A773C019A127C7BDE1D8CEB4EBE463EA21D757671FC21EFA29172D3310B584948568C454994893A9EF83954BBA999A8BEA4DCD245A4DE5627D4D6560DD2CE5927A435381563B33A9C172BB7486864FEE52D8FDCFEE363BBC757B41C58D73D821F1CF98E008B631E716518A2352CE40977D6317C9423A7D4CE9B39F4DA9A6DF90970CAD6AADD5906E02C3AF861476FF57436A263C7E701D969574B8F2E4C200DF495E7D9B6A5F738265DB5E0EB5616E5BF976F600DD72398BE3C076D355A02876F15245DD7EC8E18CF6BA45361AB1F60103834077D991074F606CA6185437E41C7B9862E3CCCE8A815314DBC891DD0803727A18969FA80AC3CA1A48DDB8EF249D10E938629D10BB04C5B0525D42E565E112DB0D91D7EA25A167C7238C8DBDD021B69CE31013A6B0D5135D94AB4B1ECC80428F30296D1E1A5B95886B0E444DD6AA9BF3B614B69C77A912B195986CC99D3571C9F3B76709CC668F6D21389B5DD2C5006DF96E1701CAEF2A5D0340BCB8EC5B800A37264D80F2946A2B015AF7D80E02B4EE921717A0D915B5EBFC0BF7D57D0BCFFA4579FBC77AA3BB76109B357FEC596866B927F4A1D0034772789E2F58237EA48ACB19D8C9EF67314F75C51061E0734CEB259B32DF55E6A156338818444D8065A0B580F2177F1290B4A07A1897D7F21AADE359440FD8BCEED608CBF77E01B612033276F505684550FF9A540CCE4EB78F626445344841DEE9B250C1510484B879D507DEC129BABAACEC982EB9709F6CB832303E190D0E6AC95C354ECA0733B897F2D06CF7922A21EB93926DE425217DD278291FCCE05EE231DAEE244552D0232DD8C845F5237CA0C596573A8AD3A6681B5B19218A3F185B1AE6D4F80A85A14B561526157F62CC331AD5F4FB797F9A919F615876AC601B15D6169A6810A115165A4135587AE946313D47142D10ABF34C1D5F12539EAD9AED3F57593D3EE549CCCF815C9AFD9BBF59ADBCAEAF1DB27216C23B5FC2D07C96CAA4F573C5C4ABBB1B8CD2863C14294AF6D3C04B7CA2CFACF4BDB31777D5FED91319616C09F64B9993E42629BFADFBBCD38CC8AB61D3D9293296F567480FA1F3739E6F563DADCB41F5287949AA8AA22B53ED6CC674A94BB75912D3C1FE93D48AF03C2B897350AA00FC514F8C0A8D4102ABB47547AD334DAA98F596EE88029DA40A2934F5B0B24A1AA919596D580B4FE351B544770D324DA48A2EB77647561046AAD08AE635B015368B6DDD51159C922AB0A2B93B7649301177CF3D3EABB49794FE87557681DDECB4D2603CCF5638CC6157794F5F05AA3CEE89C5DFC44B60FCF95E8691F616D73F8CB282C56661A4C1D0EF35B557DBF5ADA6F17DBC1EB3F6BEBAB69D37BDAFD7E3F50BD6670D09E9F6268A14DA8B5B9C705B1BF39B53FBC730D2552A13318DDC8D10484F31C5FE88098CE67F7853CFC56CE3CE05AE10719738A61947C33C3E3C3A163EABD99F4F5CAC38763CC5CD53F79D4B7DCEB640B7220F28B2EF5124931F36F80CA40495EACA33E2E0C789F967DAEB342D51B07FA58F0F8C59FC91B87F24D0701725D8F84B26730E438B6FBE4FEDE9470CDDBD3AFBFD53D6F5C0B88960C59C1A87822FD799E1FAA70DBDACC9BA6E60CDDA1F3CBCDC0555FBB640892A2C88F53F2558B87490CF08722BBFF1D1E3B77D4D537E2AB011A2E27380A1F00671A18EEEBF0E9696EAEFC04F9A52FDFB0D564DFD5FC7342DEDDF25FDC144D27FF76D28EFB9C3A3467119DAC69694FAB99534BD118372D76793C4ADDE68A1CBFCE91E701B70A4D7888C17462F1EEC7454B08707C3DE65683F3B65785F58C2257F63B7E4E06DF2811BDE00FDAF68C07B405C531071764FF6DD76ACE90AB87BCE98EC47E9DDB360E3F4ACDD1377B71D6CBA32EF9E075B2F7AEE9EC5DAAECECF1D475AE72374E7645B9937A47911A3AA05B79169B3C239DCF017010441965166DF40AAD95B4DCCD31685A5885EA99E36262A96168EA457926856DB6FACFCC06F1C2C976956AB215B36E9E6FB7FA36E2ED3AC5B4361DC050D5849225451B35BF6B126BED34BA2FDD646D2C2326FCB591BDFAABF2496EF204EA9AD1ECD3BE29743EA1DC425432E9D1E245EF9752F9C9D95BF9008E777ECAE4A08F6F71209B66BA766213323CB203FBC058B7211A14273852972E0483D8BA8BB4436856656634E3FE24EEB76EC4DC7023B337293D030A13064EC2FBC5AC18B25014DFA53A672DDE6F14D98FE3D9221860066BAAC367F437E4A5CCF29ECBE54D48434102CBBE0155D3697945576574F05D275403A0271F71549D11DF6430FC0E21B32470F781DDB20FCDEE315B29FCA0AA00EA47D22EA6E1F9FBB6815213FE618657FF80931ECF88F6FFF030A1D1E6B28540000, N'6.1.3-40302')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'59efec80-0732-4c32-a4b3-6b5a8913fb63', N'ccamilo2303@hotmail.com', 0, N'ADPrFlgZ4a5Xkmuh9bw2kH2cpIJAvO5cMzS2JMnLKojJVaCFKkxH+hmmymlgAtBsRQ==', N'eb99d454-7b15-47cc-b926-ba78eb116e45', NULL, 0, 0, NULL, 1, 0, N'ccamilo2303@hotmail.com')
SET IDENTITY_INSERT [dbo].[Tbl_Anuncios] ON 

INSERT [dbo].[Tbl_Anuncios] ([IdAnuncio], [AutorAnuncio], [TituloAnuncio], [DescripcionAnuncio], [FechaCreacionAnuncio], [Imagen]) VALUES (1, N'Camilo', N'Prueba', N'prueba', CAST(N'2018-01-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_Anuncios] ([IdAnuncio], [AutorAnuncio], [TituloAnuncio], [DescripcionAnuncio], [FechaCreacionAnuncio], [Imagen]) VALUES (2, N'Camilo', N'Prueba Anuncio', N'Se abre convocatoria para curso Java', CAST(N'2018-01-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Tbl_Anuncios] ([IdAnuncio], [AutorAnuncio], [TituloAnuncio], [DescripcionAnuncio], [FechaCreacionAnuncio], [Imagen]) VALUES (3, N'Camilo', N'Curso .NET', N'La escuela de instructores abre un curso sobre .NET', CAST(N'2018-06-21T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Anuncios] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Discapacidades] ON 

INSERT [dbo].[Tbl_Discapacidades] ([IdDiscapacidad], [Descripcion]) VALUES (1, N'Vidente')
INSERT [dbo].[Tbl_Discapacidades] ([IdDiscapacidad], [Descripcion]) VALUES (2, N'Ninguna')
SET IDENTITY_INSERT [dbo].[Tbl_Discapacidades] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Especializacion] ON 

INSERT [dbo].[Tbl_Especializacion] ([IdEspecializacion], [DescripcionEspecializacion]) VALUES (1, N'jee')
INSERT [dbo].[Tbl_Especializacion] ([IdEspecializacion], [DescripcionEspecializacion]) VALUES (2, N'.NET')
SET IDENTITY_INSERT [dbo].[Tbl_Especializacion] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Estados] ON 

INSERT [dbo].[Tbl_Estados] ([IdEstado], [Descripcion]) VALUES (1, N'Activo')
INSERT [dbo].[Tbl_Estados] ([IdEstado], [Descripcion]) VALUES (2, N'Inactivo')
SET IDENTITY_INSERT [dbo].[Tbl_Estados] OFF
INSERT [dbo].[Tbl_HistoricoNotificaciones] ([IdTransferencia]) VALUES (1)
INSERT [dbo].[Tbl_HistoricoNotificaciones] ([IdTransferencia]) VALUES (2)
INSERT [dbo].[Tbl_InformacionBasicaUsuario] ([Id], [Cedula], [NombreCompleto], [Email], [Telefono], [Discapacidad], [IdEstado], [IdPerfil]) VALUES (N'59efec80-0732-4c32-a4b3-6b5a8913fb63', N'102425', N'CAMILO', N'ccamilo2303@hotmail.com', N'123', 2, 1, 1)
SET IDENTITY_INSERT [dbo].[Tbl_Perfiles] ON 

INSERT [dbo].[Tbl_Perfiles] ([IdPerfil], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Tbl_Perfiles] ([IdPerfil], [Descripcion]) VALUES (2, N'Administrativo')
INSERT [dbo].[Tbl_Perfiles] ([IdPerfil], [Descripcion]) VALUES (3, N'Docente')
SET IDENTITY_INSERT [dbo].[Tbl_Perfiles] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Sedes] ON 

INSERT [dbo].[Tbl_Sedes] ([IdSede], [NombreSede], [Direccion]) VALUES (1, N'Murillo toro', N'calle 67 no 17g ')
INSERT [dbo].[Tbl_Sedes] ([IdSede], [NombreSede], [Direccion]) VALUES (2, N'CEET', N'Calle 30')
SET IDENTITY_INSERT [dbo].[Tbl_Sedes] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Transferencias] ON 

INSERT [dbo].[Tbl_Transferencias] ([NombreTransferencia], [IdTransferencia], [Descripcion], [CuposIniciales], [CuposActuales], [FechaInicio], [FechaFin], [FechaCreacion], [EstadoTransferencia], [IdEspecializacion], [IdSede]) VALUES (N'Java', 1, N'JEE', CAST(1 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(N'2018-10-01T00:00:00.000' AS DateTime), CAST(N'2018-10-01T00:00:00.000' AS DateTime), CAST(N'2018-10-01T00:00:00.000' AS DateTime), 1, 1, 1)
INSERT [dbo].[Tbl_Transferencias] ([NombreTransferencia], [IdTransferencia], [Descripcion], [CuposIniciales], [CuposActuales], [FechaInicio], [FechaFin], [FechaCreacion], [EstadoTransferencia], [IdEspecializacion], [IdSede]) VALUES (N'.NET', 2, N'Curso sobre MVC', CAST(1 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), CAST(N'2018-10-01T00:00:00.000' AS DateTime), CAST(N'2018-10-31T00:00:00.000' AS DateTime), CAST(N'2018-06-21T00:00:00.000' AS DateTime), 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Tbl_Transferencias] OFF
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
ALTER TABLE [dbo].[Tbl_ArchivosUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_ArchivosUsuario_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Id])
GO
ALTER TABLE [dbo].[Tbl_ArchivosUsuario] CHECK CONSTRAINT [FK_Tbl_ArchivosUsuario_Tbl_InformacionBasicaUsuario]
GO
ALTER TABLE [dbo].[Tbl_AsistenciaTransferencias]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_AsistenciaTransferencias_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Id])
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
ALTER TABLE [dbo].[Tbl_Calificaciones]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Calificaciones_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Id])
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
ALTER TABLE [dbo].[Tbl_EspecializacionesUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_EspecializacionesUsuario_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Id])
GO
ALTER TABLE [dbo].[Tbl_EspecializacionesUsuario] CHECK CONSTRAINT [FK_Tbl_EspecializacionesUsuario_Tbl_InformacionBasicaUsuario]
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_INFOBASICAUSUARIO_DISCAPACIDADES] FOREIGN KEY([Discapacidad])
REFERENCES [dbo].[Tbl_Discapacidades] ([IdDiscapacidad])
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario] CHECK CONSTRAINT [FK_INFOBASICAUSUARIO_DISCAPACIDADES]
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_AspNetUsers1] FOREIGN KEY([Id])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Tbl_InformacionBasicaUsuario] CHECK CONSTRAINT [FK_Tbl_InformacionBasicaUsuario_AspNetUsers1]
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
ALTER TABLE [dbo].[Tbl_Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Inscripciones_Tbl_InformacionBasicaUsuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Tbl_InformacionBasicaUsuario] ([Id])
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
