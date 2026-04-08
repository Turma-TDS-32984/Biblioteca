USE BibliotecaDB
GO 
 CREATE PROCEDURE DeletarLivro
 @idASerExcluido INT
 AS
 BEGIN
	DELETE FROM Livros WHERE LivroID = @idASerExcluido
 END
USE BibliotecaDB
EXEC ObterDados
USE BibliotecaDB
EXEC DeletarLivro 1
USE BibliotecaDB
EXEC ObterDados