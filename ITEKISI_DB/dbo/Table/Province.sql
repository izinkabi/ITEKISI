CREATE TABLE [dbo].[Province] (
    [Id]        INT          NOT NULL,
    [Name]      VARCHAR (50) NULL,
    [Code]      VARCHAR (50) NULL,
    [CountryId] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id])
);

