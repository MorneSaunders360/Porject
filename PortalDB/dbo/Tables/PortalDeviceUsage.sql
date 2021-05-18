CREATE TABLE [dbo].[PortalDeviceUsage]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PortalDeviceId] INT NULL,
    [Temps] VARCHAR(50) NULL, 
    [Power] VARCHAR(50) NULL, 
    [WhenCreated] DATETIME NULL, 
)
