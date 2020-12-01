CREATE TABLE [dbo].[Users]
(
	[Id] NVARCHAR(50) NOT NULL DEFAULT 1, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL,
    [ProfileId] INT NOT NULL,
    
)
