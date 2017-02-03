CREATE TABLE [dbo].[EventForwardExtremity] (
    [EventForwardExtremityId]	UNIQUEIDENTIFIER NOT NULL,
    [EventId]					UNIQUEIDENTIFIER NOT NULL,
    [RoomId]					UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_EventForwardExtremity] PRIMARY KEY CLUSTERED ([EventForwardExtremityId] ASC)
);

