USE [GPC]
GO

/****** Object:  Table [dbo].[Atividades]    Script Date: 16/11/2022 19:46:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Atividades]') AND type in (N'U'))
DROP TABLE [dbo].[Atividades]
GO

/****** Object:  Table [dbo].[Atividades]    Script Date: 16/11/2022 19:46:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Atividades](
	[IdAtividade] [char](3) NOT NULL,
	[IdProjeto] [int] NOT NULL,
	[nomeAtividade] [varchar](50) NOT NULL,
	[descricaoAtividade] [varchar](100) NOT NULL,
	[qtdHoraPrev] [decimal](18, 0) NOT NULL,
	[qtdHoraReal] [decimal](18, 0) NOT NULL,
	[dtInicioPrev] [date] NOT NULL,
	[dtInicioReal] [date] NOT NULL,
	[dtTerminoPrev] [date] NOT NULL,
	[dtTermininoReal] [date] NOT NULL,
	[custoTotalPrev] [decimal](18, 0) NOT NULL,
	[custoTotalReal] [decimal](18, 0) NOT NULL,
	[statusAtividade] [char](1) NOT NULL,
 CONSTRAINT [PK_Atividades] PRIMARY KEY CLUSTERED 
(
	[IdAtividade] ASC,
	[IdProjeto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


