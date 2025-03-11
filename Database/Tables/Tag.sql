﻿CREATE TABLE [dbo].[Tag]
(
	[Tag_Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Nom]  NVARCHAR(64) NOT NULL CONSTRAINT UK_Nom UNIQUE,
	[Description] NVARCHAR(512),
)
