
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/06/2018 10:18:10
-- Generated from EDMX file: D:\HomeProject\Project.DotNet\Webapi\Third\Sunxsh.Jdcat.Api\MyEntityTest\Data1\Shiren.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Shiren];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MeterPoem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Poem] DROP CONSTRAINT [FK_MeterPoem];
GO
IF OBJECT_ID(N'[dbo].[FK_PoemPoet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Poem] DROP CONSTRAINT [FK_PoemPoet];
GO
IF OBJECT_ID(N'[dbo].[FK_AlbumArtist_Album]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlbumArtist] DROP CONSTRAINT [FK_AlbumArtist_Album];
GO
IF OBJECT_ID(N'[dbo].[FK_AlbumArtist_Artist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlbumArtist] DROP CONSTRAINT [FK_AlbumArtist_Artist];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderOrderItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [FK_OrderOrderItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemOrderItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [FK_ItemOrderItem];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Poem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Poem];
GO
IF OBJECT_ID(N'[dbo].[Poet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Poet];
GO
IF OBJECT_ID(N'[dbo].[Meter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Meter];
GO
IF OBJECT_ID(N'[dbo].[Album]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Album];
GO
IF OBJECT_ID(N'[dbo].[Artist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Artist];
GO
IF OBJECT_ID(N'[dbo].[Order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Order];
GO
IF OBJECT_ID(N'[dbo].[Item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Item];
GO
IF OBJECT_ID(N'[dbo].[OrderItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderItem];
GO
IF OBJECT_ID(N'[dbo].[AlbumArtist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlbumArtist];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Poem'
CREATE TABLE [dbo].[Poem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [MeterId] int  NOT NULL,
    [PoetId] int  NOT NULL
);
GO

-- Creating table 'Poet'
CREATE TABLE [dbo].[Poet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Meter'
CREATE TABLE [dbo].[Meter] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Album'
CREATE TABLE [dbo].[Album] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Artist'
CREATE TABLE [dbo].[Artist] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Order'
CREATE TABLE [dbo].[Order] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Time] datetime  NOT NULL,
    [Customer] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Item'
CREATE TABLE [dbo].[Item] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderItem'
CREATE TABLE [dbo].[OrderItem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderId] int  NOT NULL,
    [ItemId] int  NOT NULL,
    [Count] int  NOT NULL
);
GO

-- Creating table 'AlbumArtist'
CREATE TABLE [dbo].[AlbumArtist] (
    [Albums_Id] int  NOT NULL,
    [Artists_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Poem'
ALTER TABLE [dbo].[Poem]
ADD CONSTRAINT [PK_Poem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Poet'
ALTER TABLE [dbo].[Poet]
ADD CONSTRAINT [PK_Poet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Meter'
ALTER TABLE [dbo].[Meter]
ADD CONSTRAINT [PK_Meter]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Album'
ALTER TABLE [dbo].[Album]
ADD CONSTRAINT [PK_Album]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Artist'
ALTER TABLE [dbo].[Artist]
ADD CONSTRAINT [PK_Artist]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Order'
ALTER TABLE [dbo].[Order]
ADD CONSTRAINT [PK_Order]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Item'
ALTER TABLE [dbo].[Item]
ADD CONSTRAINT [PK_Item]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderItem'
ALTER TABLE [dbo].[OrderItem]
ADD CONSTRAINT [PK_OrderItem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Albums_Id], [Artists_Id] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [PK_AlbumArtist]
    PRIMARY KEY CLUSTERED ([Albums_Id], [Artists_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MeterId] in table 'Poem'
ALTER TABLE [dbo].[Poem]
ADD CONSTRAINT [FK_MeterPoem]
    FOREIGN KEY ([MeterId])
    REFERENCES [dbo].[Meter]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MeterPoem'
CREATE INDEX [IX_FK_MeterPoem]
ON [dbo].[Poem]
    ([MeterId]);
GO

-- Creating foreign key on [PoetId] in table 'Poem'
ALTER TABLE [dbo].[Poem]
ADD CONSTRAINT [FK_PoemPoet]
    FOREIGN KEY ([PoetId])
    REFERENCES [dbo].[Poet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PoemPoet'
CREATE INDEX [IX_FK_PoemPoet]
ON [dbo].[Poem]
    ([PoetId]);
GO

-- Creating foreign key on [Albums_Id] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [FK_AlbumArtist_Album]
    FOREIGN KEY ([Albums_Id])
    REFERENCES [dbo].[Album]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Artists_Id] in table 'AlbumArtist'
ALTER TABLE [dbo].[AlbumArtist]
ADD CONSTRAINT [FK_AlbumArtist_Artist]
    FOREIGN KEY ([Artists_Id])
    REFERENCES [dbo].[Artist]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbumArtist_Artist'
CREATE INDEX [IX_FK_AlbumArtist_Artist]
ON [dbo].[AlbumArtist]
    ([Artists_Id]);
GO

-- Creating foreign key on [OrderId] in table 'OrderItem'
ALTER TABLE [dbo].[OrderItem]
ADD CONSTRAINT [FK_OrderOrderItem]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Order]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderOrderItem'
CREATE INDEX [IX_FK_OrderOrderItem]
ON [dbo].[OrderItem]
    ([OrderId]);
GO

-- Creating foreign key on [ItemId] in table 'OrderItem'
ALTER TABLE [dbo].[OrderItem]
ADD CONSTRAINT [FK_ItemOrderItem]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Item]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemOrderItem'
CREATE INDEX [IX_FK_ItemOrderItem]
ON [dbo].[OrderItem]
    ([ItemId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------