USE Hroads;


SELECT * FROM Personagens;


SELECT * FROM Classes;


SELECT * FROM TiposHabilidade;


SELECT * FROM Habilidades; 


SELECT * FROM ClassesHabilidades;


SELECT COUNT (DISTINCT idHabilidade) 'Quantidade/Habilidades' FROM Habilidades;


SELECT H.nomeHabilidade AS Habilidade, TiposHabilidade.nomeTiposHabilidade AS TiposHabilidade
FROM Habilidades AS H
INNER JOIN TiposHabilidade
ON H.idTiposHabilidade = TiposHabilidade.idTiposHabilidade;



SELECT Personagens.nomePersonagem, Classes.nomeClasse FROM Personagens
INNER JOIN Classes
ON Personagens.idClasse = Classes.idClasse;



SELECT Personagens.nomePersonagem, Classes.nomeClasse FROM Personagens
RIGHT JOIN Classes
ON Personagens.idClasse = Classes.idClasse;



SELECT H.nomeHabilidade AS Habilidade, C.nomeClasse AS Classe
FROM ClassesHabilidades AS CH
INNER JOIN Classes AS C
ON C.idClasse = CH.idClasse
INNER JOIN Habilidades AS H
ON H.idHabilidade = CH.idHabilidade;



SELECT Classes.nomeClasse, H.nomeHabilidade 
FROM ClassesHabilidades AS CH
INNER JOIN Classes
ON Classes.idClasse = CH.idClasse
INNER JOIN Habilidades AS H
ON H.idHabilidade = CH.idHabilidade;



SELECT H.nomeHabilidade AS Habilidade, C.nomeClasse AS Classe
FROM ClassesHabilidades AS CH
RIGHT JOIN Habilidades AS H
ON  H.idHabilidade = CH.idHabilidade
RIGHT JOIN Classes AS C
ON C.idClasse = CH.idClasse;
