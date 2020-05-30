CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   INT     NOT NULL IDENTITY,
    [TeamName]             NVARCHAR (50)     NULL,
    [NormalizedTeamName]   NVARCHAR (50)     NULL,
    [Email]                NVARCHAR (100)     NULL,
    [NormalizedEmail]      NVARCHAR (100)     NULL,
    [IsEmailConfirmed]       BIT                NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)     NULL,
    [SecurityStamp]        NVARCHAR (MAX)     NULL,
    [ConcurrencyStamp]     NVARCHAR (MAX)     NULL,
    [PhoneNumber]          NVARCHAR (MAX)     NULL,
    [IsPhoneNumberConfirmed] BIT                NOT NULL,
    [TwoFactorEnabled]     BIT                NOT NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]       BIT                NOT NULL,
    [AccessFailedCount]    INT                NOT NULL,
    [DOB] DATETIME NULL, 
    [Gender] NCHAR(1) NULL, 
    [Address] nvarchar(MAX) Null,
	[City] nvarchar(100) Null,
	[State] nvarchar(100) NULL,
	Pincode nvarchar (6) NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [dbo].[AspNetUsers]([NormalizedEmail] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([NormalizedTeamName] ASC) WHERE ([NormalizedTeamName] IS NOT NULL);

