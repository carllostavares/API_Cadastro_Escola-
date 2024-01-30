namespace Api.Escola.Domain.Utils
{
    public static class Constantes
    {
        public static class Aluno
        {
 
            public const string sqlSelect = "select id_cpf_aluno, nome, data_nascimento from tb_aluno";
            public const string sqlSelecPorCpf = "select id_cpf_aluno, nome, data_nascimento from tb_aluno where id_cpf_aluno =  @cpf  ";
            public const string sqlInsert = "INSERT INTO tb_aluno VALUES('\" + cpf + \"','\" + nome + \"','2099-05-20')";

        }
        public static class Professor
        {
            public const string sqlBuscarPorCpf = "select id_cpf_aluno, nome, data_nascimento from tb_professor";

        }
        public static class Aula
        {

        }

    }
}
