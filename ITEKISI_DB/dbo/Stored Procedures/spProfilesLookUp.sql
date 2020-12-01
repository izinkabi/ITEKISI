CREATE PROCEDURE [dbo].[spProfilesLookUp]
	
AS
Begin

SET NOCOUNT ON

	SELECT [Id],[Name],[Surname],[IDNumber],[Gender],[Address],[AccessId]
	FROM [dbo].[Profile]
End
