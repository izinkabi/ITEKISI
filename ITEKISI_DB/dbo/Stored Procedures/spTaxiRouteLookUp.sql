CREATE PROCEDURE [dbo].[spTaxiRouteLookUp]
	@ID int

AS
Begin
	SELECT [Id],[Name],[From],[To]
	from dbo.TaxiRoute
	where Id = @ID;

End
