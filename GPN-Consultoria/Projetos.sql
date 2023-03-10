/*
   quarta-feira, 16 de novembro de 202218:40:02
   User: fcv
   Server: NOTEFCV\SQLEXPRESS01
   Database: GPC
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	IdProjeto int NOT NULL IDENTITY (1, 1),
	IdCliente int NOT NULL,
	IdContrato int NULL,
	nomeProjeto varchar(50) NULL,
	descricaoProjeto varchar(200) NULL,
	qtdHoraPrev decimal(18, 0) NULL,
	qtdHoraReal decimal(18, 0) NULL,
	dtInicioPrev date NULL,
	dtInicioReal date NULL,
	dtTerminoPrev date NULL,
	dtTerminoReal date NULL,
	custoTotalPrev decimal(18, 0) NULL,
	custoTotalReal decimal(18, 0) NULL,
	statusProjeto char(1) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 ADD CONSTRAINT
	PK_Table_1 PRIMARY KEY CLUSTERED 
	(
	IdProjeto
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
