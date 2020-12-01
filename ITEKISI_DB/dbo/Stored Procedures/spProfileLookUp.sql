CREATE PROCEDURE [dbo].[spProfileLookUp]
	@Id int = 0
	
AS
Begin
	SELECT [Id],[UserId],[Name],[Surname],[IDNumber],[Gender],[Address],[AccessId]
	FROM [dbo].[Profile]
	Where Id = @Id
End
