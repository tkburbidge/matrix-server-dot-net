CREATE TABLE [dbo].[SentTransaction] (
    [SentTransactionId]	UNIQUEIDENTIFIER NOT NULL,
    [TransactionId]		UNIQUEIDENTIFIER NULL,
    [Destination]		NVARCHAR (MAX)   NULL,
	[ResponseCode]		INT				 NOT NULL,
	[ResponseJson]		NVARCHAR(MAX)	 NULL,
	[Ts]				BIGINT			 NULL,
    CONSTRAINT [PK_SentTransaction] PRIMARY KEY CLUSTERED ([SentTransactionId] ASC)
);

