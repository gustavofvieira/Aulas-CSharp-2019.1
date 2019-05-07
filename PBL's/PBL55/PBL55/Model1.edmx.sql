
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/06/2019 21:19:07
-- Generated from EDMX file: C:\Users\Guga\source\repos\PBL55\PBL55\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbPBL];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ReceitaSet'
CREATE TABLE [dbo].[ReceitaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Medico] nvarchar(max)  NOT NULL,
    [Especialidade] nvarchar(max)  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [ClinicaHospital] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DoencaSet'
CREATE TABLE [dbo].[DoencaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Causa] nvarchar(max)  NOT NULL,
    [Sintoma] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DoencaRemedioSet'
CREATE TABLE [dbo].[DoencaRemedioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RemedioId] int  NOT NULL,
    [DoencaId] int  NOT NULL,
    [Gravidade] int  NOT NULL
);
GO

-- Creating table 'RemedioSet'
CREATE TABLE [dbo].[RemedioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Intervalo] nvarchar(max)  NOT NULL,
    [Dosagem] nvarchar(max)  NOT NULL,
    [ReceitaId] int  NOT NULL,
    [ReterReceita] bit  NOT NULL,
    [Tarja] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ReceitaSet'
ALTER TABLE [dbo].[ReceitaSet]
ADD CONSTRAINT [PK_ReceitaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DoencaSet'
ALTER TABLE [dbo].[DoencaSet]
ADD CONSTRAINT [PK_DoencaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DoencaRemedioSet'
ALTER TABLE [dbo].[DoencaRemedioSet]
ADD CONSTRAINT [PK_DoencaRemedioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RemedioSet'
ALTER TABLE [dbo].[RemedioSet]
ADD CONSTRAINT [PK_RemedioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ReceitaId] in table 'RemedioSet'
ALTER TABLE [dbo].[RemedioSet]
ADD CONSTRAINT [FK_ReceitaRemedio]
    FOREIGN KEY ([ReceitaId])
    REFERENCES [dbo].[ReceitaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceitaRemedio'
CREATE INDEX [IX_FK_ReceitaRemedio]
ON [dbo].[RemedioSet]
    ([ReceitaId]);
GO

-- Creating foreign key on [DoencaId] in table 'DoencaRemedioSet'
ALTER TABLE [dbo].[DoencaRemedioSet]
ADD CONSTRAINT [FK_DoencaDoencaRemedio]
    FOREIGN KEY ([DoencaId])
    REFERENCES [dbo].[DoencaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoencaDoencaRemedio'
CREATE INDEX [IX_FK_DoencaDoencaRemedio]
ON [dbo].[DoencaRemedioSet]
    ([DoencaId]);
GO

-- Creating foreign key on [RemedioId] in table 'DoencaRemedioSet'
ALTER TABLE [dbo].[DoencaRemedioSet]
ADD CONSTRAINT [FK_RemedioDoencaRemedio]
    FOREIGN KEY ([RemedioId])
    REFERENCES [dbo].[RemedioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RemedioDoencaRemedio'
CREATE INDEX [IX_FK_RemedioDoencaRemedio]
ON [dbo].[DoencaRemedioSet]
    ([RemedioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------