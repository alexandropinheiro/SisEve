USE MASTER
GO

IF EXISTS(select * from sys.databases where name='ESYS_EVENTSYS')
DROP DATABASE [ESYS_EVENTSYS]
GO

CREATE DATABASE [ESYS_EVENTSYS]
GO

USE [ESYS_EVENTSYS]
GO

CREATE TABLE [dbo].[FORMA_PGTO](
	[ID_FORMA_PGTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](30) NOT NULL,
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_FORMA_PGTO] PRIMARY KEY CLUSTERED ([ID_FORMA_PGTO] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TIPO_EVENTO](
	[ID_TIPO_EVENTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](30) NOT NULL,
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_TIPO_EVENTO] PRIMARY KEY CLUSTERED ([ID_TIPO_EVENTO] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TIPO_CONTATO](
	[ID_TIPO_CONTATO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](30) NOT NULL,
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_TIPO_CONTATO] PRIMARY KEY CLUSTERED ([ID_TIPO_CONTATO] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EQUIPAMENTO](
	[ID_EQUIPAMENTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[NUMERO_SERIE] [VARCHAR](50) NULL,	
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_EQUIPAMENTO] PRIMARY KEY CLUSTERED ([ID_EQUIPAMENTO] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TIPO_SERVICO](
	[ID_TIPO_SERVICO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_SERVICO] PRIMARY KEY CLUSTERED ([ID_SERVICO] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[SERVICO](
	[ID_SERVICO] [int] IDENTITY(1,1) NOT NULL,
	[ID_TIPO_SERVICO] [int] NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_SERVICO] PRIMARY KEY CLUSTERED ([ID_SERVICO] ASC) ON [PRIMARY],
	CONSTRAINT [FK_SERVICO_TIPO_SERVICO] FOREIGN KEY ([ID_TIPO_SERVICO]) REFERENCES [dbo].[TIPO_SERVICO]([ID_TIPO_SERVICO])
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MATERIAL](
	[ID_MATERIAL] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[COMPLEMENTO] [VARCHAR](255) NULL,
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_MATERIAL] PRIMARY KEY CLUSTERED ([ID_MATERIAL] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LOCAL](
	[ID_LOCAL] [int] IDENTITY(1,1) NOT NULL,
	[NOME_LOCAL] [varchar](100) NOT NULL,
	[CEP] [INT] NOT NULL,
	[LOGRADOURO] [VARCHAR](50) NOT NULL,
	[NUMERO] [VARCHAR](5) NOT NULL,
	[COMPLEMENTO] [VARCHAR](50) NULL,		
	[ATIVO] [BIT] NULL,
	[DATA_INCLUSAO] [datetime] NOT NULL,
	[ID_USUARIO_INCLUSAO] [int] NOT NULL,
	[DATA_ALTERACAO] [datetime] NULL,
	[ID_USUARIO_ALTERACAO] [int] NULL,
	CONSTRAINT [PK_LOCAL] PRIMARY KEY CLUSTERED ([ID_LOCAL] ASC) ON [PRIMARY]
) ON [PRIMARY]
GO