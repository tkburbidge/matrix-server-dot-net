CREATE TABLE [dbo].[Destination] (
    [DestinationId]	UNIQUEIDENTIFIER NOT NULL,
    [Destination]	NVARCHAR (MAX)   NOT NULL,
	[RetryLastTs]	BIGINT			 NULL,
	[RetryInterval]	INT				 NULL,
    CONSTRAINT [PK_Destination] PRIMARY KEY CLUSTERED ([DestinationId] ASC)
);

