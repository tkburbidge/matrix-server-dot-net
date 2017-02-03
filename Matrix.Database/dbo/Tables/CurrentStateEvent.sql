CREATE TABLE [dbo].[CurrentStateEvent] (
    [CurrentStateEventId]	UNIQUEIDENTIFIER NOT NULL,
    [EventId]				UNIQUEIDENTIFIER NOT NULL,
    [RoomId]				UNIQUEIDENTIFIER NOT NULL,
	[Type]					NVARCHAR(MAX)	 NOT NULL,
	[StateKey]				NVARCHAR(MAX)	 NOT NULL,
    CONSTRAINT [PK_CurrentStateEvent] PRIMARY KEY CLUSTERED ([CurrentStateEventId] ASC)
);

