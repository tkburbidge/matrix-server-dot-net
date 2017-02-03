CREATE TABLE [dbo].[EventSignature] (
    [EventSignatureId]      UNIQUEIDENTIFIER NOT NULL,
	[EventId]				UNIQUEIDENTIFIER NOT NULL,
	[SignatureName]			NVARCHAR(MAX)	 NULL,
	[KeyId]					UNIQUEIDENTIFIER NULL,
	[Signature]				VARBINARY(MAX)	 NULL,
    CONSTRAINT [PK_EventSignature] PRIMARY KEY CLUSTERED ([EventSignatureId] ASC)
);

