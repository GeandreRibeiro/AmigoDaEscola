CREATE TABLE [dbo].[Imagens]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EscolaId] INT NULL, 
    [AlunoId] INT NULL, 
    [PaisId] INT NULL, 
    [ProfessorId] INT NULL, 
    [Descricao] VARCHAR(50) NULL, 
    [Imagem] VARBINARY(MAX) NULL, 
    CONSTRAINT [FK_Imagens_Alunos] FOREIGN KEY ([AlunoId]) REFERENCES [Alunos]([Id]), 
    CONSTRAINT [FK_Imagens_Pais] FOREIGN KEY ([PaisId]) REFERENCES [Pais]([Id]), 
    CONSTRAINT [FK_Imagens_Professor] FOREIGN KEY ([ProfessorId]) REFERENCES [Professores]([Id])
)
