CREATE TABLE [dbo].[Presence] (
    [PresenceId]	UNIQUEIDENTIFIER NOT NULL,
    [UserId]		UNIQUEIDENTIFIER NOT NULL,
    [State]			NVARCHAR (20)    NULL,
	[StatusMsg]		nvarchar(max)	 NULL,
	[Mtime]			BIGINT			 NULL,
    CONSTRAINT [PK_Presence] PRIMARY KEY CLUSTERED ([PresenceId] ASC)
);

