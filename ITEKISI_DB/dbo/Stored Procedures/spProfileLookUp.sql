CREATE PROCEDURE [dbo].[spProfileLookUp]
	@UserId nvarchar (100) = ''
	
AS
Begin
	SELECT [Id],[UserId],[Name],[Surname],[IDNumber],[Gender],[Address],[AccessId]
	FROM [dbo].[Profile]
	Where UserId = @UserId
End
