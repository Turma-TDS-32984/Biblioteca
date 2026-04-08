USE BibliotecaDB
GO 
	CREATE PROCEDURE InserirDados
		@Titulo varchar(200),
		@Genero varchar(100),
		@Autor varchar(150),
		@Editora varchar(100),
		@ISBN varchar(20),
		@Quantidade int
	AS
	BEGIN
		INSERT INTO Livros(Titulo,Genero,Autor,Editora,ISBN,QuantidadeDisponivel)
		VALUES (@Titulo,@Genero,@Autor,@Editora,@ISBN,@Quantidade)
	END
USE BibliotecaDB EXEC InserirDados 'ABC','ABC','ABC','ABC','ABC', 1