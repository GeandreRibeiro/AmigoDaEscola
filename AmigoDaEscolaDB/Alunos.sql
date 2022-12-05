CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EscolaId] INT NOT NULL,
    [Nome] VARCHAR(100) NULL, 
    [SobreNome] VARCHAR(100) NULL, 
    [CPF] VARCHAR(11) NULL, 
    [Rg] VARCHAR(11) NULL, 
    [RgOrgao] VARCHAR(4) NULL, 
    [RgEstado] VARCHAR(2) NULL,
    [CidadeId] INT NULL, 
    [Endereco] VARCHAR(100) NULL, 
    [Numero] VARCHAR(50) NULL, 
    [Bairro] VARCHAR(100) NULL, 
    [Celular] VARCHAR(50) NULL, 
    [WhatsApp] VARCHAR(50) NULL, 
    [Email] VARCHAR(100) NULL, 
    [PaisId] INT NULL, 
    CONSTRAINT [FK_Alunos_Cidade] FOREIGN KEY ([CidadeId]) REFERENCES [Cidades]([Id]), 
    CONSTRAINT [FK_Alunos_Pais] FOREIGN KEY ([PaisId]) REFERENCES [Pais]([Id]), 
    CONSTRAINT [FK_Alunos_Escola] FOREIGN KEY ([EscolaId]) REFERENCES [Escolas]([Id])
)
