CREATE TABLE [dbo].[PortalDevice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ParentPortalDeviceId] INT NULL, 
    [Name] VARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [DeviceGIUD] VARCHAR(MAX) NULL, 
    [Active] BIT NULL, 
    [Restart] BIT NULL, 
    [Shutdown] BIT NULL, 
    [LastActiveTime] DATETIME NULL, 
    [Temp] VARCHAR(50) NULL, 
   
)
