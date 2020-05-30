CREATE TABLE [dbo].[tbl_winnings]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	TotalSpots bigint NOT NULL,
	TotalWinningSpots bigint NOT NULL,
	WinningDescriptionJson nvarchar(256) NOT NULL,
	[TotalWinningAmount] BIGINT NOT NULL,
	[CreatedBy] INT NOT NULL, 
    [UpdatedBy] INT NOT NULL, 
    [UpdatedOn] DATETIME NOT NULL, 
    [CreatedOn] DATETIME NOT NULL
    

)
