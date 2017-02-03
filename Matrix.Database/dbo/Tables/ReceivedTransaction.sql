CREATE TABLE [dbo].[ReceivedTransaction] (
    [ReceivedTransactionId]	UNIQUEIDENTIFIER NOT NULL,
    [TransactionId]			UNIQUEIDENTIFIER NOT NULL,
    [Origin]				NVARCHAR (MAX)   NULL,
	[Timestamp]				DATETIME		 NOT NULL,
	[ResponseCode]			INT				 NULL,
	[ResponseJson]			VARBINARY(MAX)	 NULL,
	[HasBeenReferenced]		BIT				 NOT NULL,
    CONSTRAINT [PK_ReceivedTransaction] PRIMARY KEY CLUSTERED ([ReceivedTransactionId] ASC)
);

