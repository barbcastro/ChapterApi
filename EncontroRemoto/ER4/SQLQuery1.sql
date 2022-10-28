CREATE TABLE Usuarios (
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(225) NOT NULL UNIQUE,
	Senha VARCHAR(120) NOT NULL,
	Tipo CHAR(1) NOT NULL
); 

INSERT INTO Usuarios VALUES ('teste@email.com', 'senha123', '0');

SELECT * FROM Usuarios;

SELECT * FROM Usuarios WHERE email = 'teste@email.com' AND Senha = 'senha123';