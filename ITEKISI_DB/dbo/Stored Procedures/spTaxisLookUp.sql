CREATE PROCEDURE [dbo].[spTaxisLookUp]
AS
begin
--stored procedure for getting Taxi information
	set nocount on;

	SELECT [Id],[From],[To],[Price],[Location]
	from dbo.Taxi
end
