CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] NCHAR(10) NULL, 
    [Password] VARCHAR(50) NULL, 
    [ProfileId] INT NULL FOREIGN KEY REFERENCES Profile(Id)
)
