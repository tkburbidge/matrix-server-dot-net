CREATE TABLE [dbo].[User] (
    [UserId]       UNIQUEIDENTIFIER NOT NULL,
    [Username]     NVARCHAR (MAX)   NOT NULL,
    [PasswordHash] NVARCHAR (MAX)   NOT NULL,
    [DateCreated]  DATETIME         NOT NULL,
    [IsAdmin]        BIT              DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

