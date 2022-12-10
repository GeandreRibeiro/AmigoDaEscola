CREATE TABLE [dbo].[Contas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EscolaId] INT NULL, 
    [ContaTipo] VARCHAR NULL, 
    [DataLancamento] DATETIME NULL, 
    [DataVencimento] DATETIME NULL, 
    [Valor] MONEY NULL, 
    [AlunoId] INT NULL,
    [PaisId] INT NULL,
    [ProfessorId] INT NULL, 
    [Observacao] VARBINARY(MAX) NULL, 
    [DataBaixa] DATETIME NULL, 
    [ValorRecebido] MONEY NULL, 
    CONSTRAINT [FK_Contas_Escolas] FOREIGN KEY ([EscolaId]) REFERENCES [Escolas]([Id]), 
    CONSTRAINT [FK_Contas_Pais] FOREIGN KEY ([PaisId]) REFERENCES [Pais]([Id]), 
    CONSTRAINT [FK_Contas_Alunos] FOREIGN KEY ([AlunoId]) REFERENCES [Alunos]([Id]), 
    CONSTRAINT [FK_Contas_Professores] FOREIGN KEY ([ProfessorId]) REFERENCES [Professores]([Id])

)
