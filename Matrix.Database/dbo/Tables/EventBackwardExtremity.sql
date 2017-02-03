CREATE TABLE [dbo].[EventBackwardExtremity] (
    [EventBackwardExtremityId]	UNIQUEIDENTIFIER NOT NULL,
    [EventId]					UNIQUEIDENTIFIER NOT NULL,
    [RoomId]					UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_EventBackwardExtremity] PRIMARY KEY CLUSTERED ([EventBackwardExtremityId] ASC)
);

