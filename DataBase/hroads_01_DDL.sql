CREATE DATABASE Hroads;
GO

USE Hroads;
GO


CREATE TABLE Classes
(
	idClasse INT PRIMARY KEY IDENTITY
	,nome VARCHAR(200) NOT NULL
);
GO


CREATE TABLE Personagens
(
	idPersonagem INT PRIMARY KEY IDENTITY
	,nome VARCHAR(200)
	,idClasse INT FOREIGN KEY REFERENCES Classes(idClasse)
	,capacidadeMaxVida INT
	,capacidadeMaxMana INT
	,dataAtualizacao DATE
	,dataCriacao DATE
);
GO


CREATE TABLE TiposHabilidade
(
	idTiposHabilidade INT PRIMARY KEY IDENTITY
	,tipoHabilidade VARCHAR(200) NOT NULL
);
GO


CREATE TABLE Habilidades
(
	idHabilidade INT PRIMARY KEY IDENTITY
	,idTiposHabilidade INT FOREIGN KEY REFERENCES TiposHabilidade(idTiposHabilidade)
	,nome VARCHAR(200) NOT NULL
);
GO

CREATE TABLE TiposUsuario
(
	idTiposUsuario INT PRIMARY KEY IDENTITY
	,titulo VARCHAR(200) NOT NULL
);
GO


CREATE TABLE Usuarios
(
	idUsuario INT PRIMARY KEY IDENTITY
	,email VARCHAR(100) UNIQUE NOT NULL
	,senha VARCHAR(50) NOT NULL
	,idTiposUsuario INT FOREIGN KEY REFERENCES TiposUsuario(idTiposUsuario)
);

