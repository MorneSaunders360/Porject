﻿/*
Deployment script for aspnet-Portal-72DFF22E-558C-46C0-A5D5-28AD00684240

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "aspnet-Portal-72DFF22E-558C-46C0-A5D5-28AD00684240"
:setvar DefaultFilePrefix "aspnet-Portal-72DFF22E-558C-46C0-A5D5-28AD00684240"
:setvar DefaultDataPath "C:\Users\morne\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\"
:setvar DefaultLogPath "C:\Users\morne\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Starting rebuilding table [dbo].[PortalDevice]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_PortalDevice] (
    [PortalDeviceId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50)  NULL,
    [Description]    VARCHAR (50)  NULL,
    [DeviceGIUD]     VARCHAR (MAX) NULL,
    [Active]         BIT           NULL,
    [ErrorMail]      BIT           NULL,
    [LastActiveTime] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([PortalDeviceId] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[PortalDevice])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_PortalDevice] ON;
        INSERT INTO [dbo].[tmp_ms_xx_PortalDevice] ([PortalDeviceId], [Name], [Description], [DeviceGIUD], [Active], [LastActiveTime])
        SELECT   [PortalDeviceId],
                 [Name],
                 [Description],
                 [DeviceGIUD],
                 [Active],
                 [LastActiveTime]
        FROM     [dbo].[PortalDevice]
        ORDER BY [PortalDeviceId] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_PortalDevice] OFF;
    END

DROP TABLE [dbo].[PortalDevice];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_PortalDevice]', N'PortalDevice';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Update complete.';


GO
