CREATE TABLE [dbo].[Access] (
    [Id]           INT          NOT NULL,
    [Type]         VARCHAR (50) NULL,
    [Level]        VARCHAR (50) NULL,
    [ActivationId] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ActivationId]) REFERENCES [dbo].[Activation] ([Id])
);

