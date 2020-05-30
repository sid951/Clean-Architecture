CREATE TABLE [dbo].[tbl_ContestWinningMapping]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	ContestId int not null,
	WinningId int Not null,
	[CreatedBy] INT NOT NULL, 
    [UpdatedBy] INT NOT NULL, 
    [CreatedOn] DATETIME NOT NULL, 
    [UpdatedOn] DATETIME NOT NULL, 
	CONSTRAINT [FK_ContestWinnigMapping_Contest_Id] FOREIGN KEY ([ContestId]) REFERENCES [dbo].[tbl_Contest] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_ContestWinnigMapping_Winning_Id] FOREIGN KEY ([WinningId]) REFERENCES [dbo].[tbl_Winnings] ([Id]) ON DELETE CASCADE
)
