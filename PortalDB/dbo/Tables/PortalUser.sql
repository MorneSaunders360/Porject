CREATE TABLE [dbo].[PortalUser]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [AspNetId] VARCHAR(50) NULL, 
    [AllowNotifications] BIT NULL
)
