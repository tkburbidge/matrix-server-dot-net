CREATE TABLE [dbo].[Event] (
    [EventId]				UNIQUEIDENTIFIER NOT NULL,
	[StreamOrdering]		INT				 NOT NULL,
	[TopologicalOrdering]	BIGINT			 NOT NULL,
	[Type]					NVARCHAR(MAX)    NOT NULL,
	[RoomId]				UNIQUEIDENTIFIER NOT NULL,
	[Content]				NVARCHAR(MAX)    NOT NULL,
	[UnrecognizedKeys]		NVARCHAR(MAX)    NULL,
	[IsProcessed]			BIT				 NOT NULL,
	[IsOutlier]				BIT				 NOT NULL,
	[Depth]					BIGINT           NOT NULL,
    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([EventId] ASC)
);

