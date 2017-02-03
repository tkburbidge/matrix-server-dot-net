CREATE TABLE [dbo].[EventToStateGroup] (
    [EventToStateGroupId]	UNIQUEIDENTIFIER NOT NULL,
    [EventId]				UNIQUEIDENTIFIER NOT NULL,
    [StateGroupId]			UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_EventToStateGroup] PRIMARY KEY CLUSTERED ([EventToStateGroupId] ASC)
);

