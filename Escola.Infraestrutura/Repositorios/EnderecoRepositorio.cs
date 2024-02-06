using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;

namespace Escola.Infraestrutura.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        public void SalvarEndereco(Endereco endereco)
        {

            string scriptSql = Constantes.EnderecoQuery.sqlInsertEndereco;
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@cep", endereco.Cep);
                        command.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                        command.Parameters.AddWithValue("@bairro", endereco.Bairro);
                        command.Parameters.AddWithValue("@localidade", endereco.Localidade);
                        command.Parameters.AddWithValue("@uf", endereco.Uf);


                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

    }
}
