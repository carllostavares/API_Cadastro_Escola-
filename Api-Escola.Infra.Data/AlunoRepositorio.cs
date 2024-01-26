using Api_Escola.Infra.Data.SqlDataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Escola.Infra.Data
{
    public class AlunoRepositorio
    {
        public string? scriptSql;

        public void BuscarAluno(string nome, string cpf, DateTime dataNascimento)
        {
            scriptSql = "select id_cpf_aluno, nome, data_nascimento from tb_aluno";
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        using (MySqlDataReader retornaSelect = command.ExecuteReader())
                        {
                            while (retornaSelect.Read())
                            {
                                Console.WriteLine(retornaSelect["id_cpf_aluno"] + ",  " + retornaSelect["nome"] + ",  " + retornaSelect["data_nascimento"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SalvarAluno(string nome, string cpf, DateTime dataNascimento)
        {
            scriptSql = "INSERT INTO tb_aluno VALUES('" + cpf + "','" + nome + "','2099-05-20')";
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
