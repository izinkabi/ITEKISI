CREATE TABLE [dbo].[TaxiRoute] (
    [Id]   INT           NOT NULL,
    [Name] VARCHAR (50)  NULL,
    [From] NVARCHAR (50) NULL,
    [To]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

