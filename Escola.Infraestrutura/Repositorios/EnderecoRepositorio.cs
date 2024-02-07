using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;
using static Escola.Domain.Utils.Constantes;

namespace Escola.Infraestrutura.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        public Endereco BuscarEnderecoPorCpf(string cpf)
        {
            string scriptSql = EnderecoQuery.sqlSelectEnderecoPorCpf;

            Endereco endereco = new Endereco();
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@cpf", cpf);
                        using (MySqlDataReader retornaSelect = command.ExecuteReader())
                        {
                            while (retornaSelect.Read())
                            {

                                endereco.Cep = retornaSelect["cep"].ToString();
                                endereco.Logradouro = retornaSelect["logradouro"].ToString();
                                endereco.Numero = retornaSelect["numero"].ToString();
                                endereco.Bairro = retornaSelect["bairro"].ToString();
                                endereco.Localidade = retornaSelect["localidade"].ToString();
                                endereco.Uf = retornaSelect["uf"].ToString();
                                endereco.Cpf = cpf;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
            return endereco;
        }

        public void SalvarEnderecoAluno(Endereco endereco)
        {

            string scriptSql = Constantes.EnderecoQuery.sqlInsertEnderecoAluno;
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@cep", endereco.Cep);
                        command.Parameters.AddWithValue("@numero", endereco.Numero);
                        command.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                        command.Parameters.AddWithValue("@bairro", endereco.Bairro);
                        command.Parameters.AddWithValue("@localidade", endereco.Localidade);
                        command.Parameters.AddWithValue("@uf", endereco.Uf);
                        command.Parameters.AddWithValue("@cpf", endereco.Cpf);



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

        public void SalvarEnderecoProfessor(Endereco endereco)
        {

            string scriptSql = Constantes.EnderecoQuery.sqlInsertEnderecoProfessor;
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@cep", endereco.Cep);
                        command.Parameters.AddWithValue("@numero", endereco.Numero);
                        command.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                        command.Parameters.AddWithValue("@bairro", endereco.Bairro);
                        command.Parameters.AddWithValue("@localidade", endereco.Localidade);
                        command.Parameters.AddWithValue("@uf", endereco.Uf);
                        command.Parameters.AddWithValue("@cpf", endereco.Cpf);



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
