USE BibliotecaDB
GO 
 CREATE PROCEDURE ObterDados
 AS
 BEGIN
	SELECT *
	FROM Livros
 END
USE BibliotecaDB
EXEC ObterDados