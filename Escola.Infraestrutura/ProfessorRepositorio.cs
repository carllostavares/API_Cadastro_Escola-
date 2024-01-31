using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;
namespace Escola.Infraestrutura

{
    public class ProfessorRepositorio : IProfessorRepositorio
    {
        public List<Professor> BuscarProfessor()
        {
            string scriptSql = Constantes.ProfessorQuery.sqlSelect;

            List<Professor> professores = new List<Professor>();
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
                                Professor professor = new Professor();
                                professor.Cpf = retornaSelect["id_cpf_professor"].ToString();
                                professor.Nome = retornaSelect["nome_professor"].ToString();
                                professor.DataNascimento = retornaSelect["data_nascimento"].ToString();
                                professor.Disciplina = retornaSelect["disciplina"].ToString();

                                professores.Add(professor);
                            }
                            return professores;
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

        public Professor BuscarProfessorPorId(string cpf)
        {
            string scriptSql = Constantes.ProfessorQuery.sqlSelecPorCpf;


            Professor professor = new Professor();
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
                                professor.Cpf = retornaSelect["id_cpf_professor"].ToString();
                                professor.Nome = retornaSelect["nome_professor"].ToString();
                                professor.DataNascimento = retornaSelect["data_nascimento"].ToString();
                                professor.Disciplina = retornaSelect["disciplina"].ToString();
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
            return professor;
        }

        public void SalvarProfessor(string cpf, string nome, string dataNascimento, string disciplina)
        {
            string scriptSql = Constantes.ProfessorQuery.sqlInsert;
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                        command.Parameters.AddWithValue("@disciplina", disciplina);


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
