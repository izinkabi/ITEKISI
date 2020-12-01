CREATE PROCEDURE [dbo].[spProfileInsert]
	@Id int = 0,
	@Name nvarchar,
	@Surname nvarchar,
	@IDNumber nvarchar,
	@Gender nvarchar,
	@Address nvarchar,
	@AccessId int

AS
BEGIN
	INSERT INTO Profile ([Id],[Name],[Surname],[IDNumber],[Gender],[Address],[AccessId])
	VALUES (@Id,@Name,@Surname, @IDNumber,@Gender,@Address,@AccessId)
END
