﻿CREATE TABLE [dbo].[Users]
(
	[Id] NVARCHAR(MAX) NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [ProfileId] INT NOT NULL FOREIGN KEY REFERENCES Profile(Id)
)
