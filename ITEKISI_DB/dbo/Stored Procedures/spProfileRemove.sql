CREATE PROCEDURE [dbo].[spProfileRemove]
	@Id int = 0
	
AS
BEGIN
SET NOCOUNT ON
	Delete From Profile
	Where Id = @Id
END
