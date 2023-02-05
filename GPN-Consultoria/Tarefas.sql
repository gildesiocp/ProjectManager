USE [GPC]
GO

/****** Object:  Table [dbo].[Tarefas]    Script Date: 16/11/2022 19:50:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tarefas]') AND type in (N'U'))
DROP TABLE [dbo].[Tarefas]
GO

/****** Object:  Table [dbo].[Tarefas]    Script Date: 16/11/2022 19:50:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tarefas](
	[IdProjeto] [int] NOT NULL,
	[idAtividade] [char](3) NOT NULL,
	[IdTarefa] [char](3) NOT NULL,
	[nomeTarefa] [varchar](50) NOT NULL,
	[descricaoTarefa] [varchar](100) NOT NULL,
	[qtdHoraPrev] [decimal](18, 0) NOT NULL,
	[qtdHoraReal] [decimal](18, 0) NOT NULL,
	[dtInicioPrev] [decimal](18, 0) NOT NULL,
	[dtInicioReal] [decimal](18, 0) NOT NULL,
	[dtTerminoPrev] [decimal](18, 0) NOT NULL,
	[dtTerminoReal] [decimal](18, 0) NOT NULL,
	[custoTotalPrev] [decimal](18, 0) NOT NULL,
	[custoTotalReal] [decimal](18, 0) NOT NULL,
	[statusTarefa] [char](1) NOT NULL,
 CONSTRAINT [PK_Tarefas] PRIMARY KEY CLUSTERED 
(
	[IdProjeto] ASC,
	[idAtividade] ASC,
	[IdTarefa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


