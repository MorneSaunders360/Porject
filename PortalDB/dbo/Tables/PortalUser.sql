CREATE TABLE [dbo].[PortalUser]
(
	[PortalUserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [AspNetId] VARCHAR(50) NULL
)
