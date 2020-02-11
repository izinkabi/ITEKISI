CREATE TABLE [dbo].[Province]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Code] VARCHAR(50) NULL, 
    [CountryId] INT NULL FOREIGN KEY REFERENCES Country(Id)
)
