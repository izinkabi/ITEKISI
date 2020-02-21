CREATE PROCEDURE [dbo].[spTaxiLookUp]
	@Id int
AS
begin
--stored procedure for getting Taxi information
	set nocount on;

	SELECT [Id],[From],[To],[Price],[Location]
	from dbo.Taxi
	where Id = @Id;
end
