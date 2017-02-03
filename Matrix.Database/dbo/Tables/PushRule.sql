CREATE TABLE [dbo].[PushRule] (
    [PushRuleId]	UNIQUEIDENTIFIER NOT NULL,
    [Username]		NVARCHAR (MAX)   NOT NULL,
	[RuleId]		UNIQUEIDENTIFIER NOT NULL,
	[PriorityClass]	SMALLINT		 NOT NULL,
	[Priority]		INT				 NOT NULL,
	[Conditions]	NVARCHAR(MAX)	 NOT NULL,
	[Actions]		NVARCHAR(MAX)	 NOT NULL,
    CONSTRAINT [PK_PushRule] PRIMARY KEY CLUSTERED ([PushRuleId] ASC)
);

