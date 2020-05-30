CREATE TABLE [dbo].[tbl_ContestMapping]
(
	
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[ContestTypeId] int NOT NULL,
	[ContestFeeId] int NOT NULL,
	[ContestId] int not null,
	[CreatedBy] INT NOT NULL, 
    [UpdatedBy] INT NOT NULL, 
    [CreatedOn] DATETIME NOT NULL, 
    [UpdatedOn] DATETIME NOT NULL, 
	CONSTRAINT [FK_ContestTypeContestFeeMapping_ContestType_Id] FOREIGN KEY ([ContestTypeId]) REFERENCES [dbo].[tbl_ContestType] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_ContestTypeContestFeeMapping_ContestFee_Id] FOREIGN KEY ([ContestFeeId]) REFERENCES [dbo].[tbl_ContestFee] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_ContestTypeContestFeeMapping_Contest_Id] FOREIGN KEY ([ContestId]) REFERENCES [dbo].[tbl_Contest] ([Id]) ON DELETE CASCADE

)
