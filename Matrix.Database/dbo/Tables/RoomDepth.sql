CREATE TABLE [dbo].[RoomDepth] (
    [RoomDepthId]       UNIQUEIDENTIFIER NOT NULL,
    [RoomId]			UNIQUEIDENTIFIER NOT NULL,
	[MinDepth]			INT				 NOT NULL,
    CONSTRAINT [PK_RoomDepth] PRIMARY KEY CLUSTERED ([RoomDepthId] ASC)
);

