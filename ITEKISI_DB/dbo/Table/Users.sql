CREATE TABLE [dbo].[Users] (
    [Id]       NVARCHAR (50) DEFAULT ((1)) NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Password] VARCHAR (50)  NOT NULL
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [Id_Users]
    ON [dbo].[Users]([Id] ASC);

