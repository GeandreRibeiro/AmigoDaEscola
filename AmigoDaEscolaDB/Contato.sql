CREATE TABLE [dbo].[Contato]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] VARCHAR(50) NULL, 
    [Telefone] VARCHAR(50) NULL, 
    [Nome] VARCHAR(50) NULL, 
    [SobreNome] VARCHAR(50) NULL, 
    [Cidade] VARCHAR(50) NULL, 
    [Estado] VARCHAR(50) NULL, 
    [Cep] VARCHAR(50) NULL, 
    [ReceberInf] BIT NULL, 
    [Contatado] BIT NULL
)
