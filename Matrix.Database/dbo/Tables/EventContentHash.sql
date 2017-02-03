CREATE TABLE [dbo].[EventContentHash] (
    [EventContentHashId]    UNIQUEIDENTIFIER NOT NULL,
    [EventId]				UNIQUEIDENTIFIER NULL,
    [Algorithm]				NVARCHAR(MAX)    NULL,
	[Hash]					VARBINARY(MAX)   NULL
    CONSTRAINT [PK_EventContentHash] PRIMARY KEY CLUSTERED ([EventContentHashId] ASC)
);

