CREATE TABLE [dbo].[Profile] (
    [Id]       int   IDENTITY (1, 1) NOT NULL,
    [UserId]   NVARCHAR (50)  NOT NULL,
    [Name]     NVARCHAR (50)  NULL,
    [Surname]  NVARCHAR (50)  NULL,
    [IDNumber] NVARCHAR (100) NULL,
    [Gender]   VARCHAR (10)   NULL,
    [Address]  VARCHAR (100)  NULL,
    [AccessId] NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Profile2] PRIMARY KEY CLUSTERED ([Id] ASC),
 
    CONSTRAINT [IX_Profile2] UNIQUE NONCLUSTERED ([UserId] ASC)
);

