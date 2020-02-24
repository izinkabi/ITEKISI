CREATE PROCEDURE [dbo].[spTaxiInsert]
	@id INT = 0,
    @from VARCHAR (50) = '',
    @to VARCHAR (50) ='',
    @price VARCHAR (50) ='',
    @location NVARCHAR (50) =''

AS
BEGIN
	INSERT INTO Taxi (Id,[From],[To],[Price],[Location])
	VALUES (@id,@from,@to, @price,@location)
END