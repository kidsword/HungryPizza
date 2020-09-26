CREATE TABLE [dbo].[Pizzas] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Name]        VARCHAR (100)    NOT NULL,
    [Description] VARCHAR (MAX)    NOT NULL,
    CONSTRAINT [PK_Pizzas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

