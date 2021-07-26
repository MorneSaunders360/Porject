
CREATE PROCEDURE [dbo].[PortalDeviceUsageProc]
	@Time int = 0,
	@PortalDeviceId int
AS
	IF (@Time=1)
	BEGIN
		Select Id,PortalDeviceId,Temps,ROUND(REPLACE([Power], ',', '.'), 0)'Power',dateadd(MINUTE, datediff(MINUTE, 0, [WhenCreated]), 0) 'WhenCreated' from [PortalDeviceUsage]
                                        Where Id in
                                        (
                                        SELECT Top 10
                                        MAX(Id) as Id
                                        FROM [PortalDeviceUsage]
                                        Where[PortalDeviceId] =@PortalDeviceId
                                        GROUP BY dateadd(MINUTE, datediff(MINUTE, 0, [WhenCreated]), 0)
                                        ORDER BY MAX(Id) DESC
                                        )
                                        ORDER BY Id DESC
	END
	ELSE IF (@Time=2)
	BEGIN
		Select Id,PortalDeviceId,Temps,ROUND(REPLACE([Power], ',', '.'), 0)'Power',dateadd(hour, datediff(hour, 0, [WhenCreated]), 0) 'WhenCreated' from [PortalDeviceUsage]
                                        Where Id in
                                        (
                                        SELECT Top 10
                                        MAX(Id) as Id
                                        FROM [PortalDeviceUsage]
                                        Where[PortalDeviceId] =@PortalDeviceId
                                        GROUP BY dateadd(hour, datediff(hour, 0, [WhenCreated]), 0)
                                        ORDER BY MAX(Id) DESC
                                        )
                                        ORDER BY Id DESC
	END
	ELSE IF (@Time=3)
	BEGIN
		Select Id,PortalDeviceId,Temps,ROUND(REPLACE([Power], ',', '.'), 0)'Power',dateadd(DAY, datediff(DAY, 0, [WhenCreated]), 0) 'WhenCreated' from [PortalDeviceUsage]
                                        Where Id in
                                        (
                                        SELECT Top 10
                                        MAX(Id) as Id
                                        FROM [PortalDeviceUsage]
                                        Where[PortalDeviceId] =@PortalDeviceId
                                        GROUP BY dateadd(DAY, datediff(DAY, 0, [WhenCreated]), 0)
                                        ORDER BY MAX(Id) DESC
                                        )
                                        ORDER BY Id DESC
	END
