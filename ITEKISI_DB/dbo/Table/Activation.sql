CREATE TABLE [dbo].[Activation] (
    [Id]     INT          NOT NULL,
    [State]  VARCHAR (50) NULL,
    [Code]   VARCHAR (50) NULL,
    [Status] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

