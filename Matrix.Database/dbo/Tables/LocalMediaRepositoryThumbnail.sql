CREATE TABLE [dbo].[LocalMediaRepositoryThumbnail] (
    [LocalMediaRepositoryThumbnailId]	UNIQUEIDENTIFIER NOT NULL,
    [MediaId]							UNIQUEIDENTIFIER NULL,
	[ThumbnailWidth]					INT				 NULL,
	[ThumbnailHeight]					INT				 NULL,
	[ThumbnailType]						NVARCHAR(MAX)	 NULL,
	[ThumbnailMethod]					NVARCHAR(MAX)	 NULL,
	[ThumbnailLength]					INT				 NULL,
    CONSTRAINT [PK_LocalMediaRepositoryThumbnail] PRIMARY KEY CLUSTERED ([LocalMediaRepositoryThumbnailId] ASC)
);

