CREATE TABLE [dbo].[Street]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [CityId] INT NULL FOREIGN KEY REFERENCES City(Id), 
    [TaxiRouteId] INT NULL FOREIGN KEY REFERENCES TaxiRoute(Id), 
    
)
