CREATE PROCEDURE [dbo].[spTaxiRoutesLookUP]

AS
Begin

set nocount on;

	SELECT [Id],[Name],[From],[To]
	from dbo.TaxiRoute

End
