CREATE TABLE [dbo].[ServerSignatureKey] (
    [ServerSignatureKeyId]	UNIQUEIDENTIFIER NOT NULL,
    [ServerName]			NVARCHAR (MAX)   NULL,
	[KeyId]					UNIQUEIDENTIFIER NULL,
	[FromServer]			NVARCHAR (MAX)   NULL,
	[TimestampAddedMs]		DATETIME		 NOT NULL,
	[VerifyKey]				VARBINARY(MAX)	 NULL,
    CONSTRAINT [PK_ServerSignatureKey] PRIMARY KEY CLUSTERED ([ServerSignatureKeyId] ASC)
);

