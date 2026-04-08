USE BibliotecaDB
GO 
	CREATE PROCEDURE AtualizarDados
	@Id INT,
	@Titulo varchar(200),
	@Genero varchar(100),
	@Autor varchar(150),
	@Editora varchar(100),
	@ISBN varchar(20),
	@Quantidade int
	AS
	BEGIN
		UPDATE Livros
		SET 
			Titulo = @Titulo,
			Genero = @Genero,
			Autor = @Autor,
			Editora = @Editora,
			ISBN = @ISBN,
			QuantidadeDisponivel = @Quantidade
		WHERE
			LivroID = @Id
	END
USE BibliotecaDB
EXEC AtualizarDados 10,'Alface','Se','Deus','Céu','789',100