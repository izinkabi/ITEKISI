CREATE PROCEDURE [dbo].[spTaxiRankLookUp]
	@Id int
AS
begin
--stored procedure for getting Taxi Rank information
	set nocount on;

	SELECT [Id],[Name],[Address]
	from dbo.TaxiRank
	where Id = @Id;
end
