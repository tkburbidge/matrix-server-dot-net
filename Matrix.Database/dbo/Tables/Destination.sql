CREATE TABLE [dbo].[Destination] (
    [DestinationId]			UNIQUEIDENTIFIER NOT NULL,
    [DestinationName]		NVARCHAR (MAX)   NOT NULL,
	[RetryLastTimestamp]	DATETIME		 NULL,
	[RetryInterval]			INT				 NULL,
    CONSTRAINT [PK_Destination] PRIMARY KEY CLUSTERED ([DestinationId] ASC)
);

