CREATE TABLE [dbo].[PresenceAllowInbound] (
    [PresenceAllowInboundId]	UNIQUEIDENTIFIER NOT NULL,
    [ObservedUserId]			UNIQUEIDENTIFIER NOT NULL,
    [ObserverUserId]			UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PresenceAllowInbound] PRIMARY KEY CLUSTERED ([PresenceAllowInboundId] ASC)
);

