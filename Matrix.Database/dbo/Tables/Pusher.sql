CREATE TABLE [dbo].[Pusher] (
    [PusherId]			UNIQUEIDENTIFIER NOT NULL,
    [Username]			NVARCHAR (MAX)   NOT NULL,
	[AccessToken]		BIGINT			 NULL,
	[ProfileTag]		NVARCHAR(32)	 NOT NULL,
	[Kind]				NVARCHAR(8)		 NOT NULL,
	[AppId]				UNIQUEIDENTIFIER NOT NULL,
	[AppDisplayName]	NVARCHAR(64)	 NOT NULL,
	[DeviceDisplayName]	NVARCHAR(128)	 NOT NULL,
	[Pushkey]			VARBINARY(MAX)	 NOT NULL,
	[Timestamp]			DATETIME		 NOT NULL,
	[Lang]				NVARCHAR(8)		 NULL,
	[Data]				VARBINARY(MAX)	 NULL,
	[LastToken]			NVARCHAR(MAX)	 NULL,
	[LastSuccess]		DATETIME		 NULL,
	[FailingSince]		DATETIME		 NULL,
    CONSTRAINT [PK_Pusher] PRIMARY KEY CLUSTERED ([PusherId] ASC)
);

