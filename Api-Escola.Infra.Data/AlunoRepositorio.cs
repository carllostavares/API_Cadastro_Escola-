using Api_Escola.Domain.Entities;
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

        public List<Aluno> BuscarAluno()
        {
            scriptSql = "select id_cpf_aluno, nome, data_nascimento from tb_aluno";

            List<Aluno> alunos = new List<Aluno>();
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
                                Aluno aluno = new Aluno();
                                aluno.IdCpf = retornaSelect["id_cpf_aluno"].ToString();
                                aluno.Nome = retornaSelect["nome"].ToString();
                                aluno.DataNascimento = retornaSelect["data_nascimento"].ToString();
                                alunos.Add(aluno);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return alunos;
        }

        public Aluno BuscarAlunoPorId(string cpf)
        {
            scriptSql = "select id_cpf_aluno, nome, data_nascimento from tb_aluno where '" + cpf + "'= id_cpf_aluno ";

            Aluno aluno = new Aluno();
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
                           
                                aluno.IdCpf = retornaSelect["id_cpf_aluno"].ToString();
                                aluno.Nome = retornaSelect["nome"].ToString();
                                aluno.DataNascimento = retornaSelect["data_nascimento"].ToString();
                             
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return aluno;
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
