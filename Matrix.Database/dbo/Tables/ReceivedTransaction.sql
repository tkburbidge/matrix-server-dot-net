CREATE TABLE [dbo].[ReceivedTransaction] (
    [ReceivedTransactionId]	UNIQUEIDENTIFIER NOT NULL,
    [TransactionId]			UNIQUEIDENTIFIER NULL,
    [Origin]				NVARCHAR (MAX)   NULL,
	[Ts]					BIGINT			 NULL,
	[ResponseCode]			INT				 NULL,
	[ResponseJson]			VARBINARY(MAX)	 NULL,
	[HasBeenReferenced]		BIT				 NOT NULL,
    CONSTRAINT [PK_ReceivedTransaction] PRIMARY KEY CLUSTERED ([ReceivedTransactionId] ASC)
);

