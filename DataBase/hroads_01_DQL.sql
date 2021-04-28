USE Hroads;


SELECT * FROM Personagens;

SELECT * FROM Classes;

SELECT * FROM Habilidades;

SELECT * FROM TiposHabilidade;

SELECT * FROM TiposUsuario;

SELECT * FROM Usuarios;

-- contar número de habilidades registradas
SELECT COUNT (DISTINCT idHabilidade) 'Quantidade/Habilidades' FROM Habilidades;


-- selecionar cada habilidade com seu respectivo tipo de habilidade
SELECT H.nome AS Habilidade, TiposHabilidade.tipoHabilidade AS Tipo_Habilidade
FROM Habilidades AS H
INNER JOIN TiposHabilidade
ON H.idTiposHabilidade = TiposHabilidade.idTiposHabilidade;


-- selecionar os personagens e suas classes correspondentes
SELECT Personagens.nome, Classes.nome FROM Personagens
INNER JOIN Classes
ON Personagens.idClasse = Classes.idClasse;


-- selecionar os personagens e suas classes correspondentes, mesmo que uma classe não tenha um personagem cadastrado
SELECT Personagens.nome, Classes.nome FROM Personagens
RIGHT JOIN Classes
ON Personagens.idClasse = Classes.idClasse;





