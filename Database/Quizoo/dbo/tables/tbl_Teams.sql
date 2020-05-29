CREATE TABLE [dbo].[tbl_Teams]
(
	[TeamID] INT NOT NULL PRIMARY KEY Identity(1,1),
	[TeamName] varchar(100),
	[TeamLogo] varchar(100),
	[CreatedBy] varchar(100),
	[UpdatedBy] varchar(100),
	[CreatedDate] varchar(100),
	[ModifiedDate] varchar(100)
)
