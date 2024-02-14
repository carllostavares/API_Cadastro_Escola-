 using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.SqlDataBase;
using Escola.Infraestrutura.Interfaces;
using MySql.Data.MySqlClient;
namespace Escola.Infraestrutura.Repositorios

{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        public List<Alunos> BuscarAluno()
        {
            string scriptSql = Constantes.Aluno.sqlSelect;

            List<Alunos> alunos = new List<Alunos>();
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
                                Alunos aluno = new Alunos();
                                aluno.Cpf = retornaSelect["id_cpf_aluno"].ToString();
                                aluno.Nome = retornaSelect["nome_aluno"].ToString();
                                aluno.DataNascimento = retornaSelect["data_nascimento"].ToString();
                                alunos.Add(aluno);
                            }
                            return alunos;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public Alunos BuscarAlunoPorId(string cpf)
        {
            string scriptSql = Constantes.Aluno.sqlSelecPorCpf;

            Alunos aluno = new Alunos();
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

                                aluno.Cpf = retornaSelect["id_cpf_aluno"].ToString();
                                aluno.Nome = retornaSelect["nome_aluno"].ToString();
                                aluno.DataNascimento = retornaSelect["data_nascimento"].ToString();

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
            return aluno;
        }

        public void SalvarAluno(string cpf, string nome, string dataNascimento)
        {
            string scriptSql = Constantes.Aluno.sqlInsertAluno;
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@data_nascimento", dataNascimento);

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
