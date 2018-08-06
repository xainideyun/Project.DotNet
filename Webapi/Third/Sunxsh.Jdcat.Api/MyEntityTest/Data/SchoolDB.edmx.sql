
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/05/2018 19:44:50
-- Generated from EDMX file: D:\HomeProject\Project.DotNet\Webapi\Third\Sunxsh.Jdcat.Api\MyEntityTest\Data\SchoolDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SchoolDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[Chapter2].[FK_Course_Teacher]', 'F') IS NOT NULL
    ALTER TABLE [Chapter2].[Course] DROP CONSTRAINT [FK_Course_Teacher];
GO
IF OBJECT_ID(N'[Chapter2].[FK_Teacher_Standard]', 'F') IS NOT NULL
    ALTER TABLE [Chapter2].[Teacher] DROP CONSTRAINT [FK_Teacher_Standard];
GO
IF OBJECT_ID(N'[Chapter2].[FK_StudentCourse_Course]', 'F') IS NOT NULL
    ALTER TABLE [Chapter2].[StudentCourse] DROP CONSTRAINT [FK_StudentCourse_Course];
GO
IF OBJECT_ID(N'[Chapter2].[FK_StudentCourse_Student]', 'F') IS NOT NULL
    ALTER TABLE [Chapter2].[StudentCourse] DROP CONSTRAINT [FK_StudentCourse_Student];
GO
IF OBJECT_ID(N'[Chapter2].[FK_Address_Student]', 'F') IS NOT NULL
    ALTER TABLE [Chapter2].[Address] DROP CONSTRAINT [FK_Address_Student];
GO
IF OBJECT_ID(N'[Chapter2].[FK_StudentStandard]', 'F') IS NOT NULL
    ALTER TABLE [Chapter2].[Student] DROP CONSTRAINT [FK_StudentStandard];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[Chapter2].[Course]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[Course];
GO
IF OBJECT_ID(N'[Chapter2].[Standard]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[Standard];
GO
IF OBJECT_ID(N'[Chapter2].[Student]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[Student];
GO
IF OBJECT_ID(N'[Chapter2].[Teacher]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[Teacher];
GO
IF OBJECT_ID(N'[Chapter2].[Address]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[Address];
GO
IF OBJECT_ID(N'[Chapter2].[StudentCourse]', 'U') IS NOT NULL
    DROP TABLE [Chapter2].[StudentCourse];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Course'
CREATE TABLE [dbo].[Course] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Location] nvarchar(50)  NULL,
    [TeacherId] int  NULL
);
GO

-- Creating table 'Standard'
CREATE TABLE [dbo].[Standard] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Description] nvarchar(200)  NULL
);
GO

-- Creating table 'Student'
CREATE TABLE [dbo].[Student] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [RowVersion] nvarchar(50)  NULL,
    [StandardID] int  NOT NULL
);
GO

-- Creating table 'Teacher'
CREATE TABLE [dbo].[Teacher] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [StandardId] int  NULL,
    [TearcherType] nvarchar(50)  NULL
);
GO

-- Creating table 'Address'
CREATE TABLE [dbo].[Address] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [StudentId] int  NULL,
    [Address1] nvarchar(50)  NULL,
    [Address2] nvarchar(50)  NULL,
    [City] nvarchar(50)  NULL,
    [State] nvarchar(50)  NULL
);
GO

-- Creating table 'StudentCourse'
CREATE TABLE [dbo].[StudentCourse] (
    [Course_ID] int  NOT NULL,
    [Students_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [PK_Course]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Standard'
ALTER TABLE [dbo].[Standard]
ADD CONSTRAINT [PK_Standard]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [PK_Student]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [PK_Teacher]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Address'
ALTER TABLE [dbo].[Address]
ADD CONSTRAINT [PK_Address]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Course_ID], [Students_ID] in table 'StudentCourse'
ALTER TABLE [dbo].[StudentCourse]
ADD CONSTRAINT [PK_StudentCourse]
    PRIMARY KEY CLUSTERED ([Course_ID], [Students_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TeacherId] in table 'Course'
ALTER TABLE [dbo].[Course]
ADD CONSTRAINT [FK_Course_Teacher]
    FOREIGN KEY ([TeacherId])
    REFERENCES [dbo].[Teacher]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Course_Teacher'
CREATE INDEX [IX_FK_Course_Teacher]
ON [dbo].[Course]
    ([TeacherId]);
GO

-- Creating foreign key on [StandardId] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [FK_Teacher_Standard]
    FOREIGN KEY ([StandardId])
    REFERENCES [dbo].[Standard]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Teacher_Standard'
CREATE INDEX [IX_FK_Teacher_Standard]
ON [dbo].[Teacher]
    ([StandardId]);
GO

-- Creating foreign key on [Course_ID] in table 'StudentCourse'
ALTER TABLE [dbo].[StudentCourse]
ADD CONSTRAINT [FK_StudentCourse_Course]
    FOREIGN KEY ([Course_ID])
    REFERENCES [dbo].[Course]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Students_ID] in table 'StudentCourse'
ALTER TABLE [dbo].[StudentCourse]
ADD CONSTRAINT [FK_StudentCourse_Student]
    FOREIGN KEY ([Students_ID])
    REFERENCES [dbo].[Student]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentCourse_Student'
CREATE INDEX [IX_FK_StudentCourse_Student]
ON [dbo].[StudentCourse]
    ([Students_ID]);
GO

-- Creating foreign key on [StudentId] in table 'Address'
ALTER TABLE [dbo].[Address]
ADD CONSTRAINT [FK_Address_Student]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Student]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Address_Student'
CREATE INDEX [IX_FK_Address_Student]
ON [dbo].[Address]
    ([StudentId]);
GO

-- Creating foreign key on [StandardID] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [FK_StudentStandard]
    FOREIGN KEY ([StandardID])
    REFERENCES [dbo].[Standard]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentStandard'
CREATE INDEX [IX_FK_StudentStandard]
ON [dbo].[Student]
    ([StandardID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------