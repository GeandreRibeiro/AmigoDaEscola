CREATE TABLE [dbo].[Estados]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Descricao] VARCHAR(50) NULL, 
    [Sigla] VARCHAR(2) NULL, 
    [CodigoIBGE] VARCHAR(50) NULL
)
