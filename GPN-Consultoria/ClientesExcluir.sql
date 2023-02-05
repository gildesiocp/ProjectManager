CREATE PROCEDURE uspClienteExcluir
	@codigo INT
AS
BEGIN
	DELETE FROM 
		tblClientes
	WHERE
		codigo = @codigo

	SELECT @codigo As Retorno
END
