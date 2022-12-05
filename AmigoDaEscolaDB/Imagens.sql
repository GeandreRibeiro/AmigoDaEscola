CREATE TABLE [dbo].[Imagens]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AlunoId] INT NULL, 
    [PaisId] INT NULL, 
    [Imagem] VARBINARY(MAX) NULL, 
    CONSTRAINT [FK_Imagens_Alunos] FOREIGN KEY ([AlunoId]) REFERENCES [Alunos]([Id]), 
    CONSTRAINT [FK_Imagens_Pais] FOREIGN KEY ([PaisId]) REFERENCES [Pais]([Id])
)
