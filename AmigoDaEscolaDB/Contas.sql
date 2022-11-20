CREATE TABLE [dbo].[Contas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ContaTipo] VARCHAR NULL, 
    [DataLancamento] DATETIME NULL, 
    [DataVencimento] DATETIME NULL, 
    [Valor] MONEY NULL, 
    [AlunoId] INT NULL, 
    [ProfessorId] INT NULL, 
    [Observacao] VARBINARY(MAX) NULL, 
    [DataBaixa] DATETIME NULL, 
    [ValorRecebido] MONEY NULL
)
