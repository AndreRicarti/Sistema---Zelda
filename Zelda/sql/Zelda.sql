CREATE DATABASE Zelda
USE Zelda

CREATE TABLE Usuario (
	usu_Codigo INT IDENTITY PRIMARY KEY,
	usu_Nome VARCHAR(100),
	usu_Login VARCHAR(100),
	usu_Senha VARCHAR(100),
	usu_Ativo CHAR(1),
	usu_DataCadastro DATETIME
)
GO

CREATE TABLE Cliente (
	cli_Codigo INT IDENTITY PRIMARY KEY,
	cli_Nome VARCHAR(100),
	cli_Endereco VARCHAR(100),
	cli_Numero VARCHAR(3),
	cli_Cidade VARCHAR(100),
	cli_UF CHAR(2),
	cli_Telefone VARCHAR(15),
	cli_Email VARCHAR(100),
	cli_Ativo CHAR(1),
	cli_DataCadastro DATETIME
)
GO

CREATE TABLE Fornecedor (
	for_Codigo INT IDENTITY PRIMARY KEY,
	for_CNPJ CHAR(14),
	for_IE VARCHAR(100),
	for_RazaoSocial VARCHAR(100),
	for_Endereco VARCHAR(100),
	for_Telefone VARCHAR(15),
	for_Email VARCHAR(100),
	for_Ativo CHAR(1),
	for_DataCadastro DATETIME
)
GO

CREATE TABLE Peca (
	pec_Codigo INT IDENTITY PRIMARY KEY,
	pec_Nome VARCHAR(300),
	pec_Valor MONEY,
	pec_Ativo CHAR(1),
	pec_DataCadastro DATETIME
)
GO

CREATE TABLE Orcamento (
	orc_Codigo INT IDENTITY PRIMARY KEY

)
GO

CREATE TABLE PedidoOrcamento (
	peo_Codigo INT IDENTITY PRIMARY KEY
)
GO