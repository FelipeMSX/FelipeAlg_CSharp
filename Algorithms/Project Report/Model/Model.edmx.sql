
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2017 18:30:52
-- Generated from EDMX file: C:\WorkDir\Git\FelipeAlg_CSharp\Algorithms\Project Report\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Report];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RelatorioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RelatorioSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RelatorioSet'
CREATE TABLE [dbo].[RelatorioSet] (
    [sq_relatorio] int IDENTITY(1,1) NOT NULL,
    [sq_modulo] smallint  NOT NULL,
    [nm_arquivo] nvarchar(120)  NOT NULL,
    [nmConteudo] varbinary(max)  NOT NULL,
    [nmPalavraChave] nvarchar(400)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [sq_relatorio] in table 'RelatorioSet'
ALTER TABLE [dbo].[RelatorioSet]
ADD CONSTRAINT [PK_RelatorioSet]
    PRIMARY KEY CLUSTERED ([sq_relatorio] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------