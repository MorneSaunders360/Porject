/*
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
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Rename refactoring operation with key f7d21dfb-bfe4-4331-8414-6ff2f74630de is skipped, element [dbo].[PortalUser].[Id] (SqlSimpleColumn) will not be renamed to PortalUserId';


GO
PRINT N'Creating Table [dbo].[PortalUser]...';


GO
CREATE TABLE [dbo].[PortalUser] (
    [PortalUserId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (50)   NULL,
    [Email]        VARBINARY (50) NULL,
    [AspNetId]     VARCHAR (50)   NULL,
    PRIMARY KEY CLUSTERED ([PortalUserId] ASC)
);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f7d21dfb-bfe4-4331-8414-6ff2f74630de')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f7d21dfb-bfe4-4331-8414-6ff2f74630de')

GO

GO
PRINT N'Update complete.';


GO
