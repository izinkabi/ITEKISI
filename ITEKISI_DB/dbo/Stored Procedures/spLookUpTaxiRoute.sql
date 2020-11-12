CREATE PROCEDURE [dbo].[spLookUpTaxiRoute]
	@Id int
AS
begin
--stored procedure for getting Taxi Rioute information
	set nocount on;

	SELECT [Id],[Name],[From],[To]
	from dbo.TaxiRoute
	where Id = @Id;
end