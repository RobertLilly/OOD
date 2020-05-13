
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/08/2020 17:22:34
-- Generated from EDMX file: H:\Year 2 Programming\OOD Project\OOD Project\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProductsStock];
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

-- Creating table 'Stocks'
CREATE TABLE [dbo].[Stocks] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Section] nvarchar(max)  NOT NULL,
    [Supplier] nvarchar(max)  NOT NULL,
    [OrderDay] nvarchar(max)  NOT NULL,
    [CaseSize] int  NOT NULL,
    [StockLeft] int  NOT NULL,	
    [Margin_ProductID] int  NOT NULL
);
GO

-- Creating table 'Margins'
CREATE TABLE [dbo].[Margins] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [UnitCost] Money NOT NULL,
    [UnitSell] Money NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ProductID] in table 'Stocks'
ALTER TABLE [dbo].[Stocks]
ADD CONSTRAINT [PK_Stocks]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Margins'
ALTER TABLE [dbo].[Margins]
ADD CONSTRAINT [PK_Margins]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Margin_ProductID] in table 'Stocks'
ALTER TABLE [dbo].[Stocks]
ADD CONSTRAINT [FK_StockMargin]
    FOREIGN KEY ([Margin_ProductID])
    REFERENCES [dbo].[Margins]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StockMargin'
CREATE INDEX [IX_FK_StockMargin]
ON [dbo].[Stocks]
    ([Margin_ProductID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------