using MySql.Data.MySqlClient;


namespace Escola.Infraestrutura.SqlDataBase
{
    public static class BancoMysql
    {
        public static string? ConnectionString;

        public static MySqlConnection AbrirConexao()
        {
            ConnectionString = "server=localhost;database=db_escola;user=root;password=Wlwl2350@Ju";
            MySqlConnection conexao = new MySqlConnection(ConnectionString);
            conexao.Open();
            return conexao;
        }
    }
}
