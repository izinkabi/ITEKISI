CREATE PROCEDURE [dbo].[spTaxiRanksLookUP]
	
AS
begin
--stored procedure for getting Taxi Rank information
	set nocount on;

	SELECT [Id],[Name],[Address]
	from dbo.TaxiRank

end
