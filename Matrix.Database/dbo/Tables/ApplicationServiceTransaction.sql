CREATE TABLE [dbo].[ApplicationServiceTransaction] (
    [ApplicationServiceTransactionId]	UNIQUEIDENTIFIER NOT NULL,
    [ApplicationServiceId]				UNIQUEIDENTIFIER NOT NULL,
    [TransactionId]						UNIQUEIDENTIFIER NOT NULL,
    [EventIds]							NVARCHAR(MAX)    NOT NULL,
    CONSTRAINT [PK_ApplicationServiceTransaction] PRIMARY KEY CLUSTERED ([ApplicationServiceTransactionId] ASC)
);

