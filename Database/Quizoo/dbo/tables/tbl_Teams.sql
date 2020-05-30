CREATE TABLE [dbo].[tbl_Teams]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[TeamName] varchar(100) NOT NULL,
	[TeamLogo] varchar(100) NOT NULL,
	[CreatedBy] INT NOT NULL,
	[UpdatedBy] INT NOT NULL,
	[CreatedOn] DATETIME NOT NULL,
	[UpdatedOn] DATETIME NOT NULL, 
    [TeamAbbrevation] VARCHAR(3) NOT NULL
)
