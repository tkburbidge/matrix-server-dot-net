CREATE TABLE [dbo].[SentTransaction] (
    [SentTransactionId]	UNIQUEIDENTIFIER NOT NULL,
    [TransactionId]		UNIQUEIDENTIFIER NOT NULL,
    [Destination]		NVARCHAR (MAX)   NULL,
	[ResponseCode]		INT				 NOT NULL,
	[ResponseJson]		NVARCHAR(MAX)	 NULL,
	[Timestamp]			DATETIME		 NOT NULL,
    CONSTRAINT [PK_SentTransaction] PRIMARY KEY CLUSTERED ([SentTransactionId] ASC)
);

