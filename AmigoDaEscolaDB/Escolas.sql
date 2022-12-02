CREATE TABLE [dbo].[Escolas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(50) NULL, 
    [Estado] VARCHAR(50) NULL, 
    [CidadeId] int NULL, 
    [Bairro] VARCHAR(50) NULL, 
    [Rua] VARCHAR(50) NULL, 
    [Numero] VARCHAR(50) NULL, 
    [Cep] VARCHAR(50) NULL, 
    [Telefone] VARCHAR(50) NULL,
    [DataCadastro] DATETIME NULL, 
    [DataVencimento] DATETIME NULL, 
    [TipoAssinatura] VARCHAR(50) NULL, 
    [Observacao] XML NULL, 
    CONSTRAINT [FK_Escolas_Cidades] FOREIGN KEY ([CidadeId]) REFERENCES [Cidades]([Id])
    
)
