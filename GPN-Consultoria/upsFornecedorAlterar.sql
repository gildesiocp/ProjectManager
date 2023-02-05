ALTER PROCEDURE uspFornecedorAlterar
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
	UPDATE 
		Fornecedores
	SET
		cpfCnpj = @cpfCnpj,
		nome = @nome,
		endereco = @endereco,
		numero = @numero,
		coplemento = @coplemento,
		cep = @cep,
		bairro = @bairro,
		cidade = @cidade,
		uf = @uf

	SELECT @IdFornecedor As Retorno
END