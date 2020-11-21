CREATE PROCEDURE [dbo].[spUserInsert]
	@id nvarchar(50) = '',
	@username nvarchar(50) = '',
	@password nvarchar(50) = '',
	@profileId int 
AS
BEGIN
	INSERT INTO Users (Id,Username,[Password],ProfileId)
	VALUES (@id,@username,@password,@profileId)
END