CREATE TABLE [dbo].[tbl_UserBankDetails]
(

	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	BankAccountNumber varchar(30) NULL,
	BankProofImagePath varchar(256) NULL,
	BankName nvarchar(100) null,
	IsVerified bit NOT NULL,
	[IfscCode] varchar(20) NULL,
	[UserId] int Not Null,
	[CreatedBy] INT NOT NULL,
	[UpdatedBy] INT NOT NULL,
	[CreatedOn] DATETIME NOT NULL,
	[UpdatedOn] DATETIME NOT NULL,
	CONSTRAINT [FK_UserBankDetails_AspNetUsers_Id] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
)
