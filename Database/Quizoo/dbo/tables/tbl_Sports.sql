CREATE TABLE [dbo].[tbl_Sports]
(
	[SportID] INT NOT NULL PRIMARY KEY Identity(1,1),
	[SportName] varchar(100),
	[SportLogo] varchar(100),
	[CreatedBy] varchar(100),
	[UpdatedBy] varchar(100),
	[CreatedDate] varchar(100),
	[ModifiedDate] varchar(100)
)
