CREATE TABLE [dbo].[Pais]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EscolaId] INT NOT NULL,
    [PaiNome] VARCHAR(100) NULL, 
    [PaiSobreNome] VARCHAR(100) NULL, 
    [PaiEndereco] VARCHAR(100) NULL, 
    [PaiNumero] VARCHAR(50) NULL, 
    [PaiCidadeId] INT NULL, 
    [PaiCelular] VARCHAR(50) NULL, 
    [PaiEmail] VARCHAR(50) NULL, 
    [PaiWhatsApp] NCHAR(10) NULL, 
    [PaiTelefoneTrabalho] VARCHAR(50) NULL, 
    [CPF] VARCHAR(11) NULL, 
    [Rg] VARCHAR(11) NULL, 
    [RgOrgao] VARCHAR(4) NULL, 
    [RgEstado] VARCHAR(2) NULL, 
    CONSTRAINT [FK_Pais_Cidades] FOREIGN KEY ([PaiCidadeId]) REFERENCES [Cidades]([Id]), 
    CONSTRAINT [FK_Pais_Escola] FOREIGN KEY ([EscolaId]) REFERENCES [Escolas]([Id])
)
