CREATE TABLE [dbo].[TaxiRoute]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [From] NVARCHAR(50) NULL, 
    [To] NVARCHAR(50) NULL 
)
