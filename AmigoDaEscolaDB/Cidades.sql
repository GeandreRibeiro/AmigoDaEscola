CREATE TABLE [dbo].[Cidades]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Descricao] VARCHAR(50) NULL, 
    [CodigoIBGE] VARCHAR(50) NULL, 
    [EstadoId] INT NULL, 
    CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY ([EstadoId]) REFERENCES [Estados]([Id])
)
