using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Api_Escola.Infra.Data.SqlDataBase
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
