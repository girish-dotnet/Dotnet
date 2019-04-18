
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/15/2016 15:13:00
-- Generated from EDMX file: D:\My Data\ELTP Contents\LINQ and Entity Framework\Demos\Example3\ModelFirstApproachEx\ModelFirstApproachEx\FlightModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FlightDatabase];
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

-- Creating table 'Flights'
CREATE TABLE [dbo].[Flights] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FlightNumber] nvarchar(max)  NOT NULL,
    [DepartureDate] nvarchar(max)  NOT NULL,
    [Airline] nvarchar(max)  NOT NULL,
    [Origin] nvarchar(max)  NOT NULL,
    [Destination] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Flights'
ALTER TABLE [dbo].[Flights]
ADD CONSTRAINT [PK_Flights]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------