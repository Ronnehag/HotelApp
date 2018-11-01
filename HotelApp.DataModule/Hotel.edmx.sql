
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/01/2018 11:03:05
-- Generated from EDMX file: C:\Users\ZAIBU\OneDrive\Skrivbord\CMS18\SQL\Inlämningsuppgifter\Hotel\HotelApp\HotelApp.DataModule\Hotel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Hotel];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Booking_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Booking] DROP CONSTRAINT [FK_Booking_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_Booking_Invoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Booking] DROP CONSTRAINT [FK_Booking_Invoice];
GO
IF OBJECT_ID(N'[dbo].[FK_Booking_Room]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Booking] DROP CONSTRAINT [FK_Booking_Room];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Booking]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Booking];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[Invoice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoice];
GO
IF OBJECT_ID(N'[dbo].[Room]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Room];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bookings'
CREATE TABLE [dbo].[Bookings] (
    [BookingId] int IDENTITY(1,1) NOT NULL,
    [IsValid] bit  NOT NULL,
    [DateBooked] datetime  NOT NULL,
    [CustomerId] int  NOT NULL,
    [RoomId] int  NOT NULL,
    [InvoiceId] int  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerId] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(50)  NOT NULL,
    [LastName] varchar(50)  NOT NULL,
    [Email] varchar(100)  NOT NULL,
    [Address] varchar(100)  NULL,
    [PostalCode] varchar(50)  NULL,
    [City] varchar(50)  NULL,
    [Country] varchar(50)  NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [InvoiceId] int IDENTITY(1,1) NOT NULL,
    [Amount] decimal(19,4)  NOT NULL,
    [IsPaid] bit  NOT NULL,
    [CustomerId] int  NOT NULL
);
GO

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [RoomId] int IDENTITY(1,1) NOT NULL,
    [RoomType] varchar(50)  NOT NULL,
    [Beds] int  NOT NULL,
    [ExtraBeds] int  NOT NULL,
    [PricePerNight] decimal(19,4)  NOT NULL,
    [BookedFrom] datetime  NULL,
    [BookedTo] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BookingId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [PK_Bookings]
    PRIMARY KEY CLUSTERED ([BookingId] ASC);
GO

-- Creating primary key on [CustomerId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- Creating primary key on [InvoiceId] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([InvoiceId] ASC);
GO

-- Creating primary key on [RoomId] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([RoomId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_Booking_Customer]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([CustomerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Booking_Customer'
CREATE INDEX [IX_FK_Booking_Customer]
ON [dbo].[Bookings]
    ([CustomerId]);
GO

-- Creating foreign key on [InvoiceId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_Booking_Invoice]
    FOREIGN KEY ([InvoiceId])
    REFERENCES [dbo].[Invoices]
        ([InvoiceId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Booking_Invoice'
CREATE INDEX [IX_FK_Booking_Invoice]
ON [dbo].[Bookings]
    ([InvoiceId]);
GO

-- Creating foreign key on [RoomId] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_Booking_Room]
    FOREIGN KEY ([RoomId])
    REFERENCES [dbo].[Rooms]
        ([RoomId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Booking_Room'
CREATE INDEX [IX_FK_Booking_Room]
ON [dbo].[Bookings]
    ([RoomId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------