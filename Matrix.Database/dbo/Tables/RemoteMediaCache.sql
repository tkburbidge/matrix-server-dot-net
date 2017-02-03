CREATE TABLE [dbo].[RemoteMediaCache] (
    [RemoteMediaCacheId]	UNIQUEIDENTIFIER NOT NULL,
    [MediaOrigin]			NVARCHAR (MAX)   NULL,
    [MediaId]				UNIQUEIDENTIFIER NULL,
    [MediaType]				NVARCHAR (MAX)   NULL,
	[CreatedTs]				BIGINT			 NULL,
	[UploadName]			NVARCHAR (MAX)   NULL,
	[MediaLength]			INT				 NULL,
	[FilesystemId]			UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_RemoteMediaCache] PRIMARY KEY CLUSTERED ([RemoteMediaCacheId] ASC)
);

