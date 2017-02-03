CREATE TABLE [dbo].[EventDestination] (
    [EventDestinationId]    UNIQUEIDENTIFIER NOT NULL,
    [EventId]				UNIQUEIDENTIFIER NOT NULL,
	[DestinationId]			UNIQUEIDENTIFIER NOT NULL,
	[DeliveredTs]			BIGINT           NULL,
    CONSTRAINT [PK_EventDestination] PRIMARY KEY CLUSTERED ([EventDestinationId] ASC)
);

