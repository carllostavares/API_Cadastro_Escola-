﻿namespace Escola.Domain.Utils
{
    public static class Constantes
    {
        public static class Aluno
        {
 
            public const string sqlSelect = "select id_cpf_aluno, nome_aluno, data_nascimento,id_materia from tb_aluno";
            public const string sqlSelecPorCpf = "select id_cpf_aluno, nome_aluno, data_nascimento, id_materia from tb_aluno where id_cpf_aluno =  @cpf  ";
            public const string sqlInsertAluno = "INSERT INTO tb_aluno ( id_cpf_aluno, nome_aluno, data_nascimento,id_materia) VALUES(@cpf,@nome,@data_nascimento, @materia)";

        }
        public static class ProfessorQuery
        {
            public const string sqlSelect = "select id_cpf_professor, nome_professor, data_nascimento, disciplina from tb_professor";
            public const string sqlSelecPorCpf = "select id_cpf_professor, nome_professor, data_nascimento from tb_aluno where id_cpf_professor = @cpf";
            public const string sqlInsert = "INSERT INTO tb_professor ( id_cpf_professor, nome_professor, data_nascimento, disciplina) VALUES(@cpf,@nome,@data_nascimento, @disciplina)";

        }
        public static class EnderecoQuery
        {
            public const string sqlInsertEnderecoAluno = "INSERT INTO tb_endereco(cep,logradouro,numero,bairro,localidade,uf, id_cpf_aluno) VALUES(@cep,@logradouro,@numero, @bairro,@localidade,@uf,@cpf)";
            public const string sqlInsertEnderecoProfessor = "INSERT INTO tb_endereco(cep,logradouro,numero,bairro,localidade,uf, id_cpf_professor) VALUES(@cep,@logradouro,@numero, @bairro,@localidade,@uf,@cpf)";

            public const string sqlSelectEnderecoPorCpf = "SELECT cep,logradouro,numero,bairro,localidade,uf FROM tb_endereco where id_cpf_aluno = @cpf OR id_cpf_professor =@cpf";

        }

        public static class MateriaQuery
        {
            public const string sqlInsertMateria = " INSERT INTO tb_materia(id_materia,nome,carga_horaria,id_cpf_professor) VALUES(@id , @nome , @carcaHoraria , @cpf)";
        }

    }
}
