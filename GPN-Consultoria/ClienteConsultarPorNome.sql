CREATE PROCEDURE uspClienteConsultarPorNome
	@nome varchar(60)
AS
BEGIN
	SELECT 
		* 
	FROM 
		tblClientes
	WHERE 
		nome LIKE '%' + @nome + '%'

END
