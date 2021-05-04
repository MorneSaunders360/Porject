CREATE TABLE [dbo].[PortalNotification]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Description ] VARCHAR(50) NULL, 
    [PortalUserId] INT NULL, 
    [SoftDelete] BIT NULL, 
    [NotificationTypeId] INT NULL, 
    [PortalDeviceId] INT NULL
)
