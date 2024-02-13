using Escola.Domain.Entities;
using Escola.Domain.Utils;
using Escola.Infraestrutura.Interfaces;
using Escola.Infraestrutura.SqlDataBase;
using MySql.Data.MySqlClient;

namespace Escola.Infraestrutura.Repositorios
{
    public class MateriaRepositorio : IMateriaRepositorio
    {
        public List<Materia> BuscaMateria()
        {
            string scriptSql = Constantes.MateriaQuery.sqlSelectMateria;

            List<Materia> materias = new List<Materia>();
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
                                Materia materia = new Materia();
                                materia.Id = (string)retornaSelect["id_materia"];
                                materia.Name = retornaSelect["nome"].ToString();
                                materia.CargaHoraria = ((int)retornaSelect["carga_horaria"]);
                                materia.CpfProfessor = retornaSelect["id_cpf_professor"].ToString();
                                materias.Add(materia);
                            }
                            return materias;
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
                        command.Parameters.AddWithValue("@cpf", materia.CpfProfessor);
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
