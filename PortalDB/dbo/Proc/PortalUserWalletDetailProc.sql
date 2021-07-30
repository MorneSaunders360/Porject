CREATE PROCEDURE [dbo].[PortalUserWalletDetailProc]
	@PortalUserId int
AS
BEGIN
  Select * from [dbo].[PortalUserWalletDetails]
	where dateadd(MINUTE, datediff(MINUTE, 0, [DateCreated]), 0) =  
	(
	  Select top 1 dateadd(MINUTE, datediff(MINUTE, 0, [DateCreated]), 0) 'DateCreated' from [dbo].[PortalUserWalletDetails]
  where Id in (
  	SELECT MAX(Id) as Id
	  FROM [dbo].[PortalUserWalletDetails]
	  Where [PortalUserId] = @PortalUserId
	  Group by [Currency]
  )
    GROUP BY dateadd(MINUTE, datediff(MINUTE, 0, [DateCreated]), 0)
	order by [DateCreated] desc
	)
END

