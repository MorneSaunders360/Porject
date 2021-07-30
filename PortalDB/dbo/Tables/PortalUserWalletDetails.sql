CREATE TABLE [dbo].[PortalUserWalletDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PortalUserId] INT NULL, 
    [Currency] VARCHAR(50) NULL, 
    [CurrencyValue] NVARCHAR(50) NULL, 
    [DateCreated] DATETIME NULL
)
