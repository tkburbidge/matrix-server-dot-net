CREATE TABLE [dbo].[PresenceList] (
    [PresenceListId]	UNIQUEIDENTIFIER NOT NULL,
	[UserId]			UNIQUEIDENTIFIER NOT NULL,
	[ObservedUserId]	UNIQUEIDENTIFIER NOT NULL,
	[Accepted]			BIT				 NOT NULL,
    CONSTRAINT [PK_PresenceList] PRIMARY KEY CLUSTERED ([PresenceListId] ASC)
);

