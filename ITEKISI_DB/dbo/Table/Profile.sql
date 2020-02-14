CREATE TABLE [dbo].[Profile]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Surname] VARCHAR(50) NULL, 
    [IDNumber] VARCHAR(50) NULL, 
    [Gender] VARCHAR(50) NULL, 
    [Address] VARCHAR(MAX) NULL, 
    [AccessId] INT NULL FOREIGN KEY REFERENCES Access(Id)
    )