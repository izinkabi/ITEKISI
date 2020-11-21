CREATE PROCEDURE [dbo].[spProfileLookUp]
	@Id int = 0,
	@Name nvarchar = '',
	@Surname nvarchar = '',
	@IDNumber nvarchar = '',
	@Gender nvarchar = '',
	@Address nvarchar = '',
	@AccessId int = 0
AS
Begin
	SELECT [Id],[Name],[Surname],[IDNumber],[Gender],[Address],[AccessId]
	FROM [dbo].[Profile]
	Where Id = @Id
End
