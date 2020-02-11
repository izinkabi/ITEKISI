CREATE TABLE [dbo].[City]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Code] VARCHAR(50) NULL, 
    [Province] INT NULL FOREIGN KEY REFERENCES Province(Id)
)
