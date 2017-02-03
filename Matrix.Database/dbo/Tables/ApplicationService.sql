CREATE TABLE [dbo].[ApplicationService] (
    [ApplicationServiceId]	UNIQUEIDENTIFIER NOT NULL,
	[Url]     				NVARCHAR (MAX)   NULL,
	[Token]     			NVARCHAR (MAX)   NULL,
	[HsToken]     			NVARCHAR (MAX)   NULL,
	[Sender]     			NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_ApplicationService] PRIMARY KEY CLUSTERED ([ApplicationServiceId] ASC)
);

