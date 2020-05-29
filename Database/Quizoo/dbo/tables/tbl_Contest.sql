CREATE TABLE [dbo].[tbl_Contest]
(
	[ContestID] INT NOT NULL PRIMARY KEY Identity(1,1),
	[ContestName] varchar(100),
	[ContestLogo] varchar(100),
	[CreatedBy] varchar(100),
	[UpdatedBy] varchar(100),
	[CreatedDate] varchar(100),
	[ModifiedDate] varchar(100)
)
