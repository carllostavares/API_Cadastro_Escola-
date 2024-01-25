using Api_Escola.Infra.Data.SqlDataBase;
using MySql.Data.MySqlClient;


namespace Api_Escola.Application.Services
{

    public static class AcessandoBanco
    {
        public static string? scriptSql;

        public static void BuscandoDadosAluno()
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

        public static void InserindoDadosAluno()
        {
            scriptSql = "INSERT INTO tb_aluno VALUES(\"00033344466\",\"Junior Kaua\",\"2099-05-20\")";
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

