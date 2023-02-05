USE [GPC]
GO

/****** Object:  Table [dbo].[Consultores]    Script Date: 16/11/2022 18:45:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Consultores]') AND type in (N'U'))
DROP TABLE [dbo].[Consultores]
GO 

/****** Object:  Table [dbo].[Consultores]    Script Date: 16/11/2022 18:45:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Consultores](
	[IdConsultor] [int] IDENTITY(1,1) NOT NULL,
	[cpf] [char](11) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[IdFornecedor] [int] NOT NULL,
	[valor_hora] [decimal](9, 2) NULL,
	[experiencia] [varchar](200) NULL,
 CONSTRAINT [PK_Consultores] PRIMARY KEY CLUSTERED 
(
	[cpf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


