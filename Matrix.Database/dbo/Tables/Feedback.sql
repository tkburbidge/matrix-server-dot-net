﻿CREATE TABLE [dbo].[Feedback] (
    [FeedbackId]	UNIQUEIDENTIFIER NOT NULL,
    [EventId]		UNIQUEIDENTIFIER NOT NULL,
	[FeedbackType]	NVARCHAR(MAX)	 NULL,
	[TargetEventId]	UNIQUEIDENTIFIER NULL,
	[Sender]		NVARCHAR(MAX)	 NULL,
	[RoomId]		UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED ([FeedbackId] ASC)
);

