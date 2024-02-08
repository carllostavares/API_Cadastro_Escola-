using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;

namespace Escola.Infraestrutura.Repositorios
{
    public class MateriaRepositorio : IMateriaRepositorio
    {
        public void SalvarMateria(Materia materia)
        {
            string scriptSql = Constantes.MateriaQuery.sqlInsertMateria;
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@id",materia.Id);
                        command.Parameters.AddWithValue("@nome",materia.Name);
                        command.Parameters.AddWithValue("@carcaHoraria", materia.CargaHoraria);
                        command.Parameters.AddWithValue("@cpf", materia.Cpf);
                        command.Prepare();

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
