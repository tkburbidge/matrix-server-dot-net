CREATE TABLE [dbo].[ApplicationServiceRegex] (
    [ApplicationServiceRegexId]	UNIQUEIDENTIFIER NOT NULL,
    [ApplicationServiceId]		UNIQUEIDENTIFIER NOT NULL,
	[Namespace]     			INT	   			 NULL,
	[Regex]     				NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_ApplicationServiceRegex] PRIMARY KEY CLUSTERED ([ApplicationServiceRegexId] ASC)
);

