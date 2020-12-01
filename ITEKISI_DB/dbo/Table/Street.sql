CREATE TABLE [dbo].[Street] (
    [Id]          INT          NOT NULL,
    [Name]        VARCHAR (50) NULL,
    [CityId]      INT          NULL,
    [TaxiRouteId] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([Id]),
    FOREIGN KEY ([TaxiRouteId]) REFERENCES [dbo].[TaxiRoute] ([Id])
);

