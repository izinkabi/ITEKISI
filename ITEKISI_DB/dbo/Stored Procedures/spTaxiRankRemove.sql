CREATE PROCEDURE [dbo].[spTaxiRankRemove]
	@id INT  = 0
	
AS
BEGIN
 SET NOCOUNT ON
	Delete From TaxiRank 
	Where Id = @id
END