CREATE PROCEDURE [dbo].[spTaxiRouteRomve]
@id INT = 0

AS
BEGIN
 
set nocount on;
	Delete 
	From [dbo].[TaxiRoute]
	Where [Id] = @id
END