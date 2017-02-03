CREATE TABLE [dbo].[PushRulesEnable] (
    [PushRulesEnableId]	UNIQUEIDENTIFIER NOT NULL,
    [Username]			NVARCHAR (MAX)   NOT NULL,
	[RuleId]			UNIQUEIDENTIFIER NOT NULL,
	[IsEnabled]			BIT				 NULL,
    CONSTRAINT [PK_PushRulesEnable] PRIMARY KEY CLUSTERED ([PushRulesEnableId] ASC)
);

