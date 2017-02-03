CREATE TABLE [dbo].[UserIp] (
    [UserIpId]     	UNIQUEIDENTIFIER NOT NULL,
    [UserId]      	UNIQUEIDENTIFIER NOT NULL,
    [AccessTokenId] UNIQUEIDENTIFIER NOT NULL,
    [DeviceId]     	NVARCHAR (MAX)   NULL,
    [Ip]     		NVARCHAR (MAX)   NOT NULL,
    [UserAgent]     NVARCHAR (MAX)   NOT NULL,
    [LastSeen]  	BIGINT         	 NOT NULL,
    CONSTRAINT [PK_UserIp] PRIMARY KEY CLUSTERED ([UserIpId] ASC)
);

