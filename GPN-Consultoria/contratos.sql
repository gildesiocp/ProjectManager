USE [GPC]
GO

/****** Object:  Table [dbo].[Contratos]    Script Date: 16/11/2022 18:59:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contratos]') AND type in (N'U'))
DROP TABLE [dbo].[Contratos]
GO

/****** Object:  Table [dbo].[Contratos]    Script Date: 16/11/2022 18:59:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contratos](
	[IdContrato] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[dtVigInicio] [date] NOT NULL,
	[dtVigTermino] [date] NOT NULL,
	[vlrHoraHomem] [decimal](9, 2) NOT NULL,
	[przFatEmDias] [int] NOT NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


