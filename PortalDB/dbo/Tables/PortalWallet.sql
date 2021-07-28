CREATE TABLE [dbo].[PortalWallet]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL,
    [Secret] VARCHAR(50) NULL, 
    [AccessKey] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NULL
)
