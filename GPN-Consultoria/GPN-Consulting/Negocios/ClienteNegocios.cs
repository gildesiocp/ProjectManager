using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using DTO;
using System.Data;

namespace Negocios
{
    public class ClienteNegocios
    {
        //Instanciar a classe de acesso a dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        #region Manutenção do Cadastro de Clientes
        public string Inserir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CpfCnpj", cliente.CpfCnpj);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Endereco", cliente.Endereco);
                acessoDadosSqlServer.AdicionarParametros("@Numero", cliente.Numero);
                acessoDadosSqlServer.AdicionarParametros("Complemento", cliente.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@Cep", cliente.Cep);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", cliente.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", cliente.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Uf", cliente.Uf);

                string idCodigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return idCodigo;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@CpfCnpj", cliente.CpfCnpj);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Endereco", cliente.Endereco);
                acessoDadosSqlServer.AdicionarParametros("@Numero", cliente.Numero);
                acessoDadosSqlServer.AdicionarParametros("Complemento", cliente.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@Cep", cliente.Cep);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", cliente.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", cliente.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Uf", cliente.Uf);

                string idCodigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return idCodigo;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);

                string idCodigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();
                return idCodigo;

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        #endregion

        #region Consultas ao Cadastro de Clientes
        public ClienteColecao ConsultarPorCnpjCpf(string CpfCnpj)
        {
            try
            {
                //Cria uma nova Coleção de clientes
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CpfCnpj", CpfCnpj);

                DataTable dtCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorCnpjCpf");

                //Percorre o dtCliente (DataTable) e transforma em uma coleção de Clientes
                foreach (DataRow linha in dtCliente.Rows)
                {
                    //Cria um cliente vazio
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.CpfCnpj = Convert.ToString(linha["CpfCnpj"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.Endereco = Convert.ToString(linha["Endereco"]);
                    cliente.Numero = Convert.ToString(linha["Numero"]);
                    cliente.Complemento = Convert.ToString(linha["Complemento"]);
                    cliente.Bairro = Convert.ToString(linha["Bairro"]);
                    cliente.Cep = Convert.ToString(linha["Cep"]);
                    cliente.Cidade = Convert.ToString(linha["Cidade"]);
                    cliente.Uf = Convert.ToString(linha["Uf"]);

                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possivel consultar pelo CNPJ/CPF. Detalhes: " + e.Message);
            }
        }

        public ClienteColecao ConsultarPorNome(string nome)
        {
            try
            {
                //Cria uma nova coleção de cliente
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);

                DataTable dtCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                //Percorre o dtCliente (DataTable) e transforma em uma Coleção de Clientes
                foreach (DataRow linha in dtCliente.Rows)
                {
                    //Cria um cliente vazio
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.CpfCnpj = Convert.ToString(linha["CpfCnpj"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.Endereco = Convert.ToString(linha["Endereco"]);
                    cliente.Numero = Convert.ToString(linha["Numero"]);
                    cliente.Complemento = Convert.ToString(linha["Complemento"]);
                    cliente.Bairro = Convert.ToString(linha["Bairro"]);
                    cliente.Cep = Convert.ToString(linha["Cep"]);
                    cliente.Cidade = Convert.ToString(linha["Cidade"]);
                    cliente.Uf = Convert.ToString(linha["Uf"]);

                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception e)
            {

                throw new Exception("Não foi possivel consultar por Nome. Detalhes: " + e.Message);
            }
        }
        #endregion
    }
}
