CREATE PROCEDURE [dbo].[spTaxiRouteRemove]
	@id INT  = 0
	
AS
BEGIN
 SET NOCOUNT ON
	Delete From TaxiRoute 
	Where Id = @id
END