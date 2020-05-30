CREATE TABLE [dbo].[tbl_ContestFee]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	FeeAmount  decimal (7,2) NOT NULL,
	CreatedOn DateTime NOT NULL,
    UpdatedOn DateTime NOT NULL,
    CreatedBy int NOT NULL,
    UpdatedBy int NOT NULL
)
