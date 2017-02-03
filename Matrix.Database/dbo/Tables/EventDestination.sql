CREATE TABLE [dbo].[EventDestination] (
    [EventDestinationId]    UNIQUEIDENTIFIER NOT NULL,
    [EventId]				UNIQUEIDENTIFIER NOT NULL,
	[DestinationId]			UNIQUEIDENTIFIER NOT NULL,
	[DeliveredTimestamp]	DATETIME         NULL,
    CONSTRAINT [PK_EventDestination] PRIMARY KEY CLUSTERED ([EventDestinationId] ASC)
);

