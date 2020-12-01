CREATE PROCEDURE [dbo].[spASPUserLoopUp]
	@Email NVARCHAR (50) = ''
AS

BEGIN
	SELECT Id
	FROM [dbo].[AspNetUsers]
	WHERE Email = @Email
END
