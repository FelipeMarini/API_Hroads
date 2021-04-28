USE Hroads;
GO


INSERT INTO Classes (nomeClasse)
VALUES				('Barbaro')
				,	('Cruzado')
				,	('Caçadora de Demonios')
				,	('Monge')	
				,	('Necromante')
				,	('Feiticeiro')
				,	('Arcanista');
GO


INSERT INTO Personagens (nomePersonagem, idClasse, capacidadeMaxVida, capacidadeMaxMana, dataAtualizacao, dataCriacao)
VALUES					('DeuBug', 1, 100, 80, '2021/04/26', '2019/01/18'),
						('BitBug', 4, 100, 100, '2021/04/26', '2016/03/17'),
						('Fer8' , 7, 75, 60, '2021/04/26', '2018/03/18');
GO




INSERT INTO Habilidades (nomeHabilidade, idTiposHabilidade)
VALUES					('Lança Mortal', 1)
					   ,('Escudo Supremo', 2)
					   ,('Recuperar Vida', 3);
GO					  



INSERT INTO TiposHabilidade(nomeTiposHabilidade)
VALUES					   ('Ataque')
						,  ('Defesa')
						,  ('Cura')
						,  ('Magia');
GO


INSERT INTO ClassesHabilidades(idClasse,idHabilidade)
VALUES					   (1, 2),
						   (1, 3),
						   (2, 3),
						   (3, 2),
						   (4, 3),
						   (4, 4),
						   (6, 4);
							



							
