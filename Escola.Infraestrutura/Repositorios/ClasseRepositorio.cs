using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;

namespace Escola.Infraestrutura.Repositorios
{
    public class ClasseRepositorio : IClasseRepositorio
    {
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
                        command.Parameters.AddWithValue("@cpf", classe.CpfAluno);
                        command.Parameters.AddWithValue("@salaf", classe.Sala);

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
