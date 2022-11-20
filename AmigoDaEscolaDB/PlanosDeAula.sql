CREATE TABLE [dbo].[PlanosDeAula]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProfessorId] INT NULL, 
    [EscolaId] INT NULL, 
    [Data] DATETIME NULL, 
    [ObjetivoGeral] VARCHAR(MAX) NULL, 
    [PublicoAlvo] VARCHAR(MAX) NULL, 
    [Conteudo] VARCHAR(MAX) NULL, 
    [Procedimentos] VARCHAR(MAX) NULL, 
    [Recursos] VARCHAR(MAX) NULL, 
    [Avaliacao] VARCHAR(MAX) NULL, 
    [PalavrasChave] VARCHAR(50) NULL, 
    [Observacao] XML NULL, 
    CONSTRAINT [FK_PlanosDeAula_Professor] FOREIGN KEY ([ProfessorId]) REFERENCES [Professores]([Id]), 
    CONSTRAINT [FK_PlanosDeAula_Escotas] FOREIGN KEY ([EscolaId]) REFERENCES [Escolas]([Id])
)
