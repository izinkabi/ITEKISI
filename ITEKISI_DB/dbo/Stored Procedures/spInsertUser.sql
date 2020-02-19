CREATE PROCEDURE [dbo].[spInsertUser]
	@Id nvarchar,
	@Username nvarchar,
	@Password nvarchar,
	@ProfileId int
AS
BEGIN
	INSERT INTO Users (Id,Username,Password,ProfileId)
	VALUES (@Id,@Username,@Password,@ProfileId)
END