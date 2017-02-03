CREATE TABLE [dbo].[ApplicationServiceState] (
    [ApplicationServiceStateId]	UNIQUEIDENTIFIER NOT NULL,
    [ApplicationServiceId]		UNIQUEIDENTIFIER NOT NULL,
	[State]     				NVARCHAR (5)   NULL,
    CONSTRAINT [PK_ApplicationServiceState] PRIMARY KEY CLUSTERED ([ApplicationServiceStateId] ASC)
);

