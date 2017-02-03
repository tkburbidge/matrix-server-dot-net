﻿CREATE TABLE [dbo].[Room] (
    [RoomId]	UNIQUEIDENTIFIER NOT NULL,
	[IsPublic]	BIT				 NOT NULL,
	[CreatorUserId]	UNIQUEIDENTIFIER	 NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([RoomId] ASC)
);

