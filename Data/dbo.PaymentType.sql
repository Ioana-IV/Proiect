CREATE TABLE [dbo].[PaymentType] (
    [ID]               INT             IDENTITY (1, 1) NOT NULL,
    [PaymentTypeName]  NVARCHAR (MAX)  NOT NULL,
    [AvailableAmmount] DECIMAL (18, 2) NOT NULL,
    [PaymentTypeID]    INT             NOT NULL,
    CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_PaymentType_PaymentType_PaymentTypeID] FOREIGN KEY ([PaymentTypeID]) REFERENCES [dbo].[PaymentType] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_PaymentType_PaymentTypeID]
    ON [dbo].[PaymentType]([PaymentTypeID] ASC);

