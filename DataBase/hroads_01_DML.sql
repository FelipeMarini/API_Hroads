USE Hroads;
GO


INSERT INTO Classes (nome)
VALUES				('Barbaro')
				,	('Cruzado')
				,	('Caçadora de Demonios')
				,	('Monge')	
				,	('Necromante')
				,	('Feiticeiro')
				,	('Arcanista');
GO



INSERT INTO Personagens (nome, idClasse, capacidadeMaxVida, capacidadeMaxMana, dataAtualizacao, dataCriacao)
VALUES					('DeuBug', 1, 100, 80, '2021/04/28', '2019/01/18'),
						('BitBug', 4, 100, 100, '2021/04/28', '2016/03/17'),
						('Fer8' , 7, 75, 60, '2021/04/28', '2018/03/18');
GO


INSERT INTO Habilidades (idTiposHabilidade, nome)
VALUES					(1, 'Lança Mortal')
					   ,(2, 'Escudo Supremo')
					   ,(3, 'Recuperar Vida');
GO					  


INSERT INTO TiposHabilidade(tipoHabilidade)
VALUES					   ('Ataque')
						,  ('Defesa')
						,  ('Cura')
						,  ('Magia');
GO


INSERT INTO TiposUsuario  (titulo)
VALUES					  ('jogador')
						, ('admnistrador');
GO


INSERT INTO Usuarios	  (email,senha,idTiposUsuario)
VALUES					  ('felipe@email.com','123',1)
						, ('saulo@email.com','789',2);
