CREATE TABLE [dbo].[tbl_UserBalance]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	UnutilizedAmount decimal(7,2)NOT NULL,
	CashBonus decimal(7,2) NOT NULL,
	WinningAmount Decimal(9,2) NOT NULL,
	UserId int not null,
	CreatedOn DateTime NOT NULL,
    UpdatedOn DateTime NOT NULL,
    CreatedBy int NOT NULL,
    UpdatedBy int NOT NULL,
	CONSTRAINT [FK_UserBalance_AspNetUsers_Id] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE,
)
