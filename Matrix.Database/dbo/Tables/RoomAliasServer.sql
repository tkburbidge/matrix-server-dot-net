CREATE TABLE [dbo].[RoomAliasServer] (
    [RoomAliasServerId]	UNIQUEIDENTIFIER NOT NULL,
    [RoomAliasId]		UNIQUEIDENTIFIER NOT NULL,
    [Server]			NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_RoomAliasServer] PRIMARY KEY CLUSTERED ([RoomAliasServerId] ASC)
);

