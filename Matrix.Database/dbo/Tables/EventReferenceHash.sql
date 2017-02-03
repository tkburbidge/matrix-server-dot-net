CREATE TABLE [dbo].[EventReferenceHash] (
    [EventReferenceHashId]  UNIQUEIDENTIFIER NOT NULL,
	[EventId]				UNIQUEIDENTIFIER NOT NULL,
    [Algorithm]				NVARCHAR(MAX)    NULL,
	[Hash]					VARBINARY(MAX)   NULL
    CONSTRAINT [PK_EventReferenceHash] PRIMARY KEY CLUSTERED ([EventReferenceHashId] ASC)
);

