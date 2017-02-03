CREATE TABLE [dbo].[EventEdgeHash] (
    [EventEdgeHashId]		UNIQUEIDENTIFIER NOT NULL,
	[EventId]				UNIQUEIDENTIFIER NOT NULL,
	[PreviousEventId]		UNIQUEIDENTIFIER NULL,
	[Algorithm]				NVARCHAR(MAX)    NULL,
	[Hash]					VARBINARY(MAX)   NULL,
    CONSTRAINT [PK_EventEdgeHash] PRIMARY KEY CLUSTERED ([EventEdgeHashId] ASC)
);

