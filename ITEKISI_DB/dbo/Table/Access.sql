CREATE TABLE [dbo].[Access]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Type] VARCHAR(50) NULL, 
    [Level] VARCHAR(50) NULL, 
    [ActivationId] INT NULL FOREIGN KEY REFERENCES Province(Id)
)
