CREATE PROCEDURE [dbo].[spUserInsert]
	@Id int = 0,
	@UserName VARCHAR (100) = '',
	@Password VARCHAR (100) = ''
AS

Begin
	INSERT INTO Users (Id,Username,Password)
	VALUES (@Id,@Username,@Password)
End
