CREATE TABLE [dbo].[tbl_Sports]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[SportName] varchar(100) NOT NULL,
	[SportLogo] varchar(100) NOT NULL,
	[CreatedBy] INT NOT NULL,
	[UpdatedBy] INT NOT NULL,
	[CreatedOn] DATETIME NOT NULL,
	[UpdatedOn] DATETIME NOT NULL
)
