CREATE PROCEDURE [dbo].[spRegisterProfile]
	@UserId NVARCHAR  (50) = ''
AS
Begin

	INSERT INTO Profile ([UserId])
	VALUES (@UserId)
End
