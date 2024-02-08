using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;

namespace Escola.Infraestrutura.Repositorios
{
    public class materiaRepositorio : IMateriaRepositorio
    {
        public Materia SalvarMateria(Materia materia)
        {
            string scriptSql = Constantes.MateriaQuery.sqlInserMateria;
            try
            {
                using (MySqlConnection connection = BancoMysql.AbrirConexao())
                {
                    using (MySqlCommand command = new MySqlCommand(scriptSql, connection))
                    {
                        command.Parameters.AddWithValue("@id",materia.id);
                        command.Parameters.AddWithValue("@nome",materia.name);
                        command.Parameters.AddWithValue("@carcaHoraria", materia.cargaHoraria);
                        command.Parameters.AddWithValue("@cpf", materia.Cpf);


                        command.ExecuteNonQuery();
                        return materia;
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
