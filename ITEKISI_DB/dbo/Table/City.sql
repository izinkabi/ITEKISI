CREATE TABLE [dbo].[City] (
    [Id]       INT          NOT NULL,
    [Name]     VARCHAR (50) NULL,
    [Code]     VARCHAR (50) NULL,
    [Province] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Province]) REFERENCES [dbo].[Province] ([Id])
);

