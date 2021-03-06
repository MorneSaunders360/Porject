
CREATE PROCEDURE [dbo].[PortalDeviceUsageProc]
	@Time int = 0,
	@PortalDeviceId int
AS
	IF (@Time=1)
	BEGIN
 Select * from  [PortalDeviceUsage]
				   Where Id in 
				   (
				   			    SELECT Top 10
												MAX(PDU1.Id)
												FROM [PortalDeviceUsage] PDU
												LEFT JOIN [PortalDeviceUsage] PDU1 on PDU1.Id =  PDU.Id
											    Where PDU.[PortalDeviceId] =@PortalDeviceId
												GROUP BY dateadd(MINUTE, datediff(MINUTE, 0, PDU.[WhenCreated]), 0)
												ORDER BY dateadd(MINUTE, datediff(MINUTE, 0, PDU.[WhenCreated]), 0) DESC

				   )
	END
	ELSE IF (@Time=2)
	BEGIN
	 Select * from  [PortalDeviceUsage]
				   Where Id in 
				   (
				   			    SELECT Top 10
												MAX(PDU1.Id)
												FROM [PortalDeviceUsage] PDU
												LEFT JOIN [PortalDeviceUsage] PDU1 on PDU1.Id =  PDU.Id
											    Where PDU.[PortalDeviceId] =@PortalDeviceId
												GROUP BY dateadd(hour, datediff(hour, 0, PDU.[WhenCreated]), 0)
												ORDER BY dateadd(hour, datediff(hour, 0, PDU.[WhenCreated]), 0) DESC

				   )


	
	END
	ELSE IF (@Time=3)
	BEGIN
	 Select * from  [PortalDeviceUsage]
				   Where Id in 
				   (
				   			    SELECT Top 10
												MAX(PDU1.Id)
												FROM [PortalDeviceUsage] PDU
												LEFT JOIN [PortalDeviceUsage] PDU1 on PDU1.Id =  PDU.Id
											    Where PDU.[PortalDeviceId] =@PortalDeviceId
												GROUP BY dateadd(DAY, datediff(DAY, 0, PDU.[WhenCreated]), 0)
												ORDER BY dateadd(DAY, datediff(DAY, 0, PDU.[WhenCreated]), 0) DESC

				   )

	END

		
