CREATE PROCEDURE [dbo].[spLookUpTaxiRoutes]

AS
BEGIN

	set nocount on;

	SELECT *
	FROM [dbo].[TaxiRoute];

END