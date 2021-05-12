CREATE TABLE [dbo].[PortalSettings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Value] VARCHAR(50) NULL, 
    [SoftDelete] BIT NULL
)
