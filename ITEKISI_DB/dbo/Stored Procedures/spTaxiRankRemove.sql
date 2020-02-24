CREATE PROCEDURE [dbo].[spTaxiRankRemove]
	@id INT 

AS
BEGIN
	Delete From  TaxiRank 
	Where Id = @id
END