CREATE TABLE [dbo].[Professores]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EscolaId] INT NOT NULL, 
    [Nome] VARCHAR(50) NULL, 
    [Telefone] VARCHAR(50) NULL, 
    [CidadeId] INT NULL, 
    [Bairro] VARCHAR(50) NULL, 
    [Rua] VARCHAR(50) NULL, 
    [Numero] VARCHAR(50) NULL, 
    [CPF] VARCHAR(50) NULL, 
    [Observacao] XML NULL, 
    [DataCadastro] DATETIME NULL, 
    [Ativo] BIT NULL, 
    CONSTRAINT [FK_Professores_Escola] FOREIGN KEY ([EscolaId]) REFERENCES [Escolas]([Id]), 
    CONSTRAINT [FK_Professores_Cidades] FOREIGN KEY ([CidadeId]) REFERENCES [Cidades]([Id])
)
