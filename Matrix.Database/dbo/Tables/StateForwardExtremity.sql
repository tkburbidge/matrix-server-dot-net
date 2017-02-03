CREATE TABLE [dbo].[StateForwardExtremity] (
    [StateForwardExtremityId]   UNIQUEIDENTIFIER NOT NULL,
    [EventId]					UNIQUEIDENTIFIER NOT NULL,
	[RoomId] 					UNIQUEIDENTIFIER NOT NULL,
	[Type]						NVARCHAR(MAX)    NOT NULL,
	[StateKey]					NVARCHAR(MAX)    NOT NULL,
    CONSTRAINT [PK_StateForwardExtremity] PRIMARY KEY CLUSTERED ([StateForwardExtremityId] ASC)
);

