CREATE PROCEDURE [dbo].[spTaxiRouteAdd]
	@id INT = 0,
    @name VARCHAR (50) = '',
    @from VARCHAR (50) ='',
    @to VARCHAR (50) =''
    
AS
BEGIN
	INSERT INTO [dbo].[TaxiRoute] (Id,[Name],[From],[To])
	VALUES (@id,@name,@from,@to)
END
