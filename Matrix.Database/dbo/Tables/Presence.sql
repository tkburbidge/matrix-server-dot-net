CREATE TABLE [dbo].[Presence] (
    [PresenceId]	UNIQUEIDENTIFIER NOT NULL,
    [UserId]		UNIQUEIDENTIFIER NOT NULL,
    [State]			NVARCHAR (20)    NULL,
	[StatusMsg]		NVARCHAR(max)	 NULL,
	[Mtime]			DATETIME		 NULL,
    CONSTRAINT [PK_Presence] PRIMARY KEY CLUSTERED ([PresenceId] ASC)
);

