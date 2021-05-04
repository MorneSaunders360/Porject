CREATE TABLE [dbo].[PortalUserOrganization]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [PortalUserId] INT NULL
)
