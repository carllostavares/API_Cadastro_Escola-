create schema db_escola character set utf8;

CREATE TABLE tb_aluno(
id_cpf_aluno VARCHAR(14) NOT NULL,
nome_Aluno VARCHAR(200),	
data_nascimento DATE  NOT NULL,

PRIMARY  KEY( id_cpf_aluno)
);

CREATE TABLE tb_professor(
id_cpf_professor VARCHAR(14) NOT NULL,
nome_professor VARCHAR(200),	
data_nascimento DATE  NOT NULL,
disciplina VARCHAR(100) NOT NULL,

PRIMARY  KEY( id_cpf_professor)
);


SELECT * FROM tb_aluno;
select id_cpf_aluno, nome, data_nascimento from tb_aluno where  "11122233344" = id_cpf_aluno;

drop  table tb_aluno;
INSERT INTO tb_aluno ( id_cpf_aluno, nome, data_nascimento) VALUES("id_cpf_aluno","nome","2099-05-30");