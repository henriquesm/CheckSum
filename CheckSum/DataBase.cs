using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSum
{
    public class DataBase
    {
        const string conexao = @"Integrated Security=SSPI;Initial Catalog=teste;Data Source=(local);";
        SqlConnection connection = null;


        public DataBase()
        {
            connection = new SqlConnection(conexao);
        }

        public List<ArquivoDTO> ListarArquivos()
        {
            SqlCommand comando = new SqlCommand();
            List<ArquivoDTO> lista = new List<ArquivoDTO>();
            ArquivoDTO dto = new ArquivoDTO();

            comando.Connection = connection;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT [ID] ,[Nome] ,[Caminho] ,[CheckSum] ,[Extensao], [DataCriacao], [DataPesquisa], [tamanho], [Dono], [Grupo], FROM [teste].[dbo].[Arquivos]";

            try
            {
                connection.Open();
                SqlDataReader oReader = comando.ExecuteReader();
                while (oReader.Read())
                {
                    dto = new ArquivoDTO();
                    dto.ID = oReader["ID"] == DBNull.Value ? 0 : (int)oReader["ID"];
                    dto.Nome = oReader["Nome"] == DBNull.Value ? "" : oReader["Nome"].ToString();
                    dto.Caminho = oReader["Caminho"] == DBNull.Value ? "" : oReader["Caminho"].ToString();
                    dto.CheckSum = oReader["CheckSum"] == DBNull.Value ? "" : oReader["CheckSum"].ToString();
                    dto.Extensao = oReader["Extensao"] == DBNull.Value ? "" : oReader["Extensao"].ToString();
                    dto.DataCriacao = oReader["DataCriacao"] == DBNull.Value ? DateTime.MinValue : (DateTime)oReader["DataCriacao"];
                    dto.DataPesquisa = oReader["DataPesquisa"] == DBNull.Value ? DateTime.MinValue : (DateTime)oReader["DataPesquisa"];
                    dto.Tamanho = oReader["tamanho"] == DBNull.Value ? 0 : (Int64)oReader["tamanho"];
                    dto.Dono = oReader["Dono"] == DBNull.Value ? "" : oReader["Dono"].ToString();
                    dto.Grupo = oReader["Grupo"] == DBNull.Value ? "" : oReader["Grupo"].ToString();

                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (comando != null)
                {
                    comando.Dispose();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return lista;

        }

        public List<ArquivoDTO> ListarArquivos(string _checkSum)
        {
            SqlCommand comando = new SqlCommand();
            List<ArquivoDTO> lista = new List<ArquivoDTO>();
            ArquivoDTO dto = new ArquivoDTO();

            comando.Connection = connection;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT [ID] ,[Nome] ,[Caminho] ,[CheckSum] ,[Extensao], [DataCriacao], [DataPesquisa], [tamanho], [Dono], [Grupo] FROM [teste].[dbo].[Arquivos] where  CheckSum = @CheckSum";

            comando.Parameters.Add("@CheckSum", SqlDbType.VarChar);
            comando.Parameters["@CheckSum"].Value = _checkSum;

            try
            {
                connection.Open();
                SqlDataReader oReader = comando.ExecuteReader();
                while (oReader.Read())
                {
                    dto = new ArquivoDTO();
                    dto.ID = oReader["ID"] == DBNull.Value ? 0 : (int)oReader["ID"];
                    dto.Nome = oReader["Nome"] == DBNull.Value ? "" : oReader["Nome"].ToString();
                    dto.Caminho = oReader["Caminho"] == DBNull.Value ? "" : oReader["Caminho"].ToString();
                    dto.CheckSum = oReader["CheckSum"] == DBNull.Value ? "" : oReader["CheckSum"].ToString();
                    dto.Extensao = oReader["Extensao"] == DBNull.Value ? "" : oReader["Extensao"].ToString();
                    dto.DataCriacao = oReader["DataCriacao"] == DBNull.Value ? DateTime.MinValue : (DateTime)oReader["DataCriacao"];
                    dto.DataPesquisa = oReader["DataPesquisa"] == DBNull.Value ? DateTime.MinValue : (DateTime)oReader["DataPesquisa"];
                    dto.Tamanho = oReader["tamanho"] == DBNull.Value ? 0 : (Int64)oReader["tamanho"];
                    dto.Dono = oReader["Dono"] == DBNull.Value ? "" : oReader["Dono"].ToString();
                    dto.Grupo = oReader["Grupo"] == DBNull.Value ? "" : oReader["Grupo"].ToString();


                    lista.Add(dto);

                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (comando != null)
                {
                    comando.Dispose();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return lista;

        }

        public void InserirArquivo(ArquivoDTO dto)
        {
            SqlCommand comando = new SqlCommand();
            string sql = string.Empty;

            sql = "INSERT INTO [teste].[dbo].[Arquivos] ([Nome] ,[Caminho] ,[CheckSum] ,[Extensao] ,[DataCriacao], [DataPesquisa], [tamanho], [Dono], [Grupo]) ";
            sql += "values (@Nome, @Caminho, @CheckSum, @Extensao, @DataCriacao, @DataPesquisa, @tamanho, @Dono, @Grupo)";


            comando.Parameters.Add("@Nome", SqlDbType.VarChar);
            comando.Parameters["@Nome"].Value = dto.Nome;

            comando.Parameters.Add("@Caminho", SqlDbType.VarChar);
            comando.Parameters["@Caminho"].Value = dto.Caminho;

            comando.Parameters.Add("@CheckSum", SqlDbType.VarChar);
            comando.Parameters["@CheckSum"].Value = dto.CheckSum;

            comando.Parameters.Add("@Extensao", SqlDbType.VarChar);
            comando.Parameters["@Extensao"].Value = dto.Extensao;

            comando.Parameters.Add("@DataCriacao", SqlDbType.DateTime);
            comando.Parameters["@DataCriacao"].Value = dto.DataCriacao;

            comando.Parameters.Add("@DataPesquisa", SqlDbType.DateTime);
            comando.Parameters["@DataPesquisa"].Value = DateTime.Now;

            comando.Parameters.Add("@tamanho", SqlDbType.BigInt);
            comando.Parameters["@tamanho"].Value = dto.Tamanho;

            comando.Parameters.Add("@Dono", SqlDbType.VarChar);
            comando.Parameters["@Dono"].Value = dto.Dono;

            comando.Parameters.Add("@Grupo", SqlDbType.VarChar);
            comando.Parameters["@Grupo"].Value = dto.Grupo;

            comando.Connection = connection;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = sql;

            try
            {
                connection.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (comando != null)
                {
                    comando.Dispose();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


    }
}
