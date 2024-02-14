using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;

namespace Escola.Infraestrutura.Repositorios
{
    public class ClasseRepositorio : IClasseRepositorio
    {
        public List<string> BuscarClassePorSala(string sala)
        {
            string scriptSql = Constantes.ClasseQuery.sqlSelectClassePorSala;

            var alunos = new List<string>();

            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@sala", sala);
                        using (MySqlDataReader retornaSelect = command.ExecuteReader())
                        {
                            while (retornaSelect.Read())
                            {

                                
                                var nomeALuno = retornaSelect["nome_aluno"].ToString();

                                alunos.Add(nomeALuno);

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


        public void SalvarClasse(Classe classe)
        {
            string scriptSql = Constantes.ClasseQuery.sqlInsertClasse;

            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@idMateria", classe.IdMateria);
                        command.Parameters.AddWithValue("@sala", classe.Sala);
                        command.Parameters.AddWithValue("@cpfAluno", classe.CpfAluno);

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
