CREATE TABLE [dbo].[Rejection] (
    [RejectionId]	UNIQUEIDENTIFIER NOT NULL,
	[EventId]		UNIQUEIDENTIFIER NOT NULL,
    [Reason]		NVARCHAR (MAX)   NOT NULL,
    [LastCheck]		NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_Rejection] PRIMARY KEY CLUSTERED ([RejectionId] ASC)
);

