CREATE TABLE [dbo].[TransactionIdToPdu] (
    [TransactionIdToPduId]	UNIQUEIDENTIFIER NOT NULL,
    [TransactionId]			UNIQUEIDENTIFIER NOT NULL,
    [Destination]			NVARCHAR (MAX)   NOT NULL,
    [PduId]					UNIQUEIDENTIFIER NOT NULL,
    [PduOrigin]				NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_TransactionIdToPdu] PRIMARY KEY CLUSTERED ([TransactionIdToPduId] ASC)
);

