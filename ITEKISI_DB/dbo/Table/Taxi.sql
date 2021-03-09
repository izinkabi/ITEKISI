﻿CREATE TABLE [dbo].[Taxi] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [From]     VARCHAR (50)  NULL,
    [To]       VARCHAR (50)  NULL,
    [Price]    VARCHAR (50)  NULL,
    [Location] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

