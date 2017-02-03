CREATE TABLE [dbo].[ServerTlsCertificate] (
    [ServerTlsCertificateId]	UNIQUEIDENTIFIER NOT NULL,
    [ServerName]				NVARCHAR (MAX)   NULL,
    [Fingerprint]				NVARCHAR (MAX)   NULL,
    [FromServer]				NVARCHAR (MAX)   NULL,
	[TsAddedMs]					BIGINT			 NULL,
	[TlsCertificate]			VARBINARY(MAX)	 NULL,
    CONSTRAINT [PK_ServerTlsCertificate] PRIMARY KEY CLUSTERED ([ServerTlsCertificateId] ASC)
);

