USE [GPC]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 16/11/2022 17:36:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbClientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[cpfCnpj] [varchar](14) NOT NULL,
	[nome] [varchar](60) NOT NULL,
	[endereco] [varchar](60) NOT NULL,
	[numero] [varchar](10) NOT NULL,
	[complemento] [varchar](50) NULL,
	[cep] [varchar](8) NOT NULL,
	[bairro] [varchar](50) NOT NULL,
	[cidade] [varchar](50) NOT NULL,
	[uf] [char](2) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[cpfCnpj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


