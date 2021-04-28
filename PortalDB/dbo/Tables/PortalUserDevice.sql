CREATE TABLE [dbo].[PortalUserDevice]
(
	[PortalUserDeviceId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PortalDeviceId] INT NULL, 
    [PortalUserId] INT NULL
)
