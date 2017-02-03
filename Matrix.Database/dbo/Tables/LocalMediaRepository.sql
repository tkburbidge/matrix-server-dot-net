CREATE TABLE [dbo].[LocalMediaRepository] (
    [LocalMediaRepositoryId]	UNIQUEIDENTIFIER NOT NULL,
    [MediaId]					UNIQUEIDENTIFIER NULL,
    [MediaType]					NVARCHAR (MAX)   NULL,
    [MediaLength]				INT				 NULL,
	[CreatedTimestamp]			DATETIME		 NULL,
	[UploadName]				NVARCHAR (MAX)   NULL,
	[UserId]					UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_LocalMediaRepository] PRIMARY KEY CLUSTERED ([LocalMediaRepositoryId] ASC)
);

