CREATE PROCEDURE [dbo].[spTaxiRouteInsert]
	@id int  = 0,
	@name nvarchar(50) = '',
	@from nvarchar (50) = '',
	@to nvarchar (50) = ''
AS
BEGIN
	INSERT INTO TaxiRoute (Id, [Name],[From],[To])
	VALUES (@id,@name,@from,@to)
END