CREATE TABLE [dbo].[AccessToken] (
    [AccessTokenId] UNIQUEIDENTIFIER NOT NULL,
    [UserId]       	UNIQUEIDENTIFIER NOT NULL,
    [DeviceId]     	UNIQUEIDENTIFIER NULL,
    [Token]		 	NVARCHAR (MAX)   NOT NULL,
    [LastUsed]  	BIGINT         	 NOT NULL,
    CONSTRAINT [PK_AccessToken] PRIMARY KEY CLUSTERED ([AccessTokenId] ASC)
);

