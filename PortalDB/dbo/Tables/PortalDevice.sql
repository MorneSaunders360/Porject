CREATE TABLE [dbo].[PortalDevice]
(
	[PortalDeviceId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [DeviceGIUD] VARCHAR(MAX) NULL, 
    [Active] BIT NULL, 
    [LastActiveTime] DATETIME NULL, 
)
