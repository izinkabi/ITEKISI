CREATE PROCEDURE [dbo].[spProfileInsert]
	
	@Name nvarchar,
	@Surname nvarchar,
	@IDNumber nvarchar,
	@Gender nvarchar,
	@Address nvarchar,
	@AccessId int

AS
BEGIN
	INSERT INTO Profile ([Name],[Surname],[IDNumber],[Gender],[Address],[AccessId])
	VALUES (@Name,@Surname, @IDNumber,@Gender,@Address,@AccessId)
END
