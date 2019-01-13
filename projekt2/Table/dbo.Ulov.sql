CREATE TABLE [dbo].[Ulov] (
    [ID_LOVA]  INT         NOT NULL IDENTITY,
    [ID_Ribe]  VARCHAR (3) NOT NULL,
    [Kolicina] FLOAT (53)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_LOVA] ASC),
    CONSTRAINT [FK_Ulov_ToRibe] FOREIGN KEY ([ID_Ribe]) REFERENCES [dbo].[Riba] ([ID_RIBE])
);

