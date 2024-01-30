using Api.Escola.Domain.Entities;
using Api.Escola.Domain.Utils;
using Api.Escola.Infra.Data.Interfaces;
using Api_Escola.Infra.Data.SqlDataBase;
using MySql.Data.MySqlClient;
namespace Api.Escola.Infra.Data

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
                                aluno.IdCpf = retornaSelect["id_cpf_aluno"].ToString();
                                aluno.Nome = retornaSelect["nome"].ToString();
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
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
            return aluno;
        }

        public void SalvarAluno(string nome, string cpf, DateTime dataNascimento)
        {
            string scriptSql = Constantes.Aluno.sqlInsert.Replace("\\", "  ");
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
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
