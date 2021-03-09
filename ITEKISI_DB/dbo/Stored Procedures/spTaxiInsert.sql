CREATE PROCEDURE [dbo].[spTaxiInsert]
	
    @from VARCHAR (50) = '',
    @to VARCHAR (50) ='',
    @price VARCHAR (50) ='',
    @location NVARCHAR (50) =''

AS
BEGIN
	INSERT INTO Taxi ([From],[To],[Price],[Location])
	VALUES (@from,@to, @price,@location)
END