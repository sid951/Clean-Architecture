CREATE TABLE [dbo].[tbl_ContestType]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	IsMultipleEnteriesAllowed bit Not Null,
	TotalEntryPerPlayer int Not NULL,
	CanCancelled bit NOT NULL,
	CreatedOn DateTime NOT NULL,
    UpdatedOn DateTime NOT NULL,
    CreatedBy int NOT NULL,
    UpdatedBy int NOT NULL,
	
    
)
