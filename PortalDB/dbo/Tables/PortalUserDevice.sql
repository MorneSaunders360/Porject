CREATE TABLE [dbo].[PortalUserDevice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PortalDeviceId] INT NULL, 
    [PortalUserId] INT NULL,
    [SoftDelete] BIT NULL DEFAULT 0, 
)
