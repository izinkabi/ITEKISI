CREATE PROCEDURE [dbo].[spTaxiRankInsert]
	@id int  = 0,
	@name nvarchar(50) = '',
	@address nvarchar (50) = ''
AS
BEGIN
	INSERT INTO TaxiRank (Id,[Name],[Address])
	VALUES (@id,@name,@address)
END