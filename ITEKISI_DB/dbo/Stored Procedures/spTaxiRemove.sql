CREATE PROCEDURE [dbo].[spTaxiRemove]
	@id INT = 0

AS
BEGIN
	Delete From Taxi 
	Where Id = @id
END
