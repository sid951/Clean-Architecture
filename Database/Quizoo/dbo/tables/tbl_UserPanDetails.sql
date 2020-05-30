CREATE TABLE [dbo].[tbl_UserPanDetails]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	PanNumber varchar(10) NULL,
	PanImagePath varchar(256) NULL,
	DOB datetime null,
	IsVerified bit NOT NULL,
	[Name] varchar(200) NULL,
	[UserId] int Not Null,
	[CreatedBy] INT NOT NULL,
	[UpdatedBy] INT NOT NULL,
	[CreatedOn] DATETIME NOT NULL,
	[UpdatedOn] DATETIME NOT NULL,
	CONSTRAINT [FK_UserPanDetails_AspNetUsers_Id] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE,
)
