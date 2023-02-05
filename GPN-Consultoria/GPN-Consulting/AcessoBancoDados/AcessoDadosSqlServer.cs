using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados.Properties;


namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        #region Criar a conexao
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }
        #endregion

        #region Parametros BD
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        #endregion

        # region Persistencia - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar nova Conexao 
                SqlConnection sqlConnection = CriarConexao();
                //abre a conexao
                sqlConnection.Open();
                //Criar Comandos para execução no BD
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Comandos - pode ser: StoredProcedure ou Text
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;   //tempo maximo de execução

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }
                //Executa o comando no BD
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Consultar registros no banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar nova Conexao 
                SqlConnection sqlConnection = CriarConexao();
                //abre a conexao
                sqlConnection.Open();
                //Criar Comandos para execução no BD
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Comandos - pode ser: StoredProcedure ou Text
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;   //tempo maximo de execução

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Criar um adaptador para o resultado da consulta
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable = Tabela de dados vazia para armazenar os dados retornados pela consulta
                DataTable dataTable = new DataTable();
                //Executar o comando no banco de dados
                sqlDataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }

}
