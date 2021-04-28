CREATE DATABASE Hroads;
GO

USE Hroads;
GO


CREATE TABLE Classes
(
	idClasse INT PRIMARY KEY IDENTITY
	,nomeClasse VARCHAR(200) NOT NULL
);
GO


CREATE TABLE Personagens
(
	idPersonagem INT PRIMARY KEY IDENTITY
	,nomePersonagem VARCHAR(200)
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
	,nomeTiposHabilidade VARCHAR(200) NOT NULL
);
GO


CREATE TABLE Habilidades
(
	idHabilidade INT PRIMARY KEY IDENTITY
	,idTiposHabilidade INT FOREIGN KEY REFERENCES TiposHabilidade(idTiposHabilidade)
	,nomeHabilidade VARCHAR(200) NOT NULL
);
GO


CREATE TABLE ClassesHabilidades
(
	idClasse INT FOREIGN KEY REFERENCES Classes(idClasse)
	,idHabilidade INT FOREIGN KEY REFERENCES Habilidades(idHabilidade)
);

