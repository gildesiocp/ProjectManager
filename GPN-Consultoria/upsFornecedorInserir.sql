ALTER PROCEDURE uspFornecedoresInserir
	@IdFornecedor int,
	@cpfCnpj varchar(14),
	@nome varchar(50),
	@endereco varchar(60),
	@numero varchar(10),
	@coplemento varchar(50),
	@cep varchar(8),
	@bairro varchar(50),
	@cidade varchar(50),
	@uf char(2)
AS
BEGIN
	INSERT INTO Fornecedores
		(
			cpfCnpj,
			nome,
			endereco,
			numero,
			coplemento,
			cep,
			bairro,
			cidade,
			uf
		)
	VALUES
		(
			@cpfCnpj,
			@nome,
			@endereco,
			@numero,
			@coplemento,
			@cep,
			@bairro,
			@cidade,
			@uf
		)
		SELECT @@IDENTITY As Retorno
END
