CREATE TABLE [dbo].[Redaction] (
    [RedactionId]	UNIQUEIDENTIFIER NOT NULL,
    [EventId]		UNIQUEIDENTIFIER NOT NULL,
    [Redacts]		NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_Redaction] PRIMARY KEY CLUSTERED ([RedactionId] ASC)
);

