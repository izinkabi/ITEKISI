CREATE PROCEDURE [dbo].[spProfilesLookUp]
	@Id int = 0,
	@Name nvarchar,
	@Surname nvarchar,
	@IDNumber nvarchar,
	@Gender nvarchar,
	@Address nvarchar,
	@AccessId int
AS
Begin

SET NOCOUNT ON

	SELECT [Id],[Name],[Surname],[IDNumber],[Gender],[Address],[AccessId]
	FROM [dbo].[Profile]
End
