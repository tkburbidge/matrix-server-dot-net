﻿CREATE TABLE [dbo].[StateEvent] (
    [StateEventId]		UNIQUEIDENTIFIER NOT NULL,
    [EventId]			UNIQUEIDENTIFIER NOT NULL,
    [RoomId]			UNIQUEIDENTIFIER NOT NULL,
	[Type]				NVARCHAR(MAX)	 NOT NULL,
	[StateKey]			NVARCHAR(MAX)	 NOT NULL,
	[PrevState]			NVARCHAR(MAX)	 NULL,
    CONSTRAINT [PK_StateEvent] PRIMARY KEY CLUSTERED ([StateEventId] ASC)
);
