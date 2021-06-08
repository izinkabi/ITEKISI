CREATE PROCEDURE [dbo].[spProfileLookUp]
	@UserId VARCHAR (250) =''
	
AS
Begin
	SELECT [Id],[UserId],[Name],[Surname],[IDNumber],[Gender],[Address],[AccessId]
	FROM [dbo].[Profile]
	Where UserId = @UserId
End
