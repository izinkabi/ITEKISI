CREATE PROCEDURE [dbo].[spASPUserLookUp]
	@Email NVARCHAR (50) = ''
AS

BEGIN
	SELECT Id
	FROM [dbo].[AspNetUsers]
	WHERE Email = @Email
END