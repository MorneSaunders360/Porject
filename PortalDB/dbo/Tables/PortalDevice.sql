CREATE TABLE [dbo].[PortalDevice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [DeviceGIUD] VARCHAR(MAX) NULL, 
    [Active] BIT NULL, 
    [ErrorMail] BIT NULL, 
    [LastActiveTime] DATETIME NULL, 
)
