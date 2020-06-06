
USE [Quizoo]
GO

/****** Object:  StoredProcedure [dbo].[usp_Registration]    Script Date: 06-06-2020 18:57:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Rohit Kumar>
-- Create date: <31-05-2020>
-- Description:	<Registration>
-- =============================================
ALTER PROCEDURE [dbo].[usp_Registration] 
	--@flag BIT
	@Email VARCHAR(100)
	,@Password VARCHAR(100)
AS
BEGIN
	BEGIN TRAN
	BEGIN TRY
		--IF @flag = 1
		--BEGIN
			IF NOT EXISTS (
					SELECT *
					FROM dbo.AspNetUsers
					WHERE Email = @Email
					)
			BEGIN
				INSERT INTO dbo.AspNetUsers (
					TeamName,
					NormalizedTeamName,
					Email,
					NormalizedEmail,
					IsEmailConfirmed,
					PasswordHash,
					SecurityStamp,
					ConcurrencyStamp,
					PhoneNumber,
					IsPhoneNumberConfirmed,
					TwoFactorEnabled,
					LockoutEnd,
					LockoutEnabled,
					AccessFailedCount,
					DOB,
					Gender,
					Address,
					City,
					State,
					Pincode
					)
				VALUES (
					'',
					'',
					@Email,
					'',
					0,
					@Password,
					'',
					'',
					'',
					0,
					0,
					'',
					0,
					0,
					'',
					'',
					'',
					'',
					'',
					''
					)
					DECLARE @ID INT;
				SET @ID = (
						SELECT SCOPE_IDENTITY()
						);

				INSERT INTO dbo.AspNetUserRoles (
					UserId,
					RoleId
					,CreatedBy
					,CreatedOn,
					UpdatedBy,
					UpdatedOn
					)
				VALUES (
					@ID,
					1
					,1
					,GETDATE()
					,1
					,GETDATE()
					)

				INSERT INTO dbo.tbl_UserBalance (
					UnutilizedAmount,
					CashBonus,
					WinningAmount,
					UserId
					,CreatedOn
					,CreatedBy,
					UpdatedOn,
					UpdatedBy
					)
				VALUES (
					100.00,
					100.00,
					100.00,
					@ID
					,GETDATE()
					,1,
					GETDATE(),
					1
					)

				INSERT INTO dbo.tbl_UserBankDetails (
					BankAccountNumber,
					BankProofImagePath,
					BankName,
					IsVerified,
					IfscCode,
					UserId,
					CreatedBy,
					UpdatedBy,
					CreatedOn,
					UpdatedOn
					)
				VALUES (
					'',
					'',
					'',
					0,
					'',
					@ID,
					1,
					1,
					GETDATE(),
					GETDATE()
					)

				INSERT INTO dbo.tbl_UserPanDetails (
					PanNumber,
					PanImagePath,
					DOB,
					IsVerified,
					[Name],
					UserId,
					CreatedBy,
					UpdatedBy,
					CreatedOn,
					UpdatedOn
					)
				VALUES (
					'',
					'',
					'',
					0,
					'',
					@ID,
					1,
					1,
					GETDATE(),
					GETDATE()
					)
			END
			ELSE
			BEGIN
				SELECT 'Email is already Exist'
			END
		--END

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END
GO
