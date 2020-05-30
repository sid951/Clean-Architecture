CREATE TABLE [dbo].[tbl_Contest]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1) ,
	[ContestName] varchar(100) NOT NULL,
	[CreatedBy] INT NOT NULL,
	[UpdatedBy] INT NOT NULL,
	[CreatedOn] DATETIME NOT NULL,
	[UpdatedOn] DATETIME NOT NULL
)
