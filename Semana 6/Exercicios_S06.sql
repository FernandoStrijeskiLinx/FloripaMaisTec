-- Cria base de dados
CREATE DATABASE VENDA;

-- Cria tabela com meu nome
CREATE TABLE Fernando (
	Id INT NOT NULL PRIMARY KEY,
	Idade INT NOT NULL UNIQUE,
	Cidade VARCHAR(MAX) NULL
);

-- Adiciona UF e telefone na tabela com meu nome
ALTER TABLE Fernando ADD UF CHAR(2) NULL, Telefone BIGINT NOT NULL;

-- Apaga a tabela com meu nome
DROP TABLE Fernando;

-- Cria a tabela veículo
CREATE TABLE VEICULO (
	Id INT PRIMARY KEY NOT NULL,
	Descricao DATETIME NOT NULL,
	TipoMotor DECIMAL NOT NULL,
	Valor SMALLMONEY NULL,
	Vendido BIT NOT NULL
)

-- Cria a tabela Cor
CREATE TABLE COR (
	Id INT PRIMARY KEY,
	NomeCor VARCHAR(100) NOT NULL UNIQUE
);

-- Altera a tabela veículo adicionando o IdCor como chave estrangeira da tabela Cor
ALTER TABLE VEICULO ADD IdCor INT NOT NULL, CONSTRAINT FK_VEICULO FOREIGN KEY(IdCor) REFERENCES COR(Id);

-- Tenta apagar a tabela Cor, que não permite por ser referencia da Veiculos
DROP TABLE COR;
