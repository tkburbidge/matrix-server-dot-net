CREATE TABLE [dbo].[RemoteMediaCacheThumbnail] (
    [RemoteMediaCacheThumbnailId]	UNIQUEIDENTIFIER NOT NULL,
    [MediaOrigin]					NVARCHAR (MAX)   NULL,
    [MediaId]						UNIQUEIDENTIFIER NULL,
	[ThumbnailWidth]				INT				 NULL,
	[ThumbnailHeight]				INT				 NULL,
    [ThumbnailMethod]				NVARCHAR (MAX)   NULL,
    [ThumbnailType]					NVARCHAR (MAX)   NULL,
	[ThumbnailLength]				INT				 NULL,
    [FilesystemId]					UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_RemoteMediaCacheThumbnail] PRIMARY KEY CLUSTERED ([RemoteMediaCacheThumbnailId] ASC)
);

