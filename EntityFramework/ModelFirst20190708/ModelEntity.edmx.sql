
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/08/2019 17:49:30
-- Generated from EDMX file: C:\Users\Administrator\Desktop\Git\EntityFramework\ModelFirst20190708\ModelEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Test];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArrangeCourseStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArrangeCourseSet] DROP CONSTRAINT [FK_ArrangeCourseStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_ArrangeCourseTeacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArrangeCourseSet] DROP CONSTRAINT [FK_ArrangeCourseTeacher];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TeacherSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherSet];
GO
IF OBJECT_ID(N'[dbo].[StudentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentSet];
GO
IF OBJECT_ID(N'[dbo].[ArrangeCourseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArrangeCourseSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TeacherSet'
CREATE TABLE [dbo].[TeacherSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StudentSet'
CREATE TABLE [dbo].[StudentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ArrangeCourseSet'
CREATE TABLE [dbo].[ArrangeCourseSet] (
    [ArrangeCourseId] int IDENTITY(1,1) NOT NULL,
    [StudentId] int  NOT NULL,
    [TeacherId] int  NOT NULL,
    [CourseId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TeacherSet'
ALTER TABLE [dbo].[TeacherSet]
ADD CONSTRAINT [PK_TeacherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [PK_StudentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ArrangeCourseId] in table 'ArrangeCourseSet'
ALTER TABLE [dbo].[ArrangeCourseSet]
ADD CONSTRAINT [PK_ArrangeCourseSet]
    PRIMARY KEY CLUSTERED ([ArrangeCourseId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentId] in table 'ArrangeCourseSet'
ALTER TABLE [dbo].[ArrangeCourseSet]
ADD CONSTRAINT [FK_ArrangeCourseStudent]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[StudentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArrangeCourseStudent'
CREATE INDEX [IX_FK_ArrangeCourseStudent]
ON [dbo].[ArrangeCourseSet]
    ([StudentId]);
GO

-- Creating foreign key on [TeacherId] in table 'ArrangeCourseSet'
ALTER TABLE [dbo].[ArrangeCourseSet]
ADD CONSTRAINT [FK_ArrangeCourseTeacher]
    FOREIGN KEY ([TeacherId])
    REFERENCES [dbo].[TeacherSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArrangeCourseTeacher'
CREATE INDEX [IX_FK_ArrangeCourseTeacher]
ON [dbo].[ArrangeCourseSet]
    ([TeacherId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------