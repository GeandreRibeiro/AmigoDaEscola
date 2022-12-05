CREATE TABLE [dbo].[PaisAlunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PaisId] INT NULL, 
    [AlunoId] INT NULL, 
    CONSTRAINT [FK_PaisAlunos_Pais] FOREIGN KEY ([PaisId]) REFERENCES [Pais]([Id]), 
    CONSTRAINT [FK_PaisAlunos_Alunos] FOREIGN KEY ([AlunoId]) REFERENCES [Alunos]([Id])
)
